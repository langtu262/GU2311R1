using System;
namespace UsingOperator
{
class Program
{
    private static void Main(string[] args)
    {
        float Width;
        float Height;
        Console.WriteLine("nhap gia tri hinh chu nhat:");
        Console.WriteLine("Nhap chieu rong: ");
        Width = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap chiu cao: ");
        Height = float.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hinh chu nhat la: " + Width*Height);

       
    }
}
}