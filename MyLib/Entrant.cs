using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class Entrant : Human
    {
        public int ZNORes { get; set; }
        public int DocProOsv { get; set; }
        public string School { get; set; }
        
        public Entrant(int znoRes = 0, int docProOSv = 0, string school = "unknow")
        {
            ZNORes = znoRes;
            DocProOsv = docProOSv;
            School = school;
        }
        public Entrant(Entrant other)
        {
            ZNORes = other.ZNORes;
            DocProOsv = other.DocProOsv;
            School = other.School;
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"ZNO result: {ZNORes}\nDocProOsv: {DocProOsv}\nSchool: {School}");
        }
        public override void add()
        {
            base.add();
            Console.WriteLine("ZNORes: ");
            ZNORes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DocProOsv: ");
            DocProOsv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("School: ");
            School = Console.ReadLine();
        }
    }
}
