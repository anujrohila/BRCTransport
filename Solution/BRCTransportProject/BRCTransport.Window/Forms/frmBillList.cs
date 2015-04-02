using BRCTransport.BAL;
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
    public partial class frmBillList : Form
    {
        public frmBillList()
        {
            InitializeComponent();
            gridViewBill.AutoGenerateColumns = false;
            this.Load += frmBillList_Load;
        }

        void frmBillList_Load(object sender, EventArgs e)
        {
            FillGridData();
        }

        private void gridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Action = this.gridViewBill.Columns[e.ColumnIndex].HeaderText;

            if (Action == "Edit")
            {
                frmEntryBills frmbill = new frmEntryBills();
                frmbill.BillId = Convert.ToInt32(gridViewBill.Rows[e.RowIndex].Cells[0].Value);
                frmbill.FormClosed += frmbill_FormClosed;
                frmbill.ShowDialog();
            }

            if (Action == "Delete")
            {
                try
                {  
                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        var result = BillBusinessLogic.Delete(Convert.ToInt32(gridViewBill.Rows[e.RowIndex].Cells[0].Value));
                        MessageBox.Show("Bill deleted successfully.");
                        FillGridData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bill already used some where else can't deleted successfully.");
                }

            }
        }

        void frmbill_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGridData();
        }
        
        private void FillGridData()
        {
            var bills = BillBusinessLogic.GetAll();
            foreach (var item in bills)
            {
                item.BillDateString = ((DateTime)item.BillDate).ToString("dd-MM-yyyy");
                item.PaymentDueDateString = ((DateTime)item.PaymentDueDate).ToString("dd-MM-yyyy");
            }
            gridViewBill.DataSource = bills;
        }

    }
}
