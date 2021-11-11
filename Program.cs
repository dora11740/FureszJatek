using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FureszSzamTipp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rosszValasz = 0;

            AppInfo();

            Udvozles();

            while (true)
            {

                Random random = new Random();

                int helyesSzam = random.Next(1, 5);

                int tipp = 0;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Mondj egy szamot 1 es 5 kozott.");
                Console.ResetColor();

                while (tipp != helyesSzam && rosszValasz<3)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out tipp))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Csukott szemmel neha jobban lat az ember. Szerintem te epp csukott szemmel gepelhettel, mert ez nem szam volt.\nKerlek szamot adj meg!");
                        Console.ResetColor();
                        rosszValasz++;

                        continue;
                    }

                    tipp = Int32.Parse(input);
                    if (tipp != helyesSzam)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Rossz szamot adtal meg.\nKerlek probalkozz ujra!");
                        Console.ResetColor();
                        rosszValasz++;
                    }

                }
                if (rosszValasz >= 3)
                {
                    Console.WriteLine("3 rossz valaszt adtal, ezert most meghaltal. Ha a pokolra jutsz, csak az ordog segithet rajtad.");
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Gratulalok, eltalaltad a szamot.");

                    Console.WriteLine("Szeretnel megint jatszani? [I/N]");
                    Console.ResetColor();

                    string valasz = Console.ReadLine().ToUpper();

                    if (valasz == "I")
                    {
                        rosszValasz = 0;
                        continue;
                    }
                    else if (valasz == "N")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("A legtobb ember annyira halatlan azert, hogy el. De te nem, mar tobbe nem. Elvezd hatralevo napjaidat!");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        static void AppInfo()
        {
            //app infok
            string appNev = "Furesz Szam Tippeles";
            string appVerzio = "1.0.0";
            string appAuthor = "Georgieviczh Dora";

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: {1} verzio, keszitette {2}", appNev, appVerzio, appAuthor);
            Console.ResetColor();
        }

        static void Udvozles()
        {
            //kirajzoljuk Billyt
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n─────▄██▀▀▀▀▀▀▀▀▀▀▀▀▀██▄─────\n────███───────────────███────\n───███─────────────────███───\n──███───▄▀▀▄─────▄▀▀▄───███──\n─████─▄▀────▀▄─▄▀────▀▄─████─\n─████──▄████─────████▄──█████\n█████─██▓▓▓██───██▓▓▓██─█████\n█████─██▓█▓██───██▓█▓██─█████\n█████─██▓▓▓█▀─▄─▀█▓▓▓██─█████\n████▀──▀▀▀▀▀─▄█▄─▀▀▀▀▀──▀████\n███─▄▀▀▀▄────███────▄▀▀▀▄─███\n███──▄▀▄─█──█████──█─▄▀▄──███\n███─█──█─█──█████──█─█──█─███\n███─█─▀──█─▄█████▄─█──▀─█─███\n███▄─▀▀▀▀──█─▀█▀─█──▀▀▀▀─▄███\n████─────────────────────████\n─███───▀█████████████▀───████\n─███───────█─────█───────████\n─████─────█───────█─────█████\n───███▄──█────█────█──▄█████─\n─────▀█████▄▄███▄▄█████▀─────\n──────────█▄─────▄█──────────\n──────────▄█─────█▄──────────\n───────▄████─────████▄───────\n─────▄███████───███████▄─────\n───▄█████████████████████▄───\n─▄███▀───███████████───▀███▄─\n███▀─────███████████─────▀███\n▌▌▌▌▒▒───███████████───▒▒▐▐▐▐\n─────▒▒──███████████──▒▒─────\n──────▒▒─███████████─▒▒──────\n───────▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒───────\n─────────████░░█████─────────\n────────█████░░██████────────\n──────███████░░███████───────\n─────█████──█░░█──█████──────\n─────█████──████──█████──────\n──────████──████──████───────\n──────████──████──████───────\n──────████───██───████───────\n──────████───██───████───────\n──────████──████──████───────\n─██────██───████───██─────██─\n─██───████──████──████────██─\n─███████████████████████████─\n─██─────────████──────────██─\n─██─────────████──────────██─\n────────────████─────────────\n─────────────██──────────────\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Szia, a nevem Billy the puppet, de ugy is hivhatsz, hogy Jigsaw. Teged hogy hivnak?");
            Console.ResetColor();


            string jatekosNev = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Szia {0}, jatsszunk egy jatekot!", jatekosNev);
            Console.ResetColor();

        }
    }
}


