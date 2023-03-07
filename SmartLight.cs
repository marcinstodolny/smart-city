using System.Xml.Linq;

namespace smart_city
{
    internal class SmartLight : Device
    {
        public string Type;
        public int Power;
        public SmartLight(string name, string serialNumber, string manufacturer, int warrantyPeriod, string type, int power) : base(name, serialNumber, manufacturer, warrantyPeriod )
        {
            Type = type;
            Power = power;
        }
        
    }
}
