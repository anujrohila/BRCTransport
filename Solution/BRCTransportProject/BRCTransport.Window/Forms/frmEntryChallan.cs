﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRCTransport.Window.Forms
{
    public partial class frmEntryChallan : Form
    {
        public frmEntryChallan()
        {
            InitializeComponent();
        }

        private void frmEntryChallan_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var childchallan = new frmChildChallan();
            childchallan.ShowDialog();


        }
    }
}
