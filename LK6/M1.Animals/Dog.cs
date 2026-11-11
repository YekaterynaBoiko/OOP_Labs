namespace M1.Animals;

/// <summary>
/// Собака — тварина, яку можна вигуляти; буває сторожовою.
/// <para>Наслідується від: <see cref="Animal"/> (тварина). Нащадок: <see cref="Puppy"/> (цуценя).</para>
/// </summary>
public class Dog : Animal
{
    /// <summary>Сторожова (true) — охороняє двір, їсть більше.</summary>
    public bool Guard { get; }

    /// <summary>Чи собаку вже вигуляли.</summary>
    public bool IsWalked { get; private set; }

    /// <summary>Конструктор: створює собаку із заданою кличкою, вагою і ознакою «сторожова».</summary>
    /// <param name="name">кличка</param>
    /// <param name="weightKg">вага, кг</param>
    /// <param name="guard">чи сторожова</param>
    public Dog(string name, int weightKg, bool guard) : base(name, weightKg)
    {
        Guard = guard;
    }

    /// <summary>Вигуляти: позначає собаку вигуляною і друкує повідомлення.</summary>
    public void Walk()
    {
        IsWalked = true;
        Console.WriteLine($"  {Name}: вигуляно");
    }

    /// <summary>Порція корму собаки: порція тварини + 25 г, якщо сторожова. Перевизначає (override) <see cref="Animal.Food"/>.</summary>
    public override int Food() => base.Food() + (Guard ? 25 : 0);

    /// <summary>Картка собаки: картка тварини + «[СТОРОЖ]», якщо сторожова. Перевизначає (override) <see cref="Animal.Info"/>.</summary>
    public override string Info() => base.Info() + (Guard ? " [СТОРОЖ]" : "");
}
