using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum6_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Умножение ступенчатого массива NxN на вектор");
            Console.WriteLine("-------------------------------------------------");
            int n;

            while (true)//ввод размерности массива
            {
                try
                {
                    Console.Write("Введите размерность ступенчатого массива NxN: ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0) throw new Exception("Размерность массива не должна быть меньше или равна нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное значение!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            int[][] arr = new int[n][];
            for (int i = 0; i < n; ++i)//заполнение ступенчатого массива
            {
                arr[i] = new int[n];
                while (true)
                {
                    try
                    {
                        for (int j = 0; j < n; ++j)
                        {
                            Console.Write($"arr[{i},{j}]= ");
                            arr[i][j] = int.Parse(Console.ReadLine());
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введено некорректное значение!");
                    }
                }

            }

            Console.WriteLine();
            int[] vector = new int[n];//объявляем вектор
            while (true)
            {
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"vector[{i}]= ");
                        vector[i] = int.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректные значения!");
                }
            }
            

            Console.WriteLine("\nВывод исходного массива");
            Console.WriteLine("-------------------------------------------------");
            for (int i = 0; i < arr.Length; ++i, Console.WriteLine())//вывод ступенчатого массива
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    Console.Write($"{arr[i][j]} ");
                }

            }


            Console.WriteLine("\nВывод массива вектора");
            Console.WriteLine("-------------------------------------------------");
            for (int i = 0; i < vector.Length; ++i)//вывод вектора
            {
                Console.Write($"{vector[i]}\n");
            }


            //умножение массива на вектор
            int[] arr_out = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr_out[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    arr_out[i] += arr[i][j] * vector[j];
                }
                
            }

            Console.WriteLine("\nВывод исходного массива");
            Console.WriteLine("-------------------------------------------------");
            for (int i = 0; i < n; ++i)//вывод результата умножения
            {
                Console.Write($"{arr_out[i]}\n");
            }
        }
    }
}
