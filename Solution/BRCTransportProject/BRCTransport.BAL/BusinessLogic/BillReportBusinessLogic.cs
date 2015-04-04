using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class BillReportBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static List<BillReportDTO> GetBillPartyWiseReport(int companyId, DateTime startdate, DateTime enddate)
        {
            return ReportRepository.GetBillPartyWiseReport(companyId, startdate, enddate);
        }

        public static List<BillReportDTO> GetMRReport(int companyId, DateTime startdate, DateTime enddate, int billNo)
        {
            return ReportRepository.GetMRReport(companyId, startdate, enddate, billNo);
        }

        #endregion
    }
}
