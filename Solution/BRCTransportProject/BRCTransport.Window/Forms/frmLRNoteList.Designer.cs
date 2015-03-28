namespace BRCTransport.Window.Forms
{
    partial class frmLRNoteList
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
            this.GridViewLR = new System.Windows.Forms.DataGridView();
            this.ConsignmentNoteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolicyNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MethodOfPacking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLR)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewLR
            // 
            this.GridViewLR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewLR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsignmentNoteNo,
            this.CompanyName,
            this.PolicyNo,
            this.CompanyDate,
            this.CompanyAmount,
            this.FromCode,
            this.ToCode,
            this.MethodOfPacking,
            this.Distance,
            this.FinalAmount});
            this.GridViewLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewLR.Location = new System.Drawing.Point(0, 0);
            this.GridViewLR.Name = "GridViewLR";
            this.GridViewLR.Size = new System.Drawing.Size(641, 427);
            this.GridViewLR.TabIndex = 0;
            this.GridViewLR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ConsignmentNoteNo
            // 
            this.ConsignmentNoteNo.HeaderText = "ConsignmentNoteNo";
            this.ConsignmentNoteNo.Name = "ConsignmentNoteNo";
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            // 
            // PolicyNo
            // 
            this.PolicyNo.HeaderText = "PolicyNo";
            this.PolicyNo.Name = "PolicyNo";
            // 
            // CompanyDate
            // 
            this.CompanyDate.HeaderText = "CompanyDate";
            this.CompanyDate.Name = "CompanyDate";
            // 
            // CompanyAmount
            // 
            this.CompanyAmount.HeaderText = "CompanyAmount";
            this.CompanyAmount.Name = "CompanyAmount";
            // 
            // FromCode
            // 
            this.FromCode.HeaderText = "FromCode";
            this.FromCode.Name = "FromCode";
            // 
            // ToCode
            // 
            this.ToCode.HeaderText = "ToCode";
            this.ToCode.Name = "ToCode";
            // 
            // MethodOfPacking
            // 
            this.MethodOfPacking.HeaderText = "MethodOfPacking";
            this.MethodOfPacking.Name = "MethodOfPacking";
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            // 
            // FinalAmount
            // 
            this.FinalAmount.HeaderText = "FinalAmount";
            this.FinalAmount.Name = "FinalAmount";
            // 
            // frmLRNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 427);
            this.Controls.Add(this.GridViewLR);
            this.Name = "frmLRNoteList";
            this.Text = "frmLRNoteList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLRNoteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewLR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsignmentNoteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolicyNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MethodOfPacking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAmount;
    }
}