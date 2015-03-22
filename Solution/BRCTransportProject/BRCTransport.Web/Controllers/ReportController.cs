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
using Microsoft.Reporting.WebForms;

namespace BRCTransport.Web.Controllers
{
    public class ReportController : Controller
    {
        #region [Party Wise Report]


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BillPartyWiseReport()
        {
            var reportBillPartyWiseSearch = new ReportBillPartyWiseSearch();
            reportBillPartyWiseSearch.IsSearchClick = false;
            reportBillPartyWiseSearch.StartDate = DateTime.Today.AddMonths(-2).ToShortDateString();
            reportBillPartyWiseSearch.EndDate = DateTime.Today.ToShortDateString();
            var partyList = ConsignorBusinessLogic.GetAll();
            foreach (var item in partyList)
            {
                item.PartyNameWithCode = item.Code + "-" + item.ConsignorName;
            }
            reportBillPartyWiseSearch.PartyList = partyList;
            reportBillPartyWiseSearch.PartyList.Insert(0, new tblConsignorDTO { ConsignorId = 0, PartyNameWithCode = "Select" });
            return View(reportBillPartyWiseSearch);
        }

        [HttpPost]
        public ActionResult BillPartyWiseReport(ReportBillPartyWiseSearch reportBillPartyWiseSearch)
        {
            reportBillPartyWiseSearch.IsSearchClick = true;
            var partyList = ConsignorBusinessLogic.GetAll();
            foreach (var item in partyList)
            {
                item.PartyNameWithCode = item.Code + "-" + item.ConsignorName;
            }
            reportBillPartyWiseSearch.PartyList = partyList;
            reportBillPartyWiseSearch.PartyList.Insert(0, new tblConsignorDTO { ConsignorId = 0, PartyNameWithCode = "Select" });
            return View(reportBillPartyWiseSearch);
        }

        public FileContentResult GenerateAndDisplayReport(int countryId, string startDate, string endDate, string format)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Server.MapPath("~/Content/Report/ReportBillPartyWiseReport.rdlc");
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            DateTime sDate;
            DateTime.TryParse(startDate, out sDate);
            DateTime eDate;
            DateTime.TryParse(endDate, out eDate);
            reportDataSource.Value = BillReportBusinessLogic.GetBillPartyWiseReport(countryId, sDate, eDate);

            localReport.DataSources.Add(reportDataSource);
            string reportType = "Image";
            string mimeType;
            string encoding;
            string fileNameExtension;
            string deviceInfo = "<DeviceInfo>" +
                "  <OutputFormat>jpeg</OutputFormat>" +
                "  <PageWidth>11.5in</PageWidth>" +
                "  <PageHeight>8.5in</PageHeight>" +
                "  <MarginTop>0in</MarginTop>" +
                "  <MarginLeft>0in</MarginLeft>" +
                "  <MarginRight>0in</MarginRight>" +
                "  <MarginBottom>0in</MarginBottom>" +
                "</DeviceInfo>";
            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;
            renderedBytes = localReport.Render(reportType, deviceInfo, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);
            //return File(renderedBytes, "image/jpeg");
            return File(renderedBytes, "pdf");
        }

        public ActionResult DownloadReport(int countryId, string startDate, string endDate, string format)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Server.MapPath("~/Content/Report/ReportBillPartyWiseReport.rdlc");
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            DateTime sDate;
            DateTime.TryParse(startDate, out sDate);
            DateTime eDate;
            DateTime.TryParse(endDate, out eDate);
            reportDataSource.Value = BillReportBusinessLogic.GetBillPartyWiseReport(countryId, sDate, eDate);
            localReport.DataSources.Add(reportDataSource);
            string reportType = "Image";
            string mimeType;
            string encoding;
            string fileNameExtension;
            //The DeviceInfo settings should be changed based on the reportType            
            //http://msdn2.microsoft.com/en-us/library/ms155397.aspx            
            string deviceInfo = "<DeviceInfo>" +
                "  <OutputFormat>jpeg</OutputFormat>" +
                "  <PageWidth>11.5in</PageWidth>" +
                "  <PageHeight>8.5in</PageHeight>" +
                "  <MarginTop>0in</MarginTop>" +
                "  <MarginLeft>0in</MarginLeft>" +
                "  <MarginRight>0in</MarginRight>" +
                "  <MarginBottom>0in</MarginBottom>" +
                "</DeviceInfo>";
            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;
            renderedBytes = localReport.Render(reportType, deviceInfo, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);
            if (format.ToUpper() == "PDF")
            {
                return File(renderedBytes, mimeType);
            }
            else
            {
                return File(renderedBytes, mimeType);
            }
        }

        #endregion
    }
}