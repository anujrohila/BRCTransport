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
    public class ConsignorController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetConsignor()
        {
            var ConsignorList = ConsignorBusinessLogic.GetAll();
            foreach (var item in ConsignorList)
            {
                if (item.Type == 1)
                {
                    item.PartyType = "Consignor";
                }
                else
                {
                    item.PartyType = "Consignee";
                }
            }
            return View(new GridModel(ConsignorList));
        }

        public ActionResult Save(int id)
        {
            tblConsignorDTO tblConsignorDTO;
            if (id == 0)
            {
                tblConsignorDTO = new tblConsignorDTO();
            }
            else
            {

                tblConsignorDTO = ConsignorBusinessLogic.Get(id);
            }
            tblConsignorDTO = FillDropDown(tblConsignorDTO);
            return View(tblConsignorDTO);
        }

        [HttpPost]
        public ActionResult Save(tblConsignorDTO tblConsignorDTO)
        {
            if (ModelState.IsValid)
            {
                if (ConsignorBusinessLogic.CheckDuplicateCodeExists(tblConsignorDTO.Code, tblConsignorDTO.ConsignorId) == false)
                {
                    tblConsignorDTO.CreationDate = DateTime.Now;
                    var result = ConsignorBusinessLogic.Save(tblConsignorDTO);
                    if (result > 0)
                        return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Code", "Code already exists.");
                }
            }
            tblConsignorDTO = FillDropDown(tblConsignorDTO);
            return View(tblConsignorDTO);
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteConsignor(int id)
        {
            var result = ConsignorBusinessLogic.Delete(id);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }

        private tblConsignorDTO FillDropDown(tblConsignorDTO tblConsignorDTO)
        {
            tblConsignorDTO.TypeList = new List<SelectListItem>();
            tblConsignorDTO.TypeList.Add(new SelectListItem { Value = "1", Text = "CONSIGNOR" });
            tblConsignorDTO.TypeList.Add(new SelectListItem { Value = "2", Text = "CONSIGNEE" });
            //-------------------
            return tblConsignorDTO;

        }

    }
}