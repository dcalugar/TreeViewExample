using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewExample.Helpers
{
    public class StringUtil
    {
        private static char[] _ALPHANUMBERIC_ARRAY = new char[36] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        /// <summary>
        /// Remove all but alpha
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemoveNonAlphaNumberic(string source)
        {
            if (String.IsNullOrEmpty(source))
                return "";

            StringBuilder sb = new StringBuilder();
            foreach (char c in source.ToLower())
                if (_ALPHANUMBERIC_ARRAY.Contains(c))
                    sb.Append(c);
            return sb.ToString();
        }
    }
}
