using BRCTransport.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRCTransport.Domain;
using BRCTransport.Window.Class;

namespace BRCTransport.Window.Forms
{
    public partial class frmParty : Form
    {
        public Int32 PartyId = 0;
        
        public frmParty()
        {
            InitializeComponent();
        }

        private void frmPartys_Load(object sender, EventArgs e)
        {
            if (PartyId > 0)
            {
                var partyDetails = ConsignorBusinessLogic.Get(PartyId);
                
                txtPartyName.Text = partyDetails.ConsignorName;
                txtCode.Text = partyDetails.Code;
                if (partyDetails.Type == 1)
                {
                    cbType.SelectedItem = "Consignor";
                }
                else
                {
                    cbType.SelectedItem = "Consignee";
                }
                txtAddress.Text = partyDetails.Address;
                txtPhoneNo.Text = partyDetails.PhoneNo;
                txtSTNOCSTNO.Text = partyDetails.STNOCSTNO;
                txtTINNOVATNO.Text = partyDetails.TINNOVATNO;
                txtDescription.Text = partyDetails.Description;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValidate())
            {
                tblConsignorDTO tblConsignorDTO = new tblConsignorDTO();
                
                tblConsignorDTO.ConsignorId = PartyId;
                tblConsignorDTO.ConsignorName = txtPartyName.Text;
                tblConsignorDTO.Code = txtCode.Text;
                if (Convert.ToString(cbType.SelectedItem) == "Consignor")
                {
                    tblConsignorDTO.Type = 1;
                }
                else
                {
                    tblConsignorDTO.Type = 2;
                }
                tblConsignorDTO.Address = txtAddress.Text;
                tblConsignorDTO.PhoneNo = txtPhoneNo.Text;
                tblConsignorDTO.STNOCSTNO = txtSTNOCSTNO.Text;
                tblConsignorDTO.TINNOVATNO = txtTINNOVATNO.Text;
                tblConsignorDTO.Description = txtDescription.Text;
                if (ConsignorBusinessLogic.CheckDuplicateCodeExists(tblConsignorDTO.Code, tblConsignorDTO.ConsignorId) == false)
                {
                    tblConsignorDTO.CreationDate = DateTime.Now;
                    var result = ConsignorBusinessLogic.Save(tblConsignorDTO);
                    if(PartyId > 0)
                       this.Close();
                }
                else
                {
                    MessageBox.Show("Code already exists.");
                }
            }
        }

        private bool IsFormValidate()
        {
            ErrorHanding.SetErrorCount();
            ErrorHanding.SetTextboxErrorWithCount(errorPartyname, txtPartyName, "Enter Party name");
            ErrorHanding.SetTextboxErrorWithCount(errorCode, txtCode, "Enter Code");
            ErrorHanding.SetTextboxErrorWithCount(errorType,cbType , "Select Type");
            ErrorHanding.SetTextboxErrorWithCount(errorAddress, txtAddress, "Enter Address");
            ErrorHanding.SetTextboxErrorWithCount(errorPhoneNo, txtPhoneNo, "Enter Phone No.");

            if (ErrorHanding.GetErrorCount() == 0)
                return true;
            else
                return false;

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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
