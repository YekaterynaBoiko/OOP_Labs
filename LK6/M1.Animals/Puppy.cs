namespace M1.Animals;

/// <summary>
/// Цуценя — молода собака; з ним можна гратися.
/// <para>Наслідується від: <see cref="Dog"/> (собака), а та — від <see cref="Animal"/> (тварина).</para>
/// </summary>
public class Puppy : Dog
{
    /// <summary>Вік цуценяти, місяців (вага — 2 кг на кожен місяць).</summary>
    public int Months { get; }

    /// <summary>Конструктор: цуценя заданого віку; вага = 2 кг × місяці, цуценя не сторожове.</summary>
    /// <param name="name">кличка</param>
    /// <param name="months">вік, місяців</param>
    public Puppy(string name, int months) : base(name, months * 2, guard: false)
    {
        Months = months;
    }

    /// <summary>Погратися: друкує повідомлення з віком цуценяти.</summary>
    public void Play() => Console.WriteLine($"  {Name}: грається ({Months} міс.)");

    /// <summary>Порція корму цуценяти: порція собаки + 30 г (бо росте). Перевизначає (override) <see cref="Dog.Food"/>.</summary>
    public override int Food() => base.Food() + 30;
}
