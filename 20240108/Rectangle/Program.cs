using System.Drawing;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" nhap chiu rong hinh chu nhat");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine(" nhap chiu cao hinh chu nhat");
        double height = double.Parse(Console.ReadLine());
        Rectangle myRectangle = new Rectangle(width, height);
    }
}