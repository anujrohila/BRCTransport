using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class ReportRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static List<BillReportDTO> GetBillPartyWiseReport(int companyId, DateTime startdate, DateTime enddate)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                startdate = startdate.AddMinutes(-1);
                var result = (from billReport in dbObject.tblBills
                              join partyList in dbObject.tblConsignors on billReport.PartyId equals partyList.ConsignorId
                              where billReport.BillDate >= startdate && billReport.BillDate <= enddate
                              select new BillReportDTO
                              {
                                  BillId = billReport.BillId,
                                  BillNo = billReport.BillNo,
                                  BillDate = billReport.BillDate ?? DateTime.Now,
                                  BillType = billReport.BillType,
                                  CompanyId = billReport.PartyId ?? 0,
                                  BranchCode = billReport.BranchCode,
                                  PaymentDueDate = billReport.PaymentDueDate ?? DateTime.Now,
                                  BasicOfChargesGC = billReport.BasicOfChargesGC == null ? string.Empty : billReport.BasicOfChargesGC,
                                  Enclosure = billReport.Enclosure,
                                  ServiceTaxThrough = billReport.ServiceTaxThrough,
                                  CheckedBy = billReport.CheckedBy == null ? string.Empty :  billReport.CheckedBy,
                                  GrandTotal = billReport.GrandTotal ?? 0,
                                  CompanyName = partyList.Code + " - " + partyList.ConsignorName,
                                  Address = partyList.Address,
                                  Description = partyList.Description,
                                  PhoneNo = partyList.PhoneNo,
                                  PolicyNo = partyList.PhoneNo,
                                  ServiceTaxRegdNo = billReport.ServiceTaxRegdNo == null ? string.Empty : billReport.ServiceTaxRegdNo,
                                  RecievePayment = (billReport.tblMRNotes.Count == 0 ? 0 : billReport.tblMRNotes.Sum(mrNote => mrNote.AmountRecieved) ?? 0),
                                  DueAmount = (billReport.GrandTotal - (billReport.tblMRNotes.Count == 0 ? 0 : billReport.tblMRNotes.Sum(mrNote => mrNote.AmountRecieved) ?? 0)) ?? 0
                              }).ToList();

                if (companyId > 0)
                {
                    result = result.Where(billList => billList.CompanyId == companyId).OrderBy(o => o.CompanyName).ToList();
                }

                return result;
            }


        }

        #endregion
    }
}
