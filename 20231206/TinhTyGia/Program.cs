using System;
namespace tinhtygia
{
	class Program
	{
		private static void Main(string[] args)
		{
			float tygia;
			float soluong;
			Console.WriteLine("nhap ty gia USD: ");
			tygia = float.Parse(Console.ReadLine());
			Console.WriteLine("nhap so luong USD Can doi: ");
			soluong = float.Parse(Console.ReadLine());
			Console.WriteLine("so tien VND= " + tygia * soluong);
		}

	}
}