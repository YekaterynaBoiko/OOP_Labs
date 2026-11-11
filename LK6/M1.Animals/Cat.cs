namespace M1.Animals;

/// <summary>
/// Кіт — тварина вагою 4 кг; буває домашнім або вуличним.
/// <para>Наслідується від: <see cref="Animal"/> (тварина).</para>
/// </summary>
public class Cat : Animal
{
    /// <summary>Домашній (true) — живе в квартирі; false — вуличний.</summary>
    public bool Indoor { get; }

    /// <summary>Конструктор: створює кота (вага завжди 4 кг).</summary>
    /// <param name="name">кличка</param>
    /// <param name="indoor">чи домашній</param>
    public Cat(string name, bool indoor) : base(name, 4)
    {
        Indoor = indoor;
    }

    /// <summary>Порція корму кота: 60 г, якщо домашній, інакше 80 г. Перевизначає (override) <see cref="Animal.Food"/>.</summary>
    public override int Food() => Indoor ? 60 : 80;

    /// <summary>Картка кота для друку. Перевизначає (override) <see cref="Animal.Info"/>.</summary>
    public override string Info() => $"[{Name}] кіт" + (Indoor ? " (домашній)" : "");
}
