using System;
namespace tinhtygia
{
	class Program
	{
		private static void Main(string[] args)
		{
			float tygia;//khai báo giá trị của biến
			float soluong;//khai báo giá trị của biến
            Console.WriteLine("nhap ty gia USD: ");
			tygia = float.Parse(Console.ReadLine()); //lấy giá trị nhập từ bàn phím vào biến "tygia", float.Parse : chuyễn giá trị string nhập từ bàn phím thành kiểu float
            Console.WriteLine("nhap so luong USD Can doi: ");
			soluong = float.Parse(Console.ReadLine());//lấy giá trị nhập từ bàn phím vào biến "soluong", float.Parse : chuyễn giá trị string nhập từ bàn phím thành kiểu float
            Console.WriteLine("so tien VND= " + tygia * soluong);
		}

	}
}