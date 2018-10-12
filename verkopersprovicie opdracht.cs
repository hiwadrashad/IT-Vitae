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
            decimal protoprijs, omzetprijs, units, units1, units2, units3, units4, units5, units6, units7, units8, units9, units10, units11;
       



            //Opvragen van de benodigde informatie

            Console.WriteLine("Vul in het aantal verkochte units van 11 maanden geleden");
            units11 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 10 maanden geleden");
            units10 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 9 maanden geleden");
            units9 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 8 maanden geleden");
            units8 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 7 maanden geleden");
            units7 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 6 maanden geleden");
            units6 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 5 maanden geleden");
            units5 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 4 maanden geleden");
            units4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 3 maanden geleden");
            units3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 2 maanden geleden");
            units2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van 1 maand geleden");
            units1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal verkochte units van deze maand");
            units = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in de omzet in euro's");
            omzetprijs = Convert.ToDecimal(Console.ReadLine());

            // uitrekenen van de formule's
            decimal omzetspercentage = 0.003m;
            protoprijs = ((omzetprijs) * omzetspercentage + (4 * units));

            decimal totaalunits = units + units1 + units2 + units3 + units4 + units5 + units6 + units7 + units8 + units9 + units10 + units11;
            decimal totaalbedrag = 0;
            decimal percentagelimiet = 0.5m;
            decimal hoogstepercentage = 0m;
            decimal eerstepercentage = 0.01m;
            decimal tweedepercentage = 0.015m;
            decimal derdepercentage = 0.02m;

            if (totaalunits <= 10000)
            { totaalbedrag = ((((Math.Floor(totaalunits / 1000)) * eerstepercentage) * units)* protoprijs); }
            if (totaalunits > 10000 && totaalunits <= 20000)
            { totaalbedrag = ((((Math.Floor(totaalunits / 1000)) * eerstepercentage) * units)* protoprijs) + (((((Math.Floor((totaalunits - 10000) / 1000)) * tweedepercentage)) * units)* protoprijs); }
            if (totaalunits > 20000)
            {
                hoogstepercentage = ((Math.Floor(totaalunits - 20000) * derdepercentage));
                if (hoogstepercentage > percentagelimiet)
                { hoogstepercentage = ((hoogstepercentage) - (hoogstepercentage - percentagelimiet)); }
                totaalbedrag = ((hoogstepercentage * units) * protoprijs) + ((((Math.Floor(totaalunits / 1000)) * eerstepercentage) * units) * protoprijs) + (((((Math.Floor((totaalunits - 10000) / 1000)) * tweedepercentage)) * units) * protoprijs);
            }

            







            //Het resultaat weergeven in de console
            Console.WriteLine("");
            Console.WriteLine("De provisie van deze maand is" + totaalbedrag.ToString());
            Console.ReadLine();
        }
    }
}