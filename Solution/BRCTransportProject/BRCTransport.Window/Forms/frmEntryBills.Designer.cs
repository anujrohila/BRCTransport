namespace BRCTransport.Window.Forms
{
    partial class frmEntryBills
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
            this.cmbParty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textservicetax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbillno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbranchcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimebilldate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeduedate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.combotickbill = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textbasicofchange = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.texttaxregdno = new System.Windows.Forms.TextBox();
            this.comboservicetax = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textenclosure = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textcheckedby = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grdEntryBill = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.errorPartyName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBrandcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorbilldate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPaymentDuedate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTickbillType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorServiceTex = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdEntryBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBrandcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbilldate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaymentDuedate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTickbillType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorServiceTex)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Party Name & Address :";
            // 
            // cmbParty
            // 
            this.cmbParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParty.FormattingEnabled = true;
            this.cmbParty.Location = new System.Drawing.Point(155, 21);
            this.cmbParty.Name = "cmbParty";
            this.cmbParty.Size = new System.Drawing.Size(174, 23);
            this.cmbParty.TabIndex = 1;
            this.cmbParty.Enter += new System.EventHandler(this.EnterEvent);
            this.cmbParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.cmbParty.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service Tax Regd. No.";
            // 
            // textservicetax
            // 
            this.textservicetax.Location = new System.Drawing.Point(155, 56);
            this.textservicetax.Name = "textservicetax";
            this.textservicetax.Size = new System.Drawing.Size(174, 21);
            this.textservicetax.TabIndex = 2;
            this.textservicetax.Enter += new System.EventHandler(this.EnterEvent);
            this.textservicetax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textservicetax.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bill No";
            // 
            // textbillno
            // 
            this.textbillno.Location = new System.Drawing.Point(482, 20);
            this.textbillno.Name = "textbillno";
            this.textbillno.ReadOnly = true;
            this.textbillno.Size = new System.Drawing.Size(140, 21);
            this.textbillno.TabIndex = 3;
            this.textbillno.Enter += new System.EventHandler(this.EnterEvent);
            this.textbillno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textbillno.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Branch Code";
            // 
            // textbranchcode
            // 
            this.textbranchcode.Location = new System.Drawing.Point(806, 21);
            this.textbranchcode.Name = "textbranchcode";
            this.textbranchcode.Size = new System.Drawing.Size(140, 21);
            this.textbranchcode.TabIndex = 4;
            this.textbranchcode.Enter += new System.EventHandler(this.EnterEvent);
            this.textbranchcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textbranchcode.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bill Date";
            // 
            // dateTimebilldate
            // 
            this.dateTimebilldate.CustomFormat = "dd-MM-yyyy";
            this.dateTimebilldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimebilldate.Location = new System.Drawing.Point(483, 55);
            this.dateTimebilldate.Name = "dateTimebilldate";
            this.dateTimebilldate.Size = new System.Drawing.Size(139, 21);
            this.dateTimebilldate.TabIndex = 5;
            this.dateTimebilldate.Enter += new System.EventHandler(this.EnterEvent);
            this.dateTimebilldate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dateTimebilldate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Payment Due Date\t";
            // 
            // dateTimeduedate
            // 
            this.dateTimeduedate.CustomFormat = "dd-MM-yyyy";
            this.dateTimeduedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeduedate.Location = new System.Drawing.Point(806, 51);
            this.dateTimeduedate.Name = "dateTimeduedate";
            this.dateTimeduedate.Size = new System.Drawing.Size(140, 21);
            this.dateTimeduedate.TabIndex = 6;
            this.dateTimeduedate.Enter += new System.EventHandler(this.EnterEvent);
            this.dateTimeduedate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dateTimeduedate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tick Bill Type";
            // 
            // combotickbill
            // 
            this.combotickbill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotickbill.FormattingEnabled = true;
            this.combotickbill.Items.AddRange(new object[] {
            "FREIGHT",
            "OCTROI",
            "SUPPLER",
            "MISC",
            "Others"});
            this.combotickbill.Location = new System.Drawing.Point(482, 91);
            this.combotickbill.Name = "combotickbill";
            this.combotickbill.Size = new System.Drawing.Size(140, 23);
            this.combotickbill.TabIndex = 7;
            this.combotickbill.Enter += new System.EventHandler(this.EnterEvent);
            this.combotickbill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.combotickbill.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Basic of Charges G.C Note or Contract No :";
            // 
            // textbasicofchange
            // 
            this.textbasicofchange.Location = new System.Drawing.Point(295, 135);
            this.textbasicofchange.Name = "textbasicofchange";
            this.textbasicofchange.Size = new System.Drawing.Size(639, 21);
            this.textbasicofchange.TabIndex = 8;
            this.textbasicofchange.Enter += new System.EventHandler(this.EnterEvent);
            this.textbasicofchange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textbasicofchange.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Our Centralised Service Tax Regd. No.";
            // 
            // texttaxregdno
            // 
            this.texttaxregdno.Location = new System.Drawing.Point(240, 197);
            this.texttaxregdno.Name = "texttaxregdno";
            this.texttaxregdno.Size = new System.Drawing.Size(216, 21);
            this.texttaxregdno.TabIndex = 10;
            this.texttaxregdno.Enter += new System.EventHandler(this.EnterEvent);
            this.texttaxregdno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.texttaxregdno.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // comboservicetax
            // 
            this.comboservicetax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboservicetax.FormattingEnabled = true;
            this.comboservicetax.Items.AddRange(new object[] {
            "CONSIGNOR",
            "CONSIGNEE",
            "BRC"});
            this.comboservicetax.Location = new System.Drawing.Point(633, 203);
            this.comboservicetax.Name = "comboservicetax";
            this.comboservicetax.Size = new System.Drawing.Size(153, 23);
            this.comboservicetax.TabIndex = 12;
            this.comboservicetax.Enter += new System.EventHandler(this.EnterEvent);
            this.comboservicetax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.comboservicetax.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Service Tax Through :";
            // 
            // textenclosure
            // 
            this.textenclosure.Location = new System.Drawing.Point(155, 171);
            this.textenclosure.Name = "textenclosure";
            this.textenclosure.Size = new System.Drawing.Size(140, 21);
            this.textenclosure.TabIndex = 9;
            this.textenclosure.Enter += new System.EventHandler(this.EnterEvent);
            this.textenclosure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textenclosure.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enclosure ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(485, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Checked By :";
            // 
            // textcheckedby
            // 
            this.textcheckedby.Location = new System.Drawing.Point(633, 174);
            this.textcheckedby.Name = "textcheckedby";
            this.textcheckedby.Size = new System.Drawing.Size(153, 21);
            this.textcheckedby.TabIndex = 11;
            this.textcheckedby.Enter += new System.EventHandler(this.EnterEvent);
            this.textcheckedby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.textcheckedby.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(473, 517);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(97, 33);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(576, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 33);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(18, 232);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(83, 24);
            this.btnEntry.TabIndex = 13;
            this.btnEntry.Text = "Add Entry";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Red;
            this.label50.Location = new System.Drawing.Point(426, 61);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(17, 24);
            this.label50.TabIndex = 102;
            this.label50.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(740, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 24);
            this.label13.TabIndex = 103;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(770, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 104;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(460, 95);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 105;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(605, 205);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 24);
            this.label16.TabIndex = 106;
            this.label16.Text = "*";
            // 
            // grdEntryBill
            // 
            this.grdEntryBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntryBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.grdEntryBill.Location = new System.Drawing.Point(12, 262);
            this.grdEntryBill.Name = "grdEntryBill";
            this.grdEntryBill.Size = new System.Drawing.Size(1142, 249);
            this.grdEntryBill.TabIndex = 107;
            this.grdEntryBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEntryBill_CellContentClick);
            // 
            // SrNo
            // 
            this.SrNo.DataPropertyName = "SrNo";
            this.SrNo.Frozen = true;
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookingOldBrCode";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "BookingOldBrCode";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "OldBillNo";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "OldBillNo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "OldBillDate";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "OldBillDate";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DestnCode";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "DestnCode";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Particulars";
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Particulars";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ChargedWeight";
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "ChargedWeight";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Rate";
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Rate";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Amount";
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Amount";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Edit";
            this.Column10.Name = "Column10";
            this.Column10.Text = "Edit";
            this.Column10.UseColumnTextForLinkValue = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Delete";
            this.Column11.Name = "Column11";
            this.Column11.Text = "Delete";
            this.Column11.UseColumnTextForLinkValue = true;
            // 
            // errorPartyName
            // 
            this.errorPartyName.ContainerControl = this;
            // 
            // errorBrandcode
            // 
            this.errorBrandcode.ContainerControl = this;
            // 
            // errorbilldate
            // 
            this.errorbilldate.ContainerControl = this;
            // 
            // errorPaymentDuedate
            // 
            this.errorPaymentDuedate.ContainerControl = this;
            // 
            // errorTickbillType
            // 
            this.errorTickbillType.ContainerControl = this;
            // 
            // errorServiceTex
            // 
            this.errorServiceTex.ContainerControl = this;
            // 
            // frmEntryBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 554);
            this.Controls.Add(this.grdEntryBill);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textcheckedby);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboservicetax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textenclosure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.texttaxregdno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textbasicofchange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combotickbill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeduedate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimebilldate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbranchcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbillno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textservicetax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbParty);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEntryBills";
            this.Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)(this.grdEntryBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBrandcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbilldate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaymentDuedate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTickbillType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorServiceTex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbParty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textservicetax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbillno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbranchcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimebilldate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeduedate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combotickbill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbasicofchange;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox texttaxregdno;
        private System.Windows.Forms.ComboBox comboservicetax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textenclosure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textcheckedby;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView grdEntryBill;
        private System.Windows.Forms.ErrorProvider errorPartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewLinkColumn Column10;
        private System.Windows.Forms.DataGridViewLinkColumn Column11;
        private System.Windows.Forms.ErrorProvider errorBrandcode;
        private System.Windows.Forms.ErrorProvider errorbilldate;
        private System.Windows.Forms.ErrorProvider errorPaymentDuedate;
        private System.Windows.Forms.ErrorProvider errorTickbillType;
        private System.Windows.Forms.ErrorProvider errorServiceTex;
    }
}