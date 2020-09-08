using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace SimonDemo.Model
{
    public class Volvo : CarMake
    {
        public new string Color { get; }

        public Volvo(string model, decimal year, string VIN, string equipment, string color, string engine,
            decimal effect, decimal topspeed, decimal price, CarType cartype)
            : base(model, year, VIN, equipment, engine, effect, topspeed, price, cartype)
        {
            Color = color;
        }

        public void Showroom()
        {
            Console.WriteLine(nameof(Volvo) + " " + Model + " er helt klart best, bare spør Geir! :)");
        }

        public void Garage()
        {
            Console.WriteLine(nameof(Volvo) + " " + Model + " er tilbake i garasjen men er fortsatt ganske bra synes Geir.");
        }

        public void GeirKjøper()
        {
            Console.WriteLine(nameof(Volvo) + " " + Model + " Geir valgte denne og tok den med seg hjem :)");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Color), Color);
        }
    }
}