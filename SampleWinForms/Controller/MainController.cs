using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SampleWinForms.Controller
{
    public class MainController
    {
        public enum OpenType
        {
            Create,
            Alter,
            Examine,
        }

        public static bool IsNull(Object obj)
        {
            return obj == null;
        }

        public static bool IsInt(String obj)
        {
            return Int32.TryParse(obj, out _);
        }

        public static bool IsPhoneNumber(String obj)
        {
            return Regex.Match(obj, @"^(\+[0-9])$").Success;
        }

        public static bool IsDouble(String obj)
        {
            return Double.TryParse(obj, out _);
        }


    }
}
