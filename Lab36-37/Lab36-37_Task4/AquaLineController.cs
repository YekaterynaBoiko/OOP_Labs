using System;

namespace Lab36_37_Task4
{
    /// <summary>
    /// Блок керування поливом моделі AquaLine.
    /// </summary>
    public class AquaLineController : IWateringController
    {
        /// <summary>
        /// Поточна вологість ґрунту у відсотках.
        /// </summary>
        private int soilMoisture = 25;

        /// <summary>
        /// Зчитує показання датчика вологості ґрунту.
        /// </summary>
        /// <returns>Вологість ґрунту у відсотках.</returns>
        public int ReadSoilMoisture()
        {
            Console.WriteLine($"[AquaLine] Датчик: вологість ґрунту {soilMoisture} %");
            return soilMoisture;
        }

        /// <summary>
        /// Відкриває клапан подачі води.
        /// </summary>
        public void OpenValve()
        {
            Console.WriteLine("[AquaLine] Клапан відкрито");
        }

        /// <summary>
        /// Закриває клапан після подачі порції води.
        /// </summary>
        public void CloseValve()
        {
            // Порція води підвищує вологість ґрунту.
            soilMoisture += 40;
            Console.WriteLine("[AquaLine] Клапан закрито");
        }
    }
}
