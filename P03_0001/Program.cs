using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_0001
{
	// 使用 for 迴圈輸出一個字母金字塔，例如：
	//```
	//   A 排數=1, 字母數= 
	//  ABA
	// ABCBA
	//ABCDCBA
	//```

	internal class Program
	{
		static void Main(string[] args)
		{
			Pyramid.Builder(5);
		}
	}

	static class Pyramid
	{
		public static void Builder(this int input)
		{
			string mark=string.Empty;

			for (int row = 1; row <= input; row++)
			{
				mark += Convert.ToChar(64 + row).ToString(); // 隨row的增加產生A~row的字串
				string reverse=Reverse.ReverseString(mark.Substring(0,row-1)); // 根據mark取除了最後字母的所有字串，再將之反轉
				Console.WriteLine(new string(' ', input - row) + mark + reverse); // 製造適當的空字元, 並與mark, reverse串接
				
			}
		}

	}

	static class Reverse 
	{
		// 反轉字串
		public static string ReverseString(this string str)
		{
			var strArray=str.ToCharArray(); // myString.ToCharAarry: 將字元轉為字元陣列
			Array.Reverse(strArray); // 陣列反轉

			return new string(strArray);
		}
	}
}
