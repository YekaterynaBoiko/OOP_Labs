namespace Lab9_Task8
{
    internal class Program
    {

        

        static void PrintInfo(string nickName, List<string> dataBase)
        {
            Console.WriteLine("Знайдено: ");
            Console.WriteLine(nickName);
            Console.WriteLine("Підписників: " + dataBase[0]);
            Console.WriteLine("Номер: " + dataBase[1]);
            Console.WriteLine("Дата народження: " + dataBase[2]);
        }

        static void Main(string[] args)
        {
            Dictionary<string, List<string>> informationAboutPeople = new Dictionary<string, List<string>>
            {
                {"@GlebKievsky", new List<string> {"999", "+380 (66) 485 39 40", "19.02"} }
            };
            string name = Console.ReadLine();
            if (informationAboutPeople.ContainsKey(name))
            {
                PrintInfo(name, informationAboutPeople[name]);
                string text = Console.ReadLine();
                if (text == "Підписатись")
                {
                    int subscribers = Convert.ToInt32(informationAboutPeople[name][0]);
                    subscribers++;
                    informationAboutPeople[name][0] = subscribers.ToString();

                    Console.WriteLine();
                    Console.WriteLine("Ви підписались на оновлення: ");
                    PrintInfo(name, informationAboutPeople[name]);
                }
                else if (text == "Вийти")
                {
                    Console.WriteLine("Closing app...");
                }
                else
                {
                    Console.WriteLine();
                }
            }
              
        }
    }
}
