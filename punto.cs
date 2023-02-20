using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms
{
    internal class Punto
    {
        private float x;
        private float y;

        public Punto()
        {
            x = 0;
            y = 0;
        }

        public float X { get { return x;  } set { x = value; } }
        public float Y { get { return y;  } set { y = value; } }
    }
}
