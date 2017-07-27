using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            mario.Ad = "Çağatay";
            mario.Amac = "İnsanlık için";
            mario.Kask = "Süper";
            mario.Sehir = "Çorum";


            Mario mario2 = (Mario)mario.Clone();
            mario2.Amac = "Hatun";

        }
    }
}
