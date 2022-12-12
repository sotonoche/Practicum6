using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum6_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] arr;

            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0) throw new Exception("Размерность массива не может быть равна или меньше нуля!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            arr = new int[n, n];
            while (true)
            {
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write($"Введите значение для [{i + 1}][{j + 1}] элемента массива: ");
                            arr[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
            }

            double sum = .0;
            double count = .0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n)
                    {
                        sum += arr[i, j];
                        count++;
                        Console.WriteLine($"{arr[i,j]} {count}");
                    }
                }
            }

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"[{arr[i, j]}]");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Средее арифметическое элементов под побочной диагональю равно {sum/count}");
        }
    }
}
