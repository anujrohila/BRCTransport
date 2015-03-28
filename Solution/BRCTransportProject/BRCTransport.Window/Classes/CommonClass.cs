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
    }

}
