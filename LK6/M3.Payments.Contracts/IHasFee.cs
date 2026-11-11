namespace M3.Payments.Contracts;

/// <summary>
/// Комісія — інтерфейс для способів оплати, які беруть комісію (відсоток від суми).
/// <para>Реалізації (класи, що виконують цей контракт) — у проєкті M3.Payments.App.</para>
/// </summary>
public interface IHasFee
{
    /// <summary>Відсоток комісії, напр. 2 означає 2%.</summary>
    int FeePercent { get; }

    /// <summary>Комісія за суму, грн: amount × FeePercent / 100. Метод із реалізацією за замовчуванням — тіло записано прямо в інтерфейсі.</summary>
    /// <param name="amount">сума оплати, грн</param>
    int FeeFor(int amount) => amount * FeePercent / 100;
}
