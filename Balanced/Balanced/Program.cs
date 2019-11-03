using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced
{
    class Program
    {
        static void Main(string[] args)
        {
           string input=Console.ReadLine();
               bool isBalanced=IsBalanced(input);
                if (isBalanced)
                {Console.WriteLine("Brackets are balanced");}
                else 
                {Console.WriteLine("wrong input");}
               Console.ReadKey();
    }

        static bool IsBalanced(string brackets)
            {
           var stack= new Stack<char> ();
            foreach(var bracket in brackets)
                {
                if (bracket=='(' || bracket=='[' || bracket=='{')
                    {
                    stack.Push(bracket);
                    }
                else 
                {
                if (stack.Count==0)
                    {
                        return false;
                    }
                char currBracket=stack.Pop();
                    if (bracket == '}' && currBracket == '{' ||
                        bracket == ')' && currBracket == '(' ||
                        bracket == ']' && currBracket == '[')
                        {
                        continue;
                        }
                    else
                        {
                        return false;
                      
                         }
                    }
                }
            return stack.Count()==0;}

                
        }
     }
