using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsole.Terminal
{
    class Commands
    {
        public static void Clear() => Console.Clear();

        public static object Oper(string[] command)
        {
            double sum = 0;
            double[] nums = new double[command.Length];
            char[] operators = new char[command.Length];

            for (int i = 1; i < command.Length; i++)
            {
                try
                {
                    if (i % 2 != 0) nums[i] = Convert.ToInt32(command[i]);
                    else operators[i] = Convert.ToChar(command[i]);
                }
                catch (FormatException)
                {
                    return "Invalid format";
                }
            }

            sum += nums[1];

            for (int i = 1; i < command.Length; i++)
            {
                switch (operators[i])
                {
                    default:
                        break;
                    case '+':
                        sum += nums[i + 1];
                        break;
                    case '-':
                        sum -= nums[i + 1];
                        break;
                    case '*':
                        sum *= nums[i + 1];
                        break;
                    case '/':
                        sum /= nums[i + 1];
                        break;
                }
            }

            return sum;
        }

        public static void Create<T>()
        {
            T[] instance = new T[2];
        }
    }
}
