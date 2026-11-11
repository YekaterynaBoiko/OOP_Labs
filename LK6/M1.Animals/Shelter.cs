namespace M1.Animals;

/// <summary>
/// Притулок — зберігає всіх прийнятих тварин в одному списку і виконує з ними дії.
/// <para>Наслідується від: object.</para>
/// </summary>
public class Shelter
{
    /// <summary>Список усіх тварин у притулку (елементи типу <see cref="Animal"/>).</summary>
    private readonly List<Animal> _animals = new List<Animal>();

    /// <summary>Кількість тварин у притулку.</summary>
    public int Count => _animals.Count;

    /// <summary>Прийняти тварину: додає її до списку і друкує картку.</summary>
    /// <param name="animal">тварина, що надходить</param>
    public void Accept(Animal animal)
    {
        _animals.Add(animal);
        Console.WriteLine($"Прийнято: {animal}");
    }

    /// <summary>Скільки корму на день потрібно всім тваринам разом, г.</summary>
    public int TotalFood()
    {
        int sum = 0;
        foreach (Animal a in _animals)
            sum += a.Food();
        return sum;
    }

    /// <summary>Вигуляти всіх собак у притулку.</summary>
    public void WalkAllDogs()
    {
        foreach (Animal a in _animals)
        {
            if (a is Dog dog && a is not Puppy)
                dog.Walk();
        }
    }

    /// <summary>Погратися з усіма цуценятами в притулку.</summary>
    public void PlayWithPuppies()
    {
        foreach (Animal a in _animals)
        {
            Puppy puppy = a as Puppy;
            if (puppy != null)
                puppy.Play();
        }
    }

    /// <summary>Порахувати сторожових собак у притулку.</summary>
    public int CountGuards()
    {
        int count = 0;
        foreach (Animal a in _animals)
        {
            if (a is Dog d)
                if (d.Guard)
                    count++;
        }
        return count;
    }

    /// <summary>Знайти тварину за кличкою. Повертає null, якщо такої немає.</summary>
    /// <param name="name">кличка, яку шукаємо</param>
    public Animal FindByName(string name)
    {
        foreach (Animal a in _animals)
        {
            if (a.Name == name)
                return a;
        }
        return null;
    }
}
