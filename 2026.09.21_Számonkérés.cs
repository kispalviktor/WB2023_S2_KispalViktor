using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._09._21_Számonkérés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat:");
            Console.WriteLine("");

            #region 1. feladat
            Console.Write("Első szám: ");
            int elso_szam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Második szám: ");
            int masodik_szam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A két szám összege: {elso_szam + masodik_szam}");
            #endregion

            Console.WriteLine("");
            Console.WriteLine("2. feladat:");
            Console.WriteLine("");

            #region 2. feladat
            Console.Write("Hosszúság: ");
            int teglalap_hosszusag = Convert.ToInt32(Console.ReadLine());

            Console.Write("Második szám: ");
            int teglalap_szelesseg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Terület: {teglalap_hosszusag * teglalap_szelesseg}");
            Console.WriteLine($"Kerület: {2 * (teglalap_hosszusag + teglalap_szelesseg)}");
            #endregion

            Console.WriteLine("");
            Console.WriteLine("3. feladat:");
            Console.WriteLine("");

            #region 3. feladat
            Console.Write("Hány számot szeretne megadni? ");
            int szamok_db = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            List<int> szamok_lista = new List<int>();
            int sorszam = 1;

            for (int i = 0; i < szamok_db; i++)
            {
                Console.Write($"{sorszam++}. szám: ");
                int felhasznalo_szama = Convert.ToInt32(Console.ReadLine());
                szamok_lista.Add(felhasznalo_szama);
            }

            Console.WriteLine("");

            Console.WriteLine($"A megadott számok: {string.Join(" ", szamok_lista)}");
            Console.WriteLine($"Összegük: {szamok_lista.Sum()}");
            #endregion

            Console.WriteLine("");
            Console.WriteLine("4. feladat:");
            Console.WriteLine("");

            #region 4. feladat
            Console.Write("Adja meg egy számot: ");
            int szam_db = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 1;

            Console.WriteLine("");

            for (int i = 0; i < szam_db; i++)
            {
                Console.WriteLine(szamlalo++);
            }
            #endregion

            Console.WriteLine("");
            Console.WriteLine("5. feladat:");
            Console.WriteLine("");

            #region 5. feladat
            Console.Write("Hány jegyet szeretne megadni? ");
            int jegyek_db = Convert.ToInt32(Console.ReadLine());
            sorszam = 1;

            Console.WriteLine("");

            List<int> jegyek_lista = new List<int>();

            for (int i = 0; i < jegyek_db; i++)
            {
                Console.Write($"{sorszam++}. jegy: ");
                int felhasznalo_jegy = Convert.ToInt32(Console.ReadLine());
                jegyek_lista.Add(felhasznalo_jegy);
            }

            Console.WriteLine("");

            Console.WriteLine($"Jegyek száma: {jegyek_lista.Count()}");
            Console.WriteLine($"Jegyek összege: {jegyek_lista.Sum()}");
            Console.WriteLine($"Átlag: {jegyek_lista.Average()}");
            #endregion
        }
    }
}
