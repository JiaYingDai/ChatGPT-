using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P05_150
{
	//  輸入一個整數陣列，找出其中出現頻率最高的數字，並顯示在 Console 上
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array1 = new int[] { -1, 1, 2, 2, 3, 3, 3, 4 };
			IntArray maxArray = new IntArray(array1);
			maxArray.GetMax();
		}

	}

	class IntArray
	{
        public int[] Array1 { get; set; }

		public IntArray(int[] array1) 
		{
			this.Array1 = array1;

		}

		public void GetMax() 
		{
			var list = new Dictionary<int,int>() ;

			int count = 1;
			foreach(int item in this.Array1)
			{
				if (list.ContainsKey(item))
				{
					list[item] += count;
				}
				else
				{
					list.Add(item, count);
				}

			}

			foreach(var item in list)
			{
				string result = $"{item.Key}出現{item.Value}次";
				Console.WriteLine(result);
			}
		}
    }
}
