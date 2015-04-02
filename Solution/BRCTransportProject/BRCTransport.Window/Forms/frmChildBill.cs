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
    public partial class frmChildBill : Form
    {
        public int srno = 0;
        public tblBillEntryDTO billdata = null;

        public frmChildBill()
        {
            InitializeComponent();

            this.Load += frmChildBill_Load;
        }

        void frmChildBill_Load(object sender, EventArgs e)
        {
            if (billdata != null)
            {
                txtBrcode.Text = billdata.BookingOldBrCode;
                dpBillDate.Text = Convert.ToString(billdata.OldBillDate);
                txtbillno.Text = billdata.OldBillNo;
                txtdestncode.Text = billdata.DestnCode;
                txtperticulers.Text = billdata.Particulars;
                txtchagesWeight.Text = billdata.ChargedWeight;
                txtrate.Text = billdata.Rate;
                txtamount.Text = Convert.ToString(billdata.Amount);
            }
            txtBrcode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tblBillEntryDTO temp = new tblBillEntryDTO();
            var srno = 1;
            if (CommonClass.tblBillEntryDTO.Count() > 0)
            {
                srno = CommonClass.tblBillEntryDTO.Select(h => h.SrNo).Max() + 1;
            }

            temp.SrNo = srno;
            temp.BookingOldBrCode = txtBrcode.Text;
            temp.OldBillDate = Convert.ToDateTime(dpBillDate.Text);
            temp.OldBillNo = txtbillno.Text;
            temp.DestnCode = txtdestncode.Text;
            temp.Particulars = txtperticulers.Text;
            temp.ChargedWeight = txtchagesWeight.Text;
            temp.Rate = txtrate.Text;
            temp.Amount = txtamount.Text.Trim() == "" ? 0 : Convert.ToDouble(txtamount.Text);

            if (billdata != null)
            {
                temp.SrNo = billdata.SrNo;
                CommonClass.tblBillEntryDTO.Remove(billdata);
                CommonClass.tblBillEntryDTO.Add(temp);
                this.Close();
            }
            else
                CommonClass.tblBillEntryDTO.Add(temp);
            CleanData();
        }

        private void CleanData()
        {
            txtBrcode.Text = "";
            dpBillDate.Text = Convert.ToString(DateTime.Today);
            txtbillno.Text = "";
            txtdestncode.Text = "";
            txtperticulers.Text = "";
            txtrate.Text = "";
            txtamount.Text = "";
            txtchagesWeight.Text = "";
            txtBrcode.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
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

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonClass.KeyPressEvents(sender, e);
        }


        #endregion

    }
}
