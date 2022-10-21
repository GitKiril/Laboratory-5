using System;

namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Hello");
            OtherPrinter OtherPrinter = new OtherPrinter();
            OtherPrinter.Print("Hello");
        }
    }
}
