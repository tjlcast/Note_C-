using System; 
using System.Collections.Generic; 
using System.Text; 

/**
	docs: 
		is 	_	[表达式 is 类型] 用于动态检测对象的运行时类型是否与给定的类型兼容. 
		as 	_ 	[表达式 as 类型] 当as指定的转换不能实现时，则运算结果为null. 

**/

namespace isOperator{
	class Program {
		static void Main(string[] args) {
			int b = 10; 
			if (b is bool) {
				Console.WriteLine("b's type is boolean"); 
			} else {
				Console.WriteLine("b's type is not boolean"); 
			}

			Console.ReadLine(); 
		}

		static void operAs() {
			object[] nums = new object[3]; 
			nums[0] = "123"; 
			nums[1] = 456; 
			nums[2] = "字符串"; 

			for (int i=0; i<nums.Length; i++) {
				string s = nums[i] as string 
				Console.Write("nums[{0}]:", i); 

				if (s != null) {
					Console.WriteLine("'" + s + "'"); 
				} else {
					Console.WriteLine("not a string"); 
				}
			}

			Console.ReadLine(); 
		}
	}
}