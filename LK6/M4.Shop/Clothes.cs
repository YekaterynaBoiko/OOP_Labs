namespace M4.Shop;

/// <summary>
/// Одяг — товар за 800 грн, продається зі знижкою 30% (розпродаж).
/// <para>Наслідується від: <see cref="Product"/> (товар). Реалізує: <see cref="IDiscount"/> (знижка).</para>
/// </summary>
public class Clothes : Product, IDiscount
{
    /// <summary>Конструктор: одяг із назвою і кількістю на складі.</summary>
    /// <param name="name">назва</param>
    /// <param name="stock">кількість на складі, шт.</param>
    public Clothes(string name, int stock) : base(name, stock)
    {
    }

    /// <summary>Знижка на одяг — 30%. Реалізує <see cref="IDiscount.Percent"/>.</summary>
    public int Percent => 30;

    /// <summary>Ціна одягу — 800 грн. Перевизначає (override) <see cref="Product.Price"/>.</summary>
    public override int Price() => 800;
}
