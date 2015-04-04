namespace BRCTransport.Window.Report
{
    partial class MRReport
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.ddlEndDate = new System.Windows.Forms.DateTimePicker();
            this.ddlStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPartyWise = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(853, 14);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 21;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ddlEndDate
            // 
            this.ddlEndDate.CustomFormat = "dd-MM-yyyy";
            this.ddlEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddlEndDate.Location = new System.Drawing.Point(719, 15);
            this.ddlEndDate.Name = "ddlEndDate";
            this.ddlEndDate.Size = new System.Drawing.Size(117, 20);
            this.ddlEndDate.TabIndex = 20;
            this.ddlEndDate.Value = new System.DateTime(2015, 1, 11, 17, 17, 18, 0);
            // 
            // ddlStartDate
            // 
            this.ddlStartDate.CustomFormat = "dd-MM-yyyy";
            this.ddlStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddlStartDate.Location = new System.Drawing.Point(555, 14);
            this.ddlStartDate.Name = "ddlStartDate";
            this.ddlStartDate.Size = new System.Drawing.Size(88, 20);
            this.ddlStartDate.TabIndex = 19;
            this.ddlStartDate.Value = new System.DateTime(2015, 1, 11, 17, 17, 18, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "EndDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Start Date ";
            // 
            // cbPartyWise
            // 
            this.cbPartyWise.DisplayMember = "PartyNameWithCode";
            this.cbPartyWise.FormattingEnabled = true;
            this.cbPartyWise.Location = new System.Drawing.Point(100, 14);
            this.cbPartyWise.Name = "cbPartyWise";
            this.cbPartyWise.Size = new System.Drawing.Size(207, 21);
            this.cbPartyWise.TabIndex = 16;
            this.cbPartyWise.ValueMember = "ConsignorId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Company Name";
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(12, 53);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1100, 488);
            this.crystalReportViewer.TabIndex = 14;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(381, 15);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 20);
            this.txtBillNo.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bill No";
            // 
            // MRReport
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
            this.Name = "MRReport";
            this.Text = "MRReport";
            this.Load += new System.EventHandler(this.MRReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DateTimePicker ddlEndDate;
        private System.Windows.Forms.DateTimePicker ddlStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPartyWise;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label4;

    }
}