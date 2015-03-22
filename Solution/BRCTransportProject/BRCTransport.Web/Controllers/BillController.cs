using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BRCTransport.Web.Models;
using BRCTransport.Domain;
using BRCTransport.BAL;
using Telerik.Web.Mvc;

namespace BRCTransport.Web.Controllers
{
    public class BillController : Controller
    {

        public ActionResult Index()
        {
            Session["BillEntrySession"] = null;
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetBills()
        {
            var bills = BillBusinessLogic.GetAll();
            foreach (var item in bills)
            {
                item.BillDateString = ((DateTime)item.BillDate).ToString("dd-MM-yyyy");
                item.PaymentDueDateString = ((DateTime)item.PaymentDueDate).ToString("dd-MM-yyyy");
            }
            return View(new GridModel(bills));
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteBill(int billId)
        {
            var result = BillBusinessLogic.Delete(billId);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }

        [GridAction]
        public ActionResult _AjaxGetBillEntrys(int billId)
        {
            List<tblBillEntryDTO> billEntryList = new List<tblBillEntryDTO>();
            if (billId == 0)
            {
                billEntryList = (List<tblBillEntryDTO>)Session["BillEntrySession"];
                if (billEntryList == null)
                    billEntryList = new List<tblBillEntryDTO>();
            }
            else
            {
                billEntryList = BillBusinessLogic.GetBillEntryList(billId);
            }
            return View(new GridModel(SetBillEntrySrNo(billEntryList)));
        }

        [HttpGet]
        public ActionResult Save(int id)
        {
            tblBillDTO tblBillDTO = new tblBillDTO();
            if (id == 0)
            {
                tblBillDTO = new tblBillDTO();
                tblBillDTO.BillNo = BillBusinessLogic.GetBillNo() + 1;
            }
            else
            {
                tblBillDTO = BillBusinessLogic.Get(id);
            }
            tblBillDTO = FillDropDown(tblBillDTO);
            return View(tblBillDTO);
        }

        [HttpPost]
        public ActionResult Save(tblBillDTO tblBillDTO)
        {
            if (ModelState.IsValid)
            {
                var resultDuplicateBllNo = BillBusinessLogic.CheckDuplicateBillNo(tblBillDTO.BillId, tblBillDTO.BillNo);
                if (resultDuplicateBllNo)
                {
                    ModelState.AddModelError("BillNo", "Bill no already exists.");
                }
                else
                {
                    if (tblBillDTO.BillId == 0)
                    {
                        tblBillDTO.BillEntryList = (List<tblBillEntryDTO>)Session["BillEntrySession"];
                    }
                    var result = BillBusinessLogic.Save(tblBillDTO);
                    return RedirectToAction("Index");
                }
            }
            tblBillDTO = FillDropDown(tblBillDTO);
            return View(tblBillDTO);
        }

        private tblBillDTO FillDropDown(tblBillDTO tblBillDTO)
        {
            var partyList = ConsignorBusinessLogic.GetAll();
            foreach (var item in partyList)
            {
                item.PartyNameWithCode = item.Code + "-" + item.ConsignorName;
            }
            tblBillDTO.PartyList = partyList;
            //-------------------
            tblBillDTO.BillTypeList = new List<SelectListItem>();
            tblBillDTO.BillTypeList.Add(new SelectListItem { Value = "FREIGHT", Text = "FREIGHT" });
            tblBillDTO.BillTypeList.Add(new SelectListItem { Value = "OCTROI", Text = "OCTROI" });
            tblBillDTO.BillTypeList.Add(new SelectListItem { Value = "SUPPLER", Text = "SUPPLER" });
            tblBillDTO.BillTypeList.Add(new SelectListItem { Value = "MISC", Text = "MISC" });
            tblBillDTO.BillTypeList.Add(new SelectListItem { Value = "Others", Text = "Others" });
            //-------------------
            tblBillDTO.ServiceTaxThroughList = new List<SelectListItem>();
            tblBillDTO.ServiceTaxThroughList.Add(new SelectListItem { Value = "CONSIGNOR", Text = "CONSIGNOR" });
            tblBillDTO.ServiceTaxThroughList.Add(new SelectListItem { Value = "CONSIGNEE", Text = "CONSIGNEE" });
            tblBillDTO.ServiceTaxThroughList.Add(new SelectListItem { Value = "BRC", Text = "BRC" });
            //-------------------
            return tblBillDTO;

        }

        /// <summary>
        /// BillEntryPartial
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public PartialViewResult BillEntryPartial(int srNO, int billId, int billOrderId)
        {
            var tblBillEntryDTO = new tblBillEntryDTO();
            if (billId == 0)
            {
                if (srNO > 0)
                {
                    var billEntryList = (List<tblBillEntryDTO>)Session["BillEntrySession"];
                    if (billEntryList == null)
                        billEntryList = new List<tblBillEntryDTO>();
                    tblBillEntryDTO = billEntryList.Where(be => be.SrNo == srNO).FirstOrDefault();
                }
            }
            else
            {
                if (billOrderId > 0)
                {
                    tblBillEntryDTO = BillBusinessLogic.GetBillEntry(billOrderId);
                }
            }
            return PartialView(tblBillEntryDTO);
        }

        /// <summary>
        /// BillEntryPartial
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult BillEntryPartial(tblBillEntryDTO tblBillEntryDTO)
        {
            if (tblBillEntryDTO.BillId == 0)
            {
                var billEntryList = (List<tblBillEntryDTO>)Session["BillEntrySession"];
                if (billEntryList == null)
                    billEntryList = new List<tblBillEntryDTO>();
                if (tblBillEntryDTO.SrNo == 0)
                {
                    billEntryList.Add(tblBillEntryDTO);
                }
                else
                {
                    var billEntry = billEntryList.Where(be => be.SrNo == tblBillEntryDTO.SrNo).FirstOrDefault();
                    billEntry.BillId = tblBillEntryDTO.BillId;
                    billEntry.BookingOldBrCode = tblBillEntryDTO.BookingOldBrCode;
                    billEntry.OldBillNo = tblBillEntryDTO.OldBillNo;
                    billEntry.OldBillDate = tblBillEntryDTO.OldBillDate;
                    billEntry.DestnCode = tblBillEntryDTO.DestnCode;
                    billEntry.Particulars = tblBillEntryDTO.Particulars;
                    billEntry.ChargedWeight = tblBillEntryDTO.ChargedWeight;
                    billEntry.Rate = tblBillEntryDTO.Rate;
                    billEntry.Amount = tblBillEntryDTO.Amount;
                }
                Session["BillEntrySession"] = SetBillEntrySrNo(billEntryList);
            }
            else
            {
                BillBusinessLogic.SaveBillEntry(tblBillEntryDTO);
            }
            return Json(new { Success = true, Message = "" });
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteBillEntry(int srNo, int billId, int billOrderId)
        {
            var result = false;
            if (billId == 0)
            {
                var billEntryList = (List<tblBillEntryDTO>)Session["BillEntrySession"];
                if (billEntryList == null)
                    billEntryList = new List<tblBillEntryDTO>();
                var billEntry = billEntryList.Where(be => be.SrNo == srNo).FirstOrDefault();
                billEntryList.Remove(billEntry);
                Session["BillEntrySession"] = SetBillEntrySrNo(billEntryList);
                result = true;
            }
            else
            {
                result = BillBusinessLogic.DeleteBillEntry(billOrderId);
            }
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }


        private List<tblBillEntryDTO> SetBillEntrySrNo(List<tblBillEntryDTO> billEntryList)
        {
            if (billEntryList != null)
            {
                for (int i = 1; i <= billEntryList.Count; i++)
                {
                    billEntryList[i - 1].SrNo = i;
                }
            }
            else
            {
                billEntryList = new List<tblBillEntryDTO>();
            }
            return billEntryList;
        }

        /// <summary>
        /// List Bill MrNotes
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListMRNotesAjax(int? billId)
        {
            var mrNoteList = new List<tblMRNoteDTO>();

            if ((billId ?? 0) > 0)
            {
                var getBillMRNoteResult = MRNoteBusinessLogic.GetBillMRNote((billId ?? 0));
                if (getBillMRNoteResult != null)
                    mrNoteList = getBillMRNoteResult;
            }

            return View(new GridModel(mrNoteList));
        }

    }
}