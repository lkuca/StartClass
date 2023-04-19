using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartClass
{
    class Startclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("sissestage esimene arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sissestage teine arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korutis võrdub {2}",arv1,arv2, arv1 * arv2);
        }
    }
    
}
