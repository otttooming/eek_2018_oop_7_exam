
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eek_exam
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
                List
            */
            Console.WriteLine();

            RAM_malu Ram1 = new RAM_malu(1, 100, 10, 1024, "SODIMM");
            Protsessor Protsessor1 = new Protsessor(2, 200, 10, 3.5);
            Salvestusseade Salvestus1 = new Salvestusseade(3, 300, 10, "SSD", 512);

            List<Komponent> Komponendid = new List<Komponent>();
            Komponendid.Add(Ram1);
            Komponendid.Add(Protsessor1);
            Komponendid.Add(Salvestus1);

            foreach (Komponent x in Komponendid)
            {
                x.Tryki();
            }

            // ---Sort
            Console.WriteLine("\n sorted");

            Komponendid.Sort();
            foreach (Komponent x in Komponendid)
            {
                x.Tryki();
            }

            Console.WriteLine("\n sorted by reverse");
            KomponentRuumalaJargi obj = new KomponentRuumalaJargi();

            Komponendid.Sort(obj);

            Ram1.malumaht = 2048;
            foreach (Komponent x in Komponendid)
            {
                x.Tryki();

                string name = x.Valjasta_tyyp();

                Console.WriteLine(" {0,5}", name);
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.Read();
        }
    }
}
