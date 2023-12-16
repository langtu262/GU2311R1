using System;
namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu cao cua ban: ");
            float ChieuCao = float.Parse(Console.ReadLine());
            Console.Write("Nhap can nang cua ban: ");
            float Cannang = float.Parse(Console.ReadLine());
            Double BMI = Cannang / (ChieuCao * ChieuCao);
            BMI= Math.Round(BMI,1);
            Console.WriteLine("chi do BMI cua ban la: " + BMI);
            if (BMI < 18)
            {
                Console.Write("Ban gay");
            }
            else if (BMI < 25)
            { 
                Console.Write("Ban binh thuong");
            }
            else if(BMI <30)
            {
                Console.Write("Ban thua can");
            }
            else if(BMI>30) 
            {
                Console.Write("Ban beo phi");
            }
            else
            {
                Console.Write("Ban nhap ko dung cu phap");
            }
        }
    }
}