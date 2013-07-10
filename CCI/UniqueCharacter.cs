using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI
{
    internal class UniqueCharacter
    {
        internal bool Test(string str)
        {
            if (str == null)
            {
                return false;
            }

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (map.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    map[c] = 1;
                }
            }

            return true;
        }
    }
}
