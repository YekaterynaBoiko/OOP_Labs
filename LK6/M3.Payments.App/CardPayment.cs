using M3.Payments.Contracts;

namespace M3.Payments.App;

/// <summary>
/// Оплата карткою — списує суму з балансу банківської картки разом із комісією 2%.
/// <para>Наслідується від: object. Реалізує: <see cref="IPayment"/> (спосіб оплати), <see cref="IRefundable"/> (повернення), <see cref="IHasFee"/> (комісія).</para>
/// </summary>
public class CardPayment : IPayment, IRefundable, IHasFee
{
    /// <summary>Останні 4 цифри номера картки.</summary>
    private readonly string _last4;

    /// <summary>Конструктор: картка з останніми цифрами номера і початковим балансом.</summary>
    /// <param name="last4">останні 4 цифри</param>
    /// <param name="balance">баланс, грн</param>
    public CardPayment(string last4, int balance)
    {
        _last4 = last4;
        Balance = balance;
    }

    /// <summary>Баланс — залишок коштів на картці, грн.</summary>
    public int Balance { get; private set; }

    /// <summary>Назва: «картка *1234». Реалізує <see cref="IPayment.Title"/>.</summary>
    public string Title => $"картка *{_last4}";

    /// <summary>Відсоток комісії картки — 2. Реалізує <see cref="IHasFee.FeePercent"/>.</summary>
    public int FeePercent => 2;

    /// <summary>Оплатити карткою: списує суму + комісію; повертає false, якщо коштів не вистачає. Реалізує <see cref="IPayment.Pay"/>.</summary>
    /// <param name="amount">сума, грн</param>
    public bool Pay(int amount)
    {
        int total = amount + ((IHasFee)this).FeeFor(amount);
        if (total > Balance)
            return false;

        Balance -= total;
        return true;
    }

    /// <summary>Повернути гроші на картку і надрукувати повідомлення. Реалізує <see cref="IRefundable.Refund"/>.</summary>
    /// <param name="amount">сума повернення, грн</param>
    public void Refund(int amount)
    {
        Balance += amount;
        Console.WriteLine($"  повернено {amount} грн → {Title}");
    }
}
