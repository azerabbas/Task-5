using System;

namespace Task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program in C# to display the first 10 natural numbers
            //  Natural10();

            // 2. Write a C# program to find the sum of first 20 odd natural numbers.
            // FindDeSum();

            // 3. Write a program in C# to read 5 numbers from keyboard and find their sum and average.
            // Average();

            // 4. Write a program in C# to display the multiplication table vertically from 1 to n.
            //  MultiplicationTable();

            // 5. Write a program in C# to display the pattern like right angle triangle using an asterisk. The pattern like :
            // Pattern();

            // 6. Write a program in C# to make such a pattern like right angle triangle with number increased by 1. The pattern like :
            Pattern2();
        }

        static void Natural10()
        {
            int nat = 1;
            for (int i = 0; i<=10; i++)
            {
                nat = nat+ i;
            }
            Console.WriteLine(nat);
        }

        static void FindDeSum()
        {
            int find = 0;
            for (int i = 1; i <= 20; i=i+2)
            {
                find = find+ i;
            }
            Console.WriteLine(find);
        }

        static void Average()
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}.ci reqemi daxil edin");
                int req = int.Parse(Console.ReadLine());
                sum = sum+ req;
            }
            int average = sum/5;
            Console.WriteLine(average);
        }

        static void MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int y = 1; y<= 10; y++)
                {
                    int ch = i*y;
                    Console.WriteLine($"{i}*{y}={ch}");
                }
                Console.WriteLine("*****************************************");
            }
        }
        static void Pattern()
        {
            string ulduz = "*";

            for (int i = 1; i <=5; i++)
            {
                for (int x = 1; x <=i; x++)
                {
                    Console.Write(ulduz);
                }

            }
        }

        static void Pattern2()
        {
            for (int i = 1; i <=1; i++)
            {
                Console.WriteLine(i);
                for (int x = 2; x<=2; x++)
                {
                    Console.Write(x);
                    for (int y = 3; y <=3; y++)
                    {
                        Console.WriteLine(y);
                        for (int z = 4; z<=4; z++)
                        {
                            Console.Write(z);
                            for (int z2 = 5; z2<=5; z2++)
                            {
                                Console.Write(z2);
                                for (int z3 = 6; z3 <= 6; z3++)
                                {
                                    Console.Write(z3);
                                }
                            }
                        }

                    }

                }

            }
        }



    }
}
