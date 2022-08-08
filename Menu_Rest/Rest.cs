using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Rest
{
    public abstract class Rest
    {
        public abstract bool eathere();
        public abstract bool ReturnFood();
        public abstract bool Delivery(int foodtype);
    }
}
