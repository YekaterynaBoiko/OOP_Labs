namespace M4.Shop;

/// <summary>
/// Хліб — простий товар за 30 грн.
/// <para>Наслідується від: <see cref="Product"/> (товар).</para>
/// </summary>
public class Bread : Product
{
    /// <summary>Конструктор: хліб із назвою і кількістю на складі.</summary>
    /// <param name="name">назва</param>
    /// <param name="stock">кількість на складі, шт.</param>
    public Bread(string name, int stock) : base(name, stock)
    {
    }

    /// <summary>Ціна хліба — 30 грн. Перевизначає (override) <see cref="Product.Price"/>.</summary>
    public override int Price() => 30;
}
