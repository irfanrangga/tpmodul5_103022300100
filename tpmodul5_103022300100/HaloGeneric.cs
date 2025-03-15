using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300100
{
    class HaloGeneric
    {
        public static void SapaUser<T>(T input)
        {
            Console.WriteLine("Halo User " + input);
        }
    }
}
