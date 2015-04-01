namespace BRCTransport.Window.Forms
{
    partial class frmParty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTINNOVATNO = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtSTNOCSTNO = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhoneNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPartyname = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhoneNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartyname)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Partys";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(17, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 3);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Party Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "STNO/CSTNO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "TinNo/VatNo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Description";
            // 
            // txtPartyName
            // 
            this.txtPartyName.Location = new System.Drawing.Point(103, 57);
            this.txtPartyName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(270, 20);
            this.txtPartyName.TabIndex = 0;
            this.txtPartyName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtPartyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPartyName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(102, 83);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(270, 20);
            this.txtCode.TabIndex = 2;
            this.txtCode.Enter += new System.EventHandler(this.EnterEvent);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCode.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 138);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 60);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Enter += new System.EventHandler(this.EnterEvent);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtAddress.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtTINNOVATNO
            // 
            this.txtTINNOVATNO.Location = new System.Drawing.Point(102, 259);
            this.txtTINNOVATNO.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTINNOVATNO.Name = "txtTINNOVATNO";
            this.txtTINNOVATNO.Size = new System.Drawing.Size(132, 20);
            this.txtTINNOVATNO.TabIndex = 7;
            this.txtTINNOVATNO.Enter += new System.EventHandler(this.EnterEvent);
            this.txtTINNOVATNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtTINNOVATNO.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(102, 205);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(132, 20);
            this.txtPhoneNo.TabIndex = 5;
            this.txtPhoneNo.Enter += new System.EventHandler(this.EnterEvent);
            this.txtPhoneNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPhoneNo.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtSTNOCSTNO
            // 
            this.txtSTNOCSTNO.Location = new System.Drawing.Point(102, 231);
            this.txtSTNOCSTNO.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSTNOCSTNO.Name = "txtSTNOCSTNO";
            this.txtSTNOCSTNO.Size = new System.Drawing.Size(132, 20);
            this.txtSTNOCSTNO.TabIndex = 6;
            this.txtSTNOCSTNO.Enter += new System.EventHandler(this.EnterEvent);
            this.txtSTNOCSTNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtSTNOCSTNO.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(102, 287);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 59);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Enter += new System.EventHandler(this.EnterEvent);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtDescription.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Consignor",
            "Consignee"});
            this.cbType.Location = new System.Drawing.Point(102, 109);
            this.cbType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(120, 21);
            this.cbType.TabIndex = 3;
            this.cbType.Enter += new System.EventHandler(this.EnterEvent);
            this.cbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.cbType.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(102, 363);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(62, 25);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(170, 363);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(62, 25);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(80, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(50, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(50, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(66, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 24);
            this.label13.TabIndex = 23;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(74, 208);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "*";
            // 
            // errorType
            // 
            this.errorType.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorCode
            // 
            this.errorCode.ContainerControl = this;
            // 
            // errorPhoneNo
            // 
            this.errorPhoneNo.ContainerControl = this;
            // 
            // errorPartyname
            // 
            this.errorPartyname.ContainerControl = this;
            // 
            // frmParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 400);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSTNOCSTNO);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtTINNOVATNO);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtPartyName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmParty";
            this.Text = "Partys";
            this.Load += new System.EventHandler(this.frmPartys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhoneNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartyname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTINNOVATNO;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtSTNOCSTNO;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorType;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorCode;
        private System.Windows.Forms.ErrorProvider errorPhoneNo;
        private System.Windows.Forms.ErrorProvider errorPartyname;
    }
}