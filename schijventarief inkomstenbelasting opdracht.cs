using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkopers_provisie
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
            decimal belastbaarinkomen = 0, tariefgroepbedrag = 0, tariefalgemeenbedrag = 0;
           



            //Opvragen van de benodigde informatie

            Console.WriteLine("Vul in het belastbaar inkomen");
            belastbaarinkomen = Convert.ToDecimal(Console.ReadLine());


            // uitrekenen van de formule's

            if (belastbaarinkomen <= 8000)
            { tariefgroepbedrag = 419; }
            if (belastbaarinkomen > 8000 && belastbaarinkomen <= 25000)
            { tariefgroepbedrag = 8799; }
            if (belastbaarinkomen > 25000 && belastbaarinkomen <= 54000)
            { tariefgroepbedrag = 17179; }
            if (belastbaarinkomen > 54000)
            { tariefgroepbedrag = 15503; }

            decimal percentagealgemeentarief = 0.12m;
            if ((belastbaarinkomen * percentagealgemeentarief) > 6704)
            { tariefalgemeenbedrag = 6704; }
            else
            { tariefalgemeenbedrag = (belastbaarinkomen * percentagealgemeentarief); }


            decimal protobelasting = 0;
            decimal tarief1percentage = ((35.75m)/100);
            decimal tarief2percentage = ((37.05m)/100);
            decimal tarief3percentage = ((50)/100);
            decimal tarief4percentage = ((60)/100);
            if (belastbaarinkomen <= 8000)
            { protobelasting = belastbaarinkomen * tarief1percentage; }
            if (belastbaarinkomen > 8000 && belastbaarinkomen <= 25000)
            { protobelasting = ((8000 * tarief1percentage) + ((belastbaarinkomen - 8000) * tarief2percentage)); }
            if (belastbaarinkomen > 25000 && belastbaarinkomen <= 54000)
            { protobelasting = ((8000 * tarief1percentage) + ((25000 - 8000) * tarief2percentage) + ((belastbaarinkomen - 25000) * tarief3percentage)); }
            if (belastbaarinkomen > 54000)
            { protobelasting = ((8000 * tarief1percentage) + ((25000 - 8000) * tarief2percentage) + ((54000 - 25000) * tarief3percentage) + (belastbaarinkomen - 54000) * tarief4percentage); }

            decimal verschuldigde_belasting = (protobelasting - (tariefalgemeenbedrag + tariefgroepbedrag));
           



            //Het resultaat weergeven in de console
            Console.WriteLine("");
            Console.WriteLine("De verschuldigde belasting is " + verschuldigde_belasting.ToString());
            Console.ReadLine();
        }
    }
}