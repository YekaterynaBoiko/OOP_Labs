using System;
using System.IO;
using System.Linq;
using Avalonia;

namespace Names.UI;

public static class Program
{
	private static readonly string dataFilePath = "names.txt";


	[STAThread]
	public static void Main(string[] args)
	{
		BuildAvaloniaApp()
			.StartWithClassicDesktopLifetime(args);
	}

	public static AppBuilder BuildAvaloniaApp()
		=> AppBuilder.Configure<App>()
			.UsePlatformDetect()
			.LogToTrace();

	public static void ShowPlots()
	{
		var namesData = ReadData();
		Charts.ShowHistogram(HistogramTask.GetBirthsPerDayHistogram(namesData, "ольга"),
            "Народжуваність людей з ім'ям Ольга");
		Charts.ShowHistogram(HistogramTask.GetBirthsPerDayHistogram(namesData, "руслан"),
            "Народжуваність людей з ім'ям Руслан");
		//CreativityTask.ShowYourStatistics(namesData);
	}

	private static NameData[] ReadData()
	{
		var lines = File.ReadAllLines(dataFilePath);
		var names = new NameData[lines.Length];
		for (var i = 0; i < lines.Length; i++)
			names[i] = NameData.ParseFrom(lines[i]);
		return names;
	}
	private static NameData[] ReadData2()
	{
		return File
			.ReadLines(dataFilePath)
			.Select(NameData.ParseFrom)
			.ToArray();
	}
}