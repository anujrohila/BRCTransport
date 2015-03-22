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
    public class CompanyController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetCompany()
        {
            var CompanyList = CompanyBusinessLogic.GetAll();
            return View(new GridModel(CompanyList));
        }

        public ActionResult Save(int id)
        {
            tblCompanyDTO tblCompanyDTO;
            if (id == 0)
            {
                tblCompanyDTO = new tblCompanyDTO();
            }
            else
            {
                tblCompanyDTO = CompanyBusinessLogic.Get(id);
            }
            return View(tblCompanyDTO);
        }

        [HttpPost]
        public ActionResult Save(tblCompanyDTO tblCompanyDTO)
        {
            if (ModelState.IsValid)
            {
                var result = CompanyBusinessLogic.Save(tblCompanyDTO);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View(tblCompanyDTO);
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteCompany(int id)
        {
            var result = CompanyBusinessLogic.Delete(id);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }


    }
}