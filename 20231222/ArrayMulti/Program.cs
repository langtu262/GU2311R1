
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("nhap so hang cua mang: ");
        int x=int.Parse(Console.ReadLine());
        Console.Write("nhap so cot cua mang: ");
        int y=int.Parse(Console.ReadLine());
        int[,] Array = new int[x,y];
        for (int i = 0; i < x; i++) //nhap gia tri mang
        {
            Console.WriteLine("Nhap gia tri dong thu: " + (i + 1));
            for (int j = 0; j < y; j++)
            {                      
                Console.Write($"nhap gia tri mang {i+1},{j+1}: ");
                Array[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Gia tri cua mang la: ");
        for (int i = 0;i < x; i++)
        {         
            for (int j = 0;j < y; j++)
            {
                Console.Write(Array[i,j]);
                Console.Write("\t");
            }
            Console.Write("\n");
        }

    }
}
 