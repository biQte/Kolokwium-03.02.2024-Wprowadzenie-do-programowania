using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_03._02._2024_Wprowadzenie_do_programowania
{
    internal class StatekPasazerski : Statek
    {
        private int iloscKadlubow = 3;
        private int maksymalnaPredkosc = 50;
        private int ladownosc = 1000;

        public override int IloscKadlubow => iloscKadlubow;

        public override int MaksymalnaPredkosc => maksymalnaPredkosc;

        public override int Ladownosc => ladownosc;

        public override void WypiszNazwe()
        {
            Console.WriteLine("Statek pasażerski");
        }

        public override void WypiszIloscKadlubow()
        {
            Console.WriteLine($"Ilość kadłubów: {IloscKadlubow}");
        }

        public override void WypiszMaksymalnaPredkosc()
        {
            Console.WriteLine($"Maksymalna prędkość: {MaksymalnaPredkosc} węzłów");
        }

        public override void WypiszLadownosc()
        {
            Console.WriteLine($"Ładowność: {Ladownosc} kg");
        }
    }
}
