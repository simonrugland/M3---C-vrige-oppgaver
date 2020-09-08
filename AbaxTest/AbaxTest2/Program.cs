using System;
using AbaxTest2.Model;

namespace AbaxTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bil1 = new Bil("NF123456", 200, 147, "grønn", Transportmiddeltype.LettKjøretøy);
            bil1.Print();
            var bil2 = new Bil("NF654321", 195, 150, "blå", Transportmiddeltype.LettKjøretøy); 
            bil2.Print();
            bil1.Sammenligne(bil2, "Bil 1 og bil 2 ");

            var fly1 = new Fly("LN1234", 1000, 30, 2, 10, Transportmiddeltype.Jetfly);
            fly1.Print();
            fly1.StartFly();

            var båt = new Båt("ABC123", 30, 100, 500);
            båt.Print();
        }
    }
}
