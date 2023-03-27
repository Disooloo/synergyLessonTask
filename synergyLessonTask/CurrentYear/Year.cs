using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// Директива InternalsVisibleTo позволяет другим сборкам (здесь yearUnitTest) иметь доступ к внутренним членам этой сборки.
[assembly: InternalsVisibleTo("yearUnitTest")]

namespace CurrentYear
{
    internal class Year
    {
        // Главный метод программы, который выводит текущий год на экран.
        private static void Main()
        {
            int year = GetCounterYear();
            Console.WriteLine(year);
        }

        // Вспомогательный метод, который возвращает текущий год.
        internal static int GetCounterYear() => DateTime.Now.Year;

    }

}
