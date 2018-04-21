using System;

namespace eek_exam
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Komponent Test1 = new Komponent(1, 10, 5);
            Console.WriteLine();
            double ruumala = Test1.ArvutaRuumala();
            Console.WriteLine("Ruumala: {0}", ruumala);

            // -------

            Komponent Test2 = new Komponent(1, 10, 5);
            Komponent Test3 = new Komponent(1, 5, 10);

            Console.WriteLine();
            if (Test2 > Test3)
                Console.WriteLine("Test2 ruumala suurem");
            
        }
    }
}
