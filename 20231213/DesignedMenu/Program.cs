using System;
using System.Xml;
namespace DesignedMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = int.Parse(Console.ReadLine());
            int i = -1;
            while (i!=0) //vòng lập while sẽ lập khi thỏa điều kiện trong ngoặt, khi không thỏa điều kiện phương trình sẽ thoát
            {
                Console.Write("nhap so 1 , 2 de hien thi hinh anh, phim 0 de thoat: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("*");
                        Console.WriteLine("**");
                        Console.WriteLine("***");
                        Console.WriteLine("****");
                        Console.WriteLine("*****");
                        break;
                    case 2:
                        {
                            Console.WriteLine("**********");
                            Console.WriteLine("**********");
                            Console.WriteLine("**********");
                            Console.WriteLine("**********");
                            Console.WriteLine("**********");
                        }
                        break;
                    default: Console.WriteLine("Xin vui long nhap lai");
                        break;
                       
                }
            }
        }
    }
}
