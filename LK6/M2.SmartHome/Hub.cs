namespace M2.SmartHome;

/// <summary>
/// Хаб розумного дому — центр керування: тримає список пристроїв і керує ними всіма.
/// <para>Наслідується від: object.</para>
/// </summary>
public class Hub
{
    /// <summary>Список підключених пристроїв (елементи типу <see cref="Device"/>).</summary>
    private readonly List<Device> _devices = new List<Device>();

    /// <summary>Підключити пристрій до хабу.</summary>
    /// <param name="device">пристрій</param>
    public void Add(Device device) => _devices.Add(device);

    /// <summary>Увімкнути всі пристрої.</summary>
    public void TurnAllOn()
    {
        foreach (Device d in _devices)
            d.TurnOn();
    }

    /// <summary>Сумарна потужність усіх пристроїв, ват.</summary>
    public int TotalPower()
    {
        int sum = 0;
        foreach (Device d in _devices)
            sum += d.PowerWatts();
        return sum;
    }

    /// <summary>Звіт: друкує опис і стан кожного пристрою.</summary>
    public void Report()
    {
        foreach (Device d in _devices)
            Console.WriteLine($"{d.Describe()} | {d.Status()}");
    }

    /// <summary>Нічний режим: має зробити всі лампи вдвічі тьмянішими (поки не реалізовано).</summary>
    public void NightMode()
    {
        foreach (Device d in _devices)
        {
            if (d is Lamp lamp)
                lamp.Dim();
        }
    }
}
