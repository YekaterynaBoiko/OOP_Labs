using static Lab13_Task2.Program;

namespace Lab13_Task2
{
    internal class Program //Task2
    {

        public class TaskItem
        {
            public string nameTask;
            public int DurationInHours;
            public bool isCompleted;

            
            public TaskItem(string nameTask, int DurationInHours)
            {
                this.nameTask = nameTask;
                this.DurationInHours = DurationInHours;
                this.isCompleted = false;
            }
            
            public void MarkComplete()
            {
                isCompleted = true;
            }

            public string Status()
            {
                return isCompleted ? "Done" : "Pending"; //if isCompited == true 
            }

            public string Description()
            {
                return $"{nameTask} [{Status()}] - Estimated: {DurationInHours}h";
            }
        }

        public class Project
        {
            public string Name;
            public List<TaskItem> tasks;

            public Project(string Name) 
            { 
                this.Name = Name; 
                this.tasks = new List<TaskItem>(); //в памяті порожній список створений -> лінива ініціалізація
            }
            public void AddTask(TaskItem task)
            {
                tasks.Add(task);
            }
            
            public int GetCompletedTask()
            {
                int completed = 0;
                
                foreach (TaskItem task in tasks)
                {
                    if (task.isCompleted) completed++;
                }
                return completed;
            }

            public int GetPendingTask()
            {
                int pending = 0;
                foreach (TaskItem task in tasks)
                {
                    if (!task.isCompleted) pending++;
                }
                return pending;
            }

            public int TotalHour()
            {
                int totalHour = 0;
                foreach (TaskItem task in tasks) totalHour += task.DurationInHours;
                return totalHour;
            }
            //
            public void AllOverview()
            {
                Console.WriteLine($"\nПроєкти: {Name}");
                int count = GetCompletedTask();
                Console.WriteLine($"Всього завдань: {tasks.Count} (Виконано: {count}, Очікує: {tasks.Count - count})");
                Console.WriteLine($"Всього годин: {TotalHour()}");

                Console.WriteLine("Tasks: ");
                for (int i = 0; i < tasks.Count; i++) Console.WriteLine($"{i + 1}. {tasks[i].Description()}");
            }
        }
        public void AddTask(Project project)
        {
            Console.Write("Назва задачі: ");
            string nameTask = Console.ReadLine();
            Console.Write("Оцінка годин: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            project.AddTask(new TaskItem(nameTask, hour));
            Console.WriteLine("Задача додана.");
        }

        public void TaskIsDone(Project projects)
        {
            if (projects.tasks.Count == 0)
            {
                Console.WriteLine("Немає задач");
                return;
            }
            for (int i = 0; i < projects.tasks.Count; i++) Console.WriteLine($"{i + 1}. {projects.tasks[i].Description()}"); //????
            Console.WriteLine("Введіть номер здачі для позначення як Done: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number <= projects.tasks.Count)
            {
                projects.tasks[number - 1].MarkComplete();
                Console.WriteLine("Задача позначена як Done");
            }
            else Console.WriteLine("Невірний номер");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Введіть назву проєкту: ");
            string name = Console.ReadLine();
            Project projects = new Project(name);

            while (true)
            {
                Console.WriteLine("\nМеню: \n1. Додати задачу \n2. Позначити задачу виконаною \n3. Показати Overview \n4. Вихід \nВиберіть опцію:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        program.AddTask(projects); break;
                    case "2":
                        program.TaskIsDone(projects); break;
                    case "3":
                        projects.AllOverview(); break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Помилка 404"); break;
                }
            }
        }
        
    }
}

