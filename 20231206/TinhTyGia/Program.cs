using System;
namespace tinhtygia
{
	class Program
	{
		private static void Main(string[] args)
		{
			float tygia;
			float soluong;
			Console.WriteLine("nhap ty gia: ");
			tygia = float.Parse(Console.ReadLine());
			Console.WriteLine("nhap so luong: ");
			soluong = float.Parse(Console.ReadLine());
			Console.WriteLine("so tien doi duoc= " + tygia * soluong);
		}

	}
}