namespace BRCTransport.Window.Forms
{
    partial class frmEntryBill
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
            this.comboaddress = new System.Windows.Forms.ComboBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bRCReportDatasetxsd = new BRCTransport.Window.Dataset.BRCReportDatasetxsd();
            this.billReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorPartyName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bRCReportDatasetxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartyName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Party Name & Address :";
            // 
            // comboaddress
            // 
            this.comboaddress.FormattingEnabled = true;
            this.comboaddress.Location = new System.Drawing.Point(122, 21);
            this.comboaddress.Name = "comboaddress";
            this.comboaddress.Size = new System.Drawing.Size(121, 21);
            this.comboaddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service Tax Regd. No.";
            // 
            // textservicetax
            // 
            this.textservicetax.Location = new System.Drawing.Point(381, 21);
            this.textservicetax.Name = "textservicetax";
            this.textservicetax.Size = new System.Drawing.Size(121, 20);
            this.textservicetax.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bill No";
            // 
            // textbillno
            // 
            this.textbillno.Location = new System.Drawing.Point(122, 52);
            this.textbillno.Name = "textbillno";
            this.textbillno.Size = new System.Drawing.Size(121, 20);
            this.textbillno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Branch Code";
            // 
            // textbranchcode
            // 
            this.textbranchcode.Location = new System.Drawing.Point(381, 52);
            this.textbranchcode.Name = "textbranchcode";
            this.textbranchcode.Size = new System.Drawing.Size(121, 20);
            this.textbranchcode.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bill Date";
            // 
            // dateTimebilldate
            // 
            this.dateTimebilldate.Location = new System.Drawing.Point(122, 84);
            this.dateTimebilldate.Name = "dateTimebilldate";
            this.dateTimebilldate.Size = new System.Drawing.Size(121, 20);
            this.dateTimebilldate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Payment Due Date\t";
            // 
            // dateTimeduedate
            // 
            this.dateTimeduedate.Location = new System.Drawing.Point(381, 84);
            this.dateTimeduedate.Name = "dateTimeduedate";
            this.dateTimeduedate.Size = new System.Drawing.Size(121, 20);
            this.dateTimeduedate.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tick Bill Type";
            // 
            // combotickbill
            // 
            this.combotickbill.FormattingEnabled = true;
            this.combotickbill.Location = new System.Drawing.Point(122, 119);
            this.combotickbill.Name = "combotickbill";
            this.combotickbill.Size = new System.Drawing.Size(121, 21);
            this.combotickbill.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Basic of Charges G.C Note or Contract No :";
            // 
            // textbasicofchange
            // 
            this.textbasicofchange.Location = new System.Drawing.Point(257, 145);
            this.textbasicofchange.Name = "textbasicofchange";
            this.textbasicofchange.Size = new System.Drawing.Size(245, 20);
            this.textbasicofchange.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Our Centralised Service Tax Regd. No.";
            // 
            // texttaxregdno
            // 
            this.texttaxregdno.Location = new System.Drawing.Point(257, 175);
            this.texttaxregdno.Name = "texttaxregdno";
            this.texttaxregdno.Size = new System.Drawing.Size(245, 20);
            this.texttaxregdno.TabIndex = 11;
            // 
            // comboservicetax
            // 
            this.comboservicetax.FormattingEnabled = true;
            this.comboservicetax.Location = new System.Drawing.Point(381, 118);
            this.comboservicetax.Name = "comboservicetax";
            this.comboservicetax.Size = new System.Drawing.Size(121, 21);
            this.comboservicetax.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Service Tax Through :";
            // 
            // textenclosure
            // 
            this.textenclosure.Location = new System.Drawing.Point(122, 207);
            this.textenclosure.Name = "textenclosure";
            this.textenclosure.Size = new System.Drawing.Size(121, 20);
            this.textenclosure.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enclosure ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Checked By :";
            // 
            // textcheckedby
            // 
            this.textcheckedby.Location = new System.Drawing.Point(370, 207);
            this.textcheckedby.Name = "textcheckedby";
            this.textcheckedby.Size = new System.Drawing.Size(132, 20);
            this.textcheckedby.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(256, 342);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add Entry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Red;
            this.label50.Location = new System.Drawing.Point(50, 90);
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
            this.label13.Location = new System.Drawing.Point(324, 55);
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
            this.label14.Location = new System.Drawing.Point(350, 90);
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
            this.label15.Location = new System.Drawing.Point(80, 122);
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
            this.label16.Location = new System.Drawing.Point(357, 120);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 24);
            this.label16.TabIndex = 106;
            this.label16.Text = "*";
            // 
            // bRCReportDatasetxsd
            // 
            this.bRCReportDatasetxsd.DataSetName = "BRCReportDatasetxsd";
            this.bRCReportDatasetxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billReportBindingSource
            // 
            this.billReportBindingSource.DataMember = "BillReport";
            this.billReportBindingSource.DataSource = this.bRCReportDatasetxsd;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 64);
            this.dataGridView1.TabIndex = 107;
            // 
            // errorPartyName
            // 
            this.errorPartyName.ContainerControl = this;
            // 
            // frmEntryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.comboaddress);
            this.Controls.Add(this.label1);
            this.Name = "frmEntryBill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.frmEntryBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bRCReportDatasetxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartyName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboaddress;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Dataset.BRCReportDatasetxsd bRCReportDatasetxsd;
        private System.Windows.Forms.BindingSource billReportBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorPartyName;
    }
}