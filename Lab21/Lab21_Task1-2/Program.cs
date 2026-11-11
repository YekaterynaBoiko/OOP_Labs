namespace Lab21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer(50, true);
            Console.WriteLine($"Toner level: {printer.TonerLevel}");
            Console.WriteLine($"Toner added {printer.AddToner(50)}");
            Console.WriteLine($"Toner level: {printer.TonerLevel}");
            Console.WriteLine("Printing in duplex mode");
            Console.WriteLine($"initial page count = {printer.PagesPrinted}");
            int pagesPrinted = printer.PrintPages(4);
            Console.WriteLine($"Pages printed was {pagesPrinted} new total print count for printer = {printer.PagesPrinted}");
            pagesPrinted = printer.PrintPages(1);
            Console.WriteLine($"Pages printed was {pagesPrinted} new total print count for printer = {printer.PagesPrinted}");
            pagesPrinted = printer.PrintPages(2);
            Console.WriteLine($"Pages printed was {pagesPrinted} new total print count for printer = {printer.PagesPrinted}");

            Console.WriteLine(new string('-', 45));
            Console.WriteLine();

            Printer printer2 = new Printer(80, false);
            Console.WriteLine($"Toner level: {printer2.TonerLevel}");
            Console.WriteLine($"Toner added {printer2.AddToner(120)}");
            Console.WriteLine($"Toner level: {printer2.TonerLevel}");
            Console.WriteLine($"Toner added {printer2.AddToner(10)}");
            Console.WriteLine($"Toner level: {printer2.TonerLevel}");
            Console.WriteLine("Printing in simplex mode");
            Console.WriteLine($"initial page count = {printer2.PagesPrinted}");
            pagesPrinted = printer2.PrintPages(3);
            Console.WriteLine($"Pages printed was {pagesPrinted} new total print count for printer = {printer2.PagesPrinted}");
            pagesPrinted = printer2.PrintPages(2);
            Console.WriteLine($"Pages printed was {pagesPrinted} new total print count for printer = {printer2.PagesPrinted}");

        }
    }
}
