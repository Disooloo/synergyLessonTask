using System;

namespace synergyLessonTask.Task8
{
    public class Task8
    {
        public static void task8()
        {
            int pass = 54;
            int key = 44;

            int encrypt = pass ^ key;

            int decrypt = encrypt ^ key;

            Console.WriteLine($"encrypt пароль - {encrypt} \ndecrypt {decrypt}" );
        }

        public static void DZ_task8()
        {
            int a = 10;
            int b = 3;
            float c = 2.5f;
            bool d = true;

            // 1. Сложение a и b
            int result1 = a + b;

            // 2. Умножение результата сложения на c
            float result2 = result1 * c;

            // 3. Преобразование типа float в int и деление на b
            int result3 = (int)result2 / b;

            // 4. Логическое ИЛИ результата деления и d
            bool result4 = (result3 == 3) || d;

        }
    }
}