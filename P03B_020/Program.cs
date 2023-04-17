using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03B_020
{
	// 設計一個類別來表示一個線段，擁有起點和終點兩個屬性，以及計算線段長度的方法
	internal class Program
	{
		static void Main(string[] args)
		{
			double[] siteA = { 1, 2 };
			double[] siteB= { 3, 4 };
			
			Line calLine = new Line(siteA, siteB);
			
			Console.WriteLine(calLine.LineLength());
		}
	}

	class Line
	{
        public double[] SiteA { get; set; }
		public double[] SiteB { get; set;}

		public Line(double[] siteA, double[] siteB) 
		{
			this.SiteA = siteA;
			this.SiteB = siteB;
		}

		public double LineLength()
		{
			double xSquare = Math.Pow((this.SiteA[0] - this.SiteB[0]), 2); // x座標相減的平方和
			double ySquare = Math.Pow((this.SiteA[1] - this.SiteB[1]), 2); // y座標相減的平方和

			double result=Math.Sqrt(xSquare+ySquare); // 對xSquare+ySquare開根號即為兩座標點距離

			return result;
		}
    }
}
