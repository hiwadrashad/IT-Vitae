using System;
using System.Collections.Generic;

namespace Waterverbruik
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
            decimal prijstarief1,prijstarief2,kubiekmeter;


            //Opvragen van de benodigde informatie
            
            Console.WriteLine("Vul in het aantal kubieke meter aan waterverbruik dit jaar");
            kubiekmeter = Convert.ToDecimal(Console.ReadLine());
         
            // berekenen van de formule's
            decimal tarief1vastrecht = 100;
            decimal tarief1verbruikkosten = 0.25m;
            prijstarief1 = (tarief1vastrecht + (kubiekmeter * tarief1verbruikkosten));

            decimal tarief2vastrecht = 75;
            decimal tarief2verbruikkosten = 0.38m;
            prijstarief2 = (tarief2vastrecht + (kubiekmeter * tarief2verbruikkosten));

            decimal prijs = 0;
            if (prijstarief1 > prijstarief2)
            { prijstarief2 = prijs; }
            else
            { prijstarief1 = prijs; }
           
            
            //Het resultaat weergeven in de console
            Console.WriteLine("");
            Console.WriteLine("De kosten zijn" + prijs.ToString());
            Console.ReadLine();
        }
    }
}