using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var character in input)
            {
                stack.Push(character);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop().ToString());
            }
        }
    }
}
