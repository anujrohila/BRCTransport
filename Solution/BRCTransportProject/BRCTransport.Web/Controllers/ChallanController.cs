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
    public class ChallanController : Controller
    {
        public ActionResult Index()
        {
            Session["ChallanEntrySession"] = null;
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetChallans()
        {
            var Challans = ChallanBusinessLogic.GetAll();
            return View(new GridModel(Challans));
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteChallan(int ChallanId)
        {
            var result = ChallanBusinessLogic.Delete(ChallanId);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }

        [GridAction]
        public ActionResult _AjaxGetChallanEntrys(int ChallanId)
        {
            List<tblChallanEntryDTO> ChallanEntryList = new List<tblChallanEntryDTO>();
            if (ChallanId == 0)
            {
                ChallanEntryList = (List<tblChallanEntryDTO>)Session["ChallanEntrySession"];
                if (ChallanEntryList == null)
                    ChallanEntryList = new List<tblChallanEntryDTO>();
            }
            else
            {
                ChallanEntryList = ChallanBusinessLogic.GetChallanEntryList(ChallanId);
            }
            return View(new GridModel(SetChallanEntrySrNo(ChallanEntryList)));
        }

        [HttpGet]
        public ActionResult Save(int id)
        {
            tblChallanDTO tblChallanDTO = new tblChallanDTO();
            if (id == 0)
            {
                tblChallanDTO = new tblChallanDTO();
                tblChallanDTO.ChallanNo = (ChallanBusinessLogic.GetChallanNo()+ 1);
            }
            else
            {
                tblChallanDTO = ChallanBusinessLogic.Get(id);
            }
            return View(tblChallanDTO);
        }

        [HttpPost]
        public ActionResult Save(tblChallanDTO tblChallanDTO)
        {
            if (ModelState.IsValid)
            {
                var resultDuplicateBllNo = ChallanBusinessLogic.CheckDuplicateChallanNo(tblChallanDTO.ChallanId, tblChallanDTO.ChallanNo ?? 0);
                if (resultDuplicateBllNo)
                {
                    ModelState.AddModelError("ChallanNo", "Challan no already exists.");
                }
                else
                {
                    if (tblChallanDTO.ChallanId == 0)
                    {
                        tblChallanDTO.ChallanEntryList = (List<tblChallanEntryDTO>)Session["ChallanEntrySession"];
                    }
                    var result = ChallanBusinessLogic.Save(tblChallanDTO);
                    return RedirectToAction("Index");
                }
            }
            return View(tblChallanDTO);
        }

        /// <summary>
        /// ChallanEntryPartial
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public PartialViewResult ChallanEntryPartial(int srNO, int ChallanId, int ChallanOrderId)
        {
            var tblChallanEntryDTO = new tblChallanEntryDTO();
            if (ChallanId == 0)
            {
                if (srNO > 0)
                {
                    var ChallanEntryList = (List<tblChallanEntryDTO>)Session["ChallanEntrySession"];
                    if (ChallanEntryList == null)
                        ChallanEntryList = new List<tblChallanEntryDTO>();
                    tblChallanEntryDTO = ChallanEntryList.Where(be => be.SrNo == srNO).FirstOrDefault();
                }
            }
            else
            {
                if (ChallanOrderId > 0)
                {
                    tblChallanEntryDTO = ChallanBusinessLogic.GetChallanEntry(ChallanOrderId);
                }
            }
            return PartialView(tblChallanEntryDTO);
        }

        /// <summary>
        /// ChallanEntryPartial
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ChallanEntryPartial(tblChallanEntryDTO tblChallanEntryDTO)
        {
            if (tblChallanEntryDTO.ChallanId == 0)
            {
                var ChallanEntryList = (List<tblChallanEntryDTO>)Session["ChallanEntrySession"];
                if (ChallanEntryList == null)
                    ChallanEntryList = new List<tblChallanEntryDTO>();
                if (tblChallanEntryDTO.SrNo == 0)
                {
                    ChallanEntryList.Add(tblChallanEntryDTO);
                }
                else
                {
                    var ChallanEntry = ChallanEntryList.Where(be => be.SrNo == tblChallanEntryDTO.SrNo).FirstOrDefault();
                    ChallanEntry.ChallanId = tblChallanEntryDTO.ChallanId;
                    ChallanEntry.ChallanEntryNo = tblChallanEntryDTO.ChallanEntryNo;
                    ChallanEntry.ChallanId = tblChallanEntryDTO.ChallanId;
                    ChallanEntry.BkgStnCode = tblChallanEntryDTO.BkgStnCode;
                    ChallanEntry.CNNoWithAlphaCode = tblChallanEntryDTO.CNNoWithAlphaCode;
                    ChallanEntry.PackagesNos = tblChallanEntryDTO.PackagesNos;
                    ChallanEntry.PackagesMethod = tblChallanEntryDTO.PackagesMethod;
                    ChallanEntry.SaidToContain = tblChallanEntryDTO.SaidToContain;
                    ChallanEntry.ActualWeightKgs = tblChallanEntryDTO.ActualWeightKgs;
                    ChallanEntry.DestinationName = tblChallanEntryDTO.DestinationName;

                }
                Session["ChallanEntrySession"] = SetChallanEntrySrNo(ChallanEntryList);
            }
            else
            {
                ChallanBusinessLogic.SaveChallanEntry(tblChallanEntryDTO);
            }
            return Json(new { Success = true, Message = "" });
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteChallanEntry(int srNo, int ChallanId, int ChallanOrderId)
        {
            var result = false;
            if (ChallanId == 0)
            {
                var ChallanEntryList = (List<tblChallanEntryDTO>)Session["ChallanEntrySession"];
                if (ChallanEntryList == null)
                    ChallanEntryList = new List<tblChallanEntryDTO>();
                var ChallanEntry = ChallanEntryList.Where(be => be.SrNo == srNo).FirstOrDefault();
                ChallanEntryList.Remove(ChallanEntry);
                Session["ChallanEntrySession"] = SetChallanEntrySrNo(ChallanEntryList);
                result = true;
            }
            else
            {
                result = ChallanBusinessLogic.DeleteChallanEntry(ChallanOrderId);
            }
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }

        private List<tblChallanEntryDTO> SetChallanEntrySrNo(List<tblChallanEntryDTO> ChallanEntryList)
        {
            if (ChallanEntryList != null)
            {
                for (int i = 1; i <= ChallanEntryList.Count; i++)
                {
                    ChallanEntryList[i - 1].SrNo = i;
                }
            }
            else
            {
                ChallanEntryList = new List<tblChallanEntryDTO>();
            }
            return ChallanEntryList;
        }
    }
}