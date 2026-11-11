using Lab32_Task3;

GradeHelper gradeHelper = new GradeHelper();
gradeHelper.AddGrade(5);
gradeHelper.AddGrade(12);
gradeHelper.AddGrade(8);

GradeHelper.Result result = gradeHelper.GetResult();
Console.WriteLine($"\nЗагальна кількість оцінок: {result.Count}" +
    $"\nМінімальна оцінка: {result.Min}" +
    $"\nМаксимальна оцінка: {result.Max}" +
    $"\nСередня оцінка: {result.Average}");