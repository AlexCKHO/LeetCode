using System.Runtime.CompilerServices;

namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string parentheses = "]";


            Console.WriteLine(IsValid(parentheses));


        }

        public static bool IsValid(string s)
        {
            // Get ready initial state (enforce element type)
            var k = new Stack<char>();
            // Evaluate each character for potential mismatch 
            foreach (char c in s)
            {
                
                // Push closing round bracket onto the stack
                if (c == '(') { k.Push(')'); continue; }
                // Push closing curly bracket onto the stack
                if (c == '{') { k.Push('}'); continue; }
                // Push closing square bracket onto the stack
                if (c == '[') { k.Push(']'); continue; }
                // Look out for imbalanced strings or mismatches
                if (k.Count == 0 || c != k.Pop()) return false;
                //^^^ k.Count == 0 prevent stack empty error,
                //When string is "}", there is nothing in the stack
                //c != k.Pop(), will Pop() an empty stack, which will cause an error
            }
            // Empty stack means string is valid and invalid otherwise
            return k.Count == 0;
        }

 

        }
    }
