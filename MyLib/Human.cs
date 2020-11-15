using System;

namespace MyLib
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOFBirth { get; set; }

        public Human(string name = "unknow", string surname = "unknow", string dateOfBirth = "unknow")
        {
            Name = name;
            Surname = surname;
            DateOFBirth = dateOfBirth;
        }
        public Human(Human other)
        {
            Name = other.Name;
            Surname = other.Surname;
            DateOFBirth = other.DateOFBirth;
        }
        public virtual void showInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nDate of birth: {DateOFBirth}");
        }
        public virtual void add()
        {
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            Surname = Console.ReadLine();
            Console.WriteLine("Date of bitrh: ");
            DateOFBirth = Console.ReadLine();
        }
    }
}
