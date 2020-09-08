using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;

namespace SimonDemo.Model
{
    public class CarMake
    {
        public string Model { get; }
        public decimal Year { get; }
        public string VIN { get; }
        public string Equipment { get; }
        public string Color { get; }
        public string Engine { get; }
        public decimal Effect { get; } 
        public decimal Topspeed { get; }
        public decimal Price { get; }
        public CarType? Type { get; }


        protected Dictionary<string, string> Units = new Dictionary<string, string>
        {
            {
                nameof(Topspeed), "km/h" },
            {
                nameof(Effect), "kw" },
            {
                nameof(Price), "NOK"},
        };

        public CarMake(string model, decimal year, string vIN, string equipment, string engine, decimal effect, decimal topspeed, decimal price, CarType? cartype)
        {
            Model = model;
            Year = year;
            VIN = vIN;
            Equipment = equipment;
            Engine = engine;
            Effect = effect;
            Topspeed = topspeed;
            Price = price;
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(GetType().Name);
            Add(text, nameof(Model), Model);
            Add(text, nameof(Year), Year);
            Add(text, nameof(VIN), VIN);
            Add(text, nameof(Equipment), Equipment);
            Add(text, nameof(Color), Color);
            Add(text, nameof(Engine), Engine);
            Add(text, nameof(Effect), Effect);
            Add(text, nameof(Topspeed), Topspeed);
            Add(text, nameof(Price), Price);
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
            if (Units.ContainsKey(name)) text.Append(Units[name]);
            text.AppendLine();
        }

        public virtual void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(CarType), Type);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CarMake);
        }

        private bool Equals(CarMake carmake)
        {
            return carmake != null && GetType() == carmake.GetType() && Model == carmake.Model;
        }

        public void Compare(CarMake carmake2, string prefix)
        {
            var areEqual = Equals(carmake2);
            var areEqualText = areEqual ? string.Empty : "not ";
            Console.Write(prefix);
            Console.WriteLine("is {0}the same vehicle", areEqualText);
            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}