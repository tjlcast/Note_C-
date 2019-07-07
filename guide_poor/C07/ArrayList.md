### ArrayList
+ 动态数组，在System.Collections的命名空间下


### element的添加
#### example. 
```C#
using System; 
using System.Collections.Generic; 
using System.Text; 

namespace ArrayListAdd{
	class Program {
		static void Main(string[] args) {
			System.Collections.ArrayList al = new System.Collections.ArrayList(3); 
			Console.WriteLine(al.Count); 

			al.Add("abc"); 
			al.Add(10); 
			al.Add(50); 
			Console.WriteLine(al.Count); 

			string[] last = {"lasta", "lastb"}; 
			al.AddRange(last); 
			Console.WriteLine(al.Count); 

			Console.ReadLine(); 
		}
	}
}
```

- 从上面可以看出
+ 默认为object. 
+ "abc"、10、50具有相同的父类型. 
+ 数组(Array)也是Collections下的子类（集合类). 

### element的删除
+ ArrayList 对象.Remove(val)
+ ArrayList 对象.RemoveAt(index)
+ ArrayList 对象.RemoveRange(startIndex, num)