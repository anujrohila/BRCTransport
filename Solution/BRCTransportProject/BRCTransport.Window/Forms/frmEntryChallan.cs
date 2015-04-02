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
        public frmEntryChallan()
        {
            InitializeComponent();
        }

        private void frmEntryChallan_Load(object sender, EventArgs e)
        {

        }

        public static int ChallanEntryNo { get; set; }


        private void clearData()
        {
            txtAddress.Text = "";
            txtAddress2.Text = "";
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
            txtEngagedByName.Text = "";
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
            txtMobileNo.Text = "";
            txtMobileNo2.Text = "";
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
            txtValidUpto.Text = "";
            txtValidUpto2.Text = "";
            txtValidUpto3.Text = "";
            txtVehicleChassisNo.Text = "";
            txtVehicleEngineNo.Text = "";
            txtVehicleFinancier.Text = "";
            txtVehicleNo.Text = "";
            txtVehicleType.Text = "";
            txtWeightPerTon.Text = "";
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
            clearData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            var childchallan = new frmChildChallan();
            childchallan.ShowDialog();
        }
    }
}
