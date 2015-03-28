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
using BRCTransport.Window.Class;

namespace BRCTransport.Window.Forms
{
    public partial class ChallanList : Form
    {
        #region MyRegion

        private Int32 ChallanEntryNo = 0;
        frmEntryChallan frmchallan = new frmEntryChallan();

       
        
        #endregion

        public ChallanList()
        {
            InitializeComponent();
            this.Load += frmChallanList_Load;
            GridViewChallan.AutoGenerateColumns = false;
            
        }

        void frmChallanList_Load(object sender, EventArgs e)
        {
            FillGridData();
        }

        

       

        private void FillGridData()
        {

            var ChallanList = ChallanBusinessLogic.GetAll();
            
            GridViewChallan.DataSource = ChallanList;
        }

        private void GridViewChallan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string Action = this.GridViewChallan.Columns[e.ColumnIndex].HeaderText;

            if (Action == "Edit")
            {
                ChallanEntryNo = Convert.ToInt32(GridViewChallan.Rows[e.RowIndex].Cells[0].Value);
                //frmchallan.ChallanEntryNo = ChallanEntryNo;
                frmchallan.FormClosed += frmParty_FormClosed;
                frmchallan.Show();
              
            }

            if (Action == "Delete")
            {
                try
                {
                    ChallanEntryNo = Convert.ToInt32(GridViewChallan.Rows[e.RowIndex].Cells[0].Value);
                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        var result = ChallanBusinessLogic.Delete(ChallanEntryNo);
                        MessageBox.Show("Party deleted successfully.");
                        FillGridData();
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
            FillGridData();
        }
       
    }
}
