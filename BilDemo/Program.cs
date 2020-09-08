using System;
using SimonDemo.Model;

namespace SimonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmw1 = new BMW("E60", 2010, "WBSNB91010B559959", "Highend", "Lemans Red", "S85V10", 373, 250, 800000, CarType.Sedan);
            bmw1.Print();
            bmw1.Showroom();
            var bmw2 = new BMW("E60", 2010, "WBSNB91010B559969", "Medium", "Metallic Blue", "S85V10", 373, 250, 700000, CarType.Touring);
            bmw2.Print();
            bmw2.Showroom();
            bmw1.Compare(bmw2, "Car 1 and Car 2 ");
            bmw1.Garage();
            bmw2.SimonSynes();

            var mercedes1 = new Mercedes("C63 AMG", 2008, "WBSNB91010B559991", "Highend", "Hot Pink", "M156V8", 336, 250, 1200000, CarType.Touring);
            mercedes1.Print();
            mercedes1.Showroom();
            var mercedes2 = new Mercedes("E63 AMG", 2011, "WBSNB91010B559944", "Extreme", "Aquamarine", "M156V8", 540, 290, 1500000, CarType.Coupe);
            mercedes2.Print();
            mercedes2.Showroom();
            mercedes1.Compare(mercedes2, "Car 1 and Car 2 ");
            mercedes2.Garage();
            mercedes1.Garage();

            var audi1 = new Audi("RS4", 2006, "WBSNB91010B559959", "Lowend", "Military Green", "RS4V8", 253, 250, 650000, CarType.Sedan);
            audi1.Print();
            audi1.Showroom();
            var audi2 = new Audi("RS3", 2008, "WBSNB91010B559969", "Highend", "Pearlescent White", "RS3V8", 253, 250, 800000, CarType.Hatchback);
            audi2.Print();
            audi2.Showroom();
            audi1.Compare(audi2, "Car 1 and Car 2 ");
            audi2.Garage();
            audi1.Garage();

            var volvo1 = new Volvo("XC70", 2005, "WBSNB91010B559478", "Highend", "Matte Black","D5244T17", 224, 250, 650000, CarType.SUV);
            volvo1.Print();
            volvo1.Showroom();
            var volvo2 = new Volvo("XC90", 2010, "WBSNB91010B559173", "Luxury", "Sun Yellow","B6304T4", 224, 250, 700000, CarType.SUV);
            volvo2.Print();
            volvo2.Showroom();
            volvo1.Compare(volvo2, "Car 1 and Car 2 ");
            volvo2.Garage();
            volvo1.GeirKjøper();
        }
    }
}
