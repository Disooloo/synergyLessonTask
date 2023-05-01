using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace synergyLessonTask2.Task4
{
    internal class DZ
    {
        private const int Capacity = 2000;
        private int _currentWaterAmount = 0;

        internal static void Task()
        {
            DZ tank = new DZ();

            tank.addWater(1500);
            tank.RemoveWater(500);
        }


        public void addWater(int waterAmount)
        {
            int newWaterAmount = _currentWaterAmount += waterAmount;
            if (newWaterAmount > Capacity)
            {
                Console.WriteLine("Невозможно добавить воду: емкость резервуара превышена");
            }
            else
            {
                _currentWaterAmount = newWaterAmount;
                Console.WriteLine($"Добавлено {waterAmount} литров воды, текущее количество воды: {_currentWaterAmount} литров");
            }
        }
        
        public void RemoveWater(int waterAmount)
        {
            int newWaterAmount = _currentWaterAmount -= waterAmount;
            if (newWaterAmount < 0 ) 
            {
                Console.WriteLine("Невозможно удалить воду: недостаточно воды в резервуаре\n");
            } else
            {
                _currentWaterAmount = newWaterAmount;
                Console.WriteLine($"Удалено {waterAmount} литров воды, текущее количество воды: {_currentWaterAmount} литров");
            }
        }
        
       
    }
    /*
Задание: 
Вы программист, который отвечает за склад, на котором хранится информация, 
а также за надежную работу вашей техники на водохранилище. В Вашем распоряжении 
огромный резервуар на 2 тонны. Но Вы так же в этом хранилище живут рыбы и когда приобретают 
рыб у Вас также берут немного воды для них, пока их переносят в аквариум к покупателю. 
И Вам пришёл запрос от нового поставщика, что Вам перелили с главного водохранилища -500 
литров воды. Новость хорошая, но вот беда, всем заправляет автоматическая система и она 
проделывает следующую операцию (Текущее количество воды + полученное количество). 
Отсюда получается, что по факту у нас будет полное хранилище, но по программе у нас станет на 
500 литров меньше и будет запрос на новую партию. Начав копаться в файлах, Вы поняли, что проще 
будет написать код с нуля и удалили его. Ваша задача написать верный код с чистого листа. 
Код с приходом обязан содержать отрицательный показатель. */
}

