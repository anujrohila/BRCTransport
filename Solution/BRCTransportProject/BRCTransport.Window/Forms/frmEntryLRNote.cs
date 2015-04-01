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
            ErrorHanding.SetTextboxErrorWithCount(errorCharges, txtCharges1, "Enter Charges");
            ErrorHanding.SetTextboxErrorWithCount(errorAmount, txtAmount1, "Enter Amount");
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
            txtAdvancePaymentAmount.Text = "";
            txtAmount1.Text = "";
            txtAmount2.Text = "";
            txtAmount3.Text = "";
            txtAmount4.Text = "";
            txtAmount5.Text = "";
            txtBasicOfBooking.Text = "";
            txtBilledWith.Text = "";
            txtBranchCode.Text = "";
            txtBusinessType.Text = "";
            txtCentralisedServiceTaxRegNo.Text = "";
            txtCharges1.Text = "";
            txtCharges2.Text = "";
            txtCharges3.Text = "";
            txtCharges4.Text = "";
            txtCharges5.Text = "";
            txtChargeWeightInKg.Text = "";
            txtCompanyAmount.Text = "";
            txtCompanyName.Text = "";
            txtCompanyPhoneNo.Text = "";
            txtConsignmentNoteNo.Text = "";
            txtDeclaredValueGoods.Text = "";
            txtDiamentionNoOfPkgs.Text = "";
            txtDistance.Text = "";
            txtDescription.Text = "";
            txtFinalAmount.Text = "";
            txtFromCodeName.Text = "";
            txtHeight.Text = "";
            txtInvoiceNo.Text = "";
            txtKms.Text = "";
            txtLength.Text = "";
            txtLoadType.Text = "";
            txtMainConsignment.Text = "";
            txtMethodOfPacking.Text = "";
            txtMRNo.Text = "";
            txtNoOfPackages.Text = "";
            txtPanNo.Text = "";
            txtPartyCode.Text = "";
            txtPolicyNo.Text = "";
            txtPrivateMarks.Text = "";
            txtPurchaseOrderNo.Text = "";
            txtRate.Text = "";
            txtRate2.Text = "";
            txtRebooking.Text = "";
            txtSalesTaxForm.Text = "";
            txtServiceTaxThrough.Text = "";
            txtSinglePiece.Text = "";
            txtToCodeName.Text = "";
            txtToPay.Text = "";
            txtTotalCFT.Text = "";
            txtValidType.Text = "";
            txtWidth.Text = "";
            
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
                consignNoteDTO.PolicyNo = txtPolicyNo.Text;
                consignNoteDTO.CompanyDate = Convert.ToDateTime(dpCompanyDate.Value);
                consignNoteDTO.CompanyAmount = Convert.ToDouble(txtCompanyAmount.Text);
                consignNoteDTO.ConsigneeId = Convert.ToInt32(cmbConsineeName.SelectedValue);
                consignNoteDTO.ConsigneeInvoiceNo = txtInvoiceNo.Text;
                consignNoteDTO.ConsigneeServiceTaxRegNo = txtConsigneeServiceTaxRegNo.Text;
                consignNoteDTO.ConsignorId = Convert.ToInt32(cmbConsignorName.SelectedValue);
                consignNoteDTO.ConsignorPurchaseOrderNo = txtPurchaseOrderNo.Text;
                consignNoteDTO.ConsignorServiceTaxRegNo = txtConsignorServiceTaxRegNo.Text;
                consignNoteDTO.PanNo = txtPanNo.Text;
                consignNoteDTO.CentralisedServiceTaxRegnNo = txtCentralisedServiceTaxRegNo.Text;
                consignNoteDTO.FromCode = txtFromCodeName.Text;
                consignNoteDTO.ConsignmentNoteNo = Convert.ToInt32(txtConsignmentNoteNo.Text);
                consignNoteDTO.ConsignmentDate = Convert.ToDateTime(dpConsignmentDate.Value);
                consignNoteDTO.AddressofIssuing = txtAddressOfIssueOffice.Text;
                consignNoteDTO.ToCode = txtToCodeName.Text;
                consignNoteDTO.CompanyPhone = txtCompanyPhoneNo.Text;
                consignNoteDTO.NoofPackages = txtNoOfPackages.Text;
                consignNoteDTO.MethodOfPacking = txtMethodOfPacking.Text;
                consignNoteDTO.ActualWtInKGS = txtActualWeightInKg.Text;
                consignNoteDTO.CategoryOfLoad = txtChargeWeightInKg.Text;
                consignNoteDTO.Rate = txtRate.Text;
                consignNoteDTO.Charges1 = txtCharges1.Text;
                consignNoteDTO.Amount1 = double.Parse(txtAmount1.Text);
                consignNoteDTO.LoadType = txtLoadType.Text;
                consignNoteDTO.Distance = txtDistance.Text;
                consignNoteDTO.KMS = txtKms.Text;
                consignNoteDTO.Charges1 = txtCharges1.Text;
                consignNoteDTO.Charges2 = txtCharges2.Text;
                consignNoteDTO.Amount2 =  double.Parse(txtAmount2.Text);
                consignNoteDTO.Charges3 = txtCharges3.Text;
                consignNoteDTO.Charges4 = txtCharges4.Text;
                consignNoteDTO.AdvancedPaymentDate = Convert.ToDateTime(dpAdvancePaymentDate.Value);
                consignNoteDTO.Charges5 = txtCharges5.Text;
                consignNoteDTO.Amount3 = Convert.ToDouble(txtAmount3.Text);
                consignNoteDTO.Amount4 = Convert.ToDouble(txtAmount4.Text);
                consignNoteDTO.Amount5 = Convert.ToDouble(txtAmount5.Text);
                txtFinalAmount.Text = (Convert.ToDouble(txtAmount1.Text) + Convert.ToDouble(txtAmount2.Text) + Convert.ToDouble(txtAmount3.Text) + Convert.ToDouble(txtAmount4.Text) + Convert.ToDouble(txtAmount5.Text)).ToString();
                consignNoteDTO.FinalAmount = Convert.ToDouble(txtFinalAmount.Text);
                consignNoteDTO.PrivateMarketOtherIdentificaion = txtPrivateMarks.Text;
                consignNoteDTO.AdvancedPaymentAmount = txtAdvancePaymentAmount.Text;
                consignNoteDTO.BusinessType = txtBusinessType.Text;
                consignNoteDTO.DeclarationNo = txtDeclaredValueGoods.Text;
                consignNoteDTO.DimensionLength = txtLength.Text;
                consignNoteDTO.DimensionWidth = txtWidth.Text;
                consignNoteDTO.DimensionHeight = txtHeight.Text;
                consignNoteDTO.DimensionNoOfPKGS = txtDiamentionNoOfPkgs.Text;
                consignNoteDTO.DimensionTotalCFTCMT = txtTotalCFT.Text;
                consignNoteDTO.DimensionSinglePieceWeight = txtSinglePiece.Text;
                consignNoteDTO.ValidType = txtValidType.Text;
                consignNoteDTO.DeclaredValueOfGoods = txtDeclaredValueGoods.Text;
                consignNoteDTO.ServicetaxThrough = txtServiceTaxThrough.Text;
                consignNoteDTO.BasicOfBooking = txtBasicOfBooking.Text;
                consignNoteDTO.BilledWithMs = txtBilledWith.Text;
                consignNoteDTO.BranchCode = txtBranchCode.Text;
                consignNoteDTO.PartyCode = txtPartyCode.Text;
                consignNoteDTO.ToPay = txtToPay.Text;
                consignNoteDTO.Rebooking = txtRebooking.Text;
                consignNoteDTO.MainConsignmentNo = txtMainConsignment.Text;
                consignNoteDTO.ServiceTaxisPayableBy = (cmbServiceTaxisPaybleBy.SelectedItem).ToString();
                
               
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
            clearData();
        }
    }
}
