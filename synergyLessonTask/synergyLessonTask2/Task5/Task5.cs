using System;
using System.IO;

namespace synergyLessonTask2.Task5
{
    //
    internal class Task5
    {
        internal const string path = @"C:\\Users\\kroli\\Desktop\\Новая папка\\Новая папка20";
        internal static void GetTask5()
        {
            DZ.DZTask();
        }

        private static void FileOther()
        {
            string path = @"C:\\Users\\kroli\\Desktop\\Новая папка\\Новая папка20\\test.txt";

            if (!File.Exists(path))
                File.Create(path);
        }

        private static void CreacteDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            string[] subDirectories = {"Поддиректория", "Сохранения", "Тайтлы", "Что-то еще"}; 
            if (!directoryInfo.Exists)
                directoryInfo.Create();
            Random random = new Random();
            directoryInfo.CreateSubdirectory(subDirectories[random.Next(subDirectories.Length)]);
        }
        private static void DeleteDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
                directoryInfo.Delete(true);
        }
        private static void MovingDirectory()
        {
            string newPath = @"C:\\Users\\kroli\\Desktop\\test";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            if (directoryInfo.Exists)
                directoryInfo.MoveTo(newPath);
        }

        private static void DrivePathDerectory()
        {
            string path = @"C:\\Users\\kroli\\Desktop\\Новая папка";

            if (Directory.Exists(path))
            {

                Console.WriteLine("Подкатегории");
                string[] derictories = Directory.GetDirectories(path);
                foreach (string des in derictories)
                    Console.WriteLine(des);

                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                    Console.WriteLine(file);
            }
        }
        
       private void DriveInfoPath()
       {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"Имя диска - {drive.Name} " +
                    $"\n Готовность диска - {drive.IsReady} " +
                    $"\n Свободно на диске {drive.AvailableFreeSpace} байт " +
                    $"\n Свободно на диске {drive.AvailableFreeSpace / Math.Pow(2, 30)} Гб " +
                    $"\n Тип диска {drive.DriveType} " +
                    $"\n Общий обьем диска {drive.TotalSize / Math.Pow(2, 30)} Гб \n\n");
            }
        }
        
    }


}
