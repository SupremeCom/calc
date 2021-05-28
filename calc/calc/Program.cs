using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string otv;
           do
            {
                int x = GetNumber("Введите первое число");
                int y = GetNumber("Введите второе число");

                Console.WriteLine("Введите команду: +, -, *, /, min, max");
                string cmd = Console.ReadLine();

                int result = GetResult(x, y, cmd);

                Console.WriteLine(result);
                Console.WriteLine("Хотите ли вы продолжить вычисления? Введите команду: да, нет");
                otv = Console.ReadLine();

                
                
            }
            while (otv == "да");
        }

        private static int GetResult(int x, int y, string cmd)
        {
            int result = 0;
            switch (cmd)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                case "max":
                    result = GetMax(x,y);
                    break;
                case "min":
                    result = GetMin(x, y);
                    break;
            }
            return result;
        }

        private static int GetNumber(string text)
        {
            Console.WriteLine(text);
            while (true)
            {
                string str = Console.ReadLine();
                int result;
                if (Int32.TryParse(str, out result))
                    return result;
                else
                    Console.WriteLine("Введен не правильный формат числа");
            }
        }

        static int GetMax(int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        static int GetMin(int a, int b)
        {
            int min = 0;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }
            return min;
        }


    }
}
