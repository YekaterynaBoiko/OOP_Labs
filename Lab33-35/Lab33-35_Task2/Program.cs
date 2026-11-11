using Lab33_35_Task2;

class Program
{
    static void Main()
    {
        BatteryDevice batteryDevice = new BatteryDevice(50);
        batteryDevice.TurnOn();
        batteryDevice.TurnOff();
        batteryDevice.Charge();
        Console.WriteLine($"Заряд батареї: {batteryDevice.BatteryLevel}%");

        Console.WriteLine();

        WiredDevice wiredDevice = new WiredDevice();
        wiredDevice.PlugIn();
        wiredDevice.TurnOn();
        wiredDevice.TurnOff();
        wiredDevice.Unplug();

        Console.WriteLine();

        HybridDevice hybridDevice = new HybridDevice(80);
        hybridDevice.TurnOn();
        hybridDevice.TurnOff();
        hybridDevice.PlugIn();
        hybridDevice.Unplug();
        hybridDevice.Charge();
    }
}

