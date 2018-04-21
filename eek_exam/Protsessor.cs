using System;
namespace eek_exam
{
    class Protsessor : Komponent
    {
        protected double sagedus;

        public Protsessor(double sagedus = 0)
        {
            this.sagedus = sagedus;
        }

        public Protsessor(Protsessor ob)
        {
            this.sagedus = ob.sagedus;
        }

        public override void Tryki()
        {
            Console.Write(" {0,3}", sagedus);
        }

        public override string Valjasta_tyyp()
        {
            return "A";
        }
    }
}
