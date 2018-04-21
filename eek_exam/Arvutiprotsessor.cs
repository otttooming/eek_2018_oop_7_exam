using System;
namespace eek_exam
{
    class Arvutiprotsessor : Protsessor
    {
        public string firma;

        public Arvutiprotsessor(int ID = 0, double kaal = 0, double tihedus = 0, double sagedus = 0, string firma = "---")
            :base(ID, kaal, tihedus, sagedus)
        {
            this.firma = firma;
        }

        public Arvutiprotsessor(Arvutiprotsessor ob) : base(ob) { this.firma = ob.firma; }
    }
}
