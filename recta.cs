using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms
{
    internal class recta
    {
        private Punto a;
        private Punto b;

        public recta()
        {
            a = new Punto();
            b = new Punto();
        }
        public recta(Punto a, Punto b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
