using System.Text;
using M3.Payments.Contracts;

namespace M3.Payments.App;

/// <summary>Програма (точка входу): по черзі запускає сценарії S1–S4; S5 у Main закоментований.</summary>
internal static class Program
{
    /// <summary>Головний метод: вмикає українську в консолі й запускає сценарії.</summary>
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        S1_Checkout();
        S2_Explicit();
        S3_Fees();
        S4_Receipt();
        S5_CancelAll();
    }

    /// <summary>Сценарій 1: каса проводить чотири оплати трьома способами; друк залишку картки і суми комісій.</summary>
    private static void S1_Checkout()
    {
        Header("S1. Каса");
        var card = new CardPayment("4417", 1000);
        var cash = new CashPayment();
        var bonus = new BonusPayment(150);
        // amount + 2 / 100
        var checkout = new Checkout();
        checkout.Process(card, 500);
        checkout.Process(cash, 200);
        checkout.Process(bonus, 100);
        checkout.Process(card, 600);

        Console.WriteLine($"Залишок на картці: {card.Balance}");
        Console.WriteLine($"Комісії: {checkout.TotalFees()}");
    }

    /// <summary>Сценарій 2: бонусна оплата через змінну типу інтерфейсу.</summary>
    private static void S2_Explicit()
    {
        Header("S2. Бонуси");
        BonusPayment bonus = new BonusPayment(40);
        IPayment method = bonus;

        Console.WriteLine(method.Title);
        Console.WriteLine(method.Pay(50));
        Console.WriteLine(bonus.Points);
        Console.WriteLine(method is IRefundable);
        Console.WriteLine($"Навза бонусів: {method.Title}");
    }

    /// <summary>Сценарій 3: одна картка у змінних різних інтерфейсів, комісія з 1000 грн і перевірки is.</summary>
    private static void S3_Fees()
    {
        Header("S3. Комісії");
        CardPayment card = new CardPayment("1111", 5000);
        IHasFee fee = card;
        IPayment pay = card;
        IPayment cash = new CashPayment();

        Console.WriteLine(fee.FeeFor(1000));
        Console.WriteLine(pay is IRefundable);
        Console.WriteLine(cash is IHasFee);
        Console.WriteLine(ReferenceEquals(fee, pay));
    }

    /// <summary>Сценарій 4: три оплати й друк чека.</summary>
    private static void S4_Receipt()
    {
        Header("S4. Чек");
        var checkout = new Checkout();
        checkout.Process(new CardPayment("5555", 3000), 1200);
        checkout.Process(new CashPayment(), 80);
        checkout.Process(new BonusPayment(500), 300);

        Console.WriteLine("Чек:");
        checkout.PrintReceipt();
    }

    /// <summary>Сценарій 5: три оплати, потім скасування всіх.</summary>
    private static void S5_CancelAll()
    {
        Header("S5. Скасування");
        var checkout = new Checkout();
        checkout.Process(new CardPayment("2222", 1000), 100);
        checkout.Process(new CashPayment(), 50);
        checkout.Process(new BonusPayment(500), 70);
        checkout.CancelAll();
    }

    /// <summary>Друкує заголовок сценарію.</summary>
    private static void Header(string title) => Console.WriteLine($"\n=== {title} ===");
}
