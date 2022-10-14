using System;
using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter the desired array size or input '123' to exit");
                int arraySize = int.Parse(Console.ReadLine());
                if (arraySize == 123)
                {
                    break;
                }
                int[,] myArray = new int[arraySize, arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {
                        Console.WriteLine("Please, enter the values for Y: " + i + " X: " + j);
                        myArray[i, j] = int.Parse(Console.ReadLine());
                    }

                }

                Console.WriteLine();
                Console.WriteLine("This is your 2d array");
                for (int y = 0; y < arraySize; y++)
                {
                    for (int x = 0; x < arraySize; x++)
                    {
                        Console.Write(myArray[y, x] + "\t");
                    }
                    Console.WriteLine();
                }


                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {
                        if (i > j)
                        {
                            myArray[i, j] = 0;
                        }
                        else if (i < j)
                        {
                            myArray[i, j] = 1;
                        }

                    }

                }
                Console.WriteLine();
                Console.WriteLine("This is your modified 2d array");

                for (int y = 0; y < arraySize; y++)
                {
                    for (int x = 0; x < arraySize; x++)
                    {
                        Console.Write(myArray[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
