using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synergyLessonTask2.Task8
{
    internal class Customer
    {
        private string _name;
        private string _addres;
        private int _postCode;

        public Customer() { }
        public Customer(string name, string addres, int postCode) 
        {
            _name = name;
            _addres = addres;
            _postCode = postCode;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Адрес: {_addres}");
            Console.WriteLine($"Почтовый индекс: {_postCode}");
        }
    }
}
