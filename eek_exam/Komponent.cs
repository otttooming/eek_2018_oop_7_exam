using System;
namespace eek_exam
{
    abstract class Komponent : IRuumala
    {
        protected int ID;
        protected double kaal;
        protected double tihedus;

        public Komponent(int ID = 0, double kaal = 0, double tihedus = 0)
        {
            this.ID = ID;
            this.kaal = kaal;
            this.tihedus = tihedus;
        }

        /*
            Constructor for cloning
        */
        public Komponent(Komponent ob)
        {
            this.ID = ob.ID;
            this.kaal = ob.kaal;
            this.tihedus = ob.tihedus;
        }

        public double ArvutaRuumala()
        {
            double ruumala = kaal / tihedus;

            return ruumala;
        }

        public static bool operator >(Komponent a, Komponent b) { return a.ArvutaRuumala() > b.ArvutaRuumala(); }
        public static bool operator <(Komponent a, Komponent b) { return a.ArvutaRuumala() < b.ArvutaRuumala(); }

        public static bool operator >=(Komponent a, Komponent b) { return a.ArvutaRuumala() >= b.ArvutaRuumala(); }
        public static bool operator <=(Komponent a, Komponent b) { return a.ArvutaRuumala() <= b.ArvutaRuumala(); }

        public static bool operator ==(Komponent a, Komponent b) { return a.ArvutaRuumala() == b.ArvutaRuumala(); }
        public static bool operator !=(Komponent a, Komponent b) { return a.ArvutaRuumala() != b.ArvutaRuumala(); }

        public virtual void Tryki() {
            Console.WriteLine("Komponent");   
            Console.Write("ID: {0,3} Kaal: {1,8} {2,8} {3,8}", ID, kaal, tihedus, ArvutaRuumala());
        }

        public abstract string Valjasta_tyyp();
    }
}
