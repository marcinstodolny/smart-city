using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_city
{
    internal class gateway
    {
        public string Manufacturer { get; }
        public string Address { get; }
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
            device.ConnectionStatus = (int)Connection.Connected;
            DevicesConnected.Add(device);
            return true;
        }

        public int CountDevices()
        {
            return DevicesConnected.Count;
        }

    }
}
