# CODING

## A sample program

    ```
        using System; 
        using System.Collections.Generic; 
        using System.Linq; 
        using System.Text; 
        using System.Threading.Task; 

        namesspace SimpleCSharpApp {
            // option one. 
            class Program {
                static void Main() {    // 这里的签名也可以写作: static void int Main(string[] args)
                    Console.WriteLine("**** Hello CSharp! ****"); 
                    Console.ReadLine(); 
                }
            }

            // option two.
            class Program {
                static int Main(string[] args) {
                    foreach(string arg in args) {
                        Console.WriteLine("Arg: {0}", arg)
                    }
                    return 0; 
                }
            }
        }
    ```

    - Main： app入口。必须给工程指定，可以通过命令行编译器的/main选项。


```mermaid
graph LR
    start[开始] --> input[输入A,B,C]
    input --> conditionA{A是否大于B}
    conditionA -- YES --> conditionC{A是否大于C}
    conditionA -- NO --> conditionB{B是否大于C}
    conditionC -- YES --> printA[输出A]
    conditionC -- NO --> printC[输出C]
    conditionB -- YES --> printB[输出B]
    conditionB -- NO --> printC[输出C]
    printA --> stop[结束]
    printC --> stop
    printB --> stop
```
