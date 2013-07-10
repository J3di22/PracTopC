using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UniqueCharacter u = new UniqueCharacter();
                Console.WriteLine(u.Test("arsdd"));
                Console.WriteLine(u.Test("ars"));
                Console.WriteLine(u.Test(null));
                Console.WriteLine(u.Test(String.Empty));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
