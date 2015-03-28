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
        
    
    public partial class frmLRNoteList : Form
    {
        private Int32 ConsignmentId = 0;
        frmEntryLRNote lrnote = new frmEntryLRNote();

        public frmLRNoteList()
        {
            InitializeComponent();
            GridViewLR.AutoGenerateColumns = false;
        }


        public void fillgriddata()
        {
            var Lrlist = ConsignorBusinessLogic.GetAll();
            GridViewLR.DataSource = Lrlist;
        
        }

        private void frmLRNoteList_Load(object sender, EventArgs e)
        {
            fillgriddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Action = this.GridViewLR.Columns[e.ColumnIndex].HeaderText;

            if (Action == "Edit")
            {
                ConsignmentId = Convert.ToInt32(GridViewLR.Rows[e.RowIndex].Cells[0].Value);
               
              
                lrnote.FormClosed += frmParty_FormClosed;
                lrnote.Show();
            }

            if (Action == "Delete")
            {
                try
                {
                    ConsignmentId = Convert.ToInt32(GridViewLR.Rows[e.RowIndex].Cells[0].Value);
                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        var result = ConsignorBusinessLogic.Delete(ConsignmentId);
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

        public FormClosedEventHandler frmParty_FormClosed { get; set; }
    }
}
