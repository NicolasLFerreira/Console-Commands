using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsole.Control
{
    using Terminal;
    class CommandReader
    {
        public static object FunctionCall(string keyword, string[] command)
        {
            switch (keyword)
            {
                case "clear":
                    Commands.Clear();
                    return null;
                case "oper":
                    return Commands.Oper(command);
                default:
                    return "There's no such command";
            }
        }
    }
}
