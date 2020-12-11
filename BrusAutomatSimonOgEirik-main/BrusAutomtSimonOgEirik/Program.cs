using System;

namespace BrusAutomatSimonOgEirik
{
    class Program /*: VendingMachine*/
    {
        static void Main(string[] args)
        {
            //Implementer en brusautomat. Ulike drikker har ulik pris. Automaten har en lagerbeholdning.
            //Man kan putte på mynter (1kr, 5kr, 10kr, 20kr). Man trykker på en knapp for en bestemt drikk
            //- hvis man har puttet på nok får man denne og saldoen reduseres tilsvarende.
            //Det finnes en knapp for å få gjeldende saldo tilbake. 
            //en fabrikk som lager brusen
            //En storage som lagrer brus og er mellomledd mellom factory og vending machine
            //abstrakt method and override
            //SjokoladeMachine

            //spørsmål til terje: Er det best å sende Factory til storage eller å gette fra storage 

            var sodaFactory = new SodaFactory();
            var sodaMachine = new SodaMachine();
            var storage = new Storage();

            //Factory
            sodaFactory.MakeProduct(Product.Types.CocaCola, 20);
            sodaFactory.SendProductToStorage();

            //Storage
            storage.SendProductToMachine(sodaMachine);

            //VendingMachine
            sodaMachine.InsertCoins(10);
            sodaMachine.InsertCoins(20);
            sodaMachine.CheckBalance();

            sodaMachine.ChooseSoda(Product.Types.CocaCola);
            var chosenSoda = sodaMachine.ChooseSoda(Product.Types.CocaCola);
            sodaMachine.DeductPrice(chosenSoda.Price);
            sodaMachine.SpitOutProduct();

            sodaMachine.CheckBalance();
            sodaMachine.ReturnCoins();
        }
    }
}
