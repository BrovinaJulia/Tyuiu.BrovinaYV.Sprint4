using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BrovinaYV.Sprint4.Task3.V27.Lib;

namespace Tyuiu.BrovinaYV.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Бровина Ю. В. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант 27                                                              *");
            Console.WriteLine("* Выполнила: Бровина Юлия Викторовна | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями от 3 до 7. Подсчитайте количество четных элементов в массиве.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] array = new int[5, 5]
            {
                {4, 3, 5, 5, 3 },
                {6, 7, 4, 4, 3 },
                {3, 3, 7, 3, 6 },
                {3, 4, 3, 7, 7 },
                {3, 5, 6, 3, 6 }
            };
            int rows = array.GetUpperBound(0) + 1;
            int collumn = array.Length / rows;
            
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < collumn; j++)
                {
                    Console.Write($"{array[i,j]}  \t");
                }

                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество четных элементов массива: " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
