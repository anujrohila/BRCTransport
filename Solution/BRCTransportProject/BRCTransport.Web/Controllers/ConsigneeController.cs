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
    public class ConsigneeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetConsignee()
        {
            var consigneeList = ConsigneeBusinessLogic.GetAll();
            return View(new GridModel(consigneeList));
        }

        public ActionResult Save(int id)
        {
            tblConsigneeDTO tblConsigneeDTO;
            if (id == 0)
            {
                tblConsigneeDTO = new tblConsigneeDTO();
            }
            else
            {
                tblConsigneeDTO = ConsigneeBusinessLogic.Get(id);
            }
            return View(tblConsigneeDTO);
        }

        [HttpPost]
        public ActionResult Save(tblConsigneeDTO tblConsigneeDTO)
        {
            if (ModelState.IsValid)
            {
                tblConsigneeDTO.CreationDate = DateTime.Now;
                var result = ConsigneeBusinessLogic.Save(tblConsigneeDTO);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View(tblConsigneeDTO);
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteConsignee(int id)
        {
            var result = ConsigneeBusinessLogic.Delete(id);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }


    }
}