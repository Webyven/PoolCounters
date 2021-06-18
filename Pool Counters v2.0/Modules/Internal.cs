using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0.Modules
{
    class Internal
    {
        public static string UppercaseFirstMinusAnothers(string s)
        {
            // Check for empty string
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            s = s.ToLower();

            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public static string UppercaseFirst(string s)
        {
            // Check for empty string
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public static string SubdivideString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            string[] words = s.Split(' ');
            string result = "";

            for(int i = 0; i < words.Length; i++)
            {
                result += words[i];

                if (i % 7 == 0 && i != 0)
                    result += System.Environment.NewLine;
                else
                    result += " ";
            }

            return result;
        }
    }
}
