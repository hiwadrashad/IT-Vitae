using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouderbijdrage_School
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
            decimal geboortemaandindagen,peilmaandindagen, KinderenJongerDan, AantalPersonen, Prijs, geboortejaar, geboortedag, peildag, peiljaar;
            const decimal BasisBedrag = 50m, BedragJongerDan = 25m, BedragOuderDan = 37m;
            string éénoudersgezin, StringVerkort, peilmaand, geboortemaand;



            //Opvragen van de benodigde informatie
            Console.WriteLine("Vul in het aantal personen die een abonnement willen verkrijgen");
            AantalPersonen = Convert.ToDecimal(Console.ReadLine());
            decimal aantal = 0;
            Dictionary<decimal, decimal> GeboorteDagDictionary = new Dictionary<decimal, decimal>();
            Dictionary<decimal, string> GeboorteMaandDictionary = new Dictionary<decimal, string>();
            Dictionary<decimal, decimal> GeboorteJaarDictionary = new Dictionary<decimal, decimal>();


            Console.WriteLine("Vul in de dag van de peilingsdatum");
            peildag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in de maand van de peilingsdatum");
            peilmaand = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Vul in het jaar van de peilingsdatum");
            peiljaar = Convert.ToDecimal(Console.ReadLine());



            while (aantal < Aantal) ;
            { aantal = aantal + 1;
                Console.WriteLine("Vul in het geboortejaar van kind nummer " + (aantal));
                geboortejaar = Convert.ToDecimal(Console.ReadLine());
                GeboorteJaarDictionary.Add(aantal, geboortejaar);
                Console.WriteLine("Vul in de geboortemaand van kind nummer " + (aantal));
                geboortemaand = Convert.ToString(Console.ReadLine());
                GeboorteMaandDictionary.Add(aantal, geboortemaand);
                Console.WriteLine("Vul in de geboortedag van kind nummer" + (aantal));
                geboortedag = Convert.ToDecimal(Console.ReadLine());
                GeboorteDagDictionary.Add(aantal, geboortedag);
            }

            Console.WriteLine("Vul in of u recht heeft op de éénoudersgezinkorting doormiddel van een ja of nee antwoord");
            éénoudersgezin = Convert.ToString(Console.ReadLine());
            StringVerkort = éénoudersgezin.Trim(new char[] { ' ', '.', ':', '-' });



            // De formule's
            
            if (peilmaand == "Januari" || peilmaand == "januari")
                peilmaandindagen = 31;
          

            decimal dagenineenjaar = 365 + (1/4);
            decimal peiljarenindagen = peiljaar * dagenineenjaar;

            decimal totaalpeildagen = peildag + peiljarenindagen + peilmaandindagen;
            

            

            Prijs = BasisBedrag;
            decimal KinderenJongerDanValue = 3;
            if (KinderenJongerDan > 3)
            { KinderenJongerDan = (KinderenJongerDan - (KinderenJongerDan - KinderenJongerDanValue)); }
            Prijs = Prijs + (KinderenJongerDan * BedragJongerDan);
            decimal KinderenOuderDanValue = 2;
            if (KinderenJongerDan > 2)
            { KinderenOuderDan = (KinderenOuderDan - (KinderenOuderDan - KinderenOuderDanValue));  }
            Prijs = Prijs + (KinderenOuderDan * BedragOuderDan);
            decimal éénoudersgezinkorting = 0.75m;
            if (éénoudersgezin == "Ja")
            { Prijs = Prijs * éénoudersgezinkorting; }
            if (éénoudersgezin == "ja")
            { Prijs = Prijs * éénoudersgezinkorting; }
            if (éénoudersgezin == "Yes")
            { Prijs = Prijs * éénoudersgezinkorting; }
            if (éénoudersgezin == "yes")
            { Prijs = Prijs * éénoudersgezinkorting; }


            decimal prijsmaximum = 150m;
            if (Prijs > 150)
            { Prijs = (Prijs - (Prijs - prijsmaximum)); }


            





            //Het resultaat weergeven in de console
            Console.WriteLine("");
            Console.WriteLine("De kosten zijn" + Prijs.ToString());
            Console.ReadLine();
        }
    }
}