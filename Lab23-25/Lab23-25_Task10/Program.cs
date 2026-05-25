namespace Lab23_25_Task10
{
    public class Program
    {
        public static void TurnDevice(Device[] devices)
        {
            foreach (var device in devices)
            {
                device.TurnOn();
            }
        }
        static void Main(string[] args)
        {
            Device[] result = { new Phone(), new Laptop(), new Tablet() };
            TurnDevice(result);
        }
    }
}
