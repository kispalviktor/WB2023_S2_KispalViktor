using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat: 280db (1-től 1000-ig terjedő) szám");

            Random rnd = new Random();
            int[] szamok = new int[280];

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1, 1001);
            }

            Console.WriteLine(" ");
            Console.WriteLine("///");
            Console.WriteLine(" ");

            Console.WriteLine("3. feladat: Írja ki a file-ba (szamok.txt) sorba rendezve");

            StreamWriter sw = new StreamWriter("szamok.txt");

            for (int i = 0; i < szamok.Length; i++)
            {
                Array.Sort(szamok);
                sw.WriteLine(szamok[i]);
            }

            sw.Close();

            Console.WriteLine(" ");
            Console.WriteLine("///");
            Console.WriteLine(" ");

            Console.WriteLine("4. feladat: Írja ki a 3-al és 7-el osztható számokat");

            bool van = false;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 3 == 0 && szamok[i] % 7 == 0)
                {
                    van = true;
                    Console.Write($"{szamok[i]}, ");
                }
            }

            if(van == false)
            {
                Console.WriteLine("Nincsenek 3-al és 7-el osztható számok");
            }

            Console.WriteLine(" ");
            Console.WriteLine("///");
            Console.WriteLine(" ");

            Console.WriteLine("5. feladat:");

            int userSzam;
            bool van2 = false;
            while (true)
            {
                Console.Write("Írjon be egy számot 1 és 1000 között: ");
                userSzam = Convert.ToInt32(Console.ReadLine());
                if (userSzam > 0 && userSzam < 1001)
                {
                    for (int i = 0; i < szamok.Length; i++)
                    {
                        if (userSzam == szamok[i])
                        {
                            van2 = true;
                            break;
                        }
                    }
                    break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Nem megfelelő szám. ");
            }

            if(van2 == true)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Szerepel a(z) {userSzam} a számok között!");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($"A(z) {userSzam} nem szerepel a számok között");
            }
        }
    }
}
