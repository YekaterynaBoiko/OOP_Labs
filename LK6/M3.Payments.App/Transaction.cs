using M3.Payments.Contracts;

namespace M3.Payments.App;

/// <summary>
/// Транзакція — запис про одну успішну оплату: яким способом і на яку суму.
/// <para>Наслідується від: object.</para>
/// </summary>
public class Transaction
{
    /// <summary>Конструктор: запис про оплату.</summary>
    /// <param name="method">спосіб оплати</param>
    /// <param name="amount">сума, грн</param>
    public Transaction(IPayment method, int amount)
    {
        Method = method;
        Amount = amount;
    }

    /// <summary>Спосіб, яким оплачено (тип — інтерфейс <see cref="IPayment"/>).</summary>
    public IPayment Method { get; }

    /// <summary>Сума оплати, грн.</summary>
    public int Amount { get; }
}
