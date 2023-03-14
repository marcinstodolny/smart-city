namespace smart_city
{
    internal class gateway
    {
        public string Manufacturer { get; set; }
        public string Address { get; set; }
        public List<Device> DevicesConnected { get; }
        public gateway(string manufacturer, string address)
        {
            this.Manufacturer = manufacturer;
            this.Address = address;
            DevicesConnected = new List<Device>();
        }

        public bool ConnectDevice(Device device)
        {
            if (device.Manufacturer != Manufacturer) return false;
            device.ConnectionStatus = ConnectionStatus.Connected;
            DevicesConnected.Add(device);
            return true;
        }
    }
}
