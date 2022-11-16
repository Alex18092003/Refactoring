using System;
using System.Collections.Generic;
using System.Text;

namespace kr
{
    class Class1
    {
        private int n;
        public Class1 (int n)
            {
             this.n = n % 10;

            }
        public Class1()
        {
            n = -1;
        }
        public override string ToString()
        {
            return "Значение числового поля: " +n;
        }


    }
}
