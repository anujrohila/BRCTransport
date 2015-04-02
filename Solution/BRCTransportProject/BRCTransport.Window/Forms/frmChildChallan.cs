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
using BRCTransport.Window.Class;


namespace BRCTransport.Window.Forms
{
    public partial class frmChildChallan : Form
    {

        public int srno = 0;
        public tblChallanEntryDTO ChallanData = null;

        public frmChildChallan()
        {
            InitializeComponent();
        }

        private void frmChildChallan_Load(object sender, EventArgs e)
        {
            if (ChallanData != null)
            {
                text_bkg.Text = ChallanData.BkgStnCode;
                text_cnno.Text = ChallanData.CNNoWithAlphaCode;
                text_package.Text = ChallanData.PackagesNos;
                text_pckmethod.Text = ChallanData.PackagesMethod;
                text_said.Text = ChallanData.SaidToContain;
                text_actual.Text = ChallanData.ActualWeightKgs;
                text_destination.Text = ChallanData.DestinationName;
            }
            text_bkg.Focus();
        }


        private void btnsave_click(object sender, EventArgs e)
        {
            tblChallanEntryDTO tblChallanEntryDTO = new tblChallanEntryDTO();
            var srno = 1;
            if (CommonClass.tblChallanEntryDTO.Count() > 0)
            {
                srno = CommonClass.tblChallanEntryDTO.Select(h => h.SrNo).Max() + 1;
            }
            tblChallanEntryDTO.SrNo = srno;
            tblChallanEntryDTO.BkgStnCode = text_bkg.Text;
            tblChallanEntryDTO.CNNoWithAlphaCode = text_cnno.Text;
            tblChallanEntryDTO.PackagesNos = text_package.Text;
            tblChallanEntryDTO.PackagesMethod = text_pckmethod.Text;
            tblChallanEntryDTO.SaidToContain = text_said.Text;
            tblChallanEntryDTO.ActualWeightKgs = text_actual.Text;
            tblChallanEntryDTO.DestinationName = text_destination.Text;

            if (ChallanData != null)
            {
                tblChallanEntryDTO.SrNo = ChallanData.SrNo;
                CommonClass.tblChallanEntryDTO.Remove(ChallanData);
                CommonClass.tblChallanEntryDTO.Add(tblChallanEntryDTO);
                this.Close();
            }
            else
                CommonClass.tblChallanEntryDTO.Add(tblChallanEntryDTO);
            CleanData();

        }

        private void CleanData()
        {
            text_bkg.Text = "";
            text_cnno.Text = "";
            text_package.Text = "";
            text_pckmethod.Text = "";
            text_said.Text = "";
            text_actual.Text = "";
            text_destination.Text = "";
            text_bkg.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
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
