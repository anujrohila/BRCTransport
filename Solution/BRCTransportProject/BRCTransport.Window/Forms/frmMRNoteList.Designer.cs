namespace BRCTransport.Window.Forms
{
    partial class MRNoteList
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
            this.GridViewMr = new System.Windows.Forms.DataGridView();
            this.MRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecievedFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoofPackages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountRecieved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WayOfRecieve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMr)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewMr
            // 
            this.GridViewMr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MRDate,
            this.CreationDate,
            this.RecievedFrom,
            this.LocationFrom,
            this.LocationTo,
            this.NoofPackages,
            this.Weight,
            this.AmountRecieved,
            this.WayOfRecieve,
            this.TotalAmount});
            this.GridViewMr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewMr.Location = new System.Drawing.Point(0, 0);
            this.GridViewMr.Name = "GridViewMr";
            this.GridViewMr.Size = new System.Drawing.Size(561, 413);
            this.GridViewMr.TabIndex = 0;
            this.GridViewMr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MRDate
            // 
            this.MRDate.HeaderText = "MRDate";
            this.MRDate.Name = "MRDate";
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "CreationDate";
            this.CreationDate.Name = "CreationDate";
            // 
            // RecievedFrom
            // 
            this.RecievedFrom.HeaderText = "RecievedFrom";
            this.RecievedFrom.Name = "RecievedFrom";
            // 
            // LocationFrom
            // 
            this.LocationFrom.HeaderText = "LocationFrom";
            this.LocationFrom.Name = "LocationFrom";
            // 
            // LocationTo
            // 
            this.LocationTo.HeaderText = "LocationTo";
            this.LocationTo.Name = "LocationTo";
            // 
            // NoofPackages
            // 
            this.NoofPackages.HeaderText = "NoofPackages";
            this.NoofPackages.Name = "NoofPackages";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // AmountRecieved
            // 
            this.AmountRecieved.HeaderText = "AmountRecieved";
            this.AmountRecieved.Name = "AmountRecieved";
            // 
            // WayOfRecieve
            // 
            this.WayOfRecieve.HeaderText = "WayOfRecieve";
            this.WayOfRecieve.Name = "WayOfRecieve";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // MRNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 413);
            this.Controls.Add(this.GridViewMr);
            this.Name = "MRNoteList";
            this.Text = "frmMRNoteList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMRNoteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewMr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecievedFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoofPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountRecieved;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayOfRecieve;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}