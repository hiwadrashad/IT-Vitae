using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxikosten
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
            decimal Kilometers, Tijd, TijdBegin, Prijs, EindPrijs;
            const decimal A = 1.25m;
            string WeekDag,TijdBeginTrimmed, TijdBeginTrimmed2;



            //Opvragen van de benodigde informatie
            Console.WriteLine("Vul in het aantal gereden kilometer's");
            Kilometers = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in het aantal minuten dat nodig was");
            Tijd = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in wat de tijd is wanneer de rit begon volgens het 0000 principe");
            TijdBeginTrimmed = (Console.ReadLine());
            TijdBeginTrimmed2 = TijdBeginTrimmed.Trim(new Char[] {' ','*',':','.'});
            TijdBegin = Convert.ToDecimal(TijdBeginTrimmed2);
            Console.WriteLine("Vul in welke dag van de week het is in het nederlands");
            WeekDag = Convert.ToString(Console.ReadLine());



            // De formule's
            decimal PrijsBinnen = 0.25m;
            decimal PrijsBuiten = 0.45m;
            if ((TijdBegin < 800 || TijdBegin > 1800))
            { Prijs = Tijd * PrijsBinnen; }
            else
            { Prijs = Tijd * PrijsBuiten; }

            if (WeekDag == "Zaterdag")
            { Prijs = Prijs * A; }
            if (WeekDag == "zaterdag")
            { Prijs = Prijs * A; }
            if (WeekDag == "Zondag")
            { Prijs = Prijs * A; }
            if (WeekDag == "zondag")
            { Prijs = Prijs * A; }
            if (WeekDag == "Sunday")
            { Prijs = Prijs * A; }
            if (WeekDag == "sunday")
            { Prijs = Prijs * A; }
            if (WeekDag == "Saturday")
            { Prijs = Prijs * A; }
            if (WeekDag == "saturday")
            { Prijs = Prijs * A; }
            if ((WeekDag == "Vrijdag") && (TijdBegin > 2200))
            { Prijs = Prijs * A; }
            if ((WeekDag == "vrijdag") && (TijdBegin > 2200))
            { Prijs = Prijs * A; }
            if ((WeekDag == "Friday") && (TijdBegin > 2200))
            { Prijs = Prijs * A; }
            if ((WeekDag == "friday") && (TijdBegin > 2200))
            { Prijs = Prijs * A; }
            if ((WeekDag == "Maandag") && (TijdBegin < 700))
            { Prijs = Prijs * A; }
            if ((WeekDag == "maandag") && (TijdBegin < 700))
            { Prijs = Prijs * A; }
            if ((WeekDag == "Monday") && (TijdBegin < 700))
            { Prijs = Prijs * A; }
            if ((WeekDag == "monday") && (TijdBegin < 700))
            { Prijs = Prijs * A; }

            EindPrijs = decimal.Round(Prijs, 2);

                //Het resultaat weergeven in de console
                Console.WriteLine("");
                Console.WriteLine("De kosten zijn" + EindPrijs.ToString());
                Console.ReadLine();
            }
        }
    }
