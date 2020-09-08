using System;
using System.ComponentModel.Design;

namespace SimonDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.CityName = "Tvedestrand";
            city.PostalCode = 4900;
            city.CityCounty = "Agder";

            TvedestrandTurisme turisme = new TvedestrandTurisme();
            turisme.Brygga = "Langs brygga i Tvedestrand finner du barer, restauranter, hotell, butikker og boder. Spesielt populært blandt de voksne er baren Dags.";
            turisme.Jernverksmuseum = "På Nes Verk i Tvedestrand kommune ligger Norges best bevarte av de gamle jernverkene. I dag er jernverket museum, og vi har tatt vare på de viktigste bygningene fra jernverkstiden. På museet forteller vi den 300 år lange historien om hvordan jern og stål ble framstilt i gamle dager, og hvordan hverdagen var for dem som arbeidet ved verket.";

            TreBåtFestival trebåten = new TreBåtFestival();
            trebåten.FestivalNavn = "Festivalen heter Trebåtfestivalen ettersom det i begynnelsen var en samling for folk og entusiaster med trebåter.";
            trebåten.FestivalPlass = "Trebåtfestivalen blir avholdt i Risør, som ligger ca 20 minutter med bil unna Tvedestrand.";
            trebåten.FestivalBesøkende = "De siste årene har det vært oppimot 12000 besøkende under festivalen.";

            Console.WriteLine(city.GetCityInfo());

            Console.WriteLine("Hva vil du vite mer om?");
            string info = Console.ReadLine();

            if (info == "Brygga")
            {
                Console.WriteLine(turisme.Brygga);
            }

            Console.WriteLine("Vil du lese om Næs jernverkmuseum?");
            string svar = Console.ReadLine();
            if (svar == "ja")
            {
                Console.WriteLine(turisme.Jernverksmuseum);
            }
            else
            {
                Console.WriteLine("Det er greit, ha en flott dag videre! :)");
            }

            Console.WriteLine("Ønsker du informasjon om den nært forestående festivalen \"Trebåtfestivalen\"?");
            string svar1 = Console.ReadLine();

            Console.WriteLine("Er du heeeeeelt sikker?");
            string svar2 = Console.ReadLine();

            if (svar1 == "ja")
            {
                Console.WriteLine(trebåten.FestivalInfo());
            } else if (svar2 == "helt sikker")
            {
                Console.WriteLine(trebåten.FestivalInfo());
            }
            else { Console.WriteLine("Det er greit. Du aner ikke hva du går glipp av");}
        }
    }
}
