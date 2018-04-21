using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eek_exam
{
    class KomponentRuumalaJargi : IComparer<Komponent>
    {
        public int Compare(Komponent a, Komponent b)
        {
            double ak = a.ArvutaRuumala();
            double bk = b.ArvutaRuumala();

            if (ak > bk)
                return 1;
            else if (ak == bk)
                return 0;
            else
                return -1;
        }
    }
}