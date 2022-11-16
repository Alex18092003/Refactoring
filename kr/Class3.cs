using System;
using System.Collections.Generic;
using System.Text;

namespace kr
{
    class Class3
    {
        public string s;
        public char c;
        public Class3  (string s, char c)
            {
            this.s = s;
            this.c = c;
            }

        public static int operator +(Class3 a, Class3 b)
        {
            return a.s.Length + b.s.Length;
        }

        public static int operator -(Class3 a, Class3 b)
        {
            int ii;


            if (a.c >=b.c)
            {
               ii = a.c - a.c;
            }
            else
            {
                ii = b.c - a.c;
            }
            char symd = Convert.ToChar(ii);
            return symd;
        }


    }
}
