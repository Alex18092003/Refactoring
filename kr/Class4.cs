using System;
using System.Collections.Generic;
using System.Text;

namespace kr
{
    class Class4
    {
        private int r;
        private int v;
        public int getWeight
        {
            set
            {
                r = value;
            }
        }

        public int getGrowth
        {
            set
            {
                v = value;
            }
            
        }
        public string showWeight
        {
            get
            {
                double ind = (double) v / (((double)r * (double)r)/10000) ;
                if (ind < 18.5)
                {
                    return "Дефицит массы тела";
                }
                else if ((ind >= 18.5) && (ind<25))
                {
                    return "Норма" ;
                }
                else
                {
                    return "Избыточная масса тела" ;
                }
            }
        }

    }
}
