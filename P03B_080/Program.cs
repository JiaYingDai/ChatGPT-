using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03B_080
{
	internal class Program
	{
		// 設計一個類別來表示一個家庭，擁有父母、孩子姓名、年齡等屬性，以及計算平均年齡的方法。
		static void Main(string[] args)
		{
			string[] name = new string[] { "John", "Mary", "Mark" };
			int[] age = new int[] { 40, 38, 5 };
			Family anderson = new Family(name, age);
			
			for (int member=0; member < name.Count(); member++)
			{
				Console.WriteLine($"姓名: {name[member]}，年紀: {age[member]}");
			}
			Console.WriteLine($"\r\n全家平均年齡: {anderson.Average()}");

		}
	}

	class Family
	{
        public string[] Name { get; set; }
		public int[] Age { get; set; }
        public Family(string[] name, int[] age) 
		{
			this.Name = name;
			this.Age = age;
		}

		public double Average()
		{
			int sum = 0;
			for (int item = 0; item < this.Age.Count(); item++)
			{
				sum+= this.Age[item];
			}
			double average = (double)sum / this.Age.Count();
			average= Math.Round(average, 1, MidpointRounding.AwayFromZero);

			return average;
		}


	}
}
