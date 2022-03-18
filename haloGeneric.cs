using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPmod4_1302204026
{
    internal class haloGeneric
    {
        public void sapaUser<T>(T nama)
        {
            Console.WriteLine("Halo User " + nama);
        }
    }
}
