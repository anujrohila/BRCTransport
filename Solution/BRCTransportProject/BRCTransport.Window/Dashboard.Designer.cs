namespace BRCTransport.Window
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.challanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allChallanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listChallanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lRNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLRNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listLRNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMRNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMRNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partyToolStripMenuItem,
            this.challanToolStripMenuItem,
            this.billToolStripMenuItem,
            this.lRNoteToolStripMenuItem,
            this.mRNoteToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partyToolStripMenuItem
            // 
            this.partyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPartyToolStripMenuItem,
            this.partyListToolStripMenuItem});
            this.partyToolStripMenuItem.Name = "partyToolStripMenuItem";
            this.partyToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.partyToolStripMenuItem.Text = "Party";
            // 
            // addPartyToolStripMenuItem
            // 
            this.addPartyToolStripMenuItem.Name = "addPartyToolStripMenuItem";
            this.addPartyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPartyToolStripMenuItem.Tag = "Add Party";
            this.addPartyToolStripMenuItem.Text = "Add Party";
            this.addPartyToolStripMenuItem.Click += new System.EventHandler(this.Popup_Showdialog);
            // 
            // partyListToolStripMenuItem
            // 
            this.partyListToolStripMenuItem.Name = "partyListToolStripMenuItem";
            this.partyListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.partyListToolStripMenuItem.Tag = "Party List";
            this.partyListToolStripMenuItem.Text = "Party List";
            this.partyListToolStripMenuItem.Click += new System.EventHandler(this.Popup_Show);
            // 
            // challanToolStripMenuItem
            // 
            this.challanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allChallanToolStripMenuItem,
            this.listChallanToolStripMenuItem});
            this.challanToolStripMenuItem.Name = "challanToolStripMenuItem";
            this.challanToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.challanToolStripMenuItem.Text = "Challan";
            // 
            // allChallanToolStripMenuItem
            // 
            this.allChallanToolStripMenuItem.Name = "allChallanToolStripMenuItem";
            this.allChallanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allChallanToolStripMenuItem.Tag = "Add Challan";
            this.allChallanToolStripMenuItem.Text = "Add Challan";
            this.allChallanToolStripMenuItem.Click += new System.EventHandler(this.Popup_Showdialog);
            // 
            // listChallanToolStripMenuItem
            // 
            this.listChallanToolStripMenuItem.Name = "listChallanToolStripMenuItem";
            this.listChallanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listChallanToolStripMenuItem.Tag = "List Challan";
            this.listChallanToolStripMenuItem.Text = "List Challan";
            this.listChallanToolStripMenuItem.Click += new System.EventHandler(this.Popup_Show);
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBillToolStripMenuItem,
            this.listBillToolStripMenuItem});
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.billToolStripMenuItem.Tag = "Bill";
            this.billToolStripMenuItem.Text = "Bill";
            // 
            // addBillToolStripMenuItem
            // 
            this.addBillToolStripMenuItem.Name = "addBillToolStripMenuItem";
            this.addBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addBillToolStripMenuItem.Tag = "Add Bill";
            this.addBillToolStripMenuItem.Text = "Add Bill";
            this.addBillToolStripMenuItem.Click += new System.EventHandler(this.Popup_Showdialog);
            // 
            // listBillToolStripMenuItem
            // 
            this.listBillToolStripMenuItem.Name = "listBillToolStripMenuItem";
            this.listBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listBillToolStripMenuItem.Tag = "List Bill";
            this.listBillToolStripMenuItem.Text = "List Bill";
            this.listBillToolStripMenuItem.Click += new System.EventHandler(this.Popup_Show);
            // 
            // lRNoteToolStripMenuItem
            // 
            this.lRNoteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLRNoteToolStripMenuItem,
            this.listLRNoteToolStripMenuItem});
            this.lRNoteToolStripMenuItem.Name = "lRNoteToolStripMenuItem";
            this.lRNoteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.lRNoteToolStripMenuItem.Text = "LR Note";
            // 
            // addLRNoteToolStripMenuItem
            // 
            this.addLRNoteToolStripMenuItem.Name = "addLRNoteToolStripMenuItem";
            this.addLRNoteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addLRNoteToolStripMenuItem.Tag = "Add LR Note";
            this.addLRNoteToolStripMenuItem.Text = "Add LR Note";
            this.addLRNoteToolStripMenuItem.Click += new System.EventHandler(this.Popup_Showdialog);
            // 
            // listLRNoteToolStripMenuItem
            // 
            this.listLRNoteToolStripMenuItem.Name = "listLRNoteToolStripMenuItem";
            this.listLRNoteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listLRNoteToolStripMenuItem.Tag = "List LR Note";
            this.listLRNoteToolStripMenuItem.Text = "List LR Note";
            this.listLRNoteToolStripMenuItem.Click += new System.EventHandler(this.Popup_Show);
            // 
            // mRNoteToolStripMenuItem
            // 
            this.mRNoteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMRNoteToolStripMenuItem,
            this.listMRNoteToolStripMenuItem});
            this.mRNoteToolStripMenuItem.Name = "mRNoteToolStripMenuItem";
            this.mRNoteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.mRNoteToolStripMenuItem.Tag = "MR Note";
            this.mRNoteToolStripMenuItem.Text = "MR Note";
            // 
            // addMRNoteToolStripMenuItem
            // 
            this.addMRNoteToolStripMenuItem.Name = "addMRNoteToolStripMenuItem";
            this.addMRNoteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addMRNoteToolStripMenuItem.Tag = "Add MR Note";
            this.addMRNoteToolStripMenuItem.Text = "Add MR Note";
            this.addMRNoteToolStripMenuItem.Click += new System.EventHandler(this.Popup_Showdialog);
            // 
            // listMRNoteToolStripMenuItem
            // 
            this.listMRNoteToolStripMenuItem.Name = "listMRNoteToolStripMenuItem";
            this.listMRNoteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listMRNoteToolStripMenuItem.Tag = "List MR Note";
            this.listMRNoteToolStripMenuItem.Text = "List MR Note";
            this.listMRNoteToolStripMenuItem.Click += new System.EventHandler(this.Popup_Show);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.accountListToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.transactionListToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Tag = "Account";
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addAccountToolStripMenuItem.Tag = "Add Account";
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.Popup_Showdialog);
            // 
            // accountListToolStripMenuItem
            // 
            this.accountListToolStripMenuItem.Name = "accountListToolStripMenuItem";
            this.accountListToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.accountListToolStripMenuItem.Tag = "Account List";
            this.accountListToolStripMenuItem.Text = "Account List";
            this.accountListToolStripMenuItem.Click += new System.EventHandler(this.Popup_Show);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.transactionToolStripMenuItem.Tag = "Add Transaction";
            this.transactionToolStripMenuItem.Text = "Add Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.Popup_Showdialog);
            // 
            // transactionListToolStripMenuItem
            // 
            this.transactionListToolStripMenuItem.Name = "transactionListToolStripMenuItem";
            this.transactionListToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.transactionListToolStripMenuItem.Tag = "Transaction List";
            this.transactionListToolStripMenuItem.Text = "Transaction List";
            this.transactionListToolStripMenuItem.Click += new System.EventHandler(this.Popup_Show);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // billReportToolStripMenuItem
            // 
            this.billReportToolStripMenuItem.Name = "billReportToolStripMenuItem";
            this.billReportToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.billReportToolStripMenuItem.Tag = "Bill Report";
            this.billReportToolStripMenuItem.Text = "Bill Report";
            this.billReportToolStripMenuItem.Click += new System.EventHandler(this.Popup_Showdialog);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 460);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allChallanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listChallanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lRNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLRNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listLRNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMRNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listMRNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billReportToolStripMenuItem;
    }
}

