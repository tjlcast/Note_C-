using System; 
using System.Collections.Generic; 
using System.Text; 

namespace charExample {

	class Program {
		static void Main(string[] args) {
			char strChar = 'a'; 
			char numChar = '9'; 
			char conChar = 'b'; 

			if (char.IsLetter(strChar)) {
				Console.WriteLine("strChar is a letter"); 
			} else {
				Console.WriteLine("strChar is not a letter"); 
			}

			if (char.IsDigit(numChar)) {
				Console.WriteLine("numChar is a num"); 
			} else {
				Console.WriteLine("numChar is not a num"); 
			}

			Console.WriteLine(char.ToUpper(conChar)); 

			Console.ReadLine(); 
		}
	}
}