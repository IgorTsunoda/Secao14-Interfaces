using DiamondProblem.Device;

namespace DiamondProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");
            Console.WriteLine();
            Scanner s = new Scanner() { SerialNumber = 2000 };
            s.ProcessDoc("My email");
            s.Scan("My email");

            Console.WriteLine();

            ComboDevice c = new ComboDevice() { SerialNumber = 3100 };
            c.ProcessDoc("My disertation)");
            c.Print("My disertation");
            Console.WriteLine(c.Scan);
    }
}