using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class dzialanie
    {
        public int liczba { get; private set; }
        public Enum znak { get; private set; }

        public dzialanie( Enum z,int l)
        {
            liczba = l;
            znak = z;

        }

    }
}
