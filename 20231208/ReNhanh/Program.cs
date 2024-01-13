using System;
using System.Threading.Tasks.Dataflow;
namespace ReNhanh
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0 ;
            Console.WriteLine("nhap so can kiem tra: ");
            number = int.Parse(Console.ReadLine());
            if (number > 0) // điều kiện true
            {
                Console.WriteLine("so ban nhap la so duong");
            }
            else if (number < 0) // else: khi không thỏa điều kiện trên sẽ thực hiện 
            {
                Console.WriteLine("So ban nhan la so am");
            }
            else 
            {
                Console.WriteLine("So ban bang 0");
            }
        }
    }

}