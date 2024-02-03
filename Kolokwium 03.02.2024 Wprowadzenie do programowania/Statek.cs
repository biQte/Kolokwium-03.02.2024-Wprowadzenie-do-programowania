using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_03._02._2024_Wprowadzenie_do_programowania
{
    internal abstract class Statek
    {
        public abstract int IloscKadlubow { get; }
        public abstract int MaksymalnaPredkosc { get; }
        public abstract int Ladownosc { get; }

        public abstract void WypiszNazwe();

        public abstract void WypiszIloscKadlubow();
        public abstract void WypiszMaksymalnaPredkosc();
        public abstract void WypiszLadownosc();
    }
}
