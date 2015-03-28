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
using BRCTransport.Domain;
using BRCTransport.Window.Class;

namespace BRCTransport.Window.Forms
{
    public partial class MRNoteList : Form
    {

        private Int32 MRId = 0;
        frmEntryMRNote frmmr = new frmEntryMRNote();

        public MRNoteList()
        {
            InitializeComponent();
            GridViewMr.AutoGenerateColumns = false;
        }

        private void frmMRNoteList_Load(object sender, EventArgs e)
        {
            FillGridData();
        }

        private void FillGridData()
        {
            var mrlist = MRNoteBusinessLogic.GetAll();
            GridViewMr.DataSource = mrlist;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Action = this.GridViewMr.Columns[e.ColumnIndex].HeaderText;

            if (Action == "Edit")
            {
                MRId = Convert.ToInt32(GridViewMr.Rows[e.RowIndex].Cells[0].Value);
                frmEntryMRNote.MRId = MRId;
             
            }

            if (Action == "Delete")
            {
                try
                {
                    MRId = Convert.ToInt32(GridViewMr.Rows[e.RowIndex].Cells[0].Value);
                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        var result = ConsignorBusinessLogic.Delete(MRId);
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
    }
}
