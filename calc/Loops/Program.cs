using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i % 2 != 0)
            //        continue;
            //        Console.WriteLine(i);
            //}

            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    if (Int32.Parse(str) > 0)
            //        break;
            //}

            string str;
            do
            {
                str = Console.ReadLine();    
            }
            while (Int32.Parse(str) <= 0);

            



        }
    }
}
