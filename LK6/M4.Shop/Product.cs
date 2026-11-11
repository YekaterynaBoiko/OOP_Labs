namespace M4.Shop;

/// <summary>
/// Товар — абстрактний базовий клас (abstract) для всіх товарів магазину: назва і кількість на складі.
/// <para>Наслідується від: object. Нащадки: <see cref="Phone"/> (телефон), <see cref="Bread"/> (хліб), <see cref="Clothes"/> (одяг), <see cref="Bag"/> (пакет).</para>
/// </summary>
public abstract class Product
{
    /// <summary>Конструктор (protected — доступний лише нащадкам): товар із назвою і кількістю на складі.</summary>
    /// <param name="name">назва товару</param>
    /// <param name="stock">кількість на складі, шт.</param>
    protected Product(string name, int stock)
    {
        Name = name;
        Stock = stock;
    }

    /// <summary>Назва товару.</summary>
    public string Name { get; }

    /// <summary>Залишок — скільки штук є на складі.</summary>
    public int Stock { get; private set; }

    /// <summary>Чи є товар у наявності (залишок більше 0).</summary>
    public bool InStock => Stock > 0;

    /// <summary>Ціна за 1 шт., грн. Абстрактний метод (abstract) — без тіла.</summary>
    public abstract int Price();

    /// <summary>Вартість покупки qty штук, грн: ціна × кількість. Віртуальний метод (virtual).</summary>
    /// <param name="qty">кількість, шт.</param>
    public virtual int Total(int qty) => Price() * qty;

    /// <summary>Продати qty штук: зменшує залишок на складі, але не нижче 0.</summary>
    /// <param name="qty">кількість, шт.</param>
    public void Sell(int qty)
    {
        Stock = Math.Max(0, Stock - qty);
    }

    /// <summary>Рядок «Назва (N шт.)». Перевизначає (override) object.ToString().</summary>
    public override string ToString() => $"{Name} ({Stock} шт.)";
}
