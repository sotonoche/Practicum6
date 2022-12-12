using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, n;
            int[] arr;

            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введите размерность массива: ");
                    size = int.Parse(Console.ReadLine());
                    if (size <= 0) throw new Exception("Размерность массива не может быть равна или меньше нуля!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            arr = new int[size];
            while (true)
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"Введите значение для {i + 1}-го элемента массива: ");
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < n) arr[i] *= 2;
            }

            Console.Write($"Все элементы массива, которые меньше числа {n} увеличены в два раза: ");
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{arr[i]}] ");
            }
            Console.WriteLine();
        }
    }
}
