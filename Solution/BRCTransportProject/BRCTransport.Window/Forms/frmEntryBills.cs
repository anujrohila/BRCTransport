using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRCTransport.BAL;
using BRCTransport.Window.Class;
using BRCTransport.Domain;

namespace BRCTransport.Window.Forms
{
    public partial class frmEntryBills : Form
    {
        public int BillId = 0;
        public frmEntryBills()
        {
            InitializeComponent();
            this.Load += frmEntryBill_Load;
            grdEntryBill.AutoGenerateColumns = false;
        }

        void frmEntryBill_Load(object sender, EventArgs e)
        {
            FillDropDown();
            if (BillId > 0)
            {
                var bill = BillBusinessLogic.Get(BillId); ;
                textbillno.Text = Convert.ToString(bill.BillNo);
                dateTimebilldate.Text = Convert.ToString(bill.BillDateString);
                cmbParty.SelectedItem = Convert.ToString(bill.PartyId);
                textbranchcode.Text = bill.BranchCode;
                dateTimeduedate.Text = Convert.ToString(bill.PaymentDueDateString);
                combotickbill.SelectedItem = bill.BillType;
                textbasicofchange.Text = bill.BasicOfChargesGC;
                textenclosure.Text = bill.Enclosure;
                comboservicetax.SelectedItem = bill.ServiceTaxThrough;
                textcheckedby.Text = bill.CheckedBy;
                texttaxregdno.Text = bill.ServiceTaxThrough;
                textservicetax.Text = bill.ServiceTaxRegdNo;
                int i = 1;
                foreach (var item in bill.BillEntryList)
                {
                    item.SrNo = i++;
                    CommonClass.tblBillEntryDTO.Add(item);
                }
                fillGridData();
            }
            else
            {
                textbillno.Text = Convert.ToString(BillBusinessLogic.GetBillNo() + 1);
            }
        }

        private void CleanData()
        {
            textbillno.Text = "";
            dateTimebilldate.Text = "";
            cmbParty.SelectedValue = "";
            textbranchcode.Text = "";
            dateTimeduedate.Text = "";
            combotickbill.SelectedItem = "";
            textbasicofchange.Text = "";
            textenclosure.Text = "";
            comboservicetax.SelectedItem = "";
            textcheckedby.Text = "";
            textservicetax.Text = "";
            CommonClass.tblBillEntryDTO.Clear();
            grdEntryBill.DataSource = null;
            textbillno.Text = Convert.ToString(BillBusinessLogic.GetBillNo() + 1);
            cmbParty.Focus();

        }

        private void FillDropDown()
        {
            var partyList = ConsignorBusinessLogic.GetAll();
            foreach (var item in partyList)
            {
                item.PartyNameWithCode = item.Code + "-" + item.ConsignorName;
            }
            cmbParty.DataSource = partyList;
            cmbParty.DisplayMember = "PartyNameWithCode";
            cmbParty.ValueMember = "ConsignorId";
        }

        private Boolean validatedata()
        {
            ErrorHanding.SetErrorCount();
            ErrorHanding.SetTextboxErrorWithCount(errorPartyName, cmbParty, "Enter Party Name");
            ErrorHanding.SetTextboxErrorWithCount(errorBrandcode, textbranchcode, "Enter Branch Code");
            ErrorHanding.SetTextboxErrorWithCount(errorbilldate, dateTimebilldate, "Select Date");
            ErrorHanding.SetTextboxErrorWithCount(errorPaymentDuedate, dateTimeduedate, "Select Date");
            ErrorHanding.SetTextboxErrorWithCount(errorTickbillType, combotickbill, "Select Tick Bill Type");
            ErrorHanding.SetTextboxErrorWithCount(errorServiceTex, comboservicetax, "Select Service tax");

            if (ErrorHanding.GetErrorCount() == 0)
                return true;
            else
                return false;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validatedata())
            {
                if (CommonClass.tblBillEntryDTO.Count() == 0)
                {
                    MessageBox.Show("Enter Atlease On Bill Entry");
                    return;
                }

                var resultDuplicateBllNo = BillBusinessLogic.CheckDuplicateBillNo(BillId, Convert.ToInt32(textbillno.Text));
                if (resultDuplicateBllNo)
                {
                    MessageBox.Show("Bill no already exists.");
                }
                else
                {

                    tblBillDTO tblbilldto = new tblBillDTO();
                    if (BillId > 0)
                        tblbilldto.BillId = BillId;
                    tblbilldto.BillNo = Convert.ToInt32(textbillno.Text);
                    tblbilldto.BillDate = Convert.ToDateTime(dateTimebilldate.Text);
                    tblbilldto.PartyId = Convert.ToInt32(cmbParty.SelectedValue);
                    tblbilldto.BranchCode = textbranchcode.Text;
                    tblbilldto.PaymentDueDate = Convert.ToDateTime(dateTimeduedate.Text);
                    tblbilldto.BillType = Convert.ToString(combotickbill.SelectedItem);
                    tblbilldto.BasicOfChargesGC = textbasicofchange.Text;
                    tblbilldto.Enclosure = textenclosure.Text;
                    tblbilldto.ServiceTaxThrough = Convert.ToString(comboservicetax.SelectedItem);
                    tblbilldto.CheckedBy = textcheckedby.Text;
                    tblbilldto.GrandTotal = Convert.ToInt32(CommonClass.tblBillEntryDTO.Sum(h => h.Amount));
                    tblbilldto.ServiceTaxRegdNo = textservicetax.Text;
                    tblbilldto.BillEntryList = CommonClass.tblBillEntryDTO;
                    var result = BillBusinessLogic.Save(tblbilldto);
                    if (result > 0)
                    {
                        MessageBox.Show("Bill Succussfully Generate");
                        if (BillId != 0)
                        {
                            this.Close();
                        }
                        else
                        {
                            CleanData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bill Generation Fail Dua to some Problem");
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            frmChildBill frmchilbill = new frmChildBill();
            frmchilbill.FormClosed += frmchilbill_FormClosed;
            frmchilbill.ShowDialog();
        }

        void frmchilbill_FormClosed(object sender, FormClosedEventArgs e)
        {
            fillGridData();
        }

        private void fillGridData()
        {
            grdEntryBill.DataSource = null;
            if (CommonClass.tblBillEntryDTO != null)
                grdEntryBill.DataSource = CommonClass.tblBillEntryDTO.OrderBy(h => h.SrNo).ToList();
        }

        private void grdEntryBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Action = this.grdEntryBill.Columns[e.ColumnIndex].HeaderText;

            if (Action == "Edit")
            {
                frmChildBill frmchilbill = new frmChildBill();
                int billid = Convert.ToInt32(grdEntryBill.Rows[e.RowIndex].Cells["SrNo"].Value);
                frmchilbill.billdata = CommonClass.tblBillEntryDTO.Where(h => h.SrNo == billid).FirstOrDefault();
                frmchilbill.FormClosed += frmchilbill_FormClosed;
                frmchilbill.ShowDialog();
            }

            if (Action == "Delete")
            {
                try
                {
                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        int billid = Convert.ToInt32(grdEntryBill.Rows[e.RowIndex].Cells[0].Value);
                        tblBillEntryDTO billdata = CommonClass.tblBillEntryDTO.Where(h => h.SrNo == billid).FirstOrDefault();
                        CommonClass.tblBillEntryDTO.Remove(billdata);
                        fillGridData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bill already used some where else can't deleted successfully.");
                }

            }
        }

        #region Key Event

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonClass.KeyPressEvents(sender, e);
        }

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

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }


        #endregion
    }
}
