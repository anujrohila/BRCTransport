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
using BRCTransport.BAL;


namespace BRCTransport.Window.Forms
{
    public partial class frmChildChallan : Form
    {

        public Int32 ChallanEntryNo = 0;

        public frmChildChallan()
        {
            InitializeComponent();
        }

        private void frmChildChallan_Load(object sender, EventArgs e)
        {
            
            
                //var BillDetail = ConsigneeBusinessLogic.Get(ChallanEntryNo);
                //text_bkg.Text = BillDetail.;
                //text_cnno.Text = 
                //text_package.Text =
                //text_pckmethod.Text = 
                //text_said.Text = 
                //text_actual.Text =
                //text_destination.Text = 

                //text_bkg.Text = 
              


           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_click(object sender, EventArgs e)
        {   


            tblChallanEntryDTO tblChallanEntryDTO = new tblChallanEntryDTO();
            tblChallanEntryDTO.ChallanEntryNo = ChallanEntryNo;
            tblChallanEntryDTO.BkgStnCode = text_bkg.Text;
            tblChallanEntryDTO.CNNoWithAlphaCode = text_cnno.Text;
            tblChallanEntryDTO.PackagesNos = text_package.Text;
            tblChallanEntryDTO.PackagesMethod = text_pckmethod.Text;
            tblChallanEntryDTO.SaidToContain = text_said.Text;
            tblChallanEntryDTO.ActualWeightKgs = text_actual.Text;
            tblChallanEntryDTO.DestinationName = text_destination.Text;
            
            

        }
    }
}
