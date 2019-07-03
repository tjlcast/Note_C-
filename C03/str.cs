using System; 
using System.Collections.Generic; 
using System.Text; 

namespace str {
	class Program {
		static void Main(string[] args) {
			string str1 = "forepart"; 
			string str2 = str1; 
			Console.WriteLine("str1=" + str1); 
			Console.WriteLine("str2=" + str2); 
			str1 = "afterward"; 
			Console.WriteLine("str1=" + str1); 
			Console.WriteLine("str2=" + str2);
			Console.ReadLine();  
			/// 最后的str2输出还是之前的赋值
		}
	}
}