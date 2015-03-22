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
        frmParty frmParty = new frmParty();

        #endregion

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
            string Action = this.gridViewParty.Columns[e.ColumnIndex].HeaderText;
            //if (Action == "Edit")
            //{
            //    int rowIndex = e.RowIndex;
            //    DataGridViewRow row = grid_CleavingDetail.Rows[rowIndex];
            //    txt_Code.Text = Convert.ToString(row.Cells["Code"].Value);
            //    txt_Name.Text = Convert.ToString(row.Cells["Name"].Value);
            //    txt_GujratiName.Text = Convert.ToString(row.Cells["GujratiName"].Value);
            //    txt_Type.Text = Convert.ToString(row.Cells["Type"].Value);
            //    txt_Order.Text = Convert.ToString(row.Cells["Order"].Value);
            //    IsEdit = true;
            //    txt_Code.Enabled = false;
            //    btn_Add.Text = "Update";
            //}
            //else if (Action == "Delete")
            //{
            //    int rowIndex = e.RowIndex;
            //    DataGridViewRow row = grid_CleavingDetail.Rows[rowIndex];
            //    string code = Convert.ToString(row.Cells["Code"].Value);

            //    try
            //    {
            //        sqlcommand = new SqlCommand();
            //        sqlcommand.CommandType = CommandType.StoredProcedure;
            //        sqlcommand.CommandText = "CLVMAST_DELETE";
            //        sqlcommand.Parameters.AddWithValue("@CL_CODE", code);
            //        ds = modelObj.ExecuteDataSet(sqlcommand);
            //        MessageBox.Show("Successfully Delete Record");
            //        bindGrid();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //if (e.ColumnIndex == 6)
            //{
            //    PartyId = Convert.ToInt32(gridViewParty.Rows[e.RowIndex].Cells[0].Value);
            //    frmParty.PartyId = PartyId;
            //    frmParty.FormClosed += frmParty_FormClosed;
            //    frmParty.Show();
            //}

            //if (e.ColumnIndex == 7)
            //{
            //    try
            //    {
            //        PartyId = Convert.ToInt32(gridViewParty.Rows[e.RowIndex].Cells[0].Value);
            //        var messageBoxResult = MessageBox.Show("Are you sure want to delete this record?", "Delete", MessageBoxButtons.YesNo);
            //        if (messageBoxResult == DialogResult.Yes)
            //        {
            //            var result = ConsignorBusinessLogic.Delete(PartyId);
            //            MessageBox.Show("Party deleted successfully.");
            //            FillGridData();
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Party already used some where else can't deleted successfully.");
            //    }
                
            //}
        }


        void frmParty_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGridData();
        }
    }
}
