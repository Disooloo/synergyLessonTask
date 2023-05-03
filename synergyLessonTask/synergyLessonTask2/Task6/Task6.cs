using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace synergyLessonTask2.Task6
{
    //Тема 6. Чтение и запись файлов с использованием потоков
    internal class Task6
    {
        internal const string path = @"C:\\Users\\kroli\\Desktop\\";
        internal static void GetTask6()
        {
            // FileStream fileStream = new FileStream($@"{path}\append.txt", FileMode.Append);

            DZ.DZTask();

            /*
            string textToWrite = ReadTextInFile($@"{path}\append.txt");
            Console.WriteLine(textToWrite);

            Console.WriteLine("Введите текст");
             string text = Console.ReadLine();
             WriteTextInFile(text, $@"{path}\append.txt");*/
        }

        private static void WriteMessageForText()
        {
            using (StreamWriter streamWriter = new StreamWriter($@"{path}\append.txt"))
            {
                streamWriter.WriteLine("Новое сообщение");
            }
        }
        private static void ReadMessageForText()
        {
            using (StreamReader streamReader = new StreamReader($@"{path}\append.txt"))
            {
                string text = streamReader.ReadToEnd();
                Console.WriteLine(text);
            }
        }

        private static void WriteTextInFile(string textToWrite, string path)
        {
           using(FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate)) 
           {
                byte[] bytes = Encoding.UTF8.GetBytes(textToWrite);
                fileStream.Write(bytes, 0, bytes.Length);
           }
            Console.WriteLine("Информация записана");
        }

        private static string ReadTextInFile(string path)
        {
            string textToWrite = string.Empty;

            using(FileStream fileStream = File.OpenRead(path))
            {
                byte[] bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, bytes.Length);
                textToWrite = Encoding.UTF8.GetString(bytes);
            }

            return textToWrite;
        }
    }
}
