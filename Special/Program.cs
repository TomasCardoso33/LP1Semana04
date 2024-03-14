using System;


namespace Special
{
    

    class Program
    {
        static int GetSpecial(int n)
        {
            int n1 = 1;
            int n2 = 0;
            int n3 = 0;
            for ( int i = 2 ; i < n ; i ++ )
            {
                n2 = n2*2;
                n3 = n1 + n2;
                n1 = n3;

            }
            Console.WriteLine(n1);
        }
    
        static void Main(string[] args)
        {
            GetSpecial(0);
            GetSpecial(2);
            GetSpecial(7);    
        }
         
    }
}
