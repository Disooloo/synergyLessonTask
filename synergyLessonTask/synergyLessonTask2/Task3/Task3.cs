using System;
using System.CodeDom;

namespace synergyLessonTask2.Task3
{
    public class Task3
    {
        #region Тема 3. Перехват исключений



        #endregion
        internal static void GetTask3()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
            }
            catch(DivideByZeroException ex) when (a == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Деление 1 на 0: " + ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Неверный формат");
            }
            catch (Exception ex)
            {
                MFinal("Error" + ex.Message);
            }
            finally
            {
                MFinal("Finally");
            }
        }

        private static void MFinal(String message)
        {
            Console.WriteLine(message);
        }
       


    }
}