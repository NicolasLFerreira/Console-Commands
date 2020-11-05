using System;

namespace SimpleConsole
{
    using Terminal;
    using Control;
    using GetInput;
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] command = ConsoleRead.CommandInput();
                object value = CommandReader.FunctionCall(command[0], command);
                if (value != null) Console.WriteLine($"Got -> {value}");
            }
        }
    }
}