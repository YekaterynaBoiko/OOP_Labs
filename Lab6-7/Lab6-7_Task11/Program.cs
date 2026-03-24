namespace Lab6_7_Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //порахувати к-сть букв-символів масив string 
            //цікавит кільксть ел в кожному сл
            string?[] array = Console.ReadLine().Split(); //записую рядок свій
            int indexSmallWord = 0;
            int minLineLength = array[0].Length;

            for (int i = 1; i < array.Length; i++)
            {
                int length = array[i].Length;
                if (length < minLineLength)
                {
                    minLineLength = length;
                    indexSmallWord = i;
                }
            }
            Console.WriteLine(indexSmallWord + 1);
            
            //алитернатив новий масим з довжин слів і сорт

        }
    }
}
