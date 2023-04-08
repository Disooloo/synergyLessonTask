using System;

namespace synergyLessonTask.Task9
{
    public class Task9
    {
        public static void getTest9()
        {
            // DZ

            int[,,] numInts = new int[2, 2, 2] {
                { {1, 1}, {3, 3} },
                { {2, 2}, {4, 4} }
            };

            Console.WriteLine($"1 - {numInts[0,0,0]}\n2 - {numInts[1,0,0]}\n3 - {numInts[0,1,1]}");

           /*
            const int length = 3;
            string[] people = new string[length];

            for (int i = 0; i < length; i++)
                people[i] = Console.ReadLine();

            Console.Clear();

            for (int i = 0;i < length; i++)
                Console.WriteLine($"Индекс {i} - {people[i]}");

            //Console.WriteLine(people[1]);
         


            int[][] number = new int[][] {
                new int[] {1, 3, 4, 5},
                new int[] {3, 4}
            };

            Console.WriteLine($"5 - {number[0][3]}\n3 - ({number[0][1]},{number[1][0]})");


            */

        }
    }
}