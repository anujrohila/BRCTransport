namespace BRCTransport.Window.Forms
{
    partial class frmBillList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridViewBill = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsignorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STNOCSTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINNOVATNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewBill
            // 
            this.gridViewBill.AllowUserToOrderColumns = true;
            this.gridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ConsignorName,
            this.Type,
            this.Code,
            this.STNOCSTNO,
            this.TINNOVATNO,
            this.Column1,
            this.Edit,
            this.Delete});
            this.gridViewBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewBill.Location = new System.Drawing.Point(0, 0);
            this.gridViewBill.Name = "gridViewBill";
            this.gridViewBill.Size = new System.Drawing.Size(874, 474);
            this.gridViewBill.TabIndex = 28;
            this.gridViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewBill_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "BillId";
            this.Id.HeaderText = "BillId";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ConsignorName
            // 
            this.ConsignorName.DataPropertyName = "BillNo";
            this.ConsignorName.HeaderText = "BillNo";
            this.ConsignorName.Name = "ConsignorName";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "BillDate";
            this.Type.HeaderText = "BillDate";
            this.Type.Name = "Type";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "BranchCode";
            this.Code.HeaderText = "BranchCode";
            this.Code.Name = "Code";
            // 
            // STNOCSTNO
            // 
            this.STNOCSTNO.DataPropertyName = "PaymentDueDate";
            this.STNOCSTNO.HeaderText = "PaymentDueDate";
            this.STNOCSTNO.Name = "STNOCSTNO";
            // 
            // TINNOVATNO
            // 
            this.TINNOVATNO.DataPropertyName = "GrandTotal";
            this.TINNOVATNO.HeaderText = "GrandTotal";
            this.TINNOVATNO.Name = "TINNOVATNO";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PartyId";
            this.Column1.HeaderText = "PartyId";
            this.Column1.Name = "Column1";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // frmBillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 474);
            this.Controls.Add(this.gridViewBill);
            this.Name = "frmBillList";
            this.Text = "frmBillList";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsignorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn STNOCSTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINNOVATNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}