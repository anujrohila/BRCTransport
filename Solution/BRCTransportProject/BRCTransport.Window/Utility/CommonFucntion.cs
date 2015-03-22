using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRCTransport.Window
{
    public static class CommonFucntion
    {
        public static string ApplicationWebPath
        {
            get
            {
                return Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["ApplicationWebPath"]);
            }
        }
    }
}
