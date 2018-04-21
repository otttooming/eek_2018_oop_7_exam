using System;
namespace eek_exam
{
    class Protsessor : Komponent
    {
        public double sagedus { get; set; }

        public Protsessor(int ID = 0, double kaal = 0, double tihedus = 0, double sagedus = 0)
            : base(ID, kaal, tihedus)
        {
            this.sagedus = sagedus;
        }

        public Protsessor(Protsessor ob)
            : base(ob)
        {
            this.sagedus = ob.sagedus;
        }

        public override void Tryki()
        {
            base.Tryki();
            Console.Write(" {0,3}", sagedus);
        }

        public override string Valjasta_tyyp()
        {
            return "Protsessor";
        }
    }
}
