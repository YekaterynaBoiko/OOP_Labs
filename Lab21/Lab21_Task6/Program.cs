namespace Lab21_Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var messenger = new SecreteMessenger();
            Console.WriteLine("Write a word for Encryption: ");
            string text = Console.ReadLine();
            messenger.SendMessage(text);

            Console.WriteLine(messenger.Message);
            Console.WriteLine(messenger.ReceivingMessage());
        }
    }
}
