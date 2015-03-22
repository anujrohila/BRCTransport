using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRCTransport.Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri(CommonFucntion.ApplicationWebPath, UriKind.RelativeOrAbsolute);
        }

        private void partyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/Consignor/Index", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void addPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/Consignor/Save/0", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void allChallanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/Challan/Save/0", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void listChallanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/Challan/Index", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void addBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/Bill/Save/0", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void listBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/Bill/Index", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void addLRNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/ConsignmentNote/Save/0", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void listLRNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/ConsignmentNote/Index", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void addMRNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/MRNote/Save/0", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void listMRNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/MRNote/Index", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/AccountMaster/Save/0", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/AccountMaster/Index", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/Transaction/Save/0", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void transactionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/Transaction/Index", CommonFucntion.ApplicationWebPath), UriKind.RelativeOrAbsolute);
        }

        private void billReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bill Report
        }
    }
}
