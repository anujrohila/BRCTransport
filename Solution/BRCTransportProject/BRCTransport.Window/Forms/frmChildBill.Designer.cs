namespace BRCTransport.Window.Forms
{
    partial class frmChildBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdestncode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtperticulers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtchagesWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dpBillDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Old BrCode";
            // 
            // txtBrcode
            // 
            this.txtBrcode.Location = new System.Drawing.Point(144, 17);
            this.txtBrcode.Name = "txtBrcode";
            this.txtBrcode.Size = new System.Drawing.Size(223, 21);
            this.txtBrcode.TabIndex = 1;
            this.txtBrcode.Enter += new System.EventHandler(this.EnterEvent);
            this.txtBrcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBrcode.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Old Bill No";
            // 
            // txtbillno
            // 
            this.txtbillno.Location = new System.Drawing.Point(144, 47);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(223, 21);
            this.txtbillno.TabIndex = 2;
            this.txtbillno.Enter += new System.EventHandler(this.EnterEvent);
            this.txtbillno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtbillno.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Old Bill Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "DestnCode";
            // 
            // txtdestncode
            // 
            this.txtdestncode.Location = new System.Drawing.Point(144, 107);
            this.txtdestncode.Name = "txtdestncode";
            this.txtdestncode.Size = new System.Drawing.Size(223, 21);
            this.txtdestncode.TabIndex = 4;
            this.txtdestncode.Enter += new System.EventHandler(this.EnterEvent);
            this.txtdestncode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtdestncode.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Particulars";
            // 
            // txtperticulers
            // 
            this.txtperticulers.Location = new System.Drawing.Point(144, 137);
            this.txtperticulers.Name = "txtperticulers";
            this.txtperticulers.Size = new System.Drawing.Size(223, 21);
            this.txtperticulers.TabIndex = 5;
            this.txtperticulers.Enter += new System.EventHandler(this.EnterEvent);
            this.txtperticulers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtperticulers.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ChargedWeight";
            // 
            // txtchagesWeight
            // 
            this.txtchagesWeight.Location = new System.Drawing.Point(144, 167);
            this.txtchagesWeight.Name = "txtchagesWeight";
            this.txtchagesWeight.Size = new System.Drawing.Size(223, 21);
            this.txtchagesWeight.TabIndex = 6;
            this.txtchagesWeight.Enter += new System.EventHandler(this.EnterEvent);
            this.txtchagesWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtchagesWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtchagesWeight.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rate";
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(144, 197);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(223, 21);
            this.txtrate.TabIndex = 7;
            this.txtrate.Enter += new System.EventHandler(this.EnterEvent);
            this.txtrate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtrate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Amount";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(144, 227);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(223, 21);
            this.txtamount.TabIndex = 8;
            this.txtamount.Enter += new System.EventHandler(this.EnterEvent);
            this.txtamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtamount.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(144, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(239, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dpBillDate
            // 
            this.dpBillDate.CustomFormat = "dd-MM-yyyy";
            this.dpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpBillDate.Location = new System.Drawing.Point(144, 77);
            this.dpBillDate.Name = "dpBillDate";
            this.dpBillDate.Size = new System.Drawing.Size(223, 21);
            this.dpBillDate.TabIndex = 11;
            this.dpBillDate.Enter += new System.EventHandler(this.EnterEvent);
            this.dpBillDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dpBillDate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // frmChildBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 303);
            this.Controls.Add(this.dpBillDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtchagesWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtperticulers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdestncode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbillno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrcode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChildBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Bill Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdestncode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtperticulers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtchagesWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dpBillDate;
    }
}