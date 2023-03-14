namespace smart_city
{
    public abstract class Device
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int WarrantyPeriod { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }

        protected Device(string name, string serialNumber, string manufacturer, int warrantyPeriod)
        {
            this.Manufacturer = manufacturer;
            this.Name = name;
            this.SerialNumber = serialNumber;
            this.WarrantyPeriod = warrantyPeriod;
            ConnectionStatus = ConnectionStatus.Error;
        }
    }
}
