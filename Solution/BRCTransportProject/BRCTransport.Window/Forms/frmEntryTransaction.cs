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
    public partial class frmEntryTransaction : Form
    {
        public int TransactionId = 0;
        public frmEntryTransaction()
        {
            InitializeComponent();
            this.Load += frmEntryTransaction_Load;
        }

        void frmEntryTransaction_Load(object sender, EventArgs e)
        {
            var accountList = AccountsMasterBusinessLogic.GetAll();
            cmbAccountName.DataSource = accountList;
            cmbAccountName.DisplayMember = "AccountName";
            cmbAccountName.ValueMember = "AccountId";

            if (TransactionId > 0)
            {
                var tblTransactionDTO = TransactionBusinessLogic.Get(TransactionId);
                dpTdate.Text = Convert.ToString(tblTransactionDTO.TDate);
                cmbAccountName.SelectedValue = tblTransactionDTO.AccountId;
                if (tblTransactionDTO.TransactionType == 1)
                {
                    rbrecieved.Checked = true;
                }
                else
                {
                    rbPaid.Checked = true;
                }
                txtAmount.Text = Convert.ToString(tblTransactionDTO.Amount);
                txtChanqueno.Text = tblTransactionDTO.ChequeNo;
                dpChaqurDate.Text = Convert.ToString(tblTransactionDTO.ChequeDate);
                txtRecievedby.Text = tblTransactionDTO.Recievedby;
                txtPaidby.Text = tblTransactionDTO.PaidBy;
                txtDescription.Text = tblTransactionDTO.Description;
            }
            cmbAccountName.Focus();
        }

        private void CleanData()
        {
            dpTdate.Text = "";
            cmbAccountName.SelectedIndex = 0;
            rbrecieved.Checked = true;
            txtAmount.Text = "";
            txtChanqueno.Text = "";
            dpChaqurDate.Text = "";
            txtRecievedby.Text = "";
            txtPaidby.Text = "";
            txtDescription.Text = "";
        }


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

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsFormValidate()
        {
            ErrorHanding.SetErrorCount();
            ErrorHanding.SetTextboxErrorWithCount(errorAccountName, cmbAccountName, "Select Account Name");
            ErrorHanding.SetTextboxErrorWithCount(errorTDate, dpTdate, "Select Date");
            ErrorHanding.SetTextboxErrorWithCount(errorChequeno, txtChanqueno, "Enter Cheque No");
            ErrorHanding.SetTextboxErrorWithCount(errorChequeDate, dpChaqurDate, "Select Date");
            ErrorHanding.SetTextboxErrorWithCount(errorPaidBy, txtPaidby, "Enter Paid Person Name");
            ErrorHanding.SetTextboxErrorWithCount(errorRecievedby, txtRecievedby, "Enter Recieve Person Name");
            ErrorHanding.SetTextboxErrorWithCount(errorDescription, txtDescription, "Enter Description");

            if (ErrorHanding.GetErrorCount() == 0)
                return true;
            else
                return false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsFormValidate())
            {
                tblTransactionDTO tblTransactiondto = new tblTransactionDTO();
                if (TransactionId > 0)
                    tblTransactiondto.TransactionId = TransactionId;

                tblTransactiondto.TDate = Convert.ToDateTime(dpTdate.Text);
                tblTransactiondto.AccountId = Convert.ToInt32(cmbAccountName.SelectedValue);

                if (rbPaid.Checked)
                {
                    tblTransactiondto.CrAmount = Convert.ToDouble(txtAmount.Text);
                }
                else
                {
                    tblTransactiondto.DrAmount = Convert.ToDouble(txtAmount.Text);
                }
                tblTransactiondto.ChequeNo = txtChanqueno.Text;
                tblTransactiondto.ChequeDate = Convert.ToDateTime(dpChaqurDate.Text);
                tblTransactiondto.Recievedby = txtRecievedby.Text;
                tblTransactiondto.PaidBy = txtPaidby.Text;
                tblTransactiondto.Description = txtDescription.Text;
                var result = TransactionBusinessLogic.Save(tblTransactiondto);
                if (TransactionId > 0)
                    this.Close();

                CleanData();
            }
         
        }
    }
}
