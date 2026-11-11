namespace M2.SmartHome;

/// <summary>
/// Пристрій розумного дому — абстрактний базовий клас (abstract): напряму створити об'єкт не можна, лише нащадків.
/// <para>Наслідується від: object. Нащадки: <see cref="Lamp"/> (лампа), <see cref="Heater"/> (обігрівач).</para>
/// </summary>
public abstract class Device
{
    /// <summary>Назва пристрою — кімната, де він стоїть, напр. «Кухня».</summary>
    public string Name { get; }

    /// <summary>Конструктор (protected — доступний лише нащадкам): запам'ятовує назву і друкує рядок «+ опис», викликаючи <see cref="Describe"/>.</summary>
    /// <param name="name">назва пристрою</param>
    protected Device(string name)
    {
        Name = name;
        Console.WriteLine($"+ {Describe()}");
    }

    /// <summary>Опис пристрою для звіту. Віртуальний метод (virtual).</summary>
    public virtual string Describe() => $"пристрій {Name}";

    /// <summary>Потужність пристрою, ват. Абстрактний метод (abstract) — без тіла.</summary>
    public abstract int PowerWatts();

    /// <summary>Стан пристрою для звіту, за замовчуванням «ок». Віртуальний метод (virtual).</summary>
    public virtual string Status() => "ок";

    /// <summary>Увімкнути: друкує назву і потужність. Звичайний метод (не virtual).</summary>
    public void TurnOn() => Console.WriteLine($"{Name}: увімкнено, {PowerWatts()} Вт");
}
