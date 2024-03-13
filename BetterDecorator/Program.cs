using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string c = "";
            int co = 0; 
            string fs = "";

            for (int i1 = 0; i1 < args.Length; i1++)
            {
                if (i1 == 0)
                {
                    s = args[i1];
                }
                else if (i1 == 1)
                {
                    c = args[i1];
                }
                else if (i1 == 2)
                {
                   
                    co = int.Parse(args[i1]);
                }
            }

            for (int j = 0; j < co; j++)
            {
                fs += c;
            }

            fs += s;

            for (int j = 0; j < co; j++)
            {
                fs += c;
            }

            Console.WriteLine(fs);
        }
    }
}
