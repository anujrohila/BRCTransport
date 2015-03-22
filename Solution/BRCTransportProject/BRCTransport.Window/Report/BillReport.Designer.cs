namespace BRCTransport.Window.Report
{
    partial class BillReport
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
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(688, 15);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 13;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ddlEndDate
            // 
            this.ddlEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddlEndDate.Location = new System.Drawing.Point(565, 15);
            this.ddlEndDate.Name = "ddlEndDate";
            this.ddlEndDate.Size = new System.Drawing.Size(100, 20);
            this.ddlEndDate.TabIndex = 12;
            this.ddlEndDate.Value = new System.DateTime(2015, 1, 11, 17, 17, 18, 0);
            // 
            // ddlStartDate
            // 
            this.ddlStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddlStartDate.Location = new System.Drawing.Point(393, 15);
            this.ddlStartDate.Name = "ddlStartDate";
            this.ddlStartDate.Size = new System.Drawing.Size(100, 20);
            this.ddlStartDate.TabIndex = 11;
            this.ddlStartDate.Value = new System.DateTime(2015, 1, 11, 17, 17, 18, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "EndDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start Date ";
            // 
            // cbPartyWise
            // 
            this.cbPartyWise.DisplayMember = "PartyNameWithCode";
            this.cbPartyWise.FormattingEnabled = true;
            this.cbPartyWise.Location = new System.Drawing.Point(100, 15);
            this.cbPartyWise.Name = "cbPartyWise";
            this.cbPartyWise.Size = new System.Drawing.Size(207, 21);
            this.cbPartyWise.TabIndex = 8;
            this.cbPartyWise.ValueMember = "ConsignorId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Company Name";
            // 
            // BillReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 607);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.ddlEndDate);
            this.Controls.Add(this.ddlStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPartyWise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "BillReport";
            this.Text = "Bill Report";
            this.Load += new System.EventHandler(this.BillReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DateTimePicker ddlEndDate;
        private System.Windows.Forms.DateTimePicker ddlStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPartyWise;
        private System.Windows.Forms.Label label1;
    }
}