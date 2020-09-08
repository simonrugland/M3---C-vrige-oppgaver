using System.Dynamic;

namespace SimonDemo2
{
    public class City
    {
        public string CityName { get; set; }
        public decimal PostalCode { get; set; }
        public string CityCounty { get; set; }

        
        public string GetCityInfo()
        {
            return CityName + ", " + PostalCode + ", " + CityCounty;
        }
    }
}