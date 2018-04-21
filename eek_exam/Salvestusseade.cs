using System;
namespace eek_exam
{
    class Salvestusseade : Komponent
    {
        protected string tyyp;
        public double salvestusmaht { get; set; }

        public Salvestusseade(int ID = 0, double kaal = 0, double tihedus = 0, string tyyp = "", double salvestusmaht = 0)
            : base(ID, kaal, tihedus)
        {
            this.tyyp = tyyp;
            this.salvestusmaht = salvestusmaht;
        }

        public Salvestusseade(Salvestusseade ob)
            : base(ob)
        {
            this.tyyp = ob.tyyp;
            this.salvestusmaht = ob.salvestusmaht;
        }

        public override void Tryki()
        {
            base.Tryki();
            Console.Write(" {0,3} {1,8}  ", tyyp, salvestusmaht);
        }

        public override string Valjasta_tyyp()
        {
            return "Salvesusseade";
        }
    }
}
