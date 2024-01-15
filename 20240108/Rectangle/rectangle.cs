public class Rectangle
{
    double width, height;//được gán giá trị bởi this.width, và this.height
    public Rectangle(double width, double height, bool change) // phương thức
    {
        if (change)
        { 
        this.width = width / 2; 
        this.width = height / 2;

            Console.WriteLine("dai: "+width);
            Console.WriteLine("cao: " + height);

            Console.WriteLine(this.width);
            Console.WriteLine(this.height);
        }
    }
    public Rectangle(double width, double height) //phương thức có đối là width và height
    { 
        this.width = width; //giá trị witch lấy từ bên class Program
        this.height = height; //giá trị height từ bên class Program
    }
    public void PrintfArea()//phương thức
    {
        Console.WriteLine("dien tich: " + this.width * this.height); 
    }
    public void Perimetter()// phương thức
    {
        Console.WriteLine("chu vi la: " + (this.width + this.height) * 2);
    }
}