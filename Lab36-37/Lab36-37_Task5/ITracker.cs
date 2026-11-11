namespace Lab36_37_Task5
{
    /// <summary>
    /// Носимий смарт-пристрій.
    /// </summary>
    public interface ITracker
    {
        /// <summary>
        /// Показує кількість кроків за день.
        /// </summary>
        void ShowSteps();

        /// <summary>
        /// Показує поточний пульс.
        /// </summary>
        void ShowPulse();
    }
}
