using M3.Payments.Contracts;

namespace M3.Payments.App;

/// <summary>
/// Оплата бонусами — списує бонусні бали (1 бал = 1 грн) замість грошей.
/// <para>Наслідується від: object. Реалізує: <see cref="IPayment"/> (спосіб оплати), <see cref="IRefundable"/> (повернення).</para>
/// </summary>
public class BonusPayment : IPayment
{
    /// <summary>Конструктор: бонусний рахунок із початковою кількістю балів.</summary>
    /// <param name="points">кількість балів</param>
    public BonusPayment(int points)
    {
        Points = points;
    }

    /// <summary>Бали — залишок бонусних балів.</summary>
    public int Points { get; private set; }

    /// <summary>Назва: «бонуси (N б.)». Явна реалізація (explicit implementation) <see cref="IPayment.Title"/>.</summary>
    string IPayment.Title => $"бонуси ({Points} б.)";

    /// <summary>Оплатити балами; повертає false, якщо балів не вистачає. Реалізує <see cref="IPayment.Pay"/>.</summary>
    /// <param name="amount">сума, грн</param>
    public bool Pay(int amount)
    {
        if (amount > Points)
            return false;

        Points -= amount;
        return true;
    }

    /// <summary>Повернення бонусів: кидає виняток NotSupportedException. Явна реалізація (explicit implementation) <see cref="IRefundable.Refund"/>.</summary>
    /// <param name="amount">сума повернення, грн</param>
    //void IRefundable.Refund(int amount) =>
    //    throw new NotSupportedException("Бонуси не повертаються");
}
