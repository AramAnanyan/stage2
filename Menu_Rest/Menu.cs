using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Rest
{
    public  interface Menu
    {
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public int Caloria { get; set; }
        public abstract void Make();
    }
}
