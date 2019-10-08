using System;

namespace Deciscion_constructs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine(true);
            }

            if (false)
            {
                Console.WriteLine(true);
            }

            if (false)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("if/else {0}", false);
            }

            #region switch statement example
            Console.WriteLine("Switch Statement Example");
            // To give a statement of values. Normally no for loop 
            for(int i=0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine(i);
                        break;
                    case 1:
                        Console.WriteLine(i);
                        break;
                        // falls down untill it can find code
                    case 2:
                    case 3:
                        Console.WriteLine("2 or 3: {0}", i);
                        break;
                    default:
                        Console.WriteLine("default: {0}", i);
                        break;
                }
            }

            #endregion

        }
    }
}
