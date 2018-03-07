using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbrStudents = int.Parse(Console.ReadLine());
            Student[] arrStudents = new Student[nmbrStudents];
            for (int i = 0; i < nmbrStudents; i++)
            {
                string[] arrayStudentData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Student newStudent = new Student() { Name = arrayStudentData[0],Grades = new List<double>() };
                for (int j = 1; j < arrayStudentData.Length; j++)
                {
                    double grade = double.Parse(arrayStudentData[j]);
                    newStudent.Grades.Add(grade);
                }
                arrStudents[i] = newStudent;
            }
            var finalStudents = arrStudents.Where(x=>x.AverageGrade>=5.0).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade);
            foreach (var item in finalStudents)
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrade,0:f2}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }
    }
}
