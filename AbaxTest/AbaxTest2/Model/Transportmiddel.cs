using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxTest2.Model
{
    public class Transportmiddel
    {
        public string Kjennetegn { get; }
        public decimal? Maksimalfart { get; }
        public decimal Effekt { get; }
        public Transportmiddeltype? Type { get; }

        protected Dictionary<string, string> Enheter = new Dictionary<string, string>
        {
            {nameof(Maksimalfart), "km/t" },
            {nameof(Effekt), "kw" },
        };

        public Transportmiddel(string kjennetegn, decimal? maksimalfart, decimal effekt, Transportmiddeltype? type)
        {
            Kjennetegn = kjennetegn;
            Maksimalfart = maksimalfart;
            Effekt = effekt;
            Type = type;
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(GetType().Name);
            Add(text, nameof(Kjennetegn), Kjennetegn);
            Add(text, nameof(Maksimalfart), Maksimalfart);
            Add(text, nameof(Effekt), Effekt);
            ToStringOptional(text);
            return text.ToString();
        }

        protected void Add(StringBuilder text, string name, object value)
        {
            if (value == null) return;
            text.Append("  ");
            text.Append(name);
            text.Append("=");
            text.Append(value);
            if (Enheter.ContainsKey(name)) text.Append(Enheter[name]);
            text.AppendLine();
        }

        public virtual void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(Transportmiddeltype), Type);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Transportmiddel);
        }

        private bool Equals(Transportmiddel transportmiddel)
        {
            return transportmiddel != null && GetType() == transportmiddel.GetType() && Kjennetegn == transportmiddel.Kjennetegn;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public void Sammenligne(Transportmiddel transportmiddel2, string prefix)
        {
            var erLike = Equals(transportmiddel2);
            var erLikeTekst = erLike ? string.Empty : "ikke ";
            Console.Write(prefix);
            Console.WriteLine("er {0}samme kjøretøy.", erLikeTekst);
            Console.WriteLine();
        }
    }
}
