namespace BRCTransport.Window.Forms
{
    partial class ChallanList
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
            this.GridViewChallan = new System.Windows.Forms.DataGridView();
            this.ChallanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BkgStnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNNoWithAlphaCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagesNos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagesMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidToContain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualWeightKgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChallan)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewChallan
            // 
            this.GridViewChallan.AllowUserToOrderColumns = true;
            this.GridViewChallan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridViewChallan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewChallan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChallanNo,
            this.BkgStnCode,
            this.CNNoWithAlphaCode,
            this.PackagesNos,
            this.PackagesMethod,
            this.SaidToContain,
            this.ActualWeightKgs,
            this.DestinationName,
            this.Edit,
            this.Delete});
            this.GridViewChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewChallan.Location = new System.Drawing.Point(0, 0);
            this.GridViewChallan.Name = "GridViewChallan";
            this.GridViewChallan.Size = new System.Drawing.Size(814, 464);
            this.GridViewChallan.TabIndex = 0;
            this.GridViewChallan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewChallan_CellContentClick);
            // 
            // ChallanNo
            // 
            this.ChallanNo.HeaderText = "ChallanNo";
            this.ChallanNo.Name = "ChallanNo";
            this.ChallanNo.Width = 81;
            // 
            // BkgStnCode
            // 
            this.BkgStnCode.HeaderText = "BkgStnCode";
            this.BkgStnCode.Name = "BkgStnCode";
            this.BkgStnCode.Width = 92;
            // 
            // CNNoWithAlphaCode
            // 
            this.CNNoWithAlphaCode.HeaderText = "CNNoWithAlphaCode";
            this.CNNoWithAlphaCode.Name = "CNNoWithAlphaCode";
            this.CNNoWithAlphaCode.Width = 135;
            // 
            // PackagesNos
            // 
            this.PackagesNos.HeaderText = "PackagesNos";
            this.PackagesNos.Name = "PackagesNos";
            this.PackagesNos.Width = 99;
            // 
            // PackagesMethod
            // 
            this.PackagesMethod.HeaderText = "PackagesMethod";
            this.PackagesMethod.Name = "PackagesMethod";
            this.PackagesMethod.Width = 116;
            // 
            // SaidToContain
            // 
            this.SaidToContain.HeaderText = "SaidToContain";
            this.SaidToContain.Name = "SaidToContain";
            this.SaidToContain.Width = 102;
            // 
            // ActualWeightKgs
            // 
            this.ActualWeightKgs.HeaderText = "ActualWeightKgs";
            this.ActualWeightKgs.Name = "ActualWeightKgs";
            this.ActualWeightKgs.Width = 114;
            // 
            // DestinationName
            // 
            this.DestinationName.HeaderText = "DestinationName";
            this.DestinationName.Name = "DestinationName";
            this.DestinationName.Width = 113;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 31;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            this.Delete.Width = 44;
            // 
            // ChallanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 464);
            this.Controls.Add(this.GridViewChallan);
            this.Name = "ChallanList";
            this.Text = "frmChallanList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChallan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewChallan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BkgStnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNNoWithAlphaCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagesNos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagesMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaidToContain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualWeightKgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationName;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}