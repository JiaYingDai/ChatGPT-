using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P02_020
{
	// 讓使用者輸入三個整數a、b、c，然後判斷這三個數是否能夠組成一個三角形。如果可以，則輸出「可以組成三角形」，否則輸出「無法組成三角形」
	// Hint: 最短兩邊總和>第三邊
	internal class Program
	{
		static void Main(string[] args)
		{
			bool result = Triangle.IsTriangle(-3.5,4,5);

			if (result == true)
			{
				Console.WriteLine("可以組成三角形");
			}
			else
			{
				Console.WriteLine("不能組成三角形");
			}
		}
	}

	static class Triangle
	{
		
        public static bool IsTriangle(this double num1, double num2, double num3) 
		{
			if (num1>0 && num2>0 && num3>0) // 三個邊長都要是正數
			{
				List<double> triangleSide = new List<double> { num1, num2, num3 }; // 建立容納三邊長的list
				double maxSide = triangleSide.Max(); // 選取list中最長邊

				triangleSide.Remove(maxSide); // 將list最長邊移除，剩最短兩邊


				if (triangleSide.Sum() > maxSide) // 最短兩邊總和 > 最長邊
				{
					return true;
				}
				else
				{
					return false;
				}

			}

			else
			{
				return false;
			}
		}
	}
}
