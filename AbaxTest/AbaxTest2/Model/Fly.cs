using System;
using System.Text;

namespace AbaxTest2.Model
{
    public class Fly : Transportmiddel
    {
        public decimal Vingespenn { get; }
        public decimal Lasteevne { get; }
        public decimal Egenvekt { get; }

        public Fly(string kjennetegn, decimal effekt, decimal vingespenn, decimal lasteevne, decimal egenvekt, Transportmiddeltype type)
             : base(kjennetegn, null, effekt, type)
        {
            Vingespenn = vingespenn;
            Lasteevne = lasteevne;
            Egenvekt = egenvekt;
            Enheter.Add(nameof(Vingespenn), "m");
            Enheter.Add(nameof(Lasteevne), "tonn");
            Enheter.Add(nameof(Egenvekt), "tonn");
        }

        public void StartFly()
        {
            Console.WriteLine(nameof(Fly) + " " + Kjennetegn + " har fått beskjed om å fly.");
            Console.WriteLine();
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Vingespenn), Vingespenn);
            Add(text, nameof(Lasteevne), Lasteevne);
            Add(text, nameof(Egenvekt), Egenvekt);
        }
    }
}
