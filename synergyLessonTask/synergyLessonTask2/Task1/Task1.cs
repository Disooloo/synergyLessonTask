using System;

namespace synergyLessonTask2.Task1
{
    public class Task1
    {
        public static void GetTask1()
        {
            #region Тема 1.Создание и использование методов

            #endregion

            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 1, 2, 3 };
            int[] numbers3 = { 1, 2, 3 };

            string[] name = { "Dima", "Sasha" };

            GetNum1(numbers1);
            GetNum1(name);


            int abs1 = Abs(22);
            int abs2 = Abs(-2);

            Console.WriteLine($"{abs1} | {abs2}");

        }

        private static void GetNum1(int[] array)
        {
            foreach(int item in array)
                Console.WriteLine(item);
        }

        private static void GetNum1(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static int Abs(int value) => value >= 0 ? value : -value;
    }
}