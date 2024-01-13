internal class Program
{
    private static void Main(string[] args)
    {
        int size = 0;
        do
        {
            Console.Write("Nhap kich thuoc mang: ");
            size = int.Parse(Console.ReadLine());
            if (size > 20)
            { Console.WriteLine("nhap lai"); }
        }
        while (size > 20);
        int[] array= new int[size]; //khai báo mảng array
        Console.WriteLine($"Mang cua ban co {size} phan tu xin nhap gia tri phan tu mang"); // "$" chèn giá trị biểu thức vào lệnh xuất
        for (int i = 0;i <= array.Length-1;i++)
        {
            int j=i+1;
            Console.WriteLine("Gia tri thu: " +j );
                array[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"{size} gia tri phan tu mang cua ban la: ");
        for (int i = 0; i <= array.Length-1;i++)
        {
            Console.Write(array[i] + "\t"); // Tab
        }
        int max = array[0];
        int vitri = 0;
        for (int i = 0;i<= array.Length-1;i++)
        {
            if (max < array[i])
            { 
                max = array[i];
                vitri = i+1;
            }
        }
        Console.WriteLine("\n");// xuống dòng
        Console.WriteLine("gia tri lon nhat cua mang la: " + max + " o phan tu thu: " + vitri);
    }
}