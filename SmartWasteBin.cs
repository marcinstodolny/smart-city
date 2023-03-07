namespace smart_city
{
    internal class SmartWasteBin : Device
    {
        public bool Compactor;
        public SmartWasteBin(string name, string serialNumber, string manufacturer, int warrantyPeriod, bool compactor) : base(name, serialNumber, manufacturer, warrantyPeriod)
        {
            Compactor = compactor;
        }

    }
}
