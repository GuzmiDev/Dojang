using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Globalization;

namespace Dojang.Utils
{
    static public class StringsManipulator
    {

        public static string ToTitleCase(this string title)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
         }
    }
}
