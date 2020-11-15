using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class LibraryUser : Human
    {
        public int TicketNumber { get; set; }
        public string DateofIssue { get; set; }
        public double MonthlyPayment { get; set; }

        public LibraryUser(int ticketNumber = 0, string dateofIssue = "unknow", double mounthlyPayment = 0)
        {
            TicketNumber = ticketNumber;
            DateofIssue = dateofIssue;
            MonthlyPayment = mounthlyPayment;
        }

        public LibraryUser(LibraryUser other)
        {
            TicketNumber = other.TicketNumber;
            DateofIssue = other.DateofIssue;
            MonthlyPayment = other.MonthlyPayment;
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"\nTicket number: {TicketNumber}\nDate of issue: {DateofIssue}\nMonthle payment: {MonthlyPayment}");
        }
        public override void add()
        {
            base.add();
            Console.WriteLine("Tiket number: ");
            TicketNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date of issue: ");
            DateofIssue = Console.ReadLine();
            Console.WriteLine("MonlyPayment: ");
            MonthlyPayment = Convert.ToDouble(Console.ReadLine());
        }
    }
}
