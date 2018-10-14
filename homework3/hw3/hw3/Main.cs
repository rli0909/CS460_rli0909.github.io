using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw3
{
    class MyLQueue
    {
        static LinkedList<String> GenerateBinaryRepresentationList(int n)
        {
            LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

            LinkedList<String> output = new System.Collections.Generic.LinkedList<String>();

            if (n < 1)
            {
                return output;
            }

            q.Push(new StringBuilder("1"));

            while (n-- > 0)
            {
                StringBuilder sb = q.Pop();
                //add to output list  "not sure Addafter or Addlast"
                output.AddLast(sb.ToString());

                //copy
                StringBuilder sbc = new StringBuilder(sb.ToString());

                //left
                sb.Append('0');
                q.Push(sb);
                //right
                sbc.Append('1');
                q.Push(sbc);
            }
            return output;
        }

        //Drive program
        public static void main(String[] args)
        {
            int n = 10;
            if (args.Length < 1)
            {
                Console.WriteLine("Please invoke with the max value to print binary up to, like this:");
                Console.WriteLine("\tjava Main 12");
                return;
            }
            try
            {
                //convert "args[0]" to number
                n = int.Parse(args[0]);
            }
            catch (FormatException)
            {
                Console.WriteLine("I'm sorry, I can't understand the number: " + args[0]);
                return;
            }

            LinkedList<String> output = GenerateBinaryRepresentationList(n);

            int maxLength = output.Last().Length;  //non-invocable no"()"
            foreach (String s in output)
            {
                for (int i = 0; i < maxLength - s.Length; ++i)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s);
            }
        }


    }
}
