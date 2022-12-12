using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum6_Task1_2arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x_size, y_size, n;
            int[,] arr;

            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введите размерность массива по x: ");
                    x_size = int.Parse(Console.ReadLine());
                    Console.Write("Введите размерность массива по y: ");
                    y_size = int.Parse(Console.ReadLine());
                    if (x_size <= 0 || y_size <= 0) throw new Exception("Размерность массива не может быть равна или меньше нуля!");
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

            arr = new int[x_size, y_size];
            while (true)
            {
                try
                {
                    for (int i = 0; i < x_size; i++)
                    {
                        for (int j = 0; j < y_size; j++)
                        {
                            Console.Write($"Введите значение для [{i + 1}][{j + 1}] элемента массива: ");
                            arr[i,j] = int.Parse(Console.ReadLine());
                        }
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
            }

            for (int i = 0; i < x_size; i++)
            {
                for (int j = 0; j < y_size; j++)
                {
                    if (arr[i,j] < n) arr[i,j] *= 2;
                }
            }

            Console.WriteLine($"Все элементы массива, которые меньше числа {n} увеличены в два раза: ");

            for (int i = 0; i < x_size; i++)
            {
                for (int j = 0; j < y_size; j++)
                {
                    Console.Write($"[{arr[i,j]}]");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
