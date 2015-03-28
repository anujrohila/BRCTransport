namespace BRCTransport.Window.Forms
{
    partial class PartyList
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
            this.gridViewParty = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsignorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STNOCSTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINNOVATNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParty)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewParty
            // 
            this.gridViewParty.AllowUserToOrderColumns = true;
            this.gridViewParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewParty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ConsignorName,
            this.Type,
            this.Code,
            this.STNOCSTNO,
            this.TINNOVATNO,
            this.Edit,
            this.Delete});
            this.gridViewParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewParty.Location = new System.Drawing.Point(0, 0);
            this.gridViewParty.Name = "gridViewParty";
            this.gridViewParty.Size = new System.Drawing.Size(777, 561);
            this.gridViewParty.TabIndex = 27;
            this.gridViewParty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewParty_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ConsignorId";
            this.Id.HeaderText = "ConsignorId";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ConsignorName
            // 
            this.ConsignorName.DataPropertyName = "ConsignorName";
            this.ConsignorName.HeaderText = "PartyName";
            this.ConsignorName.Name = "ConsignorName";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "PartyType";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // STNOCSTNO
            // 
            this.STNOCSTNO.DataPropertyName = "STNOCSTNO";
            this.STNOCSTNO.HeaderText = "STNOCSTNO";
            this.STNOCSTNO.Name = "STNOCSTNO";
            // 
            // TINNOVATNO
            // 
            this.TINNOVATNO.DataPropertyName = "STNOCSTNO";
            this.TINNOVATNO.HeaderText = "TINNOVATNO";
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
            // PartyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 561);
            this.Controls.Add(this.gridViewParty);
            this.Name = "PartyList";
            this.Text = "PartyList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PartyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewParty;
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