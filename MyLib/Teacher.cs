using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class Teacher : Human
    {
        public string Position { get; set; }
        public string Chair { get; set; }
        public string College { get; set; }

        public Teacher(string position = "unknow", string chair = "unknow", string college = "unknow")
        {
            Position = position;
            Chair = chair;
            College = college;
        }
        public Teacher(Teacher other)
        {
            Name = other.Name;
            Chair = other.Chair;
            College = other.College;
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"Possition: {Position}\nChair: {Chair}\nCollege: {College}");
        }
        public override void add()
        {
            base.add();
            Console.WriteLine("Position: ");
            Position = Console.ReadLine();
            Console.WriteLine("Chair: ");
            Chair = Console.ReadLine();
            Console.WriteLine("College: ");
            College = Console.ReadLine();

        }
    }
}
