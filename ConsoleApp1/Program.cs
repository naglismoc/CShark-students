using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            string[] names = { "Petras", "Jonas", "Karolis", "Naglis", "Marija", "Dovilė", "Deimantė" };
            string[] surnames = { "Timonova", "Mockevičius", "Demidenko", "Nevinskas", "Skiparė", "Kazakevičienė", "Burkauskaitė", "Tvaska","Bruožis" };

            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student( names[random.Next(0, names.Length-1)], surnames[random.Next(0, names.Length - 1)], random.Next(18, 60), numArr(3,14,1,10)));
            }



            for (int i = 0; i < students.Count; i++)
            {
                for (int a = i + 1 ; a < students.Count; a++)
                {
                    if (students[a].avg() > students[i].avg()) {
                        Student tmp = students[a];
                        students[a] = students[i];
                        students[i] = tmp;
                    }
                }
            }




            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }


        }
        public static  int[] numArr(int arrMin, int arrMax, int valMin, int valMax)
        {
            int[] numArr = new int[random.Next(arrMin, arrMax)];
            for (int a = 0; a < numArr.Length; a++)
            {
                numArr[a] = random.Next(valMin, valMax + 1);
            }
            return numArr;
        }
       
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }



    }
}
