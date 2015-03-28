using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRCTransport.BAL;
using BRCTransport.Window.Class;
using BRCTransport.Domain;

namespace BRCTransport.Window.Forms
{
    public partial class frmEntryBill : Form
    {
        public frmEntryBill()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmbill = new frmChildBill();
            frmbill.ShowDialog();
        }

        private void frmEntryBill_Load(object sender, EventArgs e)
        {

        }


        private Boolean validatedata()
        {
            {
                
                ErrorHanding.SetErrorCount();
                ErrorHanding.SetTextboxErrorWithCount(errorPartyName,comboaddress, "Enter Account nmae");

                if (ErrorHanding.GetErrorCount() == 0)
                    return true;
                else
                    return false;
            }


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validatedata())
            { 
                tblBillDTO tblbilldto = new tblBillDTO();
               // tblbilldto.BillNo = ;

            
            }

        }
    }
}
