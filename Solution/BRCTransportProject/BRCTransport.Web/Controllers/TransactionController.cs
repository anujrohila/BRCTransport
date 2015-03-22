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
    public class TransactionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [GridAction]
        public ActionResult _AjaxGetTransaction()
        {
            var TransactionList = TransactionBusinessLogic.GetAll();
            return View(new GridModel(TransactionList));
        }

        [HttpGet]
        public ActionResult Save(int id)
        {
            tblTransactionDTO tblTransactionDTO;
            if (id == 0)
            {
                tblTransactionDTO = new tblTransactionDTO();
            }
            else
            {
                tblTransactionDTO = TransactionBusinessLogic.Get(id);
            }
            tblTransactionDTO = FillDropDown(tblTransactionDTO);
            return View(tblTransactionDTO);
        }

        [HttpPost]
        public ActionResult Save(tblTransactionDTO tblTransactionDTO)
        {
            if (ModelState.IsValid)
            {
                CheckValidation(tblTransactionDTO);
                if (ModelState.IsValid)
                {
                    if (tblTransactionDTO.TransactionType == 1)
                    {
                        tblTransactionDTO.CrAmount = tblTransactionDTO.Amount;
                    }
                    else
                    {
                        tblTransactionDTO.DrAmount = tblTransactionDTO.Amount;
                    }
                    var result = TransactionBusinessLogic.Save(tblTransactionDTO);
                    if (result > 0)
                        return RedirectToAction("Index");
                }
            }
            tblTransactionDTO = FillDropDown(tblTransactionDTO);
            return View(tblTransactionDTO);
        }

        /// <summary>
        /// Check validation
        /// </summary>
        private void CheckValidation(tblTransactionDTO tblTransactionDTO)
        {
            if (tblTransactionDTO.Amount == 0)
            {
                ModelState.AddModelError("Amount", "Amount must be greater than 0.");
            }
        }

        /// <summary>
        /// Save camera view post
        /// </summary>
        /// <param name="eventCameraViewDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteTransaction(int id)
        {
            var result = TransactionBusinessLogic.Delete(id);
            if (result)
            {
                return Json(new { Success = true, Message = "Delete Successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction." });
        }

        /// <summary>
        /// Fill drop downs
        /// </summary>
        /// <param name="tblTransactionDTO"></param>
        /// <returns></returns>
        private tblTransactionDTO FillDropDown(tblTransactionDTO tblTransactionDTO)
        {
            var accountList = AccountsMasterBusinessLogic.GetAll();
            tblTransactionDTO.Accounts = accountList;
            return tblTransactionDTO;

        }
    }
}