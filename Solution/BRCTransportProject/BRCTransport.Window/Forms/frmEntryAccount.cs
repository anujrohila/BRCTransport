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
using BRCTransport.Domain;
using BRCTransport.BAL;
using BRCTransport.Window;

namespace BRCTransport.Window.Forms
{
    public partial class frmEntryAccount : Form
    {
        public Int32 AccountId = 0;


        public frmEntryAccount()
        {
            InitializeComponent();
            this.Load += frmEntryAccount_Load;
        }

        void frmEntryAccount_Load(object sender, EventArgs e)
        {
            if (AccountId > 0)
            {
                setflag();
            }
            textaccountname.Focus();
        }


        #region private method

        private void setflag()
        {
            if (AccountId > 0)
            {
               var accountdetail = AccountsMasterBusinessLogic.Get(AccountId);
                textaccountname.Text = accountdetail.AccountName;
                textaccountno.Text = Convert.ToString(accountdetail.AccountNo);
                textaddress.Text  =accountdetail.Addrees;
                textopeningbal.Text = Convert.ToString(accountdetail.OpeningBalance);
                if (accountdetail.AccountType == "1")
                {
                    rbcash.Checked = true;
                }
                else
                {
                    rbBank.Checked = true;
                }
                textphoneno.Text = accountdetail.PhoneNo;
                accountdate.Text = Convert.ToString(accountdetail.OpeningDate);
                textdescription.Text = Convert.ToString(accountdetail.Description);
            }
        }

        private void cleandata()
        {
            textaccountname.Text = "";
            textaccountno.Text = "";
            textaddress.Text = "";
            textphoneno.Text = "";
            accountdate.Text = "";
            rbBank.Checked = true;
            textdescription.Text = "";
            textopeningbal.Text = "";
        }

        private Boolean ValidateData()
        {
            ErrorHanding.SetErrorCount();
            ErrorHanding.SetTextboxErrorWithCount(errorAcoountName, textaccountname, "Enter Account name");
            ErrorHanding.SetTextboxErrorWithCount(errorAccountno, textaccountno, "Enter the Account No");
            ErrorHanding.SetTextboxErrorWithCount(errorAddress, textaddress, "Enter The Address");
            ErrorHanding.SetTextboxErrorWithCount(errorPhoneNo, textphoneno, "Enter The Phone number");
            ErrorHanding.SetTextboxErrorWithCount(errorOpeningBalance, textopeningbal, "Enter The Opening Balance");

            if (ErrorHanding.GetErrorCount() == 0)
                return true;
            else
                return false;

        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (ValidateData())
            {

                tblAccountsMasterDTO tblaccountmasterdto = new tblAccountsMasterDTO();
                if (AccountId > 0)
                {
                    tblaccountmasterdto.AccountId = AccountId;
                }
                tblaccountmasterdto.AccountName = textaccountname.Text;
                if (rbBank.Checked)
                {
                    tblaccountmasterdto.AccountType = "2";
                }
                else
                {
                    tblaccountmasterdto.AccountType = "1";
                }

                tblaccountmasterdto.AccountNo = Convert.ToString(textaccountno.Text);
                tblaccountmasterdto.Addrees = textaddress.Text;
                tblaccountmasterdto.PhoneNo = textphoneno.Text;
                tblaccountmasterdto.OpeningBalance = Convert.ToDouble(textopeningbal.Text);
                tblaccountmasterdto.OpeningDate = accountdate.Value;
                tblaccountmasterdto.Description = textdescription.Text;
                var result = AccountsMasterBusinessLogic.Save(tblaccountmasterdto);
                if (AccountId > 0)
                {
                    this.Close();
                }
                cleandata();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
