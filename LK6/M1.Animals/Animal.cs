namespace M1.Animals;

/// <summary>
/// Тварина — базовий клас для всіх тварин притулку: має кличку і вагу.
/// <para>Наслідується від: object. Нащадки: <see cref="Cat"/> (кіт), <see cref="Dog"/> (собака).</para>
/// </summary>
public class Animal
{
    /// <summary>Кличка тварини, напр. «Рекс».</summary>
    public string Name { get; }

    /// <summary>Вага тварини, кг.</summary>
    public int WeightKg { get; }

    /// <summary>Конструктор: створює тварину із заданою кличкою і вагою.</summary>
    /// <param name="name">кличка</param>
    /// <param name="weightKg">вага, кг</param>
    public Animal(string name, int weightKg)
    {
        Name = name;
        WeightKg = weightKg;
    }

    /// <summary>Порція корму на день, г: 50 + 10 г за кожен кілограм ваги. Віртуальний метод (virtual).</summary>
    public virtual int Food() => 50 + WeightKg * 10;

    /// <summary>Картка тварини — текстовий опис для друку. Віртуальний метод (virtual).</summary>
    public virtual string Info() => $"[{Name}] тварина {WeightKg} кг";

    /// <summary>Перетворення на рядок: повертає картку <see cref="Info"/>. Перевизначає (override) object.ToString().</summary>
    public override string ToString() => Info();
}
