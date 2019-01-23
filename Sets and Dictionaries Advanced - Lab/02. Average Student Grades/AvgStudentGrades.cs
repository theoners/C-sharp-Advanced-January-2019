namespace _02._Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AvgStudentGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var studentsGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var grade = double.Parse(input[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                }
                studentsGrades[name].Add(grade);
            }

            foreach (var studentGrade in studentsGrades)
            {
                Console.Write($"{studentGrade.Key} -> ");
                foreach (var grade in studentGrade.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {studentGrade.Value.Average():F2})");
            }
        }
    }
}
