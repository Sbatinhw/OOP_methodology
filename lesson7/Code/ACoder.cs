using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class ACoder : ICoder
    {
        int step = 1;
        public string Decode(string text)
        {
            StringBuilder result = new StringBuilder();
            char[] original = text.ToCharArray();
            foreach (var n in original)
            {
                result.Append((char)(n - step));
            }
            return result.ToString();
        }

        public string Encode(string text)
        {
            StringBuilder result = new StringBuilder();
            char[] original = text.ToCharArray();
            foreach (var n in original)
            {
                result.Append((char)(n + step));
            }
            return result.ToString();
        }
    }
}
