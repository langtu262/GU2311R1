internal class Program
{
    private static void Main(string[] args)
    {
        int tong = 0;
        int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i <= mang.Length - 1; i++)
        {
            tong += mang[i];
        }
        Console.WriteLine("tong cua mang la: " + tong);
    } 
}