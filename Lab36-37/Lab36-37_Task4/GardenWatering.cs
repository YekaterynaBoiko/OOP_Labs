namespace Lab36_37_Task4
{
    /// <summary>
    /// Автоматичний полив садової ділянки.
    /// </summary>
    public class GardenWatering
    {
        /// <summary>
        /// Блок керування, який виконує полив.
        /// </summary>
        private readonly IWateringController wateringController;

        /// <summary>
        /// Мінімальна допустима вологість ґрунту у відсотках.
        /// </summary>
        private readonly int minMoisture;

        /// <summary>
        /// Кількість виконаних поливів.
        /// </summary>
        public int WateringCount { get; private set; }

        /// <summary>
        /// Створює систему поливу із заданою межею вологості.
        /// </summary>
        /// <param name="minMoisture">Мінімальна допустима вологість ґрунту у відсотках.</param>
        public GardenWatering(IWateringController wateringController, int minMoisture)
        {
            this.wateringController = wateringController;
            this.minMoisture = minMoisture;
        }

        /// <summary>
        /// Перевіряє вологість ґрунту та поливає ділянку, якщо ґрунт сухий.
        /// </summary>
        public void WaterIfDry()
        {
            if (wateringController.ReadSoilMoisture() < minMoisture)
            {
                wateringController.OpenValve();
                wateringController.CloseValve();
                WateringCount++;
            }
        }
    }
}
