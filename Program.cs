using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

           Console.WriteLine("24/12/2019 - Avi");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"{i}. click {i} for question number {i} ");
            }
            num = Convert.ToInt16(Console.ReadLine());

            while (num !=-1)
            {
                switch (num)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    case 3:
                        Q3();
                        break;
                    case 4:
                        Q4();
                        break;

                    default:
                        Console.WriteLine("Enter a question number between 1-4 or -1 to exit");
                        break;
                }
                Console.WriteLine("===============================");
                Console.WriteLine("select your question : ");
                num = Convert.ToInt16(Console.ReadLine());


            }



        }

        private static void Q2()
        {
            long avi = 0;
            int miliSec = 0;
            int sec = 0;
            int min = 0;
            int hour = 0;
            int days = 0;


            Console.WriteLine("enter Mili sec number");
            avi = Convert.ToInt64(Console.ReadLine());

            miliSec = Convert.ToInt32(avi % 1000);
            avi /= 1000;

            sec = Convert.ToInt32(avi % 60);
            avi /= 60;

            min = Convert.ToInt32(avi % 60);
            avi /= 60;

            hour = Convert.ToInt32(avi % 24);
            avi /= 24;

            days = Convert.ToInt32(avi);


            Console.WriteLine($"miliSec:{miliSec}");
            Console.WriteLine($"sec:{sec}");
            Console.WriteLine($"min:{min}");
            Console.WriteLine($"hour:{hour}");
            Console.WriteLine($"days:{days}");
        }

        private static void Q4()
        {
            int rows = 1;
            int star = 0;
            int i = 0;
            int space = 0;
            Console.WriteLine("enter number of rows");


            rows = Convert.ToInt32(Console.ReadLine());



            star = rows * 2;

            i = 1;

            space = star / 2;

            while (i <= star)
            {
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();

                i = i + 2;

                space = space - 1;
            }
        }

        private static void Q1()
        {
            int i = 2;
            int num = 0;
            int sum = 0;

            Console.WriteLine("Enter Number:");


            for (int j = 0; j < 3; j++)
            {
                num = Convert.ToInt16(Console.ReadLine());
                i = 2;
                while (num % i != 0 && num > i)
                {
                    i++;
                }

                if (i == num)
                {
                    Console.WriteLine("This is Prime");
                    sum += num;
                }
                else
                {
                    Console.WriteLine("This is NOT Prime");
                    i = 0;
                    break;
                }
            }
            if (i != 0)
            {
                Console.WriteLine();
                Console.WriteLine($"WoW 3 prime numbers :) the sum is {sum}");
            }
        }

        private static void Q3()
        {
            int num = 0;
            Console.WriteLine("Enter Godel Mesholash");
            num = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
