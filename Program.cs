namespace smart_city
{
    public class program
    {
        static List<gateway> gateways = new();
        public static void Main()
        {
            var gateway = new gateway("someone", "none");
            var gateway2 = new gateway("someone2", "none");
            gateways.Add(gateway);
            gateways.Add(gateway2);

            var device1 = new SmartLight("Lamp","4adf1a", "someone", 10, SmartLightType.Led);
            gateway.ConnectDevice(device1);

            var device2 = new SmartLight("Lamp", "4adf1d", "someone2", 10, SmartLightType.Halogen);
            gateway2.ConnectDevice(device2);

            var bin = new SmartWasteBin("bin", "4adfb1", "someone2", 10, true);
            gateway2.ConnectDevice(bin);

            var DeviceWithError = DevicesWithError();
            var DeviceCount = DevicesInstalled();

        }

        public static List<Device> DevicesWithError()
        {
            return gateways.SelectMany(gate => gate.DevicesConnected.Where(d => d.ConnectionStatus == ConnectionStatus.Error)).ToList();
        }

        public static int DevicesInstalled()
        {
            return gateways.Sum(element => element.DevicesConnected.Count);
        }
    }
}
