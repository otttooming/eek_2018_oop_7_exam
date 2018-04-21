using System;
namespace eek_exam
{
    class RAM_malu : Komponent
    {
        protected int malumaht;
        protected string malutyyp;

        public RAM_malu(int malumaht = 0, string malutyyp = "")
        {
            this.malumaht = malumaht;
            this.malutyyp = malutyyp;
        }

        public RAM_malu(RAM_malu ob)
        {
            this.malumaht = ob.malumaht;
            this.malutyyp = ob.malutyyp;
        }

        public override void Tryki()
        {
            Console.Write(" {0,3} {1,8}  ", malumaht, malutyyp);
        }

        public override string Valjasta_tyyp()
        {
            return "A";
        }
    }
}
