using BRCTransport.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BRCTransport.Window.Class
{
    public static class CommonClass
    {
        public static string Username;
        public static DateTime CurrentData;

        public static string RepName = "MAYUR";
        public static string RepHead = "Sorathiya";
        public static string RepComp = "Skynet";


        public static System.Drawing.Color m_tbcolorenter = Color.FromArgb(233, 240, 173);
        public static System.Drawing.Color m_tbcolorleave = System.Drawing.Color.White;
        public static System.Drawing.Color m_tbcolorerror = Color.FromArgb(255, 189, 186);


        public static List<tblBillEntryDTO> tblBillEntryDTO = new List<tblBillEntryDTO>();


        public static void EnterEvents(object sender, EventArgs e)
        {
            if ((sender as TextBox) is TextBox)
            {
                (sender as TextBox).BackColor = m_tbcolorenter;
            }
            else
                if ((sender as ComboBox) is ComboBox)
                {
                    (sender as ComboBox).BackColor = m_tbcolorenter;
                }
                else
                    if ((sender as DateTimePicker) is DateTimePicker)
                    {
                        (sender as DateTimePicker).BackColor = m_tbcolorenter;
                    }

        }

        public static void LeaveEvents(object sender, EventArgs e)
        {
            if ((sender as TextBox) is TextBox)
            {
                (sender as TextBox).BackColor = m_tbcolorleave;
            }
            else
                if ((sender as ComboBox) is ComboBox)
                {
                    (sender as ComboBox).BackColor = m_tbcolorleave;
                }
                else
                    if ((sender as DateTimePicker) is DateTimePicker)
                    {
                        (sender as DateTimePicker).BackColor = m_tbcolorleave;
                    }
        }

        public static void KeyPressEvents(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar))
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 && textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }

    }

}
