public class Rectangle
{
    double width, height;
    public Rectangle()
    {

    }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public void printfArea()
    {
        Console.WriteLine("dien tich hinh chu nhat la: " + this.width * this.height);
    }
    public void Perimeter()
    {
        Console.WriteLine("chu vi la: " + (this.width + this.height) * 2);
    }

}