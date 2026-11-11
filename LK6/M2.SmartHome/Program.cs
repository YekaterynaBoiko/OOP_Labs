using System.Text;

namespace M2.SmartHome;

/// <summary>Програма (точка входу): по черзі запускає сценарії S1–S4.</summary>
internal static class Program
{
    /// <summary>Головний метод: вмикає українську в консолі й запускає сценарії.</summary>
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        S1_Describe();
        S2_Hub();
        S3_Hiding();
        S4_Night();
    }

    /// <summary>Сценарій 1: звичайна і дві розумні лампи в змінних різних типів, друк опису кожної.</summary>
    private static void S1_Describe()
    {
        Header("S1. Опис пристроїв");
        Device a = new Lamp("Кухня", 60);
        Lamp b = new SmartLamp("Спальня");
        SmartLamp c = new SmartLamp("Кабінет");

        Console.WriteLine(a.Describe());
        Console.WriteLine(b.Describe());
        Console.WriteLine(c.Describe());
        Console.WriteLine(((Device)c).Describe());
    }

    /// <summary>Сценарій 2: хаб із чотирьох пристроїв — увімкнення, сумарна потужність, звіт.</summary>
    private static void S2_Hub()
    {
        Header("S2. Хаб");
        var hub = new Hub();
        hub.Add(new Lamp("Коридор", 100));
        hub.Add(new SmartLamp("Вітальня"));
        hub.Add(new Heater("Ванна", 2));
        hub.Add(new OilHeater("Балкон"));

        hub.TurnAllOn();
        Console.WriteLine($"Сумарно: {hub.TotalPower()} Вт");
        hub.Report();
    }

    /// <summary>Сценарій 3: один масляний обігрівач у трьох змінних різних типів.</summary>
    private static void S3_Hiding()
    {
        Header("S3. Масляний обігрівач");
        OilHeater oil = new OilHeater("Гараж");
        Heater heater = oil;
        Device device = oil;

        Console.WriteLine(oil.PowerWatts());
        Console.WriteLine(heater.PowerWatts());
        Console.WriteLine(device.PowerWatts());
        oil.TurnOn();
    }

    /// <summary>Сценарій 4: нічний режим хабу і звіт після нього.</summary>
    private static void S4_Night()
    {
        Header("S4. Нічний режим");
        var hub = new Hub();
        hub.Add(new Lamp("Двір", 90));
        hub.Add(new Heater("Підвал", 3));
        hub.Add(new SmartLamp("Дитяча"));

        hub.NightMode();
        hub.Report();
    }

    /// <summary>Друкує заголовок сценарію.</summary>
    private static void Header(string title) => Console.WriteLine($"\n=== {title} ===");
}
