using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT練習題
{
	// 設計一個類別來表示一個矩形，擁有長和寬兩個屬性，以及計算面積和周長的方法
	internal class Program
	{
		static void Main(string[] args)
		{
			Rectangle rect = new Rectangle(12, 5);
			rect.GetResult();
		}
	}

	public class Rectangle
	{
        public int Length { get; set; }
        public int Width { get; set; }

		public Rectangle(int length, int width)
		{
			this.Length = length;
			this.Width=width;
		}

		private int Area()
		{
			int area=this.Length*this.Width;
			return area;
		}

		private int Perimeter()
		{
			int perimeter = (this.Length + this.Width) * 2;
			return perimeter;
		}

		public void GetResult()
		{
			Console.WriteLine("長為{0}、寬為{1}的矩形，計算面積為{2}，計算周長為{3}", this.Length, this.Width, Area(), Perimeter());
		}
    }
}
