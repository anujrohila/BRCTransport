namespace BRCTransport.Window.Forms
{
    partial class frmTransactionList
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
            this.GridViewtransaction = new System.Windows.Forms.DataGridView();
            this.TDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recievedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewtransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewtransaction
            // 
            this.GridViewtransaction.AllowUserToOrderColumns = true;
            this.GridViewtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewtransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TDate,
            this.DrAmount,
            this.CrAmount,
            this.Recievedby,
            this.PaidBy,
            this.Description,
            this.ChequeNo,
            this.ChequeDate,
            this.Edit,
            this.Delete});
            this.GridViewtransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewtransaction.Location = new System.Drawing.Point(0, 0);
            this.GridViewtransaction.Name = "GridViewtransaction";
            this.GridViewtransaction.Size = new System.Drawing.Size(619, 419);
            this.GridViewtransaction.TabIndex = 0;
            this.GridViewtransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TDate
            // 
            this.TDate.DataPropertyName = "TDate";
            this.TDate.HeaderText = "TDate";
            this.TDate.Name = "TDate";
            // 
            // DrAmount
            // 
            this.DrAmount.DataPropertyName = "DrAmount";
            this.DrAmount.HeaderText = "DrAmount";
            this.DrAmount.Name = "DrAmount";
            // 
            // CrAmount
            // 
            this.CrAmount.DataPropertyName = "CrAmount";
            this.CrAmount.HeaderText = "CrAmount";
            this.CrAmount.Name = "CrAmount";
            // 
            // Recievedby
            // 
            this.Recievedby.DataPropertyName = "Recievedby";
            this.Recievedby.HeaderText = "Recievedby";
            this.Recievedby.Name = "Recievedby";
            // 
            // PaidBy
            // 
            this.PaidBy.DataPropertyName = "PaidBy";
            this.PaidBy.HeaderText = "PaidBy";
            this.PaidBy.Name = "PaidBy";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // ChequeNo
            // 
            this.ChequeNo.DataPropertyName = "ChequeNo";
            this.ChequeNo.HeaderText = "ChequeNo";
            this.ChequeNo.Name = "ChequeNo";
            // 
            // ChequeDate
            // 
            this.ChequeDate.DataPropertyName = "ChequeDate";
            this.ChequeDate.HeaderText = "ChequeDate";
            this.ChequeDate.Name = "ChequeDate";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // frmTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 419);
            this.Controls.Add(this.GridViewtransaction);
            this.Name = "frmTransactionList";
            this.Text = "frmTransactionList";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewtransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewtransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recievedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeDate;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}