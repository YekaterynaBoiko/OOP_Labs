namespace MK2_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sumOfVoices = new Dictionary<string, int>();
            string candidate;
            while ((candidate = Console.ReadLine()) != null) 
            {
                if (candidate == "") continue;
                int voices = Convert.ToInt32(Console.ReadLine());
                if (sumOfVoices.ContainsKey(candidate))  sumOfVoices[candidate] += voices;
                else sumOfVoices[candidate] = voices;
                
            }

            foreach (var result in sumOfVoices)
            {
                Console.WriteLine($"{result.Key} {result.Value}");
            }
        }
    }
}
