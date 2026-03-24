using System;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            string[] xLabels = HistogramLogic.GetXLabels();
            double[] yValues = HistogramLogic.GetBirthCounts(names, name);

            return new HistogramData(
                string.Format("Народжуваність людей з ім'ям '{0}'", name),
                xLabels,
                yValues);

        }
    }
}