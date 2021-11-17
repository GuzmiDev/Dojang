using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojang.Utils
{
     sealed public class AlertBox
    {

        static public void Error(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static public void SimpleMessage(string text, string title = "")
        {
            MessageBox.Show(text, title);
        }

    }
}
