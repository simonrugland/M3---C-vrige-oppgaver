using System;
using System.Text;

namespace SimonDemo.Model
{
    public class BMW : CarMake
    {
        public new string Color { get; }
        public BMW(string model, decimal year, string VIN, string equipment, string color, string engine, decimal effect, decimal topspeed, decimal price, CarType cartype)
            : base(model, year, VIN, equipment, engine, effect, topspeed, price, cartype)
        {
            Color = color;
        }

        public void Showroom()
        {
            Console.WriteLine(nameof(BMW) + " " + Model + " Has moved to the showroom.");
        }

        public void Garage()
        {
            Console.WriteLine(nameof(BMW) + " " + Model + " Has moved back to the garage.");
        }

        public void SimonSynes()
        {
            Console.WriteLine(nameof(BMW) + " " + Model + " Has moved back to the garage. Og Simon synes Geir skulle kjøpt en BMW.");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Color), Color);
        }
    }
}