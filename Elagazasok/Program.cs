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
            Console.Write("Kérem adja meg a hét napját (1 - 7): ");
            string hetNapja = Console.ReadLine();
            int hetNapja_int = Convert.ToInt16(hetNapja);
            char[] hetNapja_char = hetNapja.ToCharArray();
            switch (hetNapja)//String típussal,szöveges változóval
            {
                case "1": Console.WriteLine("Hétfő"); break;
                case "2": Console.WriteLine("Kedd"); break;
                case "3": Console.WriteLine("Szerda"); break;
                case "4": Console.WriteLine("Csütörtök"); break;
                case "5": Console.WriteLine("Péntek"); break;
                case "6": Console.WriteLine("Szombat"); break;
                case "7": Console.WriteLine("Vasárnap"); break;
                //Elhagyható, nem kötelező a default ág!
                default: Console.WriteLine("Nem 1 - 7 közötti számot adott meg");break;
            }

            switch (hetNapja_int)//Egész számmal kezelve, int típus
            {
                case 1: Console.WriteLine("Hétfő"); break;
                case 2: Console.WriteLine("Kedd"); break;
                case 3: Console.WriteLine("Szerda"); break;
                case 4: Console.WriteLine("Csütörtök"); break;
                case 5: Console.WriteLine("Péntek"); break;
                case 6: Console.WriteLine("Szombat"); break;
                case 7: Console.WriteLine("Vasárnap"); break;
                //Elhagyható, nem kötelező a default ág!
                default: Console.WriteLine("Nem 1 - 7 közötti számot adott meg"); break;
            }

            switch (hetNapja_char[0])//Egész számmal kezelve, int típus
            {
                case '1': Console.WriteLine("Hétfő"); break;
                case '2': Console.WriteLine("Kedd"); break;
                case '3': Console.WriteLine("Szerda"); break;
                case '4': Console.WriteLine("Csütörtök"); break;
                case '5': Console.WriteLine("Péntek"); break;
                case '6': Console.WriteLine("Szombat"); break;
                case '7': Console.WriteLine("Vasárnap"); break;
                //Elhagyható, nem kötelező a default ág!
                default: Console.WriteLine("Nem 1 - 7 közötti számot adott meg"); break;
            }

            //3.típusu elágazás, melyet kiírásnál szoktunk alkalmazni.
            Console.WriteLine((x<y) ? "igaz" : "hamis");

            /*Kérjen be a felhasználótól 3 egész számot. 
             * Írja a képernyőre a legnagyobb, majd a következő legynagyobb, majd végül
             * a közülül legkisebb számot, szóközzel elválasztva egymástól.
             */
            Console.Write("Kérem adja meg az első számot: ");
            int szam_1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az első számot: ");
            int szam_2 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az első számot: ");
            int szam_3 = int.Parse(Console.ReadLine());

            if (szam_1 > szam_2 && szam_1 > szam_3)
            {
                Console.Write(szam_1 + " ");
                if (szam_2 > szam_3)
                {
                    Console.Write(szam_2 + " " + szam_3);
                }
                else
                {
                    Console.Write(szam_3 + " " + szam_2);
                }
            }
                


            Console.ReadKey();
        }
    }
}
