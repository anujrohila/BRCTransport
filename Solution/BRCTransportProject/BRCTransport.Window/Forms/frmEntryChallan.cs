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
    public partial class frmEntryChallan : Form
    {
        public int ChallanId = 0;
      
        public frmEntryChallan()
        {
            InitializeComponent();
            this.Load += frmEntryChallan_Load;
        }

        private void GenerateCode()
        {
            txtLorryChallenNo.Text = Convert.ToString(ChallanBusinessLogic.GetChallanNo() + 1);
        }

        private void frmEntryChallan_Load(object sender, EventArgs e)
        {
            if (ChallanId > 0)
            {
                var tblChallanDTO = ChallanBusinessLogic.Get(ChallanId);
                txtLorryChallenNo.Text = (tblChallanDTO.ChallanNo).ToString();
                dpChallanDate.Value = tblChallanDTO.ChallanDateTime.Value;
                txtVehicleNo.Text = tblChallanDTO.VehicleNo;
                txtVehicleType.Text = tblChallanDTO.VehicleType;
                txtMake.Text = tblChallanDTO.VechicleMake;
                txtModel.Text = tblChallanDTO.VehicleModel;
                txtLoading.Text = tblChallanDTO.VehicleNoOfPointLoading;
                txtUnloading.Text = tblChallanDTO.Vehicle4NoOfPointUnLoading;
                txtCompanyFeetCode.Text = tblChallanDTO.VehicleFleetCode;
                txtFromBrCode.Text = tblChallanDTO.FromBrCode;
                txtLoadedFrom.Text = tblChallanDTO.LoadedForm;
                txtToBrCode.Text = tblChallanDTO.ToBrCode;
                txtDestination.Text = tblChallanDTO.Destination;
                txtDistance.Text = tblChallanDTO.DistanceKM;
                txtScheduleDateofArrival.Text = tblChallanDTO.ScheduleDateofActual;
                txtVehicleEngineNo.Text = tblChallanDTO.VechicleEngineNo;
                txtVehicleChassisNo.Text = tblChallanDTO.VechicleChassisNo;
                txtDriverMobileNo.Text = tblChallanDTO.DriverMobileNo;
                txtDriverAddress.Text = tblChallanDTO.DriverAddress;
                txtTaxTokenNumber.Text = tblChallanDTO.TaxTokenNo;
                txtTaxtokenValidUpto.Text = tblChallanDTO.TaxTokenNoValidUpto;
                txtDriverLicenceNo.Text = tblChallanDTO.DriverLicenseNo;
                txtIssuedFrom.Text = tblChallanDTO.LicenseIssuedFrom;
                txtLicenceValidUpto.Text = tblChallanDTO.LicenseValidUpto;
                txtOwnerName.Text = tblChallanDTO.VechicleOwnerName;
                txtRoadPermitNumber.Text = tblChallanDTO.RoadPermitNo;
                txtRoadPermitValidUpto3.Text = tblChallanDTO.RoadPermitValidUpto;
                txtVehicleOwnerMobileMobileNo.Text = tblChallanDTO.VechicleOwnerMobileNo;
                txtVehicleOwnerAddress.Text = tblChallanDTO.VechicleOwnerAddress;
                txtInsPolicyNo.Text = tblChallanDTO.InsPolicyNo;
                txtPANNo.Text = tblChallanDTO.VechicleOwnerPanNo;
                txtAgentName.Text = tblChallanDTO.VechicleAgentName;
                txtEngagedByEmpCode1.Text = tblChallanDTO.VechicleEngagedByNameWithEmpCode1;
                txtAgentMobileNumber.Text = tblChallanDTO.VechicleMobileNo;
                txtAgentAddress.Text = tblChallanDTO.VechicleAgentAddress;
                txtEngagedByEmpCode2.Text = tblChallanDTO.VechicleEngagedByNameWithEmpCode2;
                txtVehicleFinancier.Text = tblChallanDTO.VechicleFinancierDetails;
                txtLoadingAdviceNo.Text = tblChallanDTO.BrokerLoadingAdviceNoDate;
                txtMaterialUnloadingBy.Text = tblChallanDTO.MaterialUnLoadingBy;
                txtTotalPackageNo.Text = (tblChallanDTO.PayableTotalPackages).ToString();
                txtChargedWeightKg.Text = (tblChallanDTO.PayableChargedWeight).ToString();
                txtRatePerTon.Text = (tblChallanDTO.PayableRatePerTon).ToString();
                txtTotalLorryHire.Text = (tblChallanDTO.TotalLorryHire).ToString();
                txtITDC.Text = (tblChallanDTO.ITDSDeduction).ToString();
                txtPartLorryHire.Text = (tblChallanDTO.PartyLorryHire).ToString();
                txtBalanceLorryHire.Text = (tblChallanDTO.BalanceLorryHire).ToString();
                GenerateCode();
            }
        }

        public static int ChallanEntryNo { get; set; }

        private void clearData()
        {
            txtDriverAddress.Text = "";
            txtVehicleOwnerAddress.Text = "";
            txtAgentAddress.Text = "";
            txtAgentMobileNumber.Text = "";
            txtAgentName.Text = "";
            txtBalanceLorryHire.Text = "";
            txtChargedWeightKg.Text = "";
            txtChargedWeightKg.Text = "";
            txtCompanyFeetCode.Text = "";
            txtDestination.Text = "";
            txtDistance.Text = "";
            txtDriverLicenceNo.Text = "";
            txtDriverName.Text = "";
            txtEngagedByEmpCode2.Text = "";
            txtFromBrCode.Text = "";
            txtInsCoWithStn.Text = "";
            txtInsPolicyNo.Text = "";
            txtIssuedFrom.Text = "";
            txtITDC.Text = "";
            txtLicenceIssuedFrom.Text = "";
            txtLoadedFrom.Text = "";
            txtLoading.Text = "";
            txtLoadingAdviceNo.Text = "";
            txtLorryChallenNo.Text = "";
            txtMake.Text = "";
            txtMaterialUnloadingBy.Text = "";
            txtDriverMobileNo.Text = "";
            txtVehicleOwnerMobileMobileNo.Text = "";
            txtModel.Text = "";
            txtOwnerName.Text = "";
            txtPANNo.Text = "";
            txtPartLorryHire.Text = "";
            txtRoadPermitNumber.Text = "";
            txtScheduleDateofArrival.Text = "";
            txtTaxTokenNumber.Text = "";
            txtToBrCode.Text = "";
            txtTotalLorryHire.Text = "";
            txtTotalPackageNo.Text = "";
            txtUnloading.Text = "";
            txtTaxtokenValidUpto.Text = "";
            txtLicenceValidUpto.Text = "";
            txtRoadPermitValidUpto3.Text = "";
            txtVehicleChassisNo.Text = "";
            txtVehicleEngineNo.Text = "";
            txtVehicleFinancier.Text = "";
            txtVehicleNo.Text = "";
            txtVehicleType.Text = "";
            txtRatePerTon.Text = "";

        }

        private bool IsFormValidate()
        {
            ErrorHanding.SetErrorCount();
            ErrorHanding.SetTextboxErrorWithCount(errorChallanDate, dpChallanDate, "Select Date");
            ErrorHanding.SetTextboxErrorWithCount(errorVehicleNo, txtVehicleNo, "Enter Vehicle Number");
            ErrorHanding.SetTextboxErrorWithCount(errorVehicleType, txtVehicleType, "Enter Vehicle Type");
            ErrorHanding.SetTextboxErrorWithCount(errorMake, txtMake, "Enter Vehicle Make");
            ErrorHanding.SetTextboxErrorWithCount(errorToBrCode, txtToBrCode, "Enter to Br Code");

            if (ErrorHanding.GetErrorCount() == 0)
                return true;
            else
                return false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValidate())
            {
                tblChallanDTO dto = new tblChallanDTO();


                if (ChallanId > 0)
                    dto.ChallanId = ChallanId;

                dto.ChallanNo = Convert.ToInt32(txtLorryChallenNo.Text);
                dto.ChallanDateTime = dpChallanDate.Value;
                dto.VehicleNo = txtVehicleNo.Text;
                dto.VehicleType = txtVehicleType.Text;
                dto.VechicleMake = txtMake.Text;
                dto.VehicleModel = txtModel.Text;
                dto.VehicleNoOfPointLoading = txtLoading.Text;
                dto.Vehicle4NoOfPointUnLoading = txtUnloading.Text;
                dto.VehicleFleetCode = txtCompanyFeetCode.Text;
                dto.FromBrCode = txtFromBrCode.Text;
                dto.LoadedForm = txtLoadedFrom.Text;
                dto.ToBrCode = txtToBrCode.Text;
                dto.Destination = txtDestination.Text;
                dto.DistanceKM = txtDistance.Text;
                dto.ScheduleDateofActual = txtScheduleDateofArrival.Text;
                dto.VechicleEngineNo = txtVehicleEngineNo.Text;
                dto.VechicleChassisNo = txtVehicleChassisNo.Text;
                dto.DriverMobileNo = txtDriverMobileNo.Text;
                dto.DriverAddress = txtDriverAddress.Text;
                dto.TaxTokenNo = txtTaxTokenNumber.Text;
                dto.TaxTokenNoValidUpto = txtTaxtokenValidUpto.Text;
                dto.DriverLicenseNo = txtDriverLicenceNo.Text;
                dto.LicenseIssuedFrom = txtIssuedFrom.Text;
                dto.LicenseValidUpto = txtLicenceValidUpto.Text;
                dto.VechicleOwnerName = txtOwnerName.Text;
                dto.RoadPermitNo = txtRoadPermitNumber.Text;
                dto.RoadPermitValidUpto = txtRoadPermitValidUpto3.Text;
                dto.VechicleOwnerMobileNo = txtVehicleOwnerMobileMobileNo.Text;
                dto.VechicleOwnerAddress = txtVehicleOwnerAddress.Text;
                dto.InsPolicyNo = txtInsPolicyNo.Text;
                dto.VechicleOwnerPanNo = txtPANNo.Text;
                dto.VechicleAgentName = txtAgentName.Text;
                dto.VechicleEngagedByNameWithEmpCode1 = txtEngagedByEmpCode1.Text;
                dto.VechicleMobileNo = txtAgentMobileNumber.Text;
                dto.VechicleAgentAddress = txtAgentAddress.Text;
                dto.VechicleEngagedByNameWithEmpCode2 = txtEngagedByEmpCode2.Text;
                dto.VechicleFinancierDetails = txtVehicleFinancier.Text;
                dto.BrokerLoadingAdviceNoDate = txtLoadingAdviceNo.Text;
                dto.MaterialUnLoadingBy = txtMaterialUnloadingBy.Text;
                dto.PayableTotalPackages = Convert.ToDouble(txtTotalPackageNo.Text);
                dto.PayableChargedWeight = Convert.ToDouble(txtChargedWeightKg.Text);
                dto.PayableRatePerTon = Convert.ToDouble(txtRatePerTon.Text);
                dto.TotalLorryHire = Convert.ToDouble(txtTotalLorryHire.Text);
                dto.ITDSDeduction = Convert.ToDouble(txtITDC.Text);
                dto.PartyLorryHire = Convert.ToDouble(txtPartLorryHire.Text);
                dto.BalanceLorryHire = Convert.ToDouble(txtBalanceLorryHire.Text);
                var result = ChallanBusinessLogic.Save(dto);
                if (result > 0)
                {
                    if (ChallanId > 0)
                        this.Close();
                    else
                        clearData();
                }
                else
                {
                    MessageBox.Show("Transaction Fail");
                }
            }
        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            var childchallan = new frmChildChallan();
            childchallan.ShowDialog();
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
    }
}
