using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synergyLessonTask2.Task8
{
    internal class DZ
    {
        internal static void DZTask()
        {
            //Fish.FirstLaunch(); // Первая запись и создание псевдо БД. JSON почему-то не раболал
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите опцию:\n");
                Console.WriteLine("1. Посмотреть рыбку [1]");
                Console.WriteLine("2. Добавить рыбку [2]");
                Console.WriteLine("3. Редактировать рыбку [3]");
                Console.WriteLine("4. Выход \n");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                ConsoleKey key = keyInfo.Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" Посмотреть рыбку [1]\n");
                        Fish.ViewFish();
                        ResetZero();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(" Добавить рыбку [2]\n");
                        Fish.AddFish();
                        ResetZero();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(" Редактировать рыбку [3]\n");
                        // Не получилось реализовать редактирование. проходт исключение, что файл открыт.
                        // Я закрывал через streamWriter(Reader).Close(); Но не работает. 
                        Fish.EditFish();
                        ResetZero(); 
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine(" Выход из программы...");
                        return;
                    default:
                        Console.WriteLine(" Некорректный ввод. Попробуйте снова.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void ResetZero() 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Нажмите на 'Enter' Чтоб продолжить");
        }
    }
}

/*
 Задание: 

Вот мы и предотвратили кризис воды и поздравили с днём рождения начальника. 
Давайте теперь вернёмся к нашим рыбам в резервуаре. Напишите код, 
который поможет нам с указанием данных о наших рыбках. У наших рыб есть имя 
(но покупатель всегда сможет его сменить), вид, окрас, размер.  
 */
