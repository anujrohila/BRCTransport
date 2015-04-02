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
            this.ChallanDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ChallanDateTime,
            this.VehicleNo,
            this.VehicleType,
            this.Destination,
            this.DriverName,
            this.DriverMobileNo,
            this.DriverAddress,
            this.Edit,
            this.Delete});
            this.GridViewChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewChallan.Location = new System.Drawing.Point(0, 0);
            this.GridViewChallan.Name = "GridViewChallan";
            this.GridViewChallan.Size = new System.Drawing.Size(869, 464);
            this.GridViewChallan.TabIndex = 0;
            this.GridViewChallan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewChallan_CellContentClick);
            // 
            // ChallanNo
            // 
            this.ChallanNo.DataPropertyName = "ChallanNo";
            this.ChallanNo.HeaderText = "ChallanNo";
            this.ChallanNo.Name = "ChallanNo";
            this.ChallanNo.Width = 81;
            // 
            // ChallanDateTime
            // 
            this.ChallanDateTime.DataPropertyName = "ChallanDateTime";
            this.ChallanDateTime.HeaderText = "ChallanDateTime";
            this.ChallanDateTime.Name = "ChallanDateTime";
            this.ChallanDateTime.Width = 113;
            // 
            // VehicleNo
            // 
            this.VehicleNo.DataPropertyName = "VehicleNo";
            this.VehicleNo.HeaderText = "VehicleNo";
            this.VehicleNo.Name = "VehicleNo";
            this.VehicleNo.Width = 81;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "VehicleType";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Width = 91;
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.Width = 85;
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "DriverName";
            this.DriverName.Name = "DriverName";
            this.DriverName.Width = 88;
            // 
            // DriverMobileNo
            // 
            this.DriverMobileNo.DataPropertyName = "DriverMobileNo";
            this.DriverMobileNo.HeaderText = "DriverMobileNo";
            this.DriverMobileNo.Name = "DriverMobileNo";
            this.DriverMobileNo.Width = 105;
            // 
            // DriverAddress
            // 
            this.DriverAddress.DataPropertyName = "DriverAddress";
            this.DriverAddress.HeaderText = "DriverAddress";
            this.DriverAddress.Name = "DriverAddress";
            this.DriverAddress.Width = 98;
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
            this.ClientSize = new System.Drawing.Size(869, 464);
            this.Controls.Add(this.GridViewChallan);
            this.Name = "ChallanList";
            this.Text = "Challan List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChallan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewChallan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverAddress;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}