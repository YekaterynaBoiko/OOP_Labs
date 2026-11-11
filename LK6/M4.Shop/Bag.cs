namespace M4.Shop;

/// <summary>
/// Пакет — пакет на касі за 3 грн.
/// <para>Наслідується від: <see cref="Product"/> (товар).</para>
/// </summary>
public class Bag : Product
{
    /// <summary>Конструктор: пакет із назвою і кількістю на складі.</summary>
    /// <param name="name">назва</param>
    /// <param name="stock">кількість на складі, шт.</param>
    public Bag(string name, int stock) : base(name, stock)
    {
    }

    /// <summary>Ціна пакета — 3 грн. Перевизначає (override) <see cref="Product.Price"/>.</summary>
    public override int Price() => 3;
}
