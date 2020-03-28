using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    class gameClass
    {
        public int Loadspiner;
        public int shootaway = 2;
        public int buellets = 6;
        public int load = 1;


        public int spinmethod(int spiner)
        {
            if (spiner == 6)
            {
                spiner = 1;

            }
            else
            {
                spiner++;
            }

            return spiner;
        }
    }
}

