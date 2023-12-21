class Program
{
    static void Main(string[] args)
    {
        Console.Write("nhap gia tri i: ");
        int i = int.Parse(Console.ReadLine());
        int a = 10;
        do
        {
            Console.Write(" " + a);
            a++;
        }
        while (a < i);
    }
}