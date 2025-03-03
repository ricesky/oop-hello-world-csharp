using HelloLib;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            HelloPrinter printer = new HelloPrinter();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please write something bro...");
            }

            printer.SayHello(name);

        }
    }
}
