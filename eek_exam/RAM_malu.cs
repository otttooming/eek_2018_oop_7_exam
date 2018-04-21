using System;
namespace eek_exam
{
    class RAM_malu : Komponent
    {
        public int malumaht { get; set; }
        protected string malutyyp;

        public RAM_malu(int ID = 0, double kaal = 0, double tihedus = 0, int malumaht = 0, string malutyyp = "")
            : base(ID, kaal, tihedus)
        {
            this.malumaht = malumaht;
            this.malutyyp = malutyyp;
        }

        public RAM_malu(RAM_malu ob)
            : base(ob)
        {
            this.malumaht = ob.malumaht;
            this.malutyyp = ob.malutyyp;
        }

        public override void Tryki()
        {
            base.Tryki();
            Console.Write(" {0,3} {1,8}  ", malumaht, malutyyp);
        }

        public override string Valjasta_tyyp()
        {
            return "RAM malu";
        }
    }
}
