class Program
{
    static void Main(string[] args)
    {
        Console.Write("nhap gia tri i: ");
        int i = int.Parse(Console.ReadLine());
        int a = 10;
        do //sẽ thực hiện trước các lệnh phía sau "do"
        {
            Console.Write(" " + a);
            a++;
        }
        while (a < i);// tiếp theo sẽ đến vòng lập white
    }
}