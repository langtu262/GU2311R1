using System;
namespace ConvertFC
{
    static class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
           while (choice != 0)
            {
                Console.Write("nhap lua chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("do F la: " + celsius());
                        }
                        break;
                    case 2:
                        {
                           Console.WriteLine("do C la : "+ fahrenheit());
                        }
                        break;

                        default:
                        {
                            Console.WriteLine("nhap lai lua chon. ");
                            
                        }
                        break;
                }
            }
           static int celsius()
            {
                Console.Write("Nhap gia tri do C: ");
                int C = int.Parse(Console.ReadLine());
                int F = 9 / 5 * C + 32;
                return F;
            }
            static int fahrenheit()
            {
                Console.Write("Nhap gia tri do F: ");
                int F = int.Parse(Console.ReadLine());
                int C = (F - 32) * 5 / 9 ;
                return C;
            }

        }
    }
}
