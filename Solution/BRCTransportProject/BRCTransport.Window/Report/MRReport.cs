using BRCTransport.BAL;
using BRCTransport.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRCTransport.Window.Report
{
    public partial class MRReport : Form
    {
        public MRReport()
        {
            InitializeComponent();
        }

        private void FillPartys()
        {
            var partyList = ConsignorBusinessLogic.GetAll();
            foreach (var item in partyList)
            {
                item.PartyNameWithCode = item.Code + "-" + item.ConsignorName;
            }

            partyList.Insert(0, new tblConsignorDTO { ConsignorId = 0, PartyNameWithCode = "Select" });
            cbPartyWise.DataSource = partyList;
        }

        private void FilLReport()
        {
            int billNo;
            int.TryParse(txtBillNo.Text, out billNo);
            var result = BillReportBusinessLogic.GetMRReport(int.Parse(cbPartyWise.SelectedValue.ToString()), ddlStartDate.Value, ddlEndDate.Value, billNo);
            BRCTransport.Window.ReportFiles.MRNoteReport myDataReport = new BRCTransport.Window.ReportFiles.MRNoteReport();

            myDataReport.SetDataSource(result);

            crystalReportViewer.ReportSource = myDataReport;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FilLReport();
        }

        private void MRReport_Load(object sender, EventArgs e)
        {
            ddlStartDate.Value = DateTime.Now.AddMonths(-1);
            FillPartys();
        }
    }
}
