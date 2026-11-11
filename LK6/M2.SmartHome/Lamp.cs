namespace M2.SmartHome;

/// <summary>
/// Лампа — освітлювальний пристрій з регульованою яскравістю.
/// <para>Наслідується від: <see cref="Device"/> (пристрій). Нащадок: <see cref="SmartLamp"/> (розумна лампа).</para>
/// </summary>
public class Lamp : Device
{
    /// <summary>Яскравість, відсотки (0–100).</summary>
    public int Brightness { get; private set; }

    /// <summary>Конструктор: створює лампу з назвою і яскравістю.</summary>
    /// <param name="name">назва (кімната)</param>
    /// <param name="brightness">яскравість, %</param>
    public Lamp(string name, int brightness) : base(name)
    {
        Brightness = brightness;
    }

    /// <summary>Опис лампи з поточною яскравістю. Перевизначає (override) <see cref="Device.Describe"/>.</summary>
    public override string Describe() => $"лампа {Name} ({Brightness}%)";

    /// <summary>Потужність лампи: яскравість / 10, ват. Перевизначає (override) <see cref="Device.PowerWatts"/>.</summary>
    public override int PowerWatts() => Brightness / 10;

    /// <summary>Притлумити: зменшує яскравість удвічі.</summary>
    public void Dim() => Brightness /= 2;
}
