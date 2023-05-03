using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace synergyLessonTask2.Task8
{
    internal class Fish
    {
        private string _id { get; set; }
        private string _name { get; set; }
        private string _type { get; set; }
        private string _color { get; set; }
        private string _size { get; set; }

        const string path = @"D:\Project\Синергия\git\synergyLessonTask\synergyLessonTask\synergyLessonTask2\Task8\fish.txt";


        public Fish() { }
        public Fish(string id, string name, string type, string color, string size)
        {
            _id = id;
            _name = name;
            _type = type;
            _color = color;
            _size = size;
        }

        public static void ViewFish()
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                string text = streamReader.ReadToEnd();
                streamReader.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(text);
                streamReader.Close();
            }
        }

        public static void AddFish()
        {
            int totalLines;
            // Чтение всех строк из файла в массив
            string[] lines = File.ReadAllLines(path);

            // Получение последней строки и ее первого символа
            string lastLine = lines[lines.Length - 1];
            char firstChar = lastLine[0];

            totalLines = lines.Length;

            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                Console.WriteLine("Введите имя рыбки: ");
                string name = Console.ReadLine();

                Console.WriteLine("Введите тип рыбки: ");
                string type = Console.ReadLine();

                Console.WriteLine("Введите цвет рыбки: ");
                string color = Console.ReadLine();

                Console.WriteLine("Введите Размер рыбки: ");
                string size = Console.ReadLine();

                // Генерация ID на основе количества строк в файле
                int id = totalLines + 1;

                // Создание нового экземпляра класса Fish
                Fish newFish = new Fish(id.ToString(), name, type, color, size);

                // Запись новой рыбки в файл
                string newLine = $"{newFish._id} " +
                    $"Имя рыбки: {newFish._name} " +
                    $"Тип рыбки: {newFish._type} " +
                    $"Цвет рыбки: {newFish._color} " +
                    $"Размер рыбки: {newFish._size}";

                streamWriter.WriteLine(newLine);
                streamWriter.Close();
            }

            Console.WriteLine("Рыбка добавлена.");
        }

        public static void EditFish()
        {
            ViewFish();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Выберите id записи для редактирования: ");

            string idToEdit = Console.ReadLine();

            try
            {
                using (StreamReader streamReader = new StreamReader(path, true))
                {
                    using (StreamWriter streamWriter = new StreamWriter((path)))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (line.StartsWith(idToEdit))
                            {
                                Console.WriteLine($"Редактирование рыбки с id {idToEdit}:");
                                Console.Write("Введите новое имя: ");
                                string name = Console.ReadLine();
                                Console.Write("Введите новый тип: ");
                                string type = Console.ReadLine();
                                Console.Write("Введите новый цвет: ");
                                string color = Console.ReadLine();
                                Console.Write("Введите новый размер: ");
                                string size = Console.ReadLine();

                                Fish editedFish = new Fish(idToEdit, name, type, color, size);

                                streamWriter.WriteLine($"{idToEdit}. " +
                                        $"Имя рыбки: {name} " +
                                        $"Тип рыбки: {type} " +
                                        $"Цвет рыбки: {color} " +
                                        $"Размер рыбки: {size}");
                            }
                            else
                            {
                                streamWriter.WriteLine(line);
                            }
                        }
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void FirstLaunch()
        {
            Fish[] fish = new Fish[]
            {
                new Fish("1", "Рыбка0", "Карась", "Черный", "20"),
                new Fish("2", "Рыбка1", "Окунь", "Красный", "40")
             
            };
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {

                foreach (var item in fish)
                {
                    string test = ($"{item._id}. " +
                        $"Имя рыбки: {item._name} " +
                        $"Тип рыбки: {item._type} " +
                        $"Цвет рыбки: {item._color} " +
                        $"Размер рыбки: {item._size}");
                    streamWriter.WriteLine(test);
                }
            }


        }


    }
}
