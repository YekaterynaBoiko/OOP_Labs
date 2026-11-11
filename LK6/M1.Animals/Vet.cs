namespace M1.Animals;

/// <summary>
/// Ветеринар — статичний клас (static, об'єктів не створює) з трьома варіантами огляду: метод Examine для тварини, собаки і кота.
/// <para>Наслідується від: object.</para>
/// </summary>
public static class Vet
{
    /// <summary>Огляд тварини: вітаміни = порція корму / 10, г.</summary>
    /// <param name="a">тварина</param>
    public static string Examine(Animal a) => $"{a.Name}: загальний огляд, вітамінів {a.Food() / 10} г";

    /// <summary>Огляд собаки: вітаміни = порція корму / 5, г.</summary>
    /// <param name="d">собака</param>
    public static string Examine(Dog d) => $"{d.Name}: огляд собаки, вітамінів {d.Food() / 5} г";

    /// <summary>Огляд кота: без вітамінів.</summary>
    /// <param name="c">кіт</param>
    public static string Examine(Cat c) => $"{c.Name}: огляд кота, без вітамінів";
}
