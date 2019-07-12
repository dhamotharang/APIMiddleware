using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE._Functions
{
    public class Common
    {
        public static bool IsDate(string date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch { }
            return false;
        }

        public static string ConvertToQueryString(string data)
        {
            return data.Trim().Replace(" ", "%20");
        }
    }
}
