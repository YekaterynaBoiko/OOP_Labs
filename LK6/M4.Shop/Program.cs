using System.Text;

namespace M4.Shop;

/// <summary>Програма (точка входу): по черзі запускає сценарії S1–S3.</summary>
internal static class Program
{
    /// <summary>Головний метод: вмикає українську в консолі й запускає сценарії.</summary>
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        S1_Classify();
        S2_Sales();
        S3_OneSmartPhone();
    }

    /// <summary>Створити кошик із чотирьох товарів: телефон, хліб, куртка, смартфон.</summary>
    private static List<Product> CreateCart() => new List<Product>
    {
        new Phone("Телефон", 5),
        new Bread("Хліб", 2),
        new Clothes("Куртка", 4),
        new SmartPhone("Смартфон", 1)
    };

    /// <summary>Сценарій 1: категорія кожного товару в кошику, а також хліба без залишку і пакета.</summary>
    private static void S1_Classify()
    {
        Header("S1. Категорії");
        foreach (Product p in CreateCart())
            Console.WriteLine($"{p.Name}: {Shop.Classify(p)}");

        Console.WriteLine(Shop.Classify(new Bread("Батон", 0)));
        Console.WriteLine(Shop.Classify(new Bag("Пакет", 100)));
    }

    /// <summary>Сценарій 2: два покупці по черзі купують той самий кошик товарів.</summary>
    private static void S2_Sales()
    {
        Header("S2. Продаж");
        List<Product> cart = CreateCart();

        for (int buyer = 1; buyer <= 2; buyer++)
        {
            Console.WriteLine($"-- Покупець {buyer}");
            Shop.Sell(cart);
        }

        Console.WriteLine(string.Join(", ", cart));
        Console.WriteLine(Shop.Classify(cart[1]));
    }

    /// <summary>Сценарій 3: один смартфон у змінних трьох різних типів.</summary>
    private static void S3_OneSmartPhone()
    {
        Header("S3. Один смартфон");
        SmartPhone smart = new SmartPhone("Смартфон", 1);
        Phone phone = smart;
        IWarranty warranty = smart;
        IDiscount discount = smart;

        Console.WriteLine(phone.Price());
        Console.WriteLine(warranty.Months);
        Console.WriteLine(discount.Percent);
        Console.WriteLine(warranty is IDiscount);
        Console.WriteLine(new Clothes("Шапка", 1) is IWarranty);
        Console.WriteLine(((IDiscount)warranty).Percent);
    }

    /// <summary>Друкує заголовок сценарію.</summary>
    private static void Header(string title) => Console.WriteLine($"\n=== {title} ===");
}
