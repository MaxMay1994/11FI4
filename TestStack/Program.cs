using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace TestStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack.Stacker s = new Stack.Stacker();
            
            s.Push("Test1");
            String line = (String)s.Pop();
            Console.Write(line);
            Console.ReadLine();
        }
    }
}
