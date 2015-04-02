using BRCTransport.Window.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRCTransport.Window
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            ////webBrowser1.Url = new Uri(CommonFucntion.ApplicationWebPath, UriKind.RelativeOrAbsolute);
        }


        private void Popup_Show(object sender, EventArgs e)
        {

            string tagname = Convert.ToString((sender as ToolStripMenuItem).Tag);
            if (tagname == "")
                return;
            Form winform = new Form();
            switch (tagname)
            {
                case "Party List": winform = new PartyList(); break;
                case "List Challan": winform = new ChallanList(); break;
                case "List Bill": winform = new frmBillList(); break;
                case "List LR Note": winform = new frmLRNoteList(); break;
                case "List MR Note": winform = new MRNoteList(); break;
                case "Account List": winform = new frmAccountList(); break;
                case "Transaction List": winform = new frmTransactionList(); break;
            }
            bool flag = false;

            foreach (Form form in Application.OpenForms)
            {
                if (tagname == Convert.ToString(form.Tag))
                {
                    flag = true;
                    form.Focus();
                    break;
                }
                flag = false;
            }

            if (flag == false)
            {
                winform.ShowInTaskbar = false;
                winform.MdiParent = this;
                winform.StartPosition = FormStartPosition.CenterScreen;
                winform.Text = tagname;
               winform.WindowState = FormWindowState.Normal;
                winform.Show();
                winform = null;
            }
        }



        private void Popup_Showdialog(object sender, EventArgs e)
        {
          
            string tagname = Convert.ToString((sender as ToolStripMenuItem).Tag);
            if (tagname == "")
                return;
            Form winform = new Form();
            switch (tagname)
            {
                //master
                case "Add Party": winform = new frmParty(); break;
                case "Add Challan": winform = new frmEntryChallan(); break;
                case "Add Bill": winform = new frmEntryBills(); break;
                case "Add LR Note": winform = new frmEntryLRNote(); break;
                case "Add MR Note": winform = new frmEntryMRNote(); break;
                case "Add Account": winform = new frmEntryAccount(); break;
                case "Add Transaction": winform = new frmEntryTransaction(); break;
            }

         
            bool flag = false;

            foreach (Form form in Application.OpenForms)
            {
                if (tagname == Convert.ToString(form.Tag))
                {
                    flag = true;
                    form.Focus();
                    break;
                }
                flag = false;
            }

            if (flag == false)
            {
                winform.ShowInTaskbar = false;
              //  winform.MdiParent = this;
                winform.StartPosition = FormStartPosition.CenterScreen;
                winform.Text = tagname;
               // winform.WindowState = FormWindowState.Maximized;
                winform.ShowDialog();
                winform = null;
            }
        }
    }
}
