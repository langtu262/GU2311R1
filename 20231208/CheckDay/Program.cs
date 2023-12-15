using System;
using System.ComponentModel;
namespace CheckDay
{
    class Program
    {
        static void Main(String[] args)
        {
            int day;
            Console.WriteLine("nhap thu can in ra:(chu y: chi duoc nhap so 1 - 8)");
            day=int.Parse(Console.ReadLine());
            switch (day)
            {
                case 2: Console.WriteLine("Hom nay la Thu 2");
                    break;
                case 3:
                    Console.WriteLine("Hom nay la Thu 3");
                    break;
                case 4:
                    Console.WriteLine("Hom nay la Thu 4");
                    break;
                case 5:
                    Console.WriteLine("Hom nay la Thu 5");
                    break;
                case 6:
                    Console.WriteLine("Hom nay la Thu 6");
                    break;
                case 7:
                    Console.WriteLine("Hom nay la Thu 7");
                    break;
                case 8:
                    Console.WriteLine("Hom nay la Thu 8");
                    break;
                default: Console.WriteLine("ban da nhap sai cu phap");
                    break;

            }

        }
    }
}