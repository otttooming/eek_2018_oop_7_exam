using System;
namespace eek_exam
{
    class Salvestusseade : Komponent
    {
        protected string tyyp;
        protected double salvestusmaht;

        public Salvestusseade(string tyyp = "", double salvestusmaht = 0)
        {
            this.tyyp = tyyp;
            this.salvestusmaht = salvestusmaht;
        }

        public Salvestusseade(Salvestusseade ob)
        {
            this.tyyp = ob.tyyp;
            this.salvestusmaht = ob.salvestusmaht;
        }

        public override string Valjasta_tyyp()
        {
            return "A";
        }
    }
}
