using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synergyLessonTask2.Task4
{
    internal class Task4
    {
        //Тема 4. Выброс исключений
        internal static void GetTask4()
        {
            DZ.Task();
        }

        private void Lection()
        {
            try
            {
                int health = 100;
                int damage = 50;

                TakeDamage(ref health, -damage);
                Console.WriteLine(health);
            }
            catch (InvalideDamageException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Damage);
            }
        }

        private static void TakeDamage(ref int health, int damage)
        {
            if (damage < 0)
                throw new InvalideDamageException(damage);  


            if (health > damage)
                health -= damage;
            else
                health = 0;
        }
    }
}
