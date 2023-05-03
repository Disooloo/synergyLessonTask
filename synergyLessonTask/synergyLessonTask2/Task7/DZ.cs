using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synergyLessonTask2.Task7
{
    internal class DZ
    {
        internal static void DZTask()
        {
            Move();
        }

        private static void Move()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                ConsoleKey key = keyInfo.Key;

                switch (key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine($"\tБежим прямо");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine($"\tПовернули на лево");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine($"\tДвижение назад");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine($"\tповернули на право");
                        break;
                    case ConsoleKey.Spacebar:
                        Console.WriteLine($"\tПрыжок");
                        break;
                    default:
                        // Обработка нажатия другой клавиши
                        break;
                }
            }
        }
    }
    
}
/*Напишите код для передвижения клавиш WASD.*/
