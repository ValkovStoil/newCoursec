using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var theStack = new Stack(4);
            theStack.push("Jon Week");
            theStack.push("The Girl Next Door");
            theStack.push("Matrix");
            theStack.push("Jon Week 2");
            theStack.push("Jon Week 3");

            Console.WriteLine("======================= \nAbout the peek:");
            Console.WriteLine($"'{theStack.peek()}' is at the top of the stack.\n");

            Console.WriteLine("======================= \nThe Stack contains:\n");

            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                Console.WriteLine(movie);
            }
        }

        public class Stack
        {
            private int maxSize;
            private string[] stackArray;
            private int top;

            public Stack(int size)
            {
                maxSize = size;
                stackArray = new string[maxSize];
                top = -1;
            }

            public void push(string m)
            {
                if (isFUll())
                {
                    Console.WriteLine("This stack is full");
                }
                else
                {
                    top++;
                    stackArray[top] = m;
                }
            }
            public string pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("This stack is empty");
                    return "--";
                }
                else
                {
                    int old_top = top;
                    top--;
                    return stackArray[old_top];
                }
            }
            public string peek()
            {
                return stackArray[top];
            }
            public bool isEmpty()
            {
                return (top == -1);
            }

            public bool isFUll()
            {
                return (maxSize - 1 == top);
            }
        }
    }
}
