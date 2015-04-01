namespace BRCTransport.Window.Forms
{
    partial class frmEntryTransaction
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbrecieved = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChanqueno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRecievedby = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPaidby = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dpTdate = new System.Windows.Forms.DateTimePicker();
            this.dpChaqurDate = new System.Windows.Forms.DateTimePicker();
            this.errorAccountName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorChequeno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorChequeDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRecievedby = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPaidBy = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescription = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorAccountName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChequeno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChequeDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecievedby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaidBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Name";
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Location = new System.Drawing.Point(152, 10);
            this.cmbAccountName.Name = "cmbAccountName";
            this.cmbAccountName.Size = new System.Drawing.Size(233, 23);
            this.cmbAccountName.TabIndex = 2;
            this.cmbAccountName.Enter += new System.EventHandler(this.EnterEvent);
            this.cmbAccountName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.cmbAccountName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(96, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "TDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Transaction Type";
            // 
            // rbrecieved
            // 
            this.rbrecieved.AutoSize = true;
            this.rbrecieved.Checked = true;
            this.rbrecieved.Location = new System.Drawing.Point(152, 73);
            this.rbrecieved.Name = "rbrecieved";
            this.rbrecieved.Size = new System.Drawing.Size(76, 19);
            this.rbrecieved.TabIndex = 26;
            this.rbrecieved.TabStop = true;
            this.rbrecieved.Text = "Recieved";
            this.rbrecieved.UseVisualStyleBackColor = true;
            this.rbrecieved.Enter += new System.EventHandler(this.EnterEvent);
            this.rbrecieved.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.rbrecieved.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(241, 73);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(50, 19);
            this.rbPaid.TabIndex = 27;
            this.rbPaid.Text = "Paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            this.rbPaid.Enter += new System.EventHandler(this.EnterEvent);
            this.rbPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.rbPaid.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(152, 100);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(139, 21);
            this.txtAmount.TabIndex = 29;
            this.txtAmount.Enter += new System.EventHandler(this.EnterEvent);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtAmount.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cheque No";
            // 
            // txtChanqueno
            // 
            this.txtChanqueno.Location = new System.Drawing.Point(152, 130);
            this.txtChanqueno.Name = "txtChanqueno";
            this.txtChanqueno.Size = new System.Drawing.Size(139, 21);
            this.txtChanqueno.TabIndex = 31;
            this.txtChanqueno.Enter += new System.EventHandler(this.EnterEvent);
            this.txtChanqueno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtChanqueno.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(49, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(118, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(65, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(86, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "Cheque Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(97, 161);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 24);
            this.label13.TabIndex = 38;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "Recieved By";
            // 
            // txtRecievedby
            // 
            this.txtRecievedby.Location = new System.Drawing.Point(151, 190);
            this.txtRecievedby.Name = "txtRecievedby";
            this.txtRecievedby.Size = new System.Drawing.Size(233, 21);
            this.txtRecievedby.TabIndex = 40;
            this.txtRecievedby.Enter += new System.EventHandler(this.EnterEvent);
            this.txtRecievedby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtRecievedby.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(93, 190);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 41;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 15);
            this.label16.TabIndex = 42;
            this.label16.Text = "Paid By";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(68, 221);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 24);
            this.label17.TabIndex = 43;
            this.label17.Text = "*";
            // 
            // txtPaidby
            // 
            this.txtPaidby.Location = new System.Drawing.Point(151, 221);
            this.txtPaidby.Name = "txtPaidby";
            this.txtPaidby.Size = new System.Drawing.Size(233, 21);
            this.txtPaidby.TabIndex = 44;
            this.txtPaidby.Enter += new System.EventHandler(this.EnterEvent);
            this.txtPaidby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPaidby.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 45;
            this.label18.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 252);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(233, 67);
            this.txtDescription.TabIndex = 46;
            this.txtDescription.Enter += new System.EventHandler(this.EnterEvent);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtDescription.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(249, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(81, 252);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 24);
            this.label19.TabIndex = 49;
            this.label19.Text = "*";
            // 
            // dpTdate
            // 
            this.dpTdate.CustomFormat = "dd-MM-yyyy";
            this.dpTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpTdate.Location = new System.Drawing.Point(152, 42);
            this.dpTdate.Name = "dpTdate";
            this.dpTdate.Size = new System.Drawing.Size(139, 21);
            this.dpTdate.TabIndex = 50;
            this.dpTdate.Enter += new System.EventHandler(this.EnterEvent);
            this.dpTdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dpTdate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // dpChaqurDate
            // 
            this.dpChaqurDate.CustomFormat = "dd-MM-yyyy";
            this.dpChaqurDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpChaqurDate.Location = new System.Drawing.Point(152, 161);
            this.dpChaqurDate.Name = "dpChaqurDate";
            this.dpChaqurDate.Size = new System.Drawing.Size(139, 21);
            this.dpChaqurDate.TabIndex = 51;
            this.dpChaqurDate.Enter += new System.EventHandler(this.EnterEvent);
            this.dpChaqurDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dpChaqurDate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // errorAccountName
            // 
            this.errorAccountName.ContainerControl = this;
            // 
            // errorTDate
            // 
            this.errorTDate.ContainerControl = this;
            // 
            // errorAmount
            // 
            this.errorAmount.ContainerControl = this;
            // 
            // errorChequeno
            // 
            this.errorChequeno.ContainerControl = this;
            // 
            // errorChequeDate
            // 
            this.errorChequeDate.ContainerControl = this;
            // 
            // errorRecievedby
            // 
            this.errorRecievedby.ContainerControl = this;
            // 
            // errorPaidBy
            // 
            this.errorPaidBy.ContainerControl = this;
            // 
            // errorDescription
            // 
            this.errorDescription.ContainerControl = this;
            // 
            // frmEntryTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 369);
            this.Controls.Add(this.dpChaqurDate);
            this.Controls.Add(this.dpTdate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtPaidby);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRecievedby);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChanqueno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbPaid);
            this.Controls.Add(this.rbrecieved);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbAccountName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEntryTransaction";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.errorAccountName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChequeno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChequeDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecievedby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaidBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbrecieved;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChanqueno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRecievedby;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPaidby;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dpTdate;
        private System.Windows.Forms.DateTimePicker dpChaqurDate;
        private System.Windows.Forms.ErrorProvider errorAccountName;
        private System.Windows.Forms.ErrorProvider errorTDate;
        private System.Windows.Forms.ErrorProvider errorAmount;
        private System.Windows.Forms.ErrorProvider errorChequeno;
        private System.Windows.Forms.ErrorProvider errorChequeDate;
        private System.Windows.Forms.ErrorProvider errorRecievedby;
        private System.Windows.Forms.ErrorProvider errorPaidBy;
        private System.Windows.Forms.ErrorProvider errorDescription;
    }
}