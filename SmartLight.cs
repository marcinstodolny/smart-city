using System.Xml.Linq;

namespace smart_city
{
    internal class SmartLight : Device
    {
        public SmartLightType Type { get; }

        public int Power => (int)Type;

        public SmartLight(string name, string serialNumber, string manufacturer, int warrantyPeriod, SmartLightType type) : base(name, serialNumber, manufacturer, warrantyPeriod )
        {
            Type = type;
        }
    }
}
