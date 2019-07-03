using System; 
using System.Collections.Generic; 
using System.Text; 

namespace logic {
	class Program {
		static void Main(string[] args) {
			int a = 30; 
			int b = 10; 
			if (a > 20 || a < 5) {
				Console.WriteLine("a is targeted"); 
			}

			if (a < 50 && b < 50) {
				Console.WriteLine("a and b are targeted"); 
			}

			if (!(a <= b)) {
				Console.WriteLine("a is bigger than b"); 
			}

			Console.ReadLine(); 
		}
	}
}