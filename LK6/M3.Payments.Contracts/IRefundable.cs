namespace M3.Payments.Contracts;

/// <summary>
/// Повернення коштів — інтерфейс (контракт) для способів оплати, що дозволяють повернути гроші.
/// <para>Контракт: клас, що реалізує цей інтерфейс, гарантує — Refund повертає гроші й не кидає винятків.</para>
/// <para>Реалізації (класи, що виконують цей контракт) — у проєкті M3.Payments.App.</para>
/// </summary>
public interface IRefundable
{
    /// <summary>Повернути гроші.</summary>
    /// <param name="amount">сума повернення, грн</param>
    void Refund(int amount);
}
