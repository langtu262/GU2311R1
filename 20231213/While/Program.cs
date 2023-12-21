class Program
{
    static void Main(string[] args)
    {
        Console.Write("nhap gia tri i: ");
        int i = int.Parse(Console.ReadLine());
        int a = 0;
        while (a < i)
        {
            Console.Write(" " + a);
            a++;
        }
    }
}