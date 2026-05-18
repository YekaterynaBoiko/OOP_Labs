namespace Lab23_25_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new StandartDice();
            Console.WriteLine(dice.ThrowDice());

            Dice dice1 = new CustomDice(4);
            Console.WriteLine(dice1.ThrowDice());


            Dice dice2 = new SeveralOfSameDice(2, 5);
            Console.WriteLine(dice2.ThrowDice());
        }
    }
}
