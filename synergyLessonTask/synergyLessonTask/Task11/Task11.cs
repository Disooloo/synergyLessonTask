using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;

namespace synergyLessonTask.Task11
{
    public class Task11
    {
        public static void getTest11()
        {
            #region Домашнее задание

            #region Задача 1
            int[] numbersZInts = new int[5] { -20, 1, 51, -85, -9 };
            foreach (var numbersZ in numbersZInts)
            {
                Console.WriteLine(numbersZ);
            }
            #endregion
            #region Задача 2


            int[] fibonasi = new int[10];
            fibonasi[0] = 1; 
            fibonasi[1] = 1;

            for (int i = 2; i < 10; i++)
            {
                fibonasi[i] = fibonasi[i - 1] + fibonasi[i - 2];
            }

            foreach (int num in fibonasi)
            {
                Console.WriteLine(num);
            }

            #endregion
            #region Задача 3
                int[] valuesTask3 = new int[5] { 6, 31, 1, 45, 54 };

                Array.Sort(valuesTask3);
                foreach (int i in valuesTask3)
                {
                    Console.Write($"{i} ");
                }

            #endregion

            #endregion

            #region for

            Console.WriteLine("\n");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}^2={i * i}");
            }

            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                    continue; // Пропустит 3 и перейдет на 4
                if (i == 9)
                    break;
                Console.WriteLine($"for#2 -> {i}");
            }

            int[,] numbers =
            {
                {2,3,5},
                {3,4,5},
                {3,6,6}
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine($"{numbers[i,j]}");
                }
            }

            #endregion

            #region while

            int index = 0;

            while (index <= 5)
            {
                Console.WriteLine($"wl -> {index}");
                index++;
            }

            #endregion

            #region Dowhile

            int value = -1;
            
            do
            {
                Console.WriteLine($"value -> {value} > 0");
                value--;
            } while (value > 0);

            #endregion

            #region foreach

            int[] number = { 1, 2, 3, 5, 6, 7 };

            string[][] test = new String[][]
            {
                new string[] { "name1", "description1" },
                new string[] { "name2", "description2" }
            };

            foreach (string[] item in test)
            {
                Console.WriteLine($"Название статьи {item[0]} и их описание {item[1]}\n");
            }

            #endregion
        }

    }
}