using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class Student : Human
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string College { get; set; }
        public Student(int course = 0, string group = "unknow", string faculty = "unknow", string college = "unknow")
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            College = college;
        }
        public Student(Student other)
        {
            Name = other.Name;
            Group = other.Group;
            Faculty = other.Faculty;
            College = other.College;
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"Course: {Course}\nGroup: {Group}\nFaculty: {Faculty}\nCollege: {College}");
        }
        public override void add()
        {
            base.add();
            Console.WriteLine("Course: ");
            Course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Group: ");
            Group = Console.ReadLine();
            Console.WriteLine("Faculty: ");
            Faculty = Console.ReadLine();
            Console.WriteLine("College: ");
            College = Console.ReadLine();
        }
    }
}
