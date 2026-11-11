namespace M4.Shop;

/// <summary>
/// Телефон — товар із гарантією 12 місяців; за гарантію доплачують 10 грн за кожен місяць.
/// <para>Наслідується від: <see cref="Product"/> (товар). Реалізує: <see cref="IWarranty"/> (гарантія). Нащадок: <see cref="SmartPhone"/> (смартфон).</para>
/// </summary>
public class Phone : Product, IWarranty
{
    /// <summary>Конструктор: телефон із назвою і кількістю на складі.</summary>
    /// <param name="name">назва</param>
    /// <param name="stock">кількість на складі, шт.</param>
    public Phone(string name, int stock) : base(name, stock)
    {
    }

    /// <summary>Гарантія телефону — 12 місяців. Реалізує <see cref="IWarranty.Months"/>.</summary>
    public int Months => 12;

    /// <summary>Ціна телефону — 5000 грн. Перевизначає (override) <see cref="Product.Price"/>.</summary>
    public override int Price() => 5000;

    /// <summary>Вартість покупки: ціна × кількість + 10 грн за кожен місяць гарантії. Перевизначає (override) <see cref="Product.Total"/>.</summary>
    /// <param name="qty">кількість, шт.</param>
    public override int Total(int qty) => base.Total(qty) + Months * 10;
}
