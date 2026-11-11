namespace Lab23_25_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.WriteLine(dice.ThrowDice());
            Console.WriteLine(dice.ThrowDice(7));
            Console.WriteLine(dice.ThrowDice(7, 2));
        }
    }
}
