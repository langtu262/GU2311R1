class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so lan in : ");
        int i = int.Parse(Console.ReadLine());
        int a;
        for (a = 0; a < i; a++)
        {
            for (int b = 0; b < i; b++)
            {
                Console.Write(a + " " + b);
                Console.WriteLine(" ");
            }
        }
    }
}