using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Grading_Students
    {
        static int[] solve(int[] grades)
        {
            List<int> result = new List<int>();

            foreach (int grade in grades)
            {
                if ((grade % 5 >= 3) && (grade >= 38))
                {
                    result.Add(grade + (5 - (grade % 5)));
                }
                else
                {
                    result.Add(grade);
                }
            }
            return result.ToArray();
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = solve(grades);
            Console.WriteLine(String.Join("\n", result));


        }
    }
}
