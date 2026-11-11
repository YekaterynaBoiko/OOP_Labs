namespace M4.Shop;

/// <summary>
/// Магазин (каса) — статичний клас (static) з правилами магазину: визначення категорії товару і продаж кошика.
/// <para>Наслідується від: object.</para>
/// </summary>
public static class Shop
{
    /// <summary>Визначити категорію товару за його типом і станом (switch-вираз із шаблонами).</summary>
    /// <param name="p">товар</param>
    /// <returns>Назва категорії українською.</returns>
    public static string Classify(Product p) => p switch
    {
        SmartPhone => "смартфон зі знижкою",
        Phone { Months: > 6 } => "телефон з гарантією",
        Phone => "телефон",
        Bread { Stock: 0 } => "хліб закінчився",
        Bread => "хліб",
        IDiscount => "товар зі знижкою",
        _ => "інше"
    };

    /// <summary>Продати покупцю кошик: по 1 шт. кожного товару, що є в наявності; знижка, якщо вона є; друк чека.</summary>
    /// <param name="cart">кошик — список товарів</param>
    /// <returns>Сума до сплати, грн.</returns>
    public static int Sell(List<Product> cart)
    {
        int sum = 0;
        foreach (Product p in cart)
        {
            if (!p.InStock)
            {
                Console.WriteLine($"  {p.Name}: немає в наявності");
                continue;
            }

            p.Sell(1);
            int price = p.Total(1);

            if (p is IDiscount d)
            {
                price -= price * d.Percent / 100;
                Console.WriteLine($"  {p.Name}: {price} грн (знижка {d.Percent}%)");
            }
            else
            {
                Console.WriteLine($"  {p.Name}: {price} грн");
            }

            sum += price;
        }

        Console.WriteLine($"  До сплати: {sum} грн");
        return sum;
    }
}
