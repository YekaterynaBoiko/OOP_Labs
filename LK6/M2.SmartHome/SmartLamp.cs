namespace M2.SmartHome;

/// <summary>
/// Розумна лампа — лампа з підключенням до мережі; завжди створюється з яскравістю 80%.
/// <para>Наслідується від: <see cref="Lamp"/> (лампа), а та — від <see cref="Device"/> (пристрій).</para>
/// </summary>
public class SmartLamp : Lamp
{
    /// <summary>Конструктор: розумна лампа з назвою і яскравістю 80%.</summary>
    /// <param name="name">назва (кімната)</param>
    public SmartLamp(string name) : base(name, 80)
    {
    }

    /// <summary>Опис розумної лампи. Оголошено з модифікатором new.</summary>
    public override string Describe() => $"розумна лампа {Name}";

    /// <summary>Стан: «онлайн, » + стан батьківського класу. Перевизначає (override) <see cref="Device.Status"/>.</summary>
    public override string Status() => "онлайн, " + base.Status();
}
