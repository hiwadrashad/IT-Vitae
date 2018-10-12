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
            decimal aantalkilometersinnederland,aantalkilometersbuitennederland,solidevolume, solidegewicht, vloeibaarvolume, vloeibaargewicht,vloeibaarprijs,solideprijs;


            //Opvragen van de benodigde informatie

            Console.WriteLine("Vul in het aantal m3 aan solide lading");
            solidevolume = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal kg aan solide lading");
            solidegewicht = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal m3 aan vloeibare lading");
            vloeibaarvolume = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal kg aan vloeibare lading");
            vloeibaargewicht = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in  het aantal kilometers gereden in Nederland");
            aantalkilometersinnederland = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal kilometers gereden buiten Nederland");
            aantalkilometersbuitennederland = Convert.ToDecimal(Console.ReadLine()); 



            // berekenen van de formule's
            decimal volumebedragsolideperunit = 0.8m;
            decimal gewichtbedragsolideperunit = 0.55m;
            solideprijs = (solidevolume * volumebedragsolideperunit) + (solidegewicht * gewichtbedragsolideperunit);

            decimal volumebedragvloeibaarperunit = 1.25m;
            decimal gewichtbedragvloeibaarperunit = 0.45m;
            vloeibaarprijs = ((vloeibaarvolume * volumebedragvloeibaarperunit) + (vloeibaargewicht * gewichtbedragvloeibaarperunit));

            decimal prijsbinnennederland = ((solideprijs + vloeibaarprijs) * aantalkilometersinnederland);
            decimal toeslag1 = 1.45m;
            decimal protoprijsbuitennederland = (((solideprijs + vloeibaarprijs) * aantalkilometersbuitennederland) * toeslag1);
            decimal toeslag2 = 1.035m;
            decimal prijsbuitennederland = 0;
            if (protoprijsbuitennederland > 0)
            {if (((protoprijsbuitennederland * toeslag2) - protoprijsbuitennederland) > 45)
                { prijsbuitennederland = (protoprijsbuitennederland * toeslag2); }
                else {prijsbuitennederland = (protoprijsbuitennederland + 45); }
            }

            decimal prijs = prijsbinnennederland + prijsbuitennederland;



            //Het resultaat weergeven in de console
            Console.WriteLine("");
            Console.WriteLine("De kosten zijn" + prijs.ToString());
            Console.ReadLine();
        }
    }
}