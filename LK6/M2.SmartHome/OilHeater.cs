namespace M2.SmartHome;

/// <summary>
/// Масляний обігрівач — обігрівач із масляним радіатором; завжди рівень 1.
/// <para>Наслідується від: <see cref="Heater"/> (обігрівач), а той — від <see cref="Device"/> (пристрій).</para>
/// </summary>
public class OilHeater : Heater
{
    /// <summary>Конструктор: масляний обігрівач із назвою, рівень 1.</summary>
    /// <param name="name">назва (кімната)</param>
    public OilHeater(string name) : base(name, 1)
    {
    }

    /// <summary>Опис: «масляний » + опис обігрівача. Перевизначає (override) <see cref="Heater.Describe"/>.</summary>
    public override string Describe() => "масляний " + base.Describe();

    /// <summary>Потужність масляного обігрівача — 150 Вт. Оголошено з модифікатором new.</summary>
    public override int PowerWatts() => 150;
}
