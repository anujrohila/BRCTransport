using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BRCTransport.Domain;
using Telerik.Web.Mvc;
using BRCTransport.BAL;

namespace BRCTransport.Web.Controllers
{
    public class ConsignmentNoteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetConsignmentNote()
        {
            var ConsignmentNoteList = ConsignmentNoteBusinessLogic.GetAll();
            return View(new GridModel(ConsignmentNoteList));
        }

        [HttpGet]
        public ActionResult Save(int id)
        {
            tblConsignmentNoteDTO tblConsignmentNoteDTO;
            if (id == 0)
            {
                tblConsignmentNoteDTO = new tblConsignmentNoteDTO();
            }
            else
            {
                tblConsignmentNoteDTO = ConsignmentNoteBusinessLogic.Get(id);
            }
            tblConsignmentNoteDTO = FillDropDown(tblConsignmentNoteDTO);
            return View(tblConsignmentNoteDTO);
        }

        [HttpPost]
        public ActionResult Save(tblConsignmentNoteDTO tblConsignmentNoteDTO)
        {
            if (ModelState.IsValid)
            {
                var resultCheckDuplicateConsignmentNoteNo = ConsignmentNoteBusinessLogic.CheckDuplicateConsignmentNoteNo(tblConsignmentNoteDTO.ConsignmentId, tblConsignmentNoteDTO.ConsignmentNoteNo ?? 0);
                if (resultCheckDuplicateConsignmentNoteNo)
                {
                    ModelState.AddModelError("ConsignmentNoteNo", "Consignment Note No already exists.");
                }
                else
                {
                    tblConsignmentNoteDTO.FinalAmount = (tblConsignmentNoteDTO.Amount1
                                                            + tblConsignmentNoteDTO.Amount2
                                                            + tblConsignmentNoteDTO.Amount3
                                                            + tblConsignmentNoteDTO.Amount4
                                                            + tblConsignmentNoteDTO.Amount5);

                    var result = ConsignmentNoteBusinessLogic.Save(tblConsignmentNoteDTO);
                    return RedirectToAction("Index");
                }
            }
            tblConsignmentNoteDTO = FillDropDown(tblConsignmentNoteDTO);
            return View(tblConsignmentNoteDTO);
        }

        [HttpPost]
        public JsonResult DeleteConsignmentNote(int ConsignmentNoteId)
        {
            var result = ConsignmentNoteBusinessLogic.Delete(ConsignmentNoteId);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }

        private tblConsignmentNoteDTO FillDropDown(tblConsignmentNoteDTO tblConsignmentNoteDTO)
        {
            var partyList = ConsignorBusinessLogic.GetAll();
            foreach (var item in partyList)
            {
                item.PartyNameWithCode = item.Code + "-" + item.ConsignorName;
            }
            tblConsignmentNoteDTO.ConsigneeList = partyList.Where(type => type.Type == 1).ToList();
            tblConsignmentNoteDTO.ConsignorList = partyList.Where(type => type.Type == 2).ToList();

            //-------------------
            tblConsignmentNoteDTO.ServiceTaxisPayableByList = new List<SelectListItem>();
            tblConsignmentNoteDTO.ServiceTaxisPayableByList.Add(new SelectListItem { Value = "CONSIGNOR", Text = "CONSIGNOR" });
            tblConsignmentNoteDTO.ServiceTaxisPayableByList.Add(new SelectListItem { Value = "CONSIGNEE", Text = "CONSIGNEE" });
            tblConsignmentNoteDTO.ServiceTaxisPayableByList.Add(new SelectListItem { Value = "Transport", Text = "Transport" });

            return tblConsignmentNoteDTO;
        }
    }
}