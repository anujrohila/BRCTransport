namespace BRCTransport.Window.Forms
{
    partial class frmEntryMRNote
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
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMRno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecievefrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dpbilldate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNoofPackage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtRecievedAmount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtFright = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtstch = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtHamali = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtOther1 = new System.Windows.Forms.TextBox();
            this.txtOther2 = new System.Windows.Forms.TextBox();
            this.txtOther3 = new System.Windows.Forms.TextBox();
            this.txtOther4 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMrNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorREcievedFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBillno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBillAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNoofPackage = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorWeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRecievedAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPaymenttype = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMrNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorREcievedFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBillno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBillAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoofPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecievedAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaymenttype)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // dpDate
            // 
            this.dpDate.CustomFormat = "dd-MM-yyyy";
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDate.Location = new System.Drawing.Point(126, 20);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(110, 21);
            this.dpDate.TabIndex = 1;
            this.dpDate.Enter += new System.EventHandler(this.EnterEvent);
            this.dpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dpDate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(51, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "MRNo";
            // 
            // txtMRno
            // 
            this.txtMRno.Location = new System.Drawing.Point(126, 51);
            this.txtMRno.Name = "txtMRno";
            this.txtMRno.ReadOnly = true;
            this.txtMRno.Size = new System.Drawing.Size(110, 21);
            this.txtMRno.TabIndex = 2;
            this.txtMRno.Enter += new System.EventHandler(this.EnterEvent);
            this.txtMRno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtMRno.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Recieved From";
            // 
            // txtRecievefrom
            // 
            this.txtRecievefrom.Location = new System.Drawing.Point(125, 81);
            this.txtRecievefrom.Name = "txtRecievefrom";
            this.txtRecievefrom.Size = new System.Drawing.Size(569, 21);
            this.txtRecievefrom.TabIndex = 3;
            this.txtRecievefrom.Enter += new System.EventHandler(this.EnterEvent);
            this.txtRecievefrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtRecievefrom.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(58, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(99, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(43, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "*";
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(125, 110);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(201, 21);
            this.txtfrom.TabIndex = 4;
            this.txtfrom.Enter += new System.EventHandler(this.EnterEvent);
            this.txtfrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtfrom.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(388, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "*";
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(479, 110);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(215, 21);
            this.txtto.TabIndex = 5;
            this.txtto.Enter += new System.EventHandler(this.EnterEvent);
            this.txtto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtto.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "BillNo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(48, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "*";
            // 
            // txtbillno
            // 
            this.txtbillno.Location = new System.Drawing.Point(125, 139);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(201, 21);
            this.txtbillno.TabIndex = 6;
            this.txtbillno.Enter += new System.EventHandler(this.EnterEvent);
            this.txtbillno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtbillno.Leave += new System.EventHandler(this.txtbillno_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "Bill Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(416, 141);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 38;
            this.label14.Text = "*";
            // 
            // dpbilldate
            // 
            this.dpbilldate.Location = new System.Drawing.Point(479, 140);
            this.dpbilldate.Name = "dpbilldate";
            this.dpbilldate.ReadOnly = true;
            this.dpbilldate.Size = new System.Drawing.Size(215, 21);
            this.dpbilldate.TabIndex = 7;
            this.dpbilldate.Enter += new System.EventHandler(this.EnterEvent);
            this.dpbilldate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dpbilldate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "Bill Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(78, 167);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 24);
            this.label16.TabIndex = 41;
            this.label16.Text = "*";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(125, 167);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(201, 21);
            this.txtBillAmount.TabIndex = 8;
            this.txtBillAmount.Enter += new System.EventHandler(this.EnterEvent);
            this.txtBillAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBillAmount.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(361, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 15);
            this.label17.TabIndex = 43;
            this.label17.Text = "NoofPackage";
            // 
            // txtNoofPackage
            // 
            this.txtNoofPackage.Location = new System.Drawing.Point(479, 169);
            this.txtNoofPackage.Name = "txtNoofPackage";
            this.txtNoofPackage.Size = new System.Drawing.Size(215, 21);
            this.txtNoofPackage.TabIndex = 9;
            this.txtNoofPackage.Enter += new System.EventHandler(this.EnterEvent);
            this.txtNoofPackage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNoofPackage.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(444, 174);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 24);
            this.label18.TabIndex = 45;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 15);
            this.label19.TabIndex = 46;
            this.label19.Text = "Weight";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(57, 201);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 24);
            this.label20.TabIndex = 47;
            this.label20.Text = "*";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(124, 197);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(201, 21);
            this.txtWeight.TabIndex = 10;
            this.txtWeight.Enter += new System.EventHandler(this.EnterEvent);
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtWeight.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(359, 199);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 15);
            this.label21.TabIndex = 49;
            this.label21.Text = "Recieved Amount";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(462, 199);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 24);
            this.label22.TabIndex = 50;
            this.label22.Text = "*";
            // 
            // txtRecievedAmount
            // 
            this.txtRecievedAmount.Location = new System.Drawing.Point(479, 199);
            this.txtRecievedAmount.Name = "txtRecievedAmount";
            this.txtRecievedAmount.ReadOnly = true;
            this.txtRecievedAmount.Size = new System.Drawing.Size(214, 21);
            this.txtRecievedAmount.TabIndex = 11;
            this.txtRecievedAmount.Enter += new System.EventHandler(this.EnterEvent);
            this.txtRecievedAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtRecievedAmount.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 228);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 15);
            this.label23.TabIndex = 52;
            this.label23.Text = "PaymentType";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(91, 228);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 24);
            this.label24.TabIndex = 53;
            this.label24.Text = "*";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "--Select--",
            "Cash",
            "Bank"});
            this.cmbPaymentType.Location = new System.Drawing.Point(124, 224);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(201, 23);
            this.cmbPaymentType.TabIndex = 12;
            this.cmbPaymentType.Enter += new System.EventHandler(this.EnterEvent);
            this.cmbPaymentType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.cmbPaymentType.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(361, 229);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 15);
            this.label25.TabIndex = 55;
            this.label25.Text = "Fright";
            // 
            // txtFright
            // 
            this.txtFright.Location = new System.Drawing.Point(479, 228);
            this.txtFright.Name = "txtFright";
            this.txtFright.Size = new System.Drawing.Size(214, 21);
            this.txtFright.TabIndex = 13;
            this.txtFright.Enter += new System.EventHandler(this.EnterEvent);
            this.txtFright.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtFright.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 258);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 15);
            this.label27.TabIndex = 58;
            this.label27.Text = "St Ch.";
            // 
            // txtstch
            // 
            this.txtstch.Location = new System.Drawing.Point(125, 256);
            this.txtstch.Name = "txtstch";
            this.txtstch.Size = new System.Drawing.Size(201, 21);
            this.txtstch.TabIndex = 14;
            this.txtstch.Enter += new System.EventHandler(this.EnterEvent);
            this.txtstch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtstch.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(362, 257);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 15);
            this.label29.TabIndex = 61;
            this.label29.Text = "Hamali";
            // 
            // txtHamali
            // 
            this.txtHamali.Location = new System.Drawing.Point(479, 257);
            this.txtHamali.Name = "txtHamali";
            this.txtHamali.Size = new System.Drawing.Size(215, 21);
            this.txtHamali.TabIndex = 15;
            this.txtHamali.Enter += new System.EventHandler(this.EnterEvent);
            this.txtHamali.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtHamali.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 288);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 15);
            this.label31.TabIndex = 64;
            this.label31.Text = "Other1";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(362, 287);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 15);
            this.label32.TabIndex = 65;
            this.label32.Text = "Other2";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 316);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 15);
            this.label33.TabIndex = 66;
            this.label33.Text = "Other3";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(361, 318);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 15);
            this.label34.TabIndex = 67;
            this.label34.Text = "Other4";
            // 
            // txtOther1
            // 
            this.txtOther1.Location = new System.Drawing.Point(125, 285);
            this.txtOther1.Name = "txtOther1";
            this.txtOther1.Size = new System.Drawing.Size(201, 21);
            this.txtOther1.TabIndex = 16;
            this.txtOther1.Enter += new System.EventHandler(this.EnterEvent);
            this.txtOther1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtOther1.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtOther2
            // 
            this.txtOther2.Location = new System.Drawing.Point(479, 287);
            this.txtOther2.Name = "txtOther2";
            this.txtOther2.Size = new System.Drawing.Size(215, 21);
            this.txtOther2.TabIndex = 17;
            this.txtOther2.Enter += new System.EventHandler(this.EnterEvent);
            this.txtOther2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtOther2.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtOther3
            // 
            this.txtOther3.Location = new System.Drawing.Point(125, 316);
            this.txtOther3.Name = "txtOther3";
            this.txtOther3.Size = new System.Drawing.Size(201, 21);
            this.txtOther3.TabIndex = 18;
            this.txtOther3.Enter += new System.EventHandler(this.EnterEvent);
            this.txtOther3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtOther3.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtOther4
            // 
            this.txtOther4.Location = new System.Drawing.Point(479, 318);
            this.txtOther4.Name = "txtOther4";
            this.txtOther4.Size = new System.Drawing.Size(215, 21);
            this.txtOther4.TabIndex = 19;
            this.txtOther4.Enter += new System.EventHandler(this.EnterEvent);
            this.txtOther4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtOther4.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(266, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(359, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 29);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorDate
            // 
            this.errorDate.ContainerControl = this;
            // 
            // errorMrNo
            // 
            this.errorMrNo.ContainerControl = this;
            // 
            // errorREcievedFrom
            // 
            this.errorREcievedFrom.ContainerControl = this;
            // 
            // errorFrom
            // 
            this.errorFrom.ContainerControl = this;
            // 
            // errorTo
            // 
            this.errorTo.ContainerControl = this;
            // 
            // errorBillno
            // 
            this.errorBillno.ContainerControl = this;
            // 
            // errorBillAmount
            // 
            this.errorBillAmount.ContainerControl = this;
            // 
            // errorNoofPackage
            // 
            this.errorNoofPackage.ContainerControl = this;
            // 
            // errorWeight
            // 
            this.errorWeight.ContainerControl = this;
            // 
            // errorRecievedAmount
            // 
            this.errorRecievedAmount.ContainerControl = this;
            // 
            // errorPaymenttype
            // 
            this.errorPaymenttype.ContainerControl = this;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(126, 343);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(201, 21);
            this.txtTotal.TabIndex = 68;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 343);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 15);
            this.label26.TabIndex = 69;
            this.label26.Text = "Total";
            // 
            // frmEntryMRNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 425);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOther4);
            this.Controls.Add(this.txtOther3);
            this.Controls.Add(this.txtOther2);
            this.Controls.Add(this.txtOther1);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtHamali);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtstch);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtFright);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtRecievedAmount);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNoofPackage);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dpbilldate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtbillno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecievefrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMRno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEntryMRNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MRNote";
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMrNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorREcievedFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBillno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBillAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoofPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecievedAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaymenttype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMRno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecievefrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dpbilldate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNoofPackage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtRecievedAmount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtFright;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtstch;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtHamali;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtOther1;
        private System.Windows.Forms.TextBox txtOther2;
        private System.Windows.Forms.TextBox txtOther3;
        private System.Windows.Forms.TextBox txtOther4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorDate;
        private System.Windows.Forms.ErrorProvider errorMrNo;
        private System.Windows.Forms.ErrorProvider errorREcievedFrom;
        private System.Windows.Forms.ErrorProvider errorFrom;
        private System.Windows.Forms.ErrorProvider errorTo;
        private System.Windows.Forms.ErrorProvider errorBillno;
        private System.Windows.Forms.ErrorProvider errorBillAmount;
        private System.Windows.Forms.ErrorProvider errorNoofPackage;
        private System.Windows.Forms.ErrorProvider errorWeight;
        private System.Windows.Forms.ErrorProvider errorRecievedAmount;
        private System.Windows.Forms.ErrorProvider errorPaymenttype;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label26;

    }
}