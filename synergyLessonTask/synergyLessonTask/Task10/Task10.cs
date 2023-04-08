using System;

namespace synergyLessonTask.Task10
{
    public class Task10
    {
        public static void getTest10()
        {
            int value = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine(value >= 20 ? ">20" : "<20");

            #region switch
            int valueSwitch = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (valueSwitch)
            {
                case 0:
                    Console.WriteLine("какое-то число 0");
                    break;
                case 1:
                    Console.WriteLine("какое-то число 1");
                    break;
                case 2:
                    Console.WriteLine("какое-то число 2");
                    break;
                default:
                    Console.WriteLine("Что-то не понятно");
                    break;
            }
            #endregion
        }
    }
}