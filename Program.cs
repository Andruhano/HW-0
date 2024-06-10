using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("                     CV");
            Console.WriteLine("|----------------------------------------------|\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tMykhailenko Andrii\n");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Contacts:");
            Console.ResetColor();
            Console.WriteLine("+380681824659");
            Console.WriteLine("andrey.a.mykhailenko@gmail.com");
            Console.WriteLine("@andruhano1 (telegram)\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Languages:");
            Console.ResetColor();
            Console.WriteLine("- Ukrainian (native)");
            Console.WriteLine("- Russian (native)");
            Console.WriteLine("- English (B2)");
            Console.WriteLine("- French (A2)\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Skills:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Hard Skills:");
            Console.ResetColor();
            Console.WriteLine("  - Junior on C++");
            Console.WriteLine("  - Basic knowledge on Python");
            Console.WriteLine("  - Understanding of OOP");
            Console.WriteLine("  - Worked with UML\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Soft Skills:");
            Console.ResetColor();
            Console.WriteLine("  - Time management");
            Console.WriteLine("  - Planning");
            Console.WriteLine("  - Teamwork skills");
            Console.WriteLine("  - Multitasking");
            Console.WriteLine("  - Analytical thinking\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hobbies:");
            Console.ResetColor();
            Console.WriteLine("- Photographing");
            Console.WriteLine("- Music (writing and production)");
            Console.WriteLine("- Travelling\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Education:");
            Console.ResetColor();
            Console.WriteLine("Odesa, Lyceum #2, 2014-2025");
            Console.WriteLine("Odesa, IT school STEP, 2023-2025");
        }
    }
}
