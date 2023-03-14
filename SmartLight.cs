using System.Xml.Linq;

namespace smart_city
{
    internal class SmartLight : Device
    {
        public string? Type { get; }
        public int Power { get; }
        public SmartLight(string name, string serialNumber, string manufacturer, int warrantyPeriod, string? type, int power) : base(name, serialNumber, manufacturer, warrantyPeriod )
        {
            Type = type;
            Power = power;
        }

        public override string ToString()
        {
            return $"Type: {Type}, power: {Power}";
        }
    }
}
