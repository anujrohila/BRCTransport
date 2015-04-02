namespace BRCTransport.Window.Forms
{
    partial class frmEntryAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textaccountname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbBank = new System.Windows.Forms.RadioButton();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textaccountno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textphoneno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textopeningbal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textdescription = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorAcoountName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAccountType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhoneNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorOpeningBalance = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorOpeningDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.accountdate = new System.Windows.Forms.DateTimePicker();
            this.errorAccountno = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorAcoountName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhoneNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOpeningBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOpeningDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAccountno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Name";
            // 
            // textaccountname
            // 
            this.textaccountname.Location = new System.Drawing.Point(125, 55);
            this.textaccountname.Name = "textaccountname";
            this.textaccountname.Size = new System.Drawing.Size(272, 20);
            this.textaccountname.TabIndex = 1;
            this.textaccountname.Enter += new System.EventHandler(this.EnterEvent);
            this.textaccountname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textaccountname.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(86, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(84, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "*";
            // 
            // rbBank
            // 
            this.rbBank.AutoSize = true;
            this.rbBank.Checked = true;
            this.rbBank.Location = new System.Drawing.Point(125, 89);
            this.rbBank.Name = "rbBank";
            this.rbBank.Size = new System.Drawing.Size(50, 17);
            this.rbBank.TabIndex = 2;
            this.rbBank.TabStop = true;
            this.rbBank.Text = "Bank";
            this.rbBank.UseVisualStyleBackColor = true;
            this.rbBank.Enter += new System.EventHandler(this.EnterEvent);
            this.rbBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.rbBank.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Location = new System.Drawing.Point(186, 89);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(49, 17);
            this.rbcash.TabIndex = 3;
            this.rbcash.Text = "Cash";
            this.rbcash.UseVisualStyleBackColor = true;
            this.rbcash.Enter += new System.EventHandler(this.EnterEvent);
            this.rbcash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.rbcash.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(75, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
            // 
            // textaccountno
            // 
            this.textaccountno.Location = new System.Drawing.Point(125, 112);
            this.textaccountno.Name = "textaccountno";
            this.textaccountno.Size = new System.Drawing.Size(272, 20);
            this.textaccountno.TabIndex = 4;
            this.textaccountno.Enter += new System.EventHandler(this.EnterEvent);
            this.textaccountno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textaccountno.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(56, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "*";
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(125, 143);
            this.textaddress.Multiline = true;
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(272, 63);
            this.textaddress.TabIndex = 5;
            this.textaddress.Enter += new System.EventHandler(this.EnterEvent);
            this.textaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textaddress.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phone No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(66, 212);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "*";
            // 
            // textphoneno
            // 
            this.textphoneno.Location = new System.Drawing.Point(125, 212);
            this.textphoneno.Name = "textphoneno";
            this.textphoneno.Size = new System.Drawing.Size(272, 20);
            this.textphoneno.TabIndex = 6;
            this.textphoneno.Enter += new System.EventHandler(this.EnterEvent);
            this.textphoneno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textphoneno.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Opening Balance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(100, 248);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 24);
            this.label13.TabIndex = 36;
            this.label13.Text = "*";
            // 
            // textopeningbal
            // 
            this.textopeningbal.Location = new System.Drawing.Point(125, 245);
            this.textopeningbal.Name = "textopeningbal";
            this.textopeningbal.Size = new System.Drawing.Size(272, 20);
            this.textopeningbal.TabIndex = 7;
            this.textopeningbal.Enter += new System.EventHandler(this.EnterEvent);
            this.textopeningbal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textopeningbal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.textopeningbal.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Opening Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(82, 274);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 39;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Description";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(68, 306);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 24);
            this.label17.TabIndex = 42;
            this.label17.Text = "*";
            // 
            // textdescription
            // 
            this.textdescription.Location = new System.Drawing.Point(125, 303);
            this.textdescription.Multiline = true;
            this.textdescription.Name = "textdescription";
            this.textdescription.Size = new System.Drawing.Size(272, 71);
            this.textdescription.TabIndex = 9;
            this.textdescription.Enter += new System.EventHandler(this.EnterEvent);
            this.textdescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textdescription.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(126, 392);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(15, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 3);
            this.panel1.TabIndex = 46;
            // 
            // errorAcoountName
            // 
            this.errorAcoountName.ContainerControl = this;
            // 
            // errorAccountType
            // 
            this.errorAccountType.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorPhoneNo
            // 
            this.errorPhoneNo.ContainerControl = this;
            // 
            // errorOpeningBalance
            // 
            this.errorOpeningBalance.ContainerControl = this;
            // 
            // errorOpeningDate
            // 
            this.errorOpeningDate.ContainerControl = this;
            // 
            // errorDescription
            // 
            this.errorDescription.ContainerControl = this;
            // 
            // accountdate
            // 
            this.accountdate.CustomFormat = "dd/MM/yyyy";
            this.accountdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.accountdate.Location = new System.Drawing.Point(125, 274);
            this.accountdate.Name = "accountdate";
            this.accountdate.Size = new System.Drawing.Size(272, 20);
            this.accountdate.TabIndex = 8;
            this.accountdate.Value = new System.DateTime(2015, 3, 26, 10, 56, 11, 0);
            this.accountdate.Enter += new System.EventHandler(this.EnterEvent);
            this.accountdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.accountdate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // errorAccountno
            // 
            this.errorAccountno.ContainerControl = this;
            // 
            // frmEntryAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 427);
            this.Controls.Add(this.accountdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.textdescription);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textopeningbal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textphoneno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textaccountno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbcash);
            this.Controls.Add(this.rbBank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textaccountname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEntryAccount";
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.errorAcoountName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhoneNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOpeningBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOpeningDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAccountno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textaccountname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbBank;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textaccountno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textphoneno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textopeningbal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textdescription;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorAcoountName;
        private System.Windows.Forms.ErrorProvider errorAccountType;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorPhoneNo;
        private System.Windows.Forms.ErrorProvider errorOpeningBalance;
        private System.Windows.Forms.ErrorProvider errorOpeningDate;
        private System.Windows.Forms.ErrorProvider errorDescription;
        private System.Windows.Forms.DateTimePicker accountdate;
        private System.Windows.Forms.ErrorProvider errorAccountno;
    }
}