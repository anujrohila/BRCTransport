namespace BRCTransport.Window.Report
{
    partial class BillMRDataReport
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.ddlEndDate = new System.Windows.Forms.DateTimePicker();
            this.ddlStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPartyWise = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(12, 54);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1100, 488);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Bill No";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(366, 13);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 20);
            this.txtBillNo.TabIndex = 23;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(834, 13);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // ddlEndDate
            // 
            this.ddlEndDate.CustomFormat = "dd-MM-yyyy";
            this.ddlEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddlEndDate.Location = new System.Drawing.Point(700, 14);
            this.ddlEndDate.Name = "ddlEndDate";
            this.ddlEndDate.Size = new System.Drawing.Size(117, 20);
            this.ddlEndDate.TabIndex = 21;
            this.ddlEndDate.Value = new System.DateTime(2015, 1, 11, 17, 17, 18, 0);
            // 
            // ddlStartDate
            // 
            this.ddlStartDate.CustomFormat = "dd-MM-yyyy";
            this.ddlStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddlStartDate.Location = new System.Drawing.Point(536, 13);
            this.ddlStartDate.Name = "ddlStartDate";
            this.ddlStartDate.Size = new System.Drawing.Size(88, 20);
            this.ddlStartDate.TabIndex = 20;
            this.ddlStartDate.Value = new System.DateTime(2015, 1, 11, 17, 17, 18, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "EndDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start Date ";
            // 
            // cbPartyWise
            // 
            this.cbPartyWise.DisplayMember = "PartyNameWithCode";
            this.cbPartyWise.FormattingEnabled = true;
            this.cbPartyWise.Location = new System.Drawing.Point(101, 12);
            this.cbPartyWise.Name = "cbPartyWise";
            this.cbPartyWise.Size = new System.Drawing.Size(207, 21);
            this.cbPartyWise.TabIndex = 17;
            this.cbPartyWise.ValueMember = "ConsignorId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Company Name";
            // 
            // BillMRDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 607);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.ddlEndDate);
            this.Controls.Add(this.ddlStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPartyWise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "BillMRDataReport";
            this.Text = "Bill Report";
            this.Load += new System.EventHandler(this.BillReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DateTimePicker ddlEndDate;
        private System.Windows.Forms.DateTimePicker ddlStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPartyWise;
        private System.Windows.Forms.Label label1;
    }
}