namespace M3.Payments.Contracts;

/// <summary>
/// Оплата (спосіб оплати) — інтерфейс (контракт), який реалізує кожен спосіб оплати.
/// <para>Контракт: Pay повертає true, якщо гроші списано, і false, якщо ні.
/// Через нестачу коштів Pay НЕ кидає винятків.</para>
/// <para>Реалізації (класи, що виконують цей контракт) — у проєкті M3.Payments.App.</para>
/// </summary>
public interface IPayment
{
    /// <summary>Назва способу оплати для чека, напр. «готівка».</summary>
    string Title { get; }

    /// <summary>Оплатити суму.</summary>
    /// <param name="amount">сума, грн</param>
    /// <returns>true — гроші списано; false — оплата не пройшла.</returns>
    bool Pay(int amount);
}
