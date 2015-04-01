using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BRCTransport.Window.Class
{
    public static class ErrorHanding
    {
        private static int count;

        public static void SetTextboxErrorWithCount(this ErrorProvider ep, Control c, string message)
        {
            if ((c as TextBox) is TextBox)
            {
                if ((c as TextBox).Text.Trim() == "")
                {
                    ep.SetError(c, message);

                    c.BackColor = CommonClass.m_tbcolorerror;
                    if (count == 0)
                        c.Focus();
                    count++;
                }
                else
                {
                    ep.SetError(c, "");
                    c.BackColor = CommonClass.m_tbcolorleave;
                }
            }
            else if ((c as ComboBox) is ComboBox)
            {
                if ((c as ComboBox).Text.Trim() == "")
                {
                    ep.SetError(c, message);

                    c.BackColor = CommonClass.m_tbcolorerror;
                    if (count == 0)
                        c.Focus();
                    count++;
                }
                else
                {
                    ep.SetError(c, "");
                    c.BackColor = CommonClass.m_tbcolorleave;
                }
            }



        }

        public static void SetErrorCount()
        {
            count = 0;
        }

        public static int GetErrorCount()
        {
            return count;
        }

    }
}
