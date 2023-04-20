using System;

namespace synergyLessonTask2.Task2
{
    public class Task2
    {
        internal static void GetTask2()
        {
            #region Тема 2. Работа с параметрами по умолчанию и выходными параметрами



            #endregion

            int x = 3;
            int y = 4;

            int sum = Sum(x, y);
            Console.WriteLine(sum);

            PrintUserInfo("Joe", 12);
        }

        #region ДЗ
            private void DzTask()
        {

            int value = 5;

            Increment(value);
            // value останется равным 5, так как значение параметра было передано по значению


            int value1 = 5;
            Increment(ref value1);
            // value1 будет равен 6, так как значение параметра было передано по ссылке

            int x = 10, y = 3, result, remainder;
            Divide(x, y, out result, out remainder);
            // result будет равен 3, remainder будет равен 1

            int value2 = 5;
            Print(in value2);
            // value останется равным 5, так как параметр передан только для чтения

            string personName = "Иван";
            int personAge = 25;
            PrintPersonData(personName, personAge);


            int value3 = 5;
            IncrementByValue(value3);
            // value1 останется равным 5

            int value4 = 5;
            IncrementByRef(ref value4);
            // value2 будет равен 6


            int Sum(int a, int b)
            {
                return a + b;
            }

            int result1 = Sum(2, 3); // result1 будет равен 5

            int Square(int q)
            {
                return q * q;
            }

            int result2 = Square(3); // result2 будет равен 9

        }
        #endregion

        private static int Sum(int a, int b) => a + b;

        private static void PrintUserInfo(string name, int age, string country = "РФ") =>
            Console.WriteLine($"Ваше имя {name} и возвраст {age}. Страна: {country}");

        private static void Increase(int value)
        {
            value++;
            Console.WriteLine($"Значение внутри метода - {value}");
        }

        private static void Increase(ref int value)
        {
            value++;
            Console.WriteLine($"Значение внутри метода - {value}");
        }

        #region Supportive
        private void Increment(int xi)
        {
            xi++;
        }

        private void Increment(ref int x)
        {
            x++;
        }

        private void Divide(int x, int y, out int result, out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }

        private void Print(in int x)
        {
            Console.WriteLine(x);
        }

        private void PrintPersonData(string name, int age)
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}");
        }

        void IncrementByValue(int value)
        {
            value++;
        }

        void IncrementByRef(ref int value)
        {
            value++;
        }



        #endregion


     








    }
}