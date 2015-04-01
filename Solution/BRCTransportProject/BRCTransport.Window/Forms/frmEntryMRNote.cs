using BRCTransport.BAL;
using BRCTransport.Domain;
using BRCTransport.Window.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRCTransport.Window.Forms
{
    public partial class frmEntryMRNote : Form
    {
        public frmEntryMRNote()
        {
            InitializeComponent();
        }

      

        public static int MRId { get; set; }

        #region Key Event

        private void EnterEvent(object sender, EventArgs e)
        {
            CommonClass.EnterEvents(sender, e);
        }

        private void LeaveEvent(object sender, EventArgs e)
        {
            CommonClass.LeaveEvents(sender, e);
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtBillNo_Leave(object sender, EventArgs e)
        {
           var billInfo = MRNoteBusinessLogic.GetMRNoteBillDetail(Convert.ToInt32(txtBillNo.Text));
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                tblMRNoteDTO tblMRNoteDTO = new tblMRNoteDTO();
               tblMRNoteDTO.MRDate = dpDate.MinDate;
                tblMRNoteDTO.MrNo = Convert.ToInt32(txtMRNo.Text);
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        #region Private Method
        private Boolean ValidateData()
        {
            ErrorHanding.SetErrorCount();
            ErrorHanding.SetTextboxErrorWithCount(errorMRNo, txtMRNo, "Enter MR number");
            ErrorHanding.SetTextboxErrorWithCount(errorReceivedFrom, txtReceivedFrom, "Enter Place where you receive from");
            ErrorHanding.SetTextboxErrorWithCount(errorFrom, txtFrom, "Enter Place");
            ErrorHanding.SetTextboxErrorWithCount(errorTo, txtTo, "Enter Place where you want to Send Items.");
            ErrorHanding.SetTextboxErrorWithCount(errorBillAmount, txtBillAmount, "Enter Bill Amount");
            ErrorHanding.SetTextboxErrorWithCount(errorNoofPackage, txtNoofPackage, "Enter number of Packages");
            ErrorHanding.SetTextboxErrorWithCount(errorWeight, txtWeight, "Enter weight");
            ErrorHanding.SetTextboxErrorWithCount(errorReceivedAmount, txtReceivedAmount, "Enter received amount");

            if (ErrorHanding.GetErrorCount() == 0)
                return true;
            else
                return false;

        }
        #endregion

       

    }
}
