using System.Text;

namespace M1.Animals;

/// <summary>Програма (точка входу): по черзі запускає сценарії S1–S4; S5 у Main закоментований.</summary>
internal static class Program
{
    /// <summary>Головний метод: вмикає українську в консолі й запускає сценарії.</summary>
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        S1_OneObject();
        S2_Shelter();
        S3_Search();
        S4_Vet();
        S5_GuardCount();
    }

    /// <summary>Сценарій 1: одне цуценя, присвоєне змінним різних типів.</summary>
    private static void S1_OneObject()
    {
        Header("S1. Один об'єкт");
        Puppy puppy = new Puppy("Бобік", 4); 
        Dog dog = puppy; 
        Animal animal = dog;
        object obj = animal;

        Console.WriteLine(ReferenceEquals(puppy, obj));
        Console.WriteLine(obj.GetType().Name);
        Console.WriteLine(animal.Food());
        Console.WriteLine(obj);
        Console.WriteLine(dog.Guard);

        ((Puppy)obj).Play();

        //Cat s = (Cat)animal; 
    }

    /// <summary>Сценарій 2: притулок приймає чотирьох тварин, рахує корм, вигулює собак і грається з цуценятами.</summary>
    private static void S2_Shelter()
    {
        Header("S2. Притулок");
        var shelter = new Shelter();
        shelter.Accept(new Cat("Мурка", indoor: true));
        shelter.Accept(new Dog("Рекс", 30, guard: true));
        shelter.Accept(new Puppy("Шарик", 2));
        shelter.Accept(new Dog("Тузик", 10, guard: false));

        Console.WriteLine($"Корму на день: {shelter.TotalFood()} г");
        shelter.WalkAllDogs();
        shelter.PlayWithPuppies();
    }

    /// <summary>Сценарій 3: пошук тварин у притулку за кличкою.</summary>
    private static void S3_Search()
    {
        Header("S3. Пошук");
        var shelter = new Shelter();
        shelter.Accept(new Dog("Барон", 25, guard: true));
        shelter.Accept(new Cat("Пушок", indoor: false));
        shelter.Accept(new Puppy("Рижик", 3));

        Animal found = shelter.FindByName("Рижик");
        Console.WriteLine(found.Food());
        Console.WriteLine(found is Dog);
        Console.WriteLine(found.GetType() == typeof(Dog));

        Dog asDog = shelter.FindByName("Пушок") as Dog;
        Console.WriteLine(asDog == null);

        if (found is Puppy puppy)
        {
            Console.WriteLine(puppy.Months);
        }

        found = shelter.FindByName("bob"); 
    }

    /// <summary>Сценарій 4: ветеринар оглядає трьох тварин.</summary>
    private static void S4_Vet()
    {
        Header("S4. Ветеринар");
        Animal a1 = new Dog("Лорд", 5, guard: true);
        Dog a2 = new Puppy("Бім", 1);
        var a3 = new Cat("Сніжок", indoor: false);

        Console.WriteLine(Vet.Examine(a1));
        Console.WriteLine(Vet.Examine(a2));
        Console.WriteLine(Vet.Examine(a3));
        Console.WriteLine(Vet.Examine((Animal)a3));
        Console.WriteLine(Vet.Examine((Dog)a1));
    }

    /// <summary>Сценарій 5: підрахунок сторожових собак у притулку.</summary>
    private static void S5_GuardCount()
    {
        Header("S5. Сторожові");
        var shelter = new Shelter();
        shelter.Accept(new Dog("Джек", 20, guard: true));
        shelter.Accept(new Cat("Муся", indoor: true));
        shelter.Accept(new Puppy("Лакі", 3));

        Console.WriteLine($"Сторожових: {shelter.CountGuards()}");
    }

    /// <summary>Друкує заголовок сценарію.</summary>
    private static void Header(string title) => Console.WriteLine($"\n=== {title} ===");
}