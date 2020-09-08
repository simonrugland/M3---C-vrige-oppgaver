using System;
using System.Text;

namespace SimonDemo.Model
{
    public class Mercedes : CarMake
    {
        public new string Color { get; }
        public Mercedes(string model, decimal year, string VIN, string equipment, string color, string engine, decimal effect, decimal topspeed, decimal price, CarType cartype)
            : base(model, year, VIN, equipment, engine, effect, topspeed, price, cartype)
        {
            Color = color;
        }

        public void Showroom()
        {
            Console.WriteLine(nameof(Mercedes) + " " + Model + " Has moved to the showroom.");
        }

        public void Garage()
        {
            Console.WriteLine(nameof(Mercedes) + " " + Model + " Has moved back to the garage.");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Color), Color);
        }
    }
}