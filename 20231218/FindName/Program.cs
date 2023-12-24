using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] mang = {"A1","A2","A3","A4","A5","A6"};
        Console.Write("Nhap ten Can Tim: ");
        string name = Console.ReadLine();
        bool istrue = false;
        for(int i= 0;i <= mang.Length-1;i++)
        {
            if (mang[i].Equals(name))//Equals la so sanh
            {
                Console.Write($"Vi tri ten ban can tim la {i+1}" );
                istrue = true;
                break;
            }
        }
        if(!istrue) 
        {
            Console.Write("Tim Ko co");
        }
    }
}