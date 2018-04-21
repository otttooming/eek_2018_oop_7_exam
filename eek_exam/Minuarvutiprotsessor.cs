using System;
namespace eek_exam
{
    class Minuarvutiprotsessor : Arvutiprotsessor
    {
        public double hind;

        public Minuarvutiprotsessor(double sagedus = 0, string firma = "---", double hind = 0)
            : base(sagedus, firma)
        {
            this.hind = hind;
        }

        public Minuarvutiprotsessor(Minuarvutiprotsessor ob) : base(ob) { this.hind = ob.hind; }
    }
}
