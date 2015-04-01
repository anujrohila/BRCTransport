using BRCTransport.BAL;
using BRCTransport.Domain;
using BRCTransport.Window.Class;
using BRCTransport.Window.Classes;
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
    public partial class frmEntryLRNote : Form
    {
        public frmEntryLRNote()
        {
            InitializeComponent();
            this.Load += frmEntryLRNote_Load;
        }

        void frmEntryLRNote_Load(object sender, EventArgs e)
        {
            loadConsigneeName();
            loadConsignorName();
        }


        #region Private Method

        public void loadConsigneeName()
        {
            cmbConsineeName.DataSource = ConsigneeBusinessLogic.GetAll();
            cmbConsineeName.ValueMember = "ConsigneeId";
            cmbConsineeName.DisplayMember = "ConsigneeName";
        }

        public void loadConsignorName()
        {
            cmbConsignorName.DataSource = ConsignmentNoteBusinessLogic.GetAll();
            cmbConsignorName.ValueMember = "ConsignorId";
            cmbConsignorName.DisplayMember = "ConsignorName";
        }

        //public loadServiceTaxPaybleBy()
        //{
        //    List<ServiceTax> stuList = new List<ServiceTax>();
        //    {
        //             stuList.Add("CONSIGNOR");
        //            stuList.Add("CONSIGNEE");
        //             stuList.Add("Transport");
        //    }


        //}

        private Boolean ValidateData()
        {
            ErrorHanding.SetErrorCount();
            ErrorHanding.SetTextboxErrorWithCount(errorCompanyName, txtCompanyName, "Enter CompanyName");
            ErrorHanding.SetTextboxErrorWithCount(errorConsignmentNote, txtConsignmentNoteNo, "Enter Consignment Note number");
            ErrorHanding.SetTextboxErrorWithCount(errorCharges, txtCharges, "Enter Charges");
            ErrorHanding.SetTextboxErrorWithCount(errorAmount, txtAmount2, "Enter Amount");
            ErrorHanding.SetTextboxErrorWithCount(errorFromCode, txtFromCodeName, "Enter from Code name");
            ErrorHanding.SetTextboxErrorWithCount(errorToCode, txtToCodeName, "Enterto code name");

            if (ErrorHanding.GetErrorCount() == 0)
                return true;
            else
                return false;

        }

        #endregion

        #region setflag()
        public void clearData()
        {
            txtActualWeightInKg.Text = "";
            txtAddressOfIssueOffice.Text = "";
            txtWidth.Text = "";
            txtValidType.Text = "";
            txtTotalCFT.Text = "";
        }
        #endregion



        public static int ConsignmentId { get; set; }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                tblConsignmentNoteDTO consignNoteDTO = new tblConsignmentNoteDTO();
                consignNoteDTO.CompanyName = txtCompanyName.Text;
                consignNoteDTO.ActualWtInKGS = txtActualWeightInKg.Text;
                consignNoteDTO.AddressofIssuing = txtAddressOfIssueOffice.Text;
                consignNoteDTO.AdvancedPaymentAmount = txtAmount1.Text;
               consignNoteDTO.AdvancedPaymentDate = Convert.ToDateTime(dpDate1.MaxDate);
                consignNoteDTO.AdvancedPaymentMRNo = txtMRNo.Text;
                consignNoteDTO.Amount1 = double.Parse(txtAmount2.Text);
                consignNoteDTO.Amount2 = double.Parse(txtAmount3.Text);
                consignNoteDTO.Amount3 = double.Parse(txtAmount4.Text);
                consignNoteDTO.Amount4 = double.Parse(txtAmount5.Text);
                consignNoteDTO.Amount5 = double.Parse(txtAmount6.Text);
                consignNoteDTO.BasicOfBooking = txtBasicOfBooking.Text;
                consignNoteDTO.BilledWithMs = txtBilledWith.Text;
                consignNoteDTO.BranchCode = txtBranchCode.Text;
                consignNoteDTO.BusinessType = txtBusinessType.Text;
                consignNoteDTO.CategoryOfLoad = txtLoadType.Text;
                consignNoteDTO.CentralisedServiceTaxRegnNo = txtCentralisedServiceTaxRegNo.Text;
                consignNoteDTO.Charges1 = txtCharges.Text;
                consignNoteDTO.Charges2 = txtCharges2.Text;
                consignNoteDTO.Charges3 = txtCharges3.Text;
                consignNoteDTO.Charges4 = txtCharges4.Text;
                consignNoteDTO.Charges5 = txtCharges5.Text;
                consignNoteDTO.CompanyAmount = double.Parse(txtAmount2.Text);
               consignNoteDTO.CompanyDate = Convert.ToDateTime(dpDate2.MaxDate);
               
                consignNoteDTO.CompanyPhone = txtPhoneNo.Text;
                consignNoteDTO.ConsigneeId = Convert.ToInt32(cmbConsineeName.SelectedValue);
                consignNoteDTO.ConsigneeInvoiceNo = txtInvoiceNo.Text;
                consignNoteDTO.ConsigneeServiceTaxRegNo = txtServiceTaxRegNo.Text;
                consignNoteDTO.ConsignmentDate = Convert.ToDateTime(dpDate3.MaxDate);
                consignNoteDTO.ConsignmentNoteNo = Convert.ToInt32(txtConsignmentNoteNo.Text);
                consignNoteDTO.ConsignorId = Convert.ToInt32(cmbConsignorName.SelectedValue);
                consignNoteDTO.ConsignorPurchaseOrderNo = txtPurchaseOrderNo.Text;
                consignNoteDTO.ConsignorServiceTaxRegNo = txtServiceTaxRegNo2.Text;
                consignNoteDTO.DeclarationNo = txtDeclaredValue.Text;
                consignNoteDTO.DimensionHeight = txtHeight.Text;
                consignNoteDTO.DimensionLength = txtLength.Text;
                consignNoteDTO.DimensionNoOfPKGS = txtNoOfPackages.Text;
                consignNoteDTO.DimensionSinglePieceWeight = txtSinglePiece.Text;
                consignNoteDTO.DimensionTotalCFTCMT = txtTotalCFT.Text;
                consignNoteDTO.DimensionWidth = txtWidth.Text;
                consignNoteDTO.Distance = txtDistance.Text;
                consignNoteDTO.FinalAmount = double.Parse(txtFinalAmount.Text);
                consignNoteDTO.FromCode = txtFromCodeName.Text;
                consignNoteDTO.ToCode = txtToCodeName.Text;
                consignNoteDTO.ValidType = txtValidType.Text;
                consignNoteDTO.PanNo = txtPanNo.Text;
                consignNoteDTO.PolicyNo = txtPolicyNo.Text;
                consignNoteDTO.PrivateMarketOtherIdentificaion = txtPrivvateMarks.Text;
                consignNoteDTO.Rate = txtRate.Text;
                consignNoteDTO.Rebooking = txtRebooking.Text;
                consignNoteDTO.ServicetaxThrough = txtServiceTaxThrough.Text;
                consignNoteDTO.PartyCode = txtPartyCode.Text;
                consignNoteDTO.MethodOfPacking = txtMethodOfPacking.Text;
                consignNoteDTO.DescriptionSaidToContain = txtDescription.Text;
                consignNoteDTO.ServiceTaxisPayableBy = (cmbServiceTaxisPaybleBy.SelectedItem).ToString();
                consignNoteDTO.ValidUpto = txtOrigional.Text;
                if (ConsignmentNoteBusinessLogic.CheckDuplicateConsignmentNoteNo(consignNoteDTO.ConsignmentId, Convert.ToInt32(consignNoteDTO.ConsignmentNoteNo)) == false)
                {
                    var result = ConsignmentNoteBusinessLogic.Save(consignNoteDTO);
                    if (result > 0)
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Consignment Number already exists.");
                }

            }


        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
