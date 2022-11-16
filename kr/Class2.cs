using System;
using System.Collections.Generic;
using System.Text;

namespace kr
{
    class Class2
    {
        public static string s;
        public static void removal (int n)
        {
            if (n >= s.Length)
            {
                Console.WriteLine("В строке нет столько символов");
            }
            else { 
            s =  s.Remove(n);
            Console.WriteLine(s);
            }
        }
    }
}
