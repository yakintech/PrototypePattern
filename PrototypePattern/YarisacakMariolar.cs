using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class YarisacakMariolar : List<Mario>
    {
        public void Yaris()
        {
            foreach (var item in this)
            {
                Console.WriteLine("{0} isimli mario {1} amacıyla kosuyor", item.Ad, item.Amac);
            }
        }
    }
}
