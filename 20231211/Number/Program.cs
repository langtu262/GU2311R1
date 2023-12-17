using System;
namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so can doc:");
            int Num=int.Parse(Console.ReadLine());
            if(Num<10) 
            {
                switch(Num) 
                {
                    case 0:
                        Console.WriteLine("So khong");
                        break;
                    case 1:
                        Console.WriteLine("So mot");
                        break;
                    case 2:
                        Console.WriteLine("So hai");
                        break;
                    case 3:
                        Console.WriteLine("So ba");
                        break;
                    case 4:
                        Console.WriteLine("So bon");
                        break;
                    case 5:
                        Console.WriteLine("So nam");
                        break;
                    case 6:
                        Console.WriteLine("So sau");
                        break;
                    case 7:
                        Console.WriteLine("So bay");
                        break;
                    case 8:
                        Console.WriteLine("So tam");
                        break;
                    case 9: 
                        Console.WriteLine("So Chin");
                    break;
                }
            }
            else if(Num<20)
            {
               // int chuc = (int)Num / 10;
                int dv1 = (int)Num % 10;
                // Console.WriteLine(chuc);
                //  Console.WriteLine(dv);
                Console.Write("Muoi ");
                switch(dv1) 
                {                
                    case 1:
                        Console.WriteLine("Mot");
                        break;
                    case 2:
                        Console.WriteLine("hai");
                        break;
                    case 3:
                        Console.WriteLine("ba");
                        break;
                    case 4:
                        Console.WriteLine("bon");
                        break;
                    case 5:
                        Console.WriteLine("nam");
                        break;
                    case 6:
                        Console.WriteLine("sau");
                        break;
                    case 7:
                        Console.WriteLine("bay");
                        break;
                    case 8:
                        Console.WriteLine("tam");
                        break;
                    case 9:
                        Console.WriteLine("Chin");
                        break;
                }
            }
            else if (Num < 100)
            {
                int chuc = (int)Num / 10;
                int dv2 = (int)Num % 10;
                // Console.WriteLine(chuc);
                //  Console.WriteLine(dv);
                switch (chuc)
                {
                    case 2:
                        Console.Write("hai muoi");
                        break;
                    case 3:
                        Console.Write("ba muoi");
                        break;
                    case 4:
                        Console.Write("bon muoi");
                        break;
                    case 5:
                        Console.Write("nam muoi");
                        break;
                    case 6:
                        Console.Write("sau muoi");
                        break;
                    case 7:
                        Console.Write("bay muoi");
                        break;
                    case 8:
                        Console.Write("tam muoi");
                        break;
                    case 9:
                        Console.Write("Chin muoi");
                        break;
                }
                switch (dv2)
                {
                    case 1:
                        Console.WriteLine(" Mot");
                        break;
                    case 2:
                        Console.WriteLine(" hai");
                        break;
                    case 3:
                        Console.WriteLine(" ba");
                        break;
                    case 4:
                        Console.WriteLine(" bon");
                        break;
                    case 5:
                        Console.WriteLine(" nam");
                        break;
                    case 6:
                        Console.WriteLine(" sau");
                        break;
                    case 7:
                        Console.WriteLine(" bay");
                        break;
                    case 8:
                        Console.WriteLine(" tam");
                        break;
                    case 9:
                        Console.WriteLine(" Chin");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("xin vui long nhap lai");
            }
        }
    }
}