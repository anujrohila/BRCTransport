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
        public int MRId = 0;

        public frmEntryMRNote()
        {
            InitializeComponent();
            this.Load += frmEntryMRNote_Load;
        }

        private void GenerateCode()
        {
            txtMRno.Text = Convert.ToString(MRNoteBusinessLogic.GetMRNo() + 1);
        }

        void frmEntryMRNote_Load(object sender, EventArgs e)
        {
            if (MRId > 0)
            {
                var tblMRNoteDTO = MRNoteBusinessLogic.Get(MRId);
                txtMRno.Text = Convert.ToString(tblMRNoteDTO.MrNo);
                txtbillno.Text = Convert.ToString(tblMRNoteDTO.BillNo);
                dpDate.Text = Convert.ToString(tblMRNoteDTO.MRDate);
                txtRecievefrom.Text = tblMRNoteDTO.RecievedFrom;
                txtfrom.Text = tblMRNoteDTO.LocationFrom;
                txtto.Text = tblMRNoteDTO.LocationTo;

                dpbilldate.Text = tblMRNoteDTO.BillDate;
                txtBillAmount.Text = Convert.ToString(tblMRNoteDTO.BillAmount);
                txtNoofPackage.Text = tblMRNoteDTO.NoofPackages;
                txtWeight.Text = tblMRNoteDTO.Weight;
                txtRecievedAmount.Text = Convert.ToString(tblMRNoteDTO.AmountRecieved);
                cmbPaymentType.Text = tblMRNoteDTO.WayOfRecieve;
                txtFright.Text = Convert.ToString(tblMRNoteDTO.Fright);
                txtstch.Text = Convert.ToString(tblMRNoteDTO.StCharges);
                txtHamali.Text = Convert.ToString(tblMRNoteDTO.Hamali);
                txtOther1.Text = Convert.ToString(tblMRNoteDTO.Other1);
                txtOther2.Text = Convert.ToString(tblMRNoteDTO.Other2);
                txtOther3.Text = Convert.ToString(tblMRNoteDTO.Other3);
                txtOther4.Text = Convert.ToString(tblMRNoteDTO.Other4);
                txtTotal.Text = Convert.ToString(tblMRNoteDTO.TotalAmount);
                GenerateCode();
            }
            else
            {
                GenerateCode();
                cmbPaymentType.SelectedIndex = 0;

            }
        }

        private bool IsFormValidate()
        {
            ErrorHanding.SetErrorCount();
            ErrorHanding.SetTextboxErrorWithCount(errorDate, dpDate, "Select Date");
            ErrorHanding.SetTextboxErrorWithCount(errorMrNo, txtMRno, "Enter MR No");
            ErrorHanding.SetTextboxErrorWithCount(errorREcievedFrom, txtRecievefrom, "Enter Reciever from Name");
            ErrorHanding.SetTextboxErrorWithCount(errorFrom, txtfrom, "Enter from");
            ErrorHanding.SetTextboxErrorWithCount(errorTo, txtto, "Enter to");

            ErrorHanding.SetTextboxErrorWithCount(errorBillno, txtbillno, "Enterbillno");
            ErrorHanding.SetTextboxErrorWithCount(errorDate, dpbilldate, "Enter date");
            ErrorHanding.SetTextboxErrorWithCount(errorBillAmount, txtBillAmount, "Select bill amount");
            ErrorHanding.SetTextboxErrorWithCount(errorNoofPackage, txtNoofPackage, "Enter no of package");
            ErrorHanding.SetTextboxErrorWithCount(errorWeight, txtWeight, "Enter weight");

            ErrorHanding.SetTextboxErrorWithCount(errorRecievedAmount, txtRecievedAmount, "Enter recieve amount");
            ErrorHanding.SetTextboxErrorWithCount(errorPaymenttype, cmbPaymentType, "Select Payment Type");

            if (ErrorHanding.GetErrorCount() == 0)
                return true;
            else
                return false;

        }

        private void CleanData()
        {
            txtMRno.Text = "";
            txtbillno.Text = "";
            dpDate.Text = "";
            txtRecievefrom.Text = "";
            txtfrom.Text = "";
            txtto.Text = "";
            txtbillno.Text = "";
            dpbilldate.Text = "";
            txtBillAmount.Text = "";
            txtNoofPackage.Text = "";
            txtWeight.Text = "";
            txtRecievedAmount.Text = "";
            cmbPaymentType.SelectedIndex = 0;
            txtFright.Text = "";
            txtstch.Text = "";
            txtHamali.Text = "";
            txtOther1.Text = "";
            txtOther2.Text = "";
            txtOther3.Text = "";
            txtOther4.Text = "";
            txtTotal.Text = "";
            GenerateCode();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValidate())
            {
                tblMRNoteDTO dto = new tblMRNoteDTO();

                if (MRId > 0)
                    dto.MRId = MRId;
                dto.MrNo = Convert.ToInt32(txtMRno.Text);
                dto.BillId = Convert.ToInt32(txtbillno.Text);
                dto.MRDate = Convert.ToDateTime(dpDate.Text);
                dto.RecievedFrom = txtRecievefrom.Text;
                dto.LocationFrom = txtfrom.Text;
                dto.LocationTo = txtto.Text;
                dto.BillNo = Convert.ToInt32(txtbillno.Text);
                dto.BillDate = dpbilldate.Text;
                dto.BillAmount = Convert.ToDouble(txtBillAmount.Text);
                dto.NoofPackages = txtNoofPackage.Text;
                dto.Weight = txtWeight.Text;
                dto.AmountRecieved = txtRecievedAmount.Text.Trim() == "" ? 0 : Convert.ToDouble(txtRecievedAmount.Text);
                dto.WayOfRecieve = cmbPaymentType.SelectedText;
                dto.Fright = txtFright.Text.Trim() == "" ? 0 : Convert.ToDouble(txtFright.Text);
                dto.StCharges = txtstch.Text.Trim() == "" ? 0 : Convert.ToDouble(txtstch.Text);
                dto.Hamali = txtHamali.Text.Trim() == "" ? 0 : Convert.ToDouble(txtHamali.Text);
                dto.Other1 = txtOther1.Text.Trim() == "" ? 0 : Convert.ToDouble(txtOther1.Text);
                dto.Other2 = txtOther2.Text.Trim() == "" ? 0 : Convert.ToDouble(txtOther2.Text);
                dto.Other3 = txtOther3.Text.Trim() == "" ? 0 : Convert.ToDouble(txtOther3.Text);
                dto.Other4 = txtOther4.Text.Trim() == "" ? 0 : Convert.ToDouble(txtOther4.Text);
                dto.TotalAmount = txtTotal.Text.Trim() == "" ? 0 : Convert.ToDouble(txtTotal.Text);
                dto.CreationDate = DateTime.Now;

                var result = MRNoteBusinessLogic.Save(dto);
                if (result > 0)
                {
                    if (MRId > 0)
                        this.Close();
                    else
                        CleanData();
                }
                else
                {
                    MessageBox.Show("Transaction Fail");
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbillno_Leave(object sender, EventArgs e)
        {
            if(txtbillno.Text.Trim() =="")
                return;

            var result = MRNoteBusinessLogic.GetMRNoteBillDetail(Convert.ToInt32(txtbillno.Text));
            if (result == null)
            {
                MessageBox.Show("No bill found.");
            }
            else if (result != null && result.PendingAmount == 0)
            {
                MessageBox.Show("Bill already paid.");
                // return Json(new { Success = false, Message = "Bill already paid." });
            }
            else if (result != null)
            {
                dpbilldate.Text = result.BillDateString;
                txtBillAmount.Text = Convert.ToString(result.GrandTotal);
                txtRecievedAmount.Text = Convert.ToString(result.PendingAmount);
                CommonClass.LeaveEvents(sender, e);
                return;
            }
            txtbillno.Focus();
            dpbilldate.Text = "";
            txtBillAmount.Text = "";
        }
    }
}
