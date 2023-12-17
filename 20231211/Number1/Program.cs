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
                Write_dv2(dv1);
            }
            else if (Num < 100)
            {
                int chuc = (int)Num / 10;
                int dv2 = (int)Num % 10;
                // Console.WriteLine(chuc);
                //  Console.WriteLine(dv);
                Write_chuc(chuc);
                Console.Write(" Muoi ");
                Write_dv2(dv2);
                
            }
            else 
            {
                Console.WriteLine("xin vui long nhap lai");
            }
        }
       /* static void Write_chuc1(int temp1)
        {
            switch (temp1)
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
        }*/
        static void Write_chuc(int temp2)
        {
            switch (temp2)
            {
                case 2:
                    Console.Write("hai");
                    break;
                case 3:
                    Console.Write("ba");
                    break;
                case 4:
                    Console.Write("bon");
                    break;
                case 5:
                    Console.Write("nam");
                    break;
                case 6:
                    Console.Write("sau");
                    break;
                case 7:
                    Console.Write("bay");
                    break;
                case 8:
                    Console.Write("tam");
                    break;
                case 9:
                    Console.Write("Chin");
                    break;
            }
        }
        static void Write_dv2(int temp3)
        {
            {
                switch (temp3)
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
        }
    }
}