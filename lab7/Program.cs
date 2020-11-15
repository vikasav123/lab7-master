using MyLib;
using System;
using System.Dynamic;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;
            while (!finish)
            {
                int variant = Convert.ToInt32(prompt_menu_item());
                switch (variant)
                {
                    case 0:
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine("Create new Human:\n");
                        Human human = new Human();
                        human.add();
                        Console.WriteLine("\nHuman:\n");
                        human.showInfo();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Create new Entrant:\n");
                        Entrant entrant = new Entrant();
                        entrant.add();
                        Console.WriteLine("\nEntrant:\n");
                        entrant.showInfo();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Create new student:\n");
                        Student student = new Student();
                        student.add();
                        Console.WriteLine("\nStrudent:\n");
                        student.showInfo();
                        break;
                    case 4:
                        Console.WriteLine("Create new teacher:\n");
                        Teacher teacher = new Teacher();
                        teacher.add();
                        Console.WriteLine("\nTheacher:\n");
                        teacher.showInfo();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Create new Library User:\n");
                        LibraryUser libraryUser = new LibraryUser();
                        libraryUser.add();
                        Console.WriteLine("\nLibrary User:\n");
                        libraryUser.showInfo();
                        Console.ReadKey();
                        break;
                    case 6:
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("Ви вибрали не правильний варіант");
                        break;
                }
        }
    }

        public static int prompt_menu_item()
        {
            Console.Clear();
            int variant;
            Console.WriteLine("Виберыть варіант\n");
            Console.WriteLine("1. Створити об класу Human та переглянути введені дані\n");
            Console.WriteLine("2. Створити об класу Entrant та переглянути введені дані\n");
            Console.WriteLine("3. Створити об класу Student та переглянути введені дані\n");
            Console.WriteLine("4. Cтворити об класу Teacher та переглянути введені дані\n");
            Console.WriteLine("5. Створити об класу LebraryUser та переглянути введені дані\n");
            Console.WriteLine("6. выйти\n");
            try
            {
                variant = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ви вибрали не правильний варіант");
                variant = 0;

            }
            
            return variant;
        }
    }
}
