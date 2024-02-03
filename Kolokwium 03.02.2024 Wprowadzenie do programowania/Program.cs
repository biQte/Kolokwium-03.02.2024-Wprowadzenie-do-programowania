using System.Collections;

namespace Kolokwium_03._02._2024_Wprowadzenie_do_programowania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaStatkow = new ArrayList();

            StatekPasazerski statekPasazerski = new StatekPasazerski();
            StatekTowarowy statekTowarowy = new StatekTowarowy();

            listaStatkow.Add(statekPasazerski);
            listaStatkow.Add(statekTowarowy);

            foreach (Statek statek in listaStatkow)
            {
                statek.WypiszNazwe();
                statek.WypiszIloscKadlubow();
                statek.WypiszMaksymalnaPredkosc();
                statek.WypiszLadownosc();
                Console.WriteLine();
            }

            String[] TablicaString = { "a", "b", "c" };

            String[] ReverseTablicaString = Tablica.ReverseStringTable(TablicaString);

            foreach(String str in ReverseTablicaString)
            { 
                Console.WriteLine(str);
                Console.WriteLine();
            }

            int[] ints = { 1, 2, 3, 4, 5 };

            int[] ReverseInts = Tablica.ReverseIntTable(ints);

            foreach(int intiger in ReverseInts)
            {
                Console.WriteLine(intiger);
                Console.WriteLine();
            }


        }
    }
}