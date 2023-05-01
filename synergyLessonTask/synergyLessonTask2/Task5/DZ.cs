using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synergyLessonTask2.Task5
{
    internal class DZ
    {
        const string path = @"C:\\Users\\kroli\\Desktop\\Новая папка\\Домашняя работа";
        internal static void DZTask()
        {
            ViewFile();
        }

        private static void ViewFile()
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    switch (extension)
                    {
                        case ".rar":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case ".txt":
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case ".pptx":
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        default:
                            Console.ResetColor();
                            break;
                    }
                    Console.WriteLine(file);
                }

            }

        }

        private static void CreateFile()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            string directory = "Директория ";
            string FilepathRar = @"C:\\Users\\kroli\\Desktop\\Новая папка\\Домашняя работа\\Архив.rar";
            string FilepathTxt = @"C:\\Users\\kroli\\Desktop\\Новая папка\\Домашняя работа\\Текстовый.txt";
            string FilepathPptx = @"C:\\Users\\kroli\\Desktop\\Новая папка\\Домашняя работа\\Призенташка.pptx";

            if (!directoryInfo.Exists)
            {
                for (int i = 0; i < 5; i++)
                    directoryInfo.CreateSubdirectory(directory + i);
            }
            if (!File.Exists(FilepathRar))
            {
                for (int i = 0; i < 5; i++)
                    File.Create($"C:/Users/kroli/Desktop/Новая папка/Домашняя работа/Архив{i}.rar");
            }
            if (!File.Exists(FilepathTxt))
            {
                for (int i = 0; i < 5; i++)
                    File.Create($"C:/Users/kroli/Desktop/Новая папка/Домашняя работа/Текст{i}.txt");
            }
            if (!File.Exists(FilepathPptx))
            {
                for (int i = 0; i < 5; i++)
                    File.Create($"C:/Users/kroli/Desktop/Новая папка/Домашняя работа/Призенташка{i}.pptx");
            }

        }
    }

    /*Катерина Михайловна очень любит, что бы каждый файл обозначался своим цветом, 
     * поэтому попросила Вас раскрасить файлы. Немного подумал и вспомнив, 
     * что язык C# позволяет нам это сделать, Вы тут же принялись выполнять 
     * эту необычную просьбу. Выберите место на Вашем компьютере, где будут
     * содержаться файлы разного расширения и раскрасьте папки - синим цветом, 
     * зип архивы - красным, текстовые файлы - зелёным, а презентации - фиолетовым. */
}
