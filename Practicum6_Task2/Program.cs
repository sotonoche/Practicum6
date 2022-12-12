using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum6_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            double[] arr;

            while (true)
            {
                try
                {
                    Console.Write("Введите размерность массива: ");
                    size = int.Parse(Console.ReadLine());
                    if (size <= 0) throw new Exception("Размерность массива не может быть меньше или равна нулю");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректные значения!");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            arr = new double[size];
            while (true)
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"Введите значение для {i + 1}-го элемента массива: ");
                        arr[i] = double.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
            }

            int max_index = 0;
            double max = arr[0];
            foreach (double num in arr)
            {
                if(num > max) max = num;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max) max_index = i;
            }

            double temp = arr[max_index];
            arr[max_index] = arr[0];
            arr[0] = temp;

            Console.Write($"Массив с измененным первым и максимальным элементами: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{arr[i]}] ");
            }
            Console.WriteLine();
        }
    }
}
