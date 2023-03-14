namespace smart_city
{
    public class program
    {
        static List<gateway> gateways = new();
        static List<Device> devices = new();
        public static void Main()
        {
            var gateway = new gateway("someone", "none");
            var gateway2 = new gateway("someone2", "none");
            gateways.Add(gateway);
            gateways.Add(gateway2);

            Device device1 = new SmartLight("Lamp","4adf1", "someone", 10, Enum.GetName(SmartLightType.Led), (int)SmartLightType.Led);
            devices.Add(device1);

            Device device2 = new SmartLight("Lamp", "4adf1", "someone2", 10, Enum.GetName(SmartLightType.Halogen), (int)SmartLightType.Halogen);
            devices.Add(device2);

            Device bin = new SmartWasteBin("bin", "4adf1", "someone2", 10, true);
            devices.Add(bin);
            gateway.ConnectDevice(device1);
            gateway.ConnectDevice(device2);

            Console.WriteLine(device1.ConnectionStatus +$" {device1}" );
            Console.WriteLine(device2.ConnectionStatus);
            foreach (var deviceError in DevicesWithError())
            {
                Console.WriteLine($"Device with error: {deviceError.Name}");

            }
            Console.WriteLine($"Devices installed: {DevicesInstalled()}");
        }

        public static List<Device> DevicesWithError()
        {
            return devices.Where(t => t.ConnectionStatus == (int)Connection.Error).ToList();
        }

        public static int DevicesInstalled()
        {
            return gateways.Sum(elementGateway => elementGateway.CountDevices());
        }
    }
}
