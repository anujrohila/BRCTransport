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
    public class MRNoteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetMRNote()
        {
            var MRNoteList = MRNoteBusinessLogic.GetAll();
            return View(new GridModel(MRNoteList));
        }

        [HttpGet]
        public ActionResult Save(int id)
        {
            tblMRNoteDTO tblMRNoteDTO;
            if (id == 0)
            {
                tblMRNoteDTO = new tblMRNoteDTO();
                tblMRNoteDTO.MrNo = MRNoteBusinessLogic.GetMRNo() + 1;
            }
            else
            {
                tblMRNoteDTO = MRNoteBusinessLogic.Get(id);
            }
            tblMRNoteDTO.PaymentType = new List<SelectListItem>();
            tblMRNoteDTO.PaymentType.Add(new SelectListItem { Value = "Cash", Text = "Cash" });
            tblMRNoteDTO.PaymentType.Add(new SelectListItem { Value = "Cheque", Text = "Cheque" });
            return View(tblMRNoteDTO);
        }

        [HttpPost]
        public ActionResult Save(tblMRNoteDTO tblMRNoteDTO)
        {
            if (ModelState.IsValid)
            {
                CheckValidation(tblMRNoteDTO);
                if (ModelState.IsValid)
                {
                    var result = MRNoteBusinessLogic.Save(tblMRNoteDTO);
                    if (result > 0)
                        return RedirectToAction("Index");
                }
            }
            tblMRNoteDTO.PaymentType = new List<SelectListItem>();
            tblMRNoteDTO.PaymentType.Add(new SelectListItem { Value = "Cash", Text = "Cash" });
            tblMRNoteDTO.PaymentType.Add(new SelectListItem { Value = "Cheque", Text = "Cheque" });
            return View(tblMRNoteDTO);
        }

        /// <summary>
        /// Check validation
        /// </summary>
        private void CheckValidation(tblMRNoteDTO tblMRNoteDTO)
        {
            var resultCheckDuplicateMRNo = MRNoteBusinessLogic.CheckDuplicateMRNo(tblMRNoteDTO.MRId, tblMRNoteDTO.MrNo ?? 0);
            if (resultCheckDuplicateMRNo)
            {
                ModelState.AddModelError("MrNo", "MrNo already exists.");
            }
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteMRNote(int id)
        {
            var result = MRNoteBusinessLogic.Delete(id);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in MRNote." });
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetBillInfo(int billNo)
        {
            var result = MRNoteBusinessLogic.GetMRNoteBillDetail(billNo);
            if (result == null)
            {
                return Json(new { Success = false, Message = "No bill found." });
            }
            else if (result != null && result.PendingAmount == 0)
            {
                return Json(new { Success = false, Message = "Bill already paid." });
            }
            else if (result != null)
            {
                return Json(new { BillDetail = result, Success = true });
            }

            return Json(new { Success = false, Message = "Error in bill Details" });
        }
    }
}