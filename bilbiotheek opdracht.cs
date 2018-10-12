using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kleuren instellen
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();


            //Declaratie van de variabelen
            decimal prijs, inlevermaand, uitleenmaand, inleverdag, inleverjaar, uitleendag, uitleenjaar, aantaldagen, week = 7, romansboete = 0.25m;
            string boeknummer;




            //Opvragen van de benodigde informatie

            Console.WriteLine("Vul in het boeknummer");
            boeknummer = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Vul in welke dag van de maand het boek was uitgeleend");
            uitleendag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in welke maand het boek is uitgeleend");
            uitleenmaand = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in welk jaar het boek is uitgeleend");
            uitleenjaar = Convert.ToDecimal(Console.ReadLine());




            Console.WriteLine("Vul in welk dag van de maand het boek is terggebracht");
            inleverdag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in welke maand het boek is ingeleverd numeriek");
            inlevermaand = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in welk jaar het boek is ingeleverd");
            inleverjaar = Convert.ToDecimal(Console.ReadLine());

            decimal dageninjaar = 365.25m;
            aantaldagen = ((inleverjaar * dageninjaar) + (inlevermaand * 30) + (inleverdag)) - ((uitleenjaar * dageninjaar) + (uitleenmaand * 20) + (uitleendag));

            string eerstenummer = boeknummer.Substring(0, 1);

            if (eerstenummer == "9")
            {
                if (aantaldagen > 21)
                { prijs = (aantaldagen - 21) * romansboete; }
                else
                { prijs = 0; }
            }
            else
            {
                if (aantaldagen > 30)
                { prijs = Math.Ceiling((aantaldagen - 30) / week); }
                else
                { prijs = 0; }
            }



            //Het resultaat weergeven in de console
            Console.WriteLine("");
            Console.WriteLine("De boete bedraagt " + prijs.ToString());
            Console.ReadLine();
        }
    }
}