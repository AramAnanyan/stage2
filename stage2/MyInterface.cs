using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage2
{
    interface MyInterface
    {
        public float price { get; set; }
        public string size { get; set; }

        public DateTime date { get; set; }
        public bool isdiet { get; set; }
        public float caloria { get; set; }

    }
}
