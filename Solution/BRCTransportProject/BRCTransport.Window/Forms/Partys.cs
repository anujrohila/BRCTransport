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
                    if (result > 0)
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
            bool isValidate = true;
            if (string.IsNullOrWhiteSpace(txtPartyName.Text))
            {
                MessageBox.Show("Please provide party name.");
                txtPartyName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Please provide code.");
                txtCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(cbType.SelectedItem)))
            {
                MessageBox.Show("Please provide type.");
                txtPartyName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please provide address.");
                txtAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("Please provide phone no.");
                txtPhoneNo.Focus();
                return false;
            }
            return isValidate;
        }
    }
}
