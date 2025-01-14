﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Students_Joined_to_Specialties
{
    class Program
    {
        static void Main(string[] args)
        {
            var specs = new List<StudentSpecialty>();

            var students = new List<Student>();

            string input;

            while ((input = Console.ReadLine()) != "Students:")
            {
                var tokens = input.Split(' ');

                specs
                    .Add(new StudentSpecialty(tokens[0] + " " + tokens[1]
                    , int.Parse(tokens[2])));
            }

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(' ');

                students
                    .Add(new Student(tokens[1] + " " + tokens[2]
                    , int.Parse(tokens[0])));
            }

            specs
                 .Join(students,
                 sp => sp.FacultyNumber,
                 st => st.FacultyNumber,
                 (sp, st) => new
                 {
                     Name = st.StudentName,
                     FacNum = sp.FacultyNumber,
                     Spec = sp.SpecialtyName
                 })
                 .OrderBy(res => res.Name)
                 .ToList()
                 .ForEach(res => Console.WriteLine
                 ($"{res.Name} {res.FacNum} {res.Spec}"));
        }
    }
    public class Student
    {
        public string StudentName { get; set; }
        public int FacultyNumber { get; set; }

        public Student(string name, int number)
        {
            this.StudentName = name;
            this.FacultyNumber = number;
        }
    }
    public class StudentSpecialty
    {
        public string SpecialtyName { get; set; }
        public int FacultyNumber { get; set; }

        public StudentSpecialty(string name, int number)
        {
            this.SpecialtyName = name;
            this.FacultyNumber = number;
        }
    }
}
