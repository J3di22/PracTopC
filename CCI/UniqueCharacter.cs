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
            bool hasDuplicate = false;

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in str)
            {
                Console.WriteLine(c);
                if (map.ContainsKey(c))
                {
                    hasDuplicate = true;

                    map[c]++;
                }
                else
                {
                    map[c] = 1;
                }
            }

            foreach (char c in map.Keys)
            {
                Console.WriteLine(c + "\t" + map[c]);
            }

            return hasDuplicate;
        }
    }
}
