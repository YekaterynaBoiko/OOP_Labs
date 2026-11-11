using System;

namespace Lab36_37_Task5
{
    /// <summary>
    /// Фітнес-браслет.
    /// </summary>
    public class FitnessBand : ITracker
    {
        /// <summary>
        /// Показує кількість кроків за день.
        /// </summary>
        public void ShowSteps()
        {
            Console.WriteLine("Кроків за день: 6120");
        }

        /// <summary>
        /// Показує поточний пульс.
        /// </summary>
        public void ShowPulse()
        {
            Console.WriteLine("Пульс: 68 уд/хв");
        }
    }
}
