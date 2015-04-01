using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRCTransport.BAL;

namespace BRCTransport.Window.Forms
{
    public partial class frmTransactionList : Form
    {

        private Int32 TransactionId = 0;
       
        public frmTransactionList()
        {
            this.Load += frmTransactionList_Load;
            InitializeComponent();
            GridViewtransaction.AutoGenerateColumns = false;
        }

        void frmTransactionList_Load(object sender, EventArgs e)
        {
            fillgriddata();
        }

        public void fillgriddata()
        {
            var transactionlist = TransactionBusinessLogic.GetAll();
            GridViewtransaction.DataSource = transactionlist;
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Action = this.GridViewtransaction.Columns[e.ColumnIndex].HeaderText;

            if (Action == "Edit")
            {
                frmEntryTransaction frmtransaction = new frmEntryTransaction();

                TransactionId = Convert.ToInt32(GridViewtransaction.Rows[e.RowIndex].Cells[0].Value);
                frmtransaction.TransactionId = TransactionId;
                frmtransaction.FormClosed += frmParty_FormClosed;
                frmtransaction.Show();
            }

            if (Action == "Delete")
            {
                try
                {
                    TransactionId = Convert.ToInt32(GridViewtransaction.Rows[e.RowIndex].Cells[0].Value);
                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        var result = TransactionBusinessLogic.Delete(TransactionId);
                        MessageBox.Show("Party deleted successfully.");
                        fillgriddata();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Party already used some where else can't deleted successfully.");
                }

            }
        }
        void frmParty_FormClosed(object sender, FormClosedEventArgs e)
        {
            fillgriddata();
        }
    }
}
