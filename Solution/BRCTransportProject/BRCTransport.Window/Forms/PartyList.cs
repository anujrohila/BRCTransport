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
    public partial class PartyList : Form
    {
        #region MyRegion

        private Int32 PartyId = 0;
       
        #endregion

        public PartyList()
        {
            InitializeComponent();
            gridViewParty.AutoGenerateColumns = false;
        }

        private void PartyList_Load(object sender, EventArgs e)
        {
            FillGridData();
        }

        private void FillGridData()
        {
            var consignorList = ConsignorBusinessLogic.GetAll();
            foreach (var item in consignorList)
            {
                if (item.Type == 1)
                {
                    item.PartyType = "Consignor";
                }
                else
                {
                    item.PartyType = "Consignee";
                }
            }
            gridViewParty.DataSource = consignorList;
        }

        private void gridViewParty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Action = this.gridViewParty.Columns[e.ColumnIndex].HeaderText;

            if (Action == "Edit")
            {
                frmParty frmParty = new frmParty();
                PartyId = Convert.ToInt32(gridViewParty.Rows[e.RowIndex].Cells[0].Value);
                frmParty.PartyId = PartyId;
                frmParty.FormClosed += frmParty_FormClosed;
                frmParty.ShowInTaskbar = false;
                frmParty.Show();
            }

            if (Action == "Delete")
            {
                try
                {
                    PartyId = Convert.ToInt32(gridViewParty.Rows[e.RowIndex].Cells[0].Value);
                    var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
                    if (messageBoxResult == DialogResult.Yes)
                    {
                        var result = ConsignorBusinessLogic.Delete(PartyId);
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
