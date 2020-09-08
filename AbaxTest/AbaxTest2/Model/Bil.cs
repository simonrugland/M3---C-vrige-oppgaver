using System;
using System.Text;

namespace AbaxTest2.Model
{
    public class Bil : Transportmiddel
    {
        public string Farge { get; }

        public Bil(string kjennetegn, decimal maksimalfart, decimal effekt, string farge, Transportmiddeltype transportmiddeltype) 
            : base(kjennetegn, maksimalfart, effekt, transportmiddeltype)
        {
            Farge = farge;
        }

        public void Kjør()
        {
            Console.WriteLine(nameof(Bil) + " " + Kjennetegn + " har fått beskjed om å kjøre.");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Farge), Farge);
        }
    }
}
