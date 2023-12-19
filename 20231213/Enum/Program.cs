using System;
//namespace Se
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

    class Program
    {
        private static void Main(string[] args)
        {
        Season mySeason = Season.Spring;
        switch (mySeason)
        {
            case Season.Spring: Console.WriteLine("Day la mua Xuan");
                break;
            case Season.Summer: Console.WriteLine("Day la mua He");
                break;
            case Season.Autumn: Console.WriteLine("Day la mua thu");
                break;
            case Season.Winter: Console.WriteLine("Day la mua Dong");
                break;
            default: Console.WriteLine("ban nhap sai");
                break;
        }
        }
    }
