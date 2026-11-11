namespace M4.Shop;

/// <summary>
/// Смартфон — телефон із сенсорним екраном; дорожчий за звичайний і продається зі знижкою 10%.
/// <para>Наслідується від: <see cref="Phone"/> (телефон), а той — від <see cref="Product"/> (товар). Реалізує: <see cref="IDiscount"/> (знижка).</para>
/// </summary>
public class SmartPhone : Phone, IDiscount
{
    /// <summary>Конструктор: смартфон із назвою і кількістю на складі.</summary>
    /// <param name="name">назва</param>
    /// <param name="stock">кількість на складі, шт.</param>
    public SmartPhone(string name, int stock) : base(name, stock)
    {
    }

    /// <summary>Знижка на смартфон — 10%. Реалізує <see cref="IDiscount.Percent"/>.</summary>
    public int Percent => 10;

    /// <summary>Ціна смартфона: ціна телефону + 3000 грн. Перевизначає (override) <see cref="Phone.Price"/>.</summary>
    public override int Price() => base.Price() + 3000;
}
