using System;
namespace OrderArray
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n = 0;
            Console.Write("nhap so phan tu mang: ");
            n=int.Parse(Console.ReadLine());
            int[] array = new int[n+1];
            Console.WriteLine("Nhap gia tri mang: ");
            for (int i = 0; i < n; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Gia tri phan tu mang: ");
            for (int i = 0;i < n; i++)
            {
                Console.Write(array[i]);
                Console.Write("\t");
            }
            Console.Write("\n");
            Console.Write("Nhap gia tri phan tu can chen: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri can chen: ");
            int p = int.Parse(Console.ReadLine());
            for (int i = n; i >= p; i--)
            {
                array[i] = array[i-1];
            }
            array[p-1] = x;
            for (int i = 0;i<=n; i++)
            {
                Console.Write(array[i]);
                Console.Write("\t");
            }
        }
    }
}
