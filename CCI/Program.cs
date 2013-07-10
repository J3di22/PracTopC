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
                Console.WriteLine("arsdd " + u.Test("arsdd"));
                Console.WriteLine("ars " + u.Test("ars"));
                Console.WriteLine("null " + u.Test(null));
                Console.WriteLine("Empty" + u.Test(String.Empty));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
