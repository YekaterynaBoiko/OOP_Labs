namespace M4.Shop;

/// <summary>
/// Гарантія — інтерфейс для товарів, на які магазин дає гарантію.
/// </summary>
public interface IWarranty
{
    /// <summary>Термін гарантії, місяців.</summary>
    int Months { get; }
}
