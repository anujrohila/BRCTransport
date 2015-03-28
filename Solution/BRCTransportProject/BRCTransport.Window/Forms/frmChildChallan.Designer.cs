namespace BRCTransport.Window.Forms
{
    partial class frmChildChallan
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
            this.text_bkg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_cnno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_package = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_pckmethod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_said = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_actual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_destination = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BkgStnCode";
            // 
            // text_bkg
            // 
            this.text_bkg.Location = new System.Drawing.Point(136, 23);
            this.text_bkg.Name = "text_bkg";
            this.text_bkg.Size = new System.Drawing.Size(176, 20);
            this.text_bkg.TabIndex = 1;
            this.text_bkg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CNNoWithAlphaCode";
            // 
            // text_cnno
            // 
            this.text_cnno.Location = new System.Drawing.Point(136, 53);
            this.text_cnno.Name = "text_cnno";
            this.text_cnno.Size = new System.Drawing.Size(176, 20);
            this.text_cnno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PackagesNos";
            // 
            // text_package
            // 
            this.text_package.Location = new System.Drawing.Point(136, 87);
            this.text_package.Name = "text_package";
            this.text_package.Size = new System.Drawing.Size(176, 20);
            this.text_package.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "PackagesMethod";
            // 
            // text_pckmethod
            // 
            this.text_pckmethod.Location = new System.Drawing.Point(136, 120);
            this.text_pckmethod.Name = "text_pckmethod";
            this.text_pckmethod.Size = new System.Drawing.Size(176, 20);
            this.text_pckmethod.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "SaidToContain";
            // 
            // text_said
            // 
            this.text_said.Location = new System.Drawing.Point(136, 150);
            this.text_said.Name = "text_said";
            this.text_said.Size = new System.Drawing.Size(176, 20);
            this.text_said.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ActualWeightKgs";
            // 
            // text_actual
            // 
            this.text_actual.Location = new System.Drawing.Point(136, 184);
            this.text_actual.Name = "text_actual";
            this.text_actual.Size = new System.Drawing.Size(176, 20);
            this.text_actual.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "DestinationName";
            // 
            // text_destination
            // 
            this.text_destination.Location = new System.Drawing.Point(136, 220);
            this.text_destination.Name = "text_destination";
            this.text_destination.Size = new System.Drawing.Size(176, 20);
            this.text_destination.TabIndex = 7;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(143, 256);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.btnsave_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmChildChallan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.text_destination);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_actual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_said);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_pckmethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_package);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_cnno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_bkg);
            this.Controls.Add(this.label1);
            this.Name = "frmChildChallan";
            this.Text = "Save Challan Order";
            this.Load += new System.EventHandler(this.frmChildChallan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_bkg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_cnno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_package;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_pckmethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_said;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_actual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_destination;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button2;
    }
}