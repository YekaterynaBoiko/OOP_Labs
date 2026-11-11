using M3.Payments.Contracts;

namespace M3.Payments.App;

/// <summary>
/// Каса — проводить оплати, зберігає історію успішних оплат, друкує чек і вміє скасувати всі оплати.
/// <para>Наслідується від: object.</para>
/// </summary>
public class Checkout
{
    /// <summary>Історія успішних оплат (елементи типу <see cref="Transaction"/>).</summary>
    private readonly List<Transaction> _history = new List<Transaction>();

    /// <summary>Провести оплату вказаним способом, надрукувати результат; успішну оплату записати в історію.</summary>
    /// <param name="method">спосіб оплати</param>
    /// <param name="amount">сума, грн</param>
    /// <returns>true — оплата пройшла.</returns>
    public bool Process(IPayment method, int amount)
    {
        bool ok = method.Pay(amount);
        Console.WriteLine($"{method.Title}: {amount} грн → {(ok ? "успіх" : "відмова")}");
        if (ok)
            _history.Add(new Transaction(method, amount));
        return ok;
    }

    /// <summary>Надрукувати чек: кожна успішна оплата з історії окремим рядком.</summary>
    public void PrintReceipt()
    {
        foreach (Transaction t in _history)
        {
            Console.WriteLine($"  {t.Method.Title} — {t.Amount} грн");
            if (t.Method is CardPayment cardPayment)
                Console.WriteLine($"Залишок на карті: {cardPayment.Balance} грн");
        }
    }

    /// <summary>Скасувати всі оплати з історії: повернути гроші, де це можливо, і очистити історію.</summary>
    public void CancelAll()
    {
        foreach (Transaction t in _history)
        {
            if (t.Method is IRefundable refundable)
                refundable.Refund(t.Amount);
            else
                Console.WriteLine($"  {t.Method.Title}: повернення неможливе");
        }
        _history.Clear();
    }

    /// <summary>Сумарна комісія за всіма успішними оплатами, грн (поки не реалізовано — повертає 0).</summary>
    public int TotalFees()
    {
        int sum = 0;
        foreach (Transaction t in _history)
        {
            if (t.Method is IHasFee hasFee)
            {
                sum += hasFee.FeeFor(t.Amount); 
            }
        }
        return sum;
    }
}
