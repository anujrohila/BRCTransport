namespace BRCTransport.Window.Forms
{
    partial class frmAccountList
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
            this.gridViewAccount = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsignorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STNOCSTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINNOVATNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAccount
            // 
            this.gridViewAccount.AllowUserToOrderColumns = true;
            this.gridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ConsignorName,
            this.Type,
            this.Code,
            this.STNOCSTNO,
            this.TINNOVATNO,
            this.Edit,
            this.Delete});
            this.gridViewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewAccount.Location = new System.Drawing.Point(0, 0);
            this.gridViewAccount.Name = "gridViewAccount";
            this.gridViewAccount.Size = new System.Drawing.Size(744, 491);
            this.gridViewAccount.TabIndex = 28;
            this.gridViewAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewAccount_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "AccountId";
            this.Id.HeaderText = "AccountId";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ConsignorName
            // 
            this.ConsignorName.DataPropertyName = "AccountName";
            this.ConsignorName.HeaderText = "AccountName";
            this.ConsignorName.Name = "ConsignorName";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "AccountTypeName";
            this.Type.HeaderText = "AccountTypeName";
            this.Type.Name = "Type";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "AccountNo";
            this.Code.HeaderText = "AccountNo";
            this.Code.Name = "Code";
            // 
            // STNOCSTNO
            // 
            this.STNOCSTNO.DataPropertyName = "OpeningDate";
            this.STNOCSTNO.HeaderText = "OpeningDate";
            this.STNOCSTNO.Name = "STNOCSTNO";
            // 
            // TINNOVATNO
            // 
            this.TINNOVATNO.DataPropertyName = "Description";
            this.TINNOVATNO.HeaderText = "Description";
            this.TINNOVATNO.Name = "TINNOVATNO";
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
            // frmAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 491);
            this.Controls.Add(this.gridViewAccount);
            this.Name = "frmAccountList";
            this.Text = "frmAccountList";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsignorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn STNOCSTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINNOVATNO;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}