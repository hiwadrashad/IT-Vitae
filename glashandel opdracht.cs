using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glashandel
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
            decimal gewoonglasperunit = 30, gewoonglassnijkosten = 10, speciaalglasperunit = 55, speciaalglassnijkosten = 25, aantalm2, kosten;
            string soortglas, restantcode;




            //Opvragen van de benodigde informatie

            Console.WriteLine("Vul in hoeveel m2 aan glas nodig is");
            aantalm2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in of u gewoon of speciaal glas wilt");
            soortglas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Vul in of u een restantcode heeft of niet doormiddel van een ja of nee antwoord");
            restantcode = Convert.ToString(Console.ReadLine());

            if (restantcode == "Nee" || restantcode == "nee")
            { aantalm2 = Math.Ceiling(aantalm2); }

            if (soortglas == "Speciaal" || soortglas == "speciaal")
            { kosten = ((aantalm2 * speciaalglasperunit) + speciaalglassnijkosten); }
            else
            { kosten = ((aantalm2 * gewoonglasperunit) + gewoonglassnijkosten); }

            if (soortglas == "Speciaal" || soortglas == "speciaal")
            {
                if (kosten > 170)
                { kosten = kosten - speciaalglassnijkosten; }
            }

            else
            { if (kosten > 155)
                { kosten = kosten - gewoonglassnijkosten; }
            }

            decimal kortingsprijs = 262.5m;
            decimal kortingspercentage = 0.95m;

            if (kosten > kortingsprijs)
            { kosten = kosten * kortingspercentage; }



            //Het resultaat weergeven in de console
            Console.WriteLine("");
            Console.WriteLine("De glaskosten zijn " + kosten.ToString());
            Console.ReadLine();
        }
    }
}