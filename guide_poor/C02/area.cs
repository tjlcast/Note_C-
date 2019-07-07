using System; 
using System.Collections.Generic; 
using System.Text; 

namespace area
{
	class Program
	{
		static void Main(string[] args) {
			const double PI = 3.14; 
			Console.Write("请输入一个整数为圆的半径："); 
			int R = Convert.ToInt32(Console.ReadLine()); 
			double Area = PI * R * R; 
			Console.Write("所求圆的面积： " + area); 
			Console.ReadLine(); 
		}
	}
}