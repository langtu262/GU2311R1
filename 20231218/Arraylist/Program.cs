internal class Program
{
    private static void Main(string[] args)
    {
        //Khai báo mang dang 1: kieu[] tenmang = new kieu[do dai mang]
        int[] mylist = new int[10]; //mang co 10 phan tu
        //Khai báo mang dang 2
        int[] mylist2 = {1,2,3,4,5,6,7,8,9,10}; //mang co gia tri khoi tao tu ban dau
        int a = mylist[0]; // lay gia tri vao a
        mylist[0] = 1; // dua gia tri vao mang
        Console.WriteLine(mylist2.Length);// in do dai cua mang, co cú phap tenmang.length 
        Console.WriteLine(mylist2.Length-1);//in chi so cuoi dung cua mang
    }
}
