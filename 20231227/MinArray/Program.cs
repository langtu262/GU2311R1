internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        Console.WriteLine("gia tri nho nhat la: "+ minf(array));

    }
    static int minf(int[] array) //ham
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    void TenHam() // phương thức không có giá trị trả về
    { 
    
    }
}
