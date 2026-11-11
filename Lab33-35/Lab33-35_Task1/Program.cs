using Lab33_35_Task1;

class Program
{
    static readonly bool[] boolValues = { false, true };
    static void TestElement(SingleInputElement logElement, string info)
    {
        Console.WriteLine();
        Console.WriteLine($"{"A",7}|{info,7}");
        Console.WriteLine(new String('-', 17));
        foreach (var in1 in boolValues)
        {
            logElement.Inputs[0] = in1;
            Console.WriteLine($"{in1,7}|{logElement.Output,7}");
        }
    }

    static void TestElement(DoubleInputElement logElement, string info)
    {
        Console.WriteLine();
        Console.WriteLine($"{"A",7}|{"B",7}|{info,7}");
        Console.WriteLine(new String('-', 25));
        foreach (var in1 in boolValues)
        {
            foreach (var in2 in boolValues)
            {
                logElement.Inputs[0] = in1;
                logElement.Inputs[1] = in2;
                Console.WriteLine($"{in1,7}|{in2,7}|{logElement.Output,7}");
            }
        }
    }

    static void Main(string[] args)
    {
        Inverter inverter = new Inverter();
        AndGate andGate = new AndGate();
        OrGate orGate = new OrGate();
        TestElement(inverter, "!A");
        TestElement(orGate, "A|B");
        TestElement(andGate, "A&B");
    }
}
