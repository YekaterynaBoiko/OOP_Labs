using M3.Payments.Contracts;

namespace M3.Payments.App;

/// <summary>
/// Оплата готівкою — без комісії, завжди успішна.
/// <para>Наслідується від: object. Реалізує: <see cref="IPayment"/> (спосіб оплати).</para>
/// </summary>
public class CashPayment : IPayment
{
    /// <summary>Назва: «готівка». Реалізує <see cref="IPayment.Title"/>.</summary>
    public string Title => "готівка";

    /// <summary>Оплатити готівкою: друкує прийняту суму і повертає true. Реалізує <see cref="IPayment.Pay"/>.</summary>
    /// <param name="amount">сума, грн</param>
    public bool Pay(int amount)
    {
        Console.WriteLine($"  прийнято {amount} грн готівкою");
        return true;
    }
}
