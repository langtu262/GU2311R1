using System;
namespace Ptbacnhat
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so a: ");
            Double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap so b: ");
            Double b=Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine("phuong trinh co nghiem là: " + -b / a);
            }
            else
            {
                if (b==0)
                {
                    Console.WriteLine("phuong trinh vo nghiem: ");
                }
                else
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                }

            }
        }
    }
}
    
