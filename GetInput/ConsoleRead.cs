using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsole.GetInput
{
    class ConsoleRead
    {
        public static string[] CommandInput()
        {
            string input = Console.ReadLine();
            return input.Split(' ');
        }
    }
}
