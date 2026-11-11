namespace M4.Shop;

/// <summary>
/// Знижка — інтерфейс для товарів, які продаються зі знижкою.
/// </summary>
public interface IDiscount
{
    /// <summary>Розмір знижки, відсотків.</summary>
    int Percent { get; }
}
