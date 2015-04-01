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

namespace BRCTransport.Window.Forms
{
    public partial class frmAccountList : Form
    {
        public frmAccountList()
        {
            InitializeComponent();
            this.Load += frmAccountList_Load;
            gridViewAccount.AutoGenerateColumns = false;
        }

        void frmAccountList_Load(object sender, EventArgs e)
        {
            FillGridData();
        }

        private void FillGridData()
        {
            var accountlist = AccountsMasterBusinessLogic.GetAll();
            foreach (var item in accountlist)
            {
                if (item.AccountType == "1")
                {
                    item.AccountTypeName = "Cash";
                }
                else
                {
                    item.AccountTypeName = "Bank";
                }
            }
            gridViewAccount.DataSource = accountlist;
        }

        private void gridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Action = this.gridViewAccount.Columns[e.ColumnIndex].HeaderText;

            if (Action == "Edit")
            {
                frmEntryAccount frmaccount = new frmEntryAccount();
            
                frmaccount.AccountId = Convert.ToInt32(gridViewAccount.Rows[e.RowIndex].Cells[0].Value);
                frmaccount.FormClosed += frmaccount_FormClosed;
                frmaccount.Show();
            }

            if (Action == "Delete")
            {
                try
                {

                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        var result = AccountsMasterBusinessLogic.Delete(Convert.ToInt32(gridViewAccount.Rows[e.RowIndex].Cells[0].Value));
                        MessageBox.Show("Account deleted successfully.");
                        FillGridData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Account already used some where else can't deleted successfully.");
                }

            }
        }

        void frmaccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGridData();
        }
    }
}
