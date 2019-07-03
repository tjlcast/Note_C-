### 属性

#### setter and getter
```C#
using System; 
using System.Collections.Generic; 
using System.Text; 

namespace propertyText {
	class Program {
		static void Main(string[] args) {
			ClassText ct = new ClassText("ligang"); 
			Console.WriteLine(ct.Name); 
			ct.Name = "liuming"; 
			Console.WriteLine(ct.Name); 
			Console.ReadLine();
		}
	}

	class ClassText {
		private String name = String.Empty; 

		public ClassText() {
			Console.WriteLine("测试类"); 
		}

		public ClassText(string name) {
			this.name = name; 
		}

		public String Name {
			get {
				return name; 
			}
			set {
				name = value; 
			}
		}
	}
}
```

#### 方法的声明
+ public int add(int a, int b) {
	return a + b; 
}


```C#
using System; 
using System.Collections.Generic; 
using System.Text; 
namespace staticText {
	class Program {
		int exaVar; 
		static int stVar; 

		void exampleMethod() {
			exaVar 	= 1; 
			stVar 	= 1; 
		}

		static void sMethod() {
			// exaVar = 1; 
			stVar = 1; 
		}

		/***
			tips: 
				不能在类的实例中访问静态资源
				不能在类的实例中访问静态成员 
		***/
		static void Main(string[] args) {
			Program text 	= new Program(); 
			text.exVar 		= 1; 
			Program.stVar 	= 1; 

			text.exampleMethod(); 
			Program.sMethod(); 

			Console.ReadLine(); 
		}
	}
}
```

#### virtual method
```C#
using System; 
using System.Collections.Generic; 
using System.Text; 

namespace virtualText {
	public class AbText {
		public virtual void ab_output() {
			Console.WriteLine("this is virtual method"); 
		}

		public void noAb_output() {
			Console.WritleLine("this isn't vitual method"); 
		}
	}

	public class MyClass : AbText {
		public override void ab_output() {
			Console.WriteLine("this is the new func"); 
		}

		public new void noAb_output() {
			Console.WriteLine("this is a another func"); 
		}
	}

	class Program {
		static void Main(string[] args) {
			MyClass mc = new MyClass() ; 
			AbText ab = c1 ; 

		}
	}
}
```


#### override method
+ 重写方法用相同的签名重写所继承的虚方法. 
+ C# 通过 override 和 virtual 关键字实现了java中的继承. 
```C#
using System; 
using System.Collections.Generic; 
using System.Text; 

namespace overrideText {
	class Class1 {
		public virtual void ovText() {
			Console.WriteLine("this is a virtual method"); 
		}
	}

	class Class2 : Class1 {
		public override void ovText() {
			Console.WriteLine("this is a override method"); 
		}
	}

	class Program {
		static void Main(string[] args) {
			Class2 cl2 = new Class2(); 
			cl2.ovText(); 
			Class1 cl1 = new Class1(); 
			cl1.ovText(); 
			Console.ReadLine(); 
		}
	}
}
```

#### 外部方法
+ extern 修饰通常与 DllImport 属性一起使用，从而使外部方法可以由DLL实现.
```C#
	using System; 
	using System.Collections.Generic; 
	using System.Text; 
	using System.Runtime.InteropServices; 

	namespace externText {
		class Program {
			[DllImport("User32.dll")] 
			public static extern int MessageBox(int h, string m, string c, int type); 

			static int Main(string[] args) {
				Console.Write("Please input msg: "); 
				string str = Console.ReadLine(); 
				return MessageBox(0, str, "我的信息提示框")； 
			}
		}
	}
```