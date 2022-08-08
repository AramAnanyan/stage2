using System;

namespace Menu_Rest
{
    class Program
    {
        enum a { k = 1 }
        public static int meth(int k)
        {
            Console.WriteLine(k);
            return 3;
        }
        static void Main(string[] args)
        {
            foreach (a val in Enum.GetValues(typeof(a)))
            {
                Console.WriteLine(((int)val));
            }
            meth(5);
        }
    }
}

