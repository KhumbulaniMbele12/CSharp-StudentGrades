using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students do u have: ");
            int studentsTotal = Convert.ToInt32(Console.ReadLine());
            string[] classStudents = new string[studentsTotal];
            int[] classResults = new int[studentsTotal];

            for (int i = 0; i < classStudents.Length; i++)
            {

                Console.WriteLine("What is your name: ");
                classStudents[i] = Console.ReadLine();
                Console.WriteLine("What are your test results: ");
                classResults[i] = Convert.ToInt32(Console.ReadLine());

                string results;
                
                if (classResults[i] >= 90)
                {

                    results = "A";
                    Console.WriteLine("The student," + classStudents[i] + " passed very well with a grade" + results);

                }
                else if (classResults[i] >= 80)
                {

                    results = "B";
                    Console.WriteLine("The student," + classStudents[i] + " passed very well with a grade" + results);

                }
                else if (classResults[i] >= 70)
                {

                    results = "C";
                    Console.WriteLine("The student," + classStudents[i] + " passed very well with a grade" + results);

                }
                else
                {

                    results = "D";
                    Console.WriteLine("The student," + classStudents[i] + " perfomed very poorly with a grade" + results);

                }

            }
        }
    }
}
