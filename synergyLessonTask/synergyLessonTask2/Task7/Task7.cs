using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synergyLessonTask2.Task7
{
    // Тема 7. Создание и использование перечислений
    internal class Task7
    {
        internal static void GetTask7()
        {
            DZ.DZTask();
        }

        private static void Swith()
        {
            Direction direction = new Direction();
            switch (direction)
            {
                case Direction.Up:
                    break;
                case Direction.Down:
                    break;
                case Direction.Left:
                    break;
                case Direction.Rigth:
                    break;
                default:
                    break;
            }
        }


        private static void FollowKeys()
        {
            while (true)
            {
                Console.Write("Нажата клавиша: ");
                ConsoleKeyInfo KeyInfo = Console.ReadKey();
                ConsoleKey key = KeyInfo.Key;

                Console.WriteLine($"\t{key} \t{(int)key}");

                if (key == ConsoleKey.Delete)
                    Console.Clear();
            }
        }

        private static int GetKey()
        {
            return new Random().Next(0, 100);
        }

        private static void BadOption()
        {
            int key;
            do
            {
                key = GetKey();
                Console.WriteLine(key);
            } while (key != 87); // key87 = W
            Console.WriteLine($"Игрок нажал на клавишу {key}");
        }
    }
    enum Direction
    {
        Up,
        Down,
        Left,
        Rigth
    }
}
