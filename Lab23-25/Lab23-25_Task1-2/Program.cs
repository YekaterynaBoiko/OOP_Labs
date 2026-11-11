namespace Lab23_25_Task1_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stool stool = new Stool(5, Quality.Low);
            Chair chair = new Chair(5, Quality.Low, 10);
            Console.WriteLine(chair.AmountOfWood);
            Console.WriteLine(stool.Cost);

        }
    }
}
