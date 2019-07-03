using System; 
using System.Collections.Generic; 
using System.Text; 

/***
	docs: 
		object 	类型是所有其他类型的基类型，
				所以可把任何类型的值赋给它
***/

namespace objectType {
	class Program {
		static void Main(string[] args) {
			object obType; 
			obType = 10; 
			Console.WriteLine(obType); 
			Console.WriteLine(obType.GetType()); 
			obType = false; 
			Console.WriteLine(obType); 
			Console.WriteLine(obType.GetType()); 
			Console.ReadLine(); 
		}
	}
}