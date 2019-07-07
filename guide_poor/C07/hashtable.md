### Hashtable
----

### Hashtable 查找方法 
+ Usage: Hashtable obj.method(key); 
+ Contains
+ ContainsKey 
+ ContainValue

### Example 
```C#
using System; 
using System.Collections.Generic; 
using System.Text; 

namespace hashtableContains {
	class Program {
		static void Main(string[] args) {
			System.Collections.Hashtable ht = new System.Collections.Hashtable(); 
			ht.Add("A", "a"); 
			ht.Add("B", "b"); 
			ht.Add("C", "c"); 

			if (ht.ContainsValue("c")) {
				Console.WriteLine("c is in it"); 
			}

			if (ht.ContainsKey("A")) {
				Console.WriteLine("A is in it"); 
			}

			if (ht.Contains("B")) {
				Console.WriteLine("B is in it"); 
			}

			Console.ReadLine(); 
		}
	}
}
```