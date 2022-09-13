using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 18;
            int y = 20;
            string fiu = "fiu";
            string no = "nő";
            //Egyszerű elágazás
            if  (y < x)
            {
                Console.WriteLine($"Az {x} szám kisebb, mint {y} szám.");
            }
            else
            {
                Console.WriteLine($"Az {y} szám nem kisebb, mint {x} szám.");
            }

            //Egymásba ágyazás
            if (x < y)
            {
                if (fiu == "fiu")
                {
                    Console.WriteLine("Ő valóban fiu.");                
                }

                if(fiu.Equals("nő"))
                {
                    Console.WriteLine("Ez az életben sem fog futni!!!");
                }
                else
                {
                    Console.WriteLine("Sajnos ez a programrész le fog futni!!!");
                }
            }
            else
            {
                Console.WriteLine($"Az {y} szám nem kisebb, mint {x} szám.");
            }

            //Több if - else ág van egy programban
            Console.Write("Kérem adja meg a dolgozat eredményét %-ban: ");
            int szazalek = Convert.ToInt16(Console.ReadLine());
            if (szazalek >= 1 && szazalek <=20)
            {
                Console.WriteLine("Kedves fiam bukta van!!!");
            }
            else if (szazalek >= 21 && szazalek <= 40)
            {
                Console.WriteLine("Kedves fiam épp, hogy csak átmentél!!!");
            }
            else if (szazalek >= 41 && szazalek <= 60)
            {
                Console.WriteLine("Az eredményed kedves fiam közepes!!!");
            }
            else if (szazalek >= 61 && szazalek <= 80)
            {
                Console.WriteLine("Kedves fiam, viszonylag jó eredményt értél el!!!");
            }
            else
            {
                Console.WriteLine("Kedves fiam Te egy zseni vagy!!!!!");
            }

            //switch - case utasítás házi feladat

            Console.ReadKey();
        }
    }
}
