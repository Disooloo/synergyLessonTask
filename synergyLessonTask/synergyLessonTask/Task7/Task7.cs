using System;

namespace synergyLessonTask.Task7
{
    public class Task7
    {
        // Тема_7_Создание_и_инициализация_переменных

        public static void getTest7()
        {
            /* Литералы:
            1. логические true and false
            2. Целочисленные (100, -100)
            3. Вещественные  (123.23f)
            4. Символьные ('a')
            5. Строковые ("string")
            6. Null
             */

            int a = 123;
            uint b = 123; // Только положительные цифры
            float c = 123.23f;
            double d = 2345.34;
            decimal e = 4234.234m;

            char n = 'a';

            string name = Console.ReadLine(); 

            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);
            //int age = int.Parse(ageInput);

            int age = int.Parse(Console.ReadLine() ?? string.Empty); 

            Console.WriteLine($"{name}'s age: {age}"); 

            Console.WriteLine(0b10101); // Вывод на экран двоичного литерала 10101 в десятичном формате

        }
    }
}