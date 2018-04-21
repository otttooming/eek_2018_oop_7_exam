using System;
using System.Collections;
using System.Collections.Generic;

namespace eek_exam
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Komponent Test1 = new Komponent(1, 10, 5);
            //Console.WriteLine();
            //double ruumala = Test1.ArvutaRuumala();
            //Console.WriteLine("Ruumala: {0}", ruumala);

            //// -------

            //Komponent Test2 = new Komponent(1, 10, 5);
            //Komponent Test3 = new Komponent(1, 5, 10);

            //Console.WriteLine();
            //if (Test2 > Test3)
                //Console.WriteLine("Test2 ruumala suurem");


            /*
                List
            */
            Console.WriteLine();

            Komponent Ram1 = new RAM_malu(1024, "SODIMM");
            Komponent Protsessor1 = new Protsessor(3.5);
            Komponent Salvestus1 = new Salvestusseade("SSD", 512);

            List<Komponent> Komponendid = new List<Komponent>();
            Komponendid.Add(Ram1);
            Komponendid.Add(Protsessor1);
            Komponendid.Add(Salvestus1);

            foreach (Komponent x in Komponendid)
            {
                x.Tryki();
            }

            Console.WriteLine();
            Console.Read();

        }
    }
}
