using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Authorization
    {
        private static string _pass = "password";        

        public static bool LogIn(string text)
        {
            if (text == _pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
