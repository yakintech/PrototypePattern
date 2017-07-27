using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Mario : ICloneable
    {
        public string Ad { get; set; }

        public string Kask { get; set; }

        public string Sehir { get; set; }

        public string Amac { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
