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
    public class AccountMasterController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetAccountMaster()
        {
            var AccountsMasterList = AccountsMasterBusinessLogic.GetAll();
            return View(new GridModel(AccountsMasterList));
        }

        public ActionResult Save(int id)
        {
            tblAccountsMasterDTO tblAccountsMasterDTO;
            if (id == 0)
            {
                tblAccountsMasterDTO = new tblAccountsMasterDTO();
            }
            else
            {
                tblAccountsMasterDTO = AccountsMasterBusinessLogic.Get(id);
            }

            return View(tblAccountsMasterDTO);
        }

        [HttpPost]
        public ActionResult Save(tblAccountsMasterDTO tblAccountsMasterDTO)
        {
            if (ModelState.IsValid)
            {
                var resultCheckDuplicateAccount = AccountsMasterBusinessLogic.CheckDuplicateAccount(tblAccountsMasterDTO.AccountName, tblAccountsMasterDTO.AccountId);
                if (resultCheckDuplicateAccount)
                {
                    ModelState.AddModelError("AccountName", "Account name already exists.");
                }
                else
                {
                    var result = AccountsMasterBusinessLogic.Save(tblAccountsMasterDTO);
                    if (result > 0)
                        return RedirectToAction("Index");
                }
            }
            return View(tblAccountsMasterDTO);
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteAccountsMaster(int id)
        {
            var result = AccountsMasterBusinessLogic.Delete(id);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }


    }
}