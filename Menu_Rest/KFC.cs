using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Rest
{
    class KFC : Rest
    {
        int[] arr = new int[] { 0, 1, 3 };
        public override bool Delivery(int foodtype)
        {
            return true;
        }

        public override bool eathere()
        {
            throw new NotImplementedException();
        }

        public override bool ReturnFood()
        {
            throw new NotImplementedException();
        }
        void make(int foodnum)
        {
            bool k=false;
            for(int i=0; i<arr.Length;i++)
                if (foodnum == arr[i])
                {
                    k = true;
                    break;
                }
            if (k == false) {
                Console.WriteLine("KFC doesn't contain this food");
            }
        }
    }
}
