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
            decimal geboortemaandindagen,peilmaandindagen, KinderenJongerDan, AantalKinderen, Prijs, geboortejaar, geboortedag, peildag, peiljaar;
            const decimal BasisBedrag = 50m, BedragJongerDan = 25m, BedragOuderDan = 37m;
            string éénoudersgezin, StringVerkort, peilmaand, geboortemaand;



            //Opvragen van de benodigde informatie
            Console.WriteLine("Vul in het aantal kinderen die op reis gaan");
            AantalKinderen = Convert.ToDecimal(Console.ReadLine());
            decimal aantal = 0;
            Dictionary<decimal, decimal> GeboorteDagDictionary = new Dictionary<decimal, decimal>();
            Dictionary<decimal, string> GeboorteMaandDictionary = new Dictionary<decimal, string>();
            Dictionary<decimal, decimal> GeboorteJaarDictionary = new Dictionary<decimal, decimal>();
            Dictionary<decimal, bool> GeboorteTotaalDagen = new Dictionary<decimal, bool>();
         
            Console.WriteLine("Vul in de dag van de peilingsdatum");
            peildag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vul in de maand van de peilingsdatum");
            peilmaand = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Vul in het jaar van de peilingsdatum");
            peiljaar = Convert.ToDecimal(Console.ReadLine());
            


            while (aantal < AantalKinderen) 
            {
                aantal = aantal + 1;
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
            peilmaandindagen = 0;
            if (peilmaand == "Januari" || peilmaand == "januari")
                peilmaandindagen = 31;
            if (peilmaand == "Februari" || peilmaand == "februari")
                peilmaandindagen = 59 + (1 / 4);
            if (peilmaand == "Maart" || peilmaand == "maart")
                peilmaandindagen = 90 + (1 / 4);
            if (peilmaand == "April" || peilmaand == "april")
                peilmaandindagen = 120 + (1 / 4);
            if (peilmaand == "Mei" || peilmaand == "mei")
                peilmaandindagen = 151 + (1  + 4);
            if (peilmaand == "Juni" || peilmaand == "juni")
                peilmaandindagen = 181 + (1 / 4);
            if (peilmaand == "Juli" || peilmaand == "juli")
                peilmaandindagen = 212 + (1 / 4);
            if (peilmaand == "Augustus" || peilmaand == "augustus")
                peilmaandindagen = 243 + (1 / 4);
            if (peilmaand == "September" || peilmaand == "september")
                peilmaandindagen = 273 + (1 / 4);
            if (peilmaand == "Oktober" || peilmaand == "oktober")
                peilmaandindagen = 304 + (1 / 4);
            if (peilmaand == "November" || peilmaand == "november")
                peilmaandindagen = 334 + (1 / 4);
            if (peilmaand == "December" || peilmaand == "december")
                peilmaandindagen = 365 + (1  /4);
            

            decimal dagenineenjaar = 365 + (1/4);
            decimal peiljarenindagen = peiljaar * dagenineenjaar;
            decimal totaalpeildagen = peildag + peiljarenindagen + peilmaandindagen;

            aantal = 0;
            decimal aantal2 = 0;
            geboortemaand = "niets";
            while (aantal2 < AantalKinderen)
            {
                aantal2 = aantal2 + 1;
                aantal = aantal + 1;
                geboortemaandindagen = 0;
                if ((GeboorteMaandDictionary[aantal]) == "Januari" || peilmaand == "januari")
                    geboortemaandindagen = 31;
                if ((GeboorteMaandDictionary[aantal]) == "Februari" || peilmaand == "februari")
                    geboortemaandindagen = 59 + (1 / 4);
                if ((GeboorteMaandDictionary[aantal]) == "Maart" || peilmaand == "maart")
                    geboortemaandindagen = 90 + (1 / 4);
                if (GeboorteMaandDictionary[aantal] == "April" || peilmaand == "april")
                    geboortemaandindagen = 120 + (1 / 4);
                if (GeboorteMaandDictionary[aantal] == "Mei" || peilmaand == "mei")
                    geboortemaandindagen = 151 + (1 + 4);
                if (GeboorteMaandDictionary[aantal] == "Juni" || peilmaand == "juni")
                    geboortemaandindagen = 181 + (1 / 4);
                if (GeboorteMaandDictionary[aantal] == "Juli" || peilmaand == "juli")
                    geboortemaandindagen = 212 + (1 / 4);
                if (GeboorteMaandDictionary[aantal] == "Augustus" || peilmaand == "augustus")
                    geboortemaandindagen = 243 + (1 / 4);
                if (GeboorteMaandDictionary[aantal] == "September" || peilmaand == "september")
                    geboortemaandindagen = 273 + (1 / 4);
                if (GeboorteMaandDictionary[aantal] == "Oktober" || peilmaand == "oktober")
                    geboortemaandindagen = 304 + (1 / 4);
                if (GeboorteMaandDictionary[aantal] == "November" || peilmaand == "november")
                    geboortemaandindagen = 334 + (1 / 4);
                if (GeboorteMaandDictionary[aantal] == "December" || peilmaand == "december")
                    geboortemaandindagen = 365 + (1 / 4);


                decimal GeboorteJaarInDagen = (GeboorteJaarDictionary[aantal] * dagenineenjaar);
                decimal TotaalGeboorteDagen = GeboorteJaarInDagen + geboortemaandindagen + (GeboorteDagDictionary[aantal]);
                decimal LeeftijdInDagen = totaalpeildagen - TotaalGeboorteDagen;
                decimal LeeftijdInJaren = LeeftijdInDagen / dagenineenjaar;
                bool OuderDan = false;
                if (LeeftijdInJaren > 10)
                { OuderDan = true; }
             
                GeboorteTotaalDagen.Add(aantal,OuderDan);
            }


            aantal = 0;
            decimal aantaltrue = 0;
            decimal aantalfalse = 0;
            decimal aantal3 = 0;
            while (aantal3 < AantalKinderen)
            {
                aantal3 = aantal3 + 1;
                aantal = aantal + 1;
                if (GeboorteTotaalDagen[aantal] == true)
                { aantaltrue = aantaltrue + 1; }
                else { aantalfalse = aantalfalse + 1; }
            }



            Prijs = BasisBedrag;
            decimal KinderenJongerDanValue = 3;
            if (aantalfalse > 3)
            { aantalfalse = (aantalfalse - (aantalfalse - KinderenJongerDanValue)); }
            Prijs = Prijs + (aantalfalse * BedragJongerDan);
            decimal KinderenOuderDanValue = 2;
            if (aantaltrue > 2)
            { aantaltrue = (aantaltrue - (aantaltrue - KinderenOuderDanValue));  }
            Prijs = Prijs + (aantaltrue * BedragOuderDan);
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