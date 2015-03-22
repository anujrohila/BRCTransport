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
        private Int32 PartyId = 0;

        public PartyList()
        {
            InitializeComponent();
            gridViewParty.AutoGenerateColumns = false;
        }

        private void PartyList_Load(object sender, EventArgs e)
        {
            FillGridData();
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault; Editlink.Text = "Edit";
            gridViewParty.Columns.Add(Editlink);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            gridViewParty.Columns.Add(Deletelink);
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
            if (e.ColumnIndex == 6)
            {
                PartyId = Convert.ToInt32(gridViewParty.Rows[e.RowIndex].Cells[0].Value);
                frmParty frmParty = new frmParty();
                frmParty.PartyId = PartyId;
                frmParty.Show();
            }

            if (e.ColumnIndex == 7)
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
    }
}
