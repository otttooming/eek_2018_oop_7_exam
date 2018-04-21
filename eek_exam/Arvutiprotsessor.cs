using System;
namespace eek_exam
{
    class Arvutiprotsessor : Protsessor
    {
        public string firma;

        public Arvutiprotsessor(double sagedus = 0, string firma = "---")
            :base(sagedus)
        {
            this.firma = firma;
        }

        public Arvutiprotsessor(Arvutiprotsessor ob) : base(ob) { this.firma = ob.firma; }
    }
}
