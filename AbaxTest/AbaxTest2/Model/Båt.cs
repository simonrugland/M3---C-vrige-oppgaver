using System.Text;

namespace AbaxTest2.Model
{
    public class Båt : Transportmiddel
    {
        public decimal Bruttotonnasje { get; }

        public Båt(string kjennetegn, decimal maksimalfart, decimal effekt, decimal bruttotonnasje)
            : base(kjennetegn, maksimalfart, effekt, null)
        {
            Bruttotonnasje = bruttotonnasje;
            Enheter.Add(nameof(Bruttotonnasje), "kg");
            Enheter[nameof(Maksimalfart)] = "knop";
        }

        public override void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(Bruttotonnasje), Bruttotonnasje);
        }
    }
}
