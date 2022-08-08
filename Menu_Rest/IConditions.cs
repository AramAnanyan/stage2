using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Rest
{
    interface IConditions
    {
        public int adress { get; set; }
        public int phone { get; set; }
        public bool isDelivery { get; set; }
        DateTime isAvaliabe { get; set; }
    }
}
