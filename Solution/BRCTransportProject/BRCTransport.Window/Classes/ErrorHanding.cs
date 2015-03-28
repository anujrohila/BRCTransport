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

            if ((c as TextBox).Text == "")
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
