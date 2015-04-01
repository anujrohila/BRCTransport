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
                frmEntryMRNote frm = new frmEntryMRNote();
                MRId = Convert.ToInt32(GridViewMr.Rows[e.RowIndex].Cells[0].Value);
                frm.MRId = MRId;
                frm.FormClosed += frm_FormClosed;
                frm.Show();
                
            }

            if (Action == "Delete")
            {
                try
                {
                    MRId = Convert.ToInt32(GridViewMr.Rows[e.RowIndex].Cells[0].Value);
                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        var result = MRNoteBusinessLogic.Delete(MRId);
                        MessageBox.Show("MR Note deleted successfully.");
                        FillGridData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("MR Note already used some where else can't deleted successfully.");
                }

            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGridData();
        }
    }
}
