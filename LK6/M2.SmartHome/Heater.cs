namespace M2.SmartHome;

/// <summary>
/// Обігрівач — нагрівальний пристрій із рівнем потужності від 1 до 3.
/// <para>Наслідується від: <see cref="Device"/> (пристрій). Нащадок: <see cref="OilHeater"/> (масляний обігрівач).</para>
/// </summary>
public class Heater : Device
{
    /// <summary>Рівень потужності обігрівача (1–3).</summary>
    private readonly int _level;

    /// <summary>Конструктор: створює обігрівач із назвою і рівнем потужності.</summary>
    /// <param name="name">назва (кімната)</param>
    /// <param name="level">рівень 1–3</param>
    public Heater(string name, int level) : base(name)
    {
        _level = level;
    }

    /// <summary>Опис обігрівача. Перевизначає (override) <see cref="Device.Describe"/>.</summary>
    public override string Describe() => $"обігрівач {Name}";

    /// <summary>Потужність: 500 Вт × рівень. Позначено sealed override (перевизначає <see cref="Device.PowerWatts"/>, модифікатор sealed — «запечатаний»).</summary>
    public override int PowerWatts() => 500 * _level;

    /// <summary>Стан: попередження, якщо рівень 3 і вище, інакше — стан батьківського класу. Перевизначає (override) <see cref="Device.Status"/>.</summary>
    public override string Status() => _level >= 3 ? "увага, висока потужність" : base.Status();
}
