using System;

namespace Names;

internal static class HistogramSample
{
	public static HistogramData GetHistogramBirthsByYear(NameData[] names)
	{

        Console.WriteLine("Статистика народжуваності за роками");
        var minYear = int.MaxValue;
		var maxYear = int.MinValue;
		foreach (var name in names)
		{
			minYear = Math.Min(minYear, name.BirthDate.Year);
			maxYear = Math.Max(maxYear, name.BirthDate.Year);
		}

		var years = new string[maxYear - minYear + 1];
		for (var y = 0; y < years.Length; y++)
			years[y] = (y + minYear).ToString();
		var birthsCounts = new double[maxYear - minYear + 1];
		foreach (var name in names)
			birthsCounts[name.BirthDate.Year - minYear]++;

		return new HistogramData("Народжуваність за роками", years, birthsCounts);
	}
}