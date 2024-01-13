using System;
namespace SystemTime
{
class Program
{
    private static void Main(string[] args)
    {
        DateTime localTime = DateTime.Now; // lấy giờ hệ thống
        Console.WriteLine("Thoi gian hien tai la: " + localTime); // xuất ra giờ hệ thống
    }
}
}