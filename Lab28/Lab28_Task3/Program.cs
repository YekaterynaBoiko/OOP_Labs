namespace Lab28_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("N: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0)
                    throw new ArgumentException("Array size must be greater than 0");
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                    array[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("a(left): ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b(right): ");
                int b = Convert.ToInt32(Console.ReadLine());

                if (a < 0 || b < 0 || a >= n || b >= n)
                    throw new ArgumentException("Indices go beyond the array limits");

                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                    Console.WriteLine("a and b swapped places");
                }
                if (a < 0 || b >= n)
                {
                    Console.WriteLine("Incorrect indices");
                    return;
                }
                while (a < b)
                {
                    int temp = array[a];
                    array[a] = array[b];
                    array[b] = temp;
                    a++;
                    b--;
                }
                Console.WriteLine("Result: ");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(array[i] + " ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input"); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    } 
}
