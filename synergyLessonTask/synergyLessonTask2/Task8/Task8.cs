using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synergyLessonTask2.Task8
{
    //Тема 8. Создание и использование классов
    internal class Task8
    {
        internal static void GetTask8()
        {
            DZ.DZTask();
        }

        private static void lection()
        {
            /* Customer customer = new Customer(); // Не верный вариант 
             customer.Name = "Ivan";
             customer.Addres = "Moscov";
             customer.PostCode = 200200; 
            customer.DisplayInfo();*/

            //Customer Othercustomer = InitializeCustomer("Avo", "SPB", 20000); // Не совсем верный вариант 
            //Othercustomer.DisplayInfo();


            Customer customer1 = new Customer("Bob", "EKB", 203002); // перегруз класса. Верный вариант 
            customer1.DisplayInfo();
        }
        /*
        private static Customer InitializeCustomer(string name, string addres, int postCode)
        {
            Customer customer = new Customer();

            customer.Name = name;
            customer.Addres = addres;
            customer.PostCode = postCode;

            return customer;
        }
        */

    }
}
