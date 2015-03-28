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
        }


        #region private method

        private void setflag()
        {
            //if (AccountId > 0)
            //{
            //    int anint;    
            //    var accountdetail = AccountsMasterBusinessLogic.Get(AccountId);
            //    textaccountname.Text = accountdetail.AccountName;
            //    anint = Convert.ToInt32(accountdetail.AccountNo);

            //    textaddress.Text = accountdetail.Addrees;
            //    if (radioButton1.Checked)
            //    {
            //        accountdetail.AccountType = "Bank";
            //    }
            //    else if (radioButton2.Checked)ta
            //    {
            //        accountdetail.AccountType = "Cash";
            //    }
            //    textphoneno.Text = accountdetail.PhoneNo;
            //    anint = Convert.ToInt32(accountdetail.OpeningBalance);
            //    accountdate.Text = System.DateTime.Today.ToShortDateString();          
          
            //}
        }
        private void cleandata()
        {

            tblAccountsMasterDTO tblaccountmasterdto = new tblAccountsMasterDTO();
            tblaccountmasterdto.AccountName = " ";
            
            
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
                tblaccountmasterdto.AccountName = textaccountname.Text;
                if (Convert.ToString(radioButton1.Checked) == "Bank")
                {
                    tblaccountmasterdto.AccountType = "2";
                }
                else
                {
                    tblaccountmasterdto.AccountType = "1";
                }


                //if (Convert.ToString(radioButton1.Checked) == "Bank")
                //{
                //    tblaccountmasterdto.AccountType = "1";
                //}
                //else if (Convert.ToString(radioButton1.Checked) == "Cash")
                //{
                //    tblaccountmasterdto.AccountType = "2";
                //}

                tblaccountmasterdto.AccountNo = Convert.ToInt32(textaccountno.Text);
                tblaccountmasterdto.Addrees = textaddress.Text;
                tblaccountmasterdto.PhoneNo = textphoneno.Text;
                tblaccountmasterdto.OpeningBalance = Convert.ToDouble(textopeningbal.Text);                                
                tblaccountmasterdto.OpeningDate = accountdate.Value;
              
                
                var result = AccountsMasterBusinessLogic.Save(tblaccountmasterdto);
                tblaccountmasterdto.AccountName = " ";
               

                
            }

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

    }
}
