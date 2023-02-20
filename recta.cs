using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms
{
    internal class Recta
    {
        private Punto a;
        private Punto b;

        public Recta()
        {
            a = new Punto();
            b = new Punto();
        }

        public Punto A { get { return a; } set { a = value; } }
        public Punto B { get { return b; } set { b = value; } }

        static public double CalcularDistancia(Punto a, Punto b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }

        static public string CalcularPendiente(Punto a, Punto b)
        {
            float numerador, denominador;

            numerador = b.Y - a.Y;
            denominador = b.X - a.X;

            return $"{numerador}/{denominador}";
        }

        static public string CalcularPuntoMedio(Punto a, Punto b)
        {
            float xMedio, yMedio;

            xMedio = (a.X + b.X) / 2;
            yMedio = (a.Y+ b.Y) / 2;

            return "(" + xMedio.ToString() + ", " + yMedio.ToString() + ")";

        }

    }
}
