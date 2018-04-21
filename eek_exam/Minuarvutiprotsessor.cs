using System;
namespace eek_exam
{
    class Minuarvutiprotsessor : Arvutiprotsessor
    {
        public double hind;

        public Minuarvutiprotsessor(int ID = 0, double kaal = 0, double tihedus = 0, double sagedus = 0, string firma = "---", double hind = 0)
            : base(ID, kaal, tihedus, sagedus, firma)
        {
            this.hind = hind;
        }

        public Minuarvutiprotsessor(Minuarvutiprotsessor ob) : base(ob) { this.hind = ob.hind; }
    }
}
