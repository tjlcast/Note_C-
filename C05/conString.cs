using System; 
using System.Collections.Generic; 
using System.Text; 

namespace conString {
	class Program {
		static void Main(string[] args) {
			string conStr; 
			conStr = "This is An Example Of The Conversion On The String. ";

			string capital; 
			string lowercase; 
			capital = conStr.ToUpper(); 
			lowercase = conStr.ToLower(); 

			Console.WriteLine("big case: 	" + capital); 
			Console.WriteLine("small case: 	" + lowercase); 
			Console.ReadLine(); 
		}

		static void strEqual(){
			if ("A" == "B") {

			} else {

			}

			if (string.Equals("A", "B")) {

			} else {

			}
		}

		static void strFormat() {
			/// string.Format(要转换的格式, 	格式化的对象)
			/// string.Format(要转换的格式，	格式化的对象一，	格式化的对象二)
			String.Format(
				"默认格式:	_{0}" + 
				"其他格式:	_{0:C}" + 
				"其他格式:	_{0:D}", 300); 
		}

		static void todo() {
			/// todo 
		}
	}
}