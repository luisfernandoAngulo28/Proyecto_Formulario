using System;
using System.Collections.Generic;
using System.Text;

namespace CApp
{
  public class clsNatu
    {
        // Atributo
        private int _n;

        // Propiedades
        public int n
        {
            get { return _n; }
            set { _n = value; }
        }

        // Constructores

        public clsNatu() { n = 0; }

        public clsNatu(int x)
        {
            if (x >= 0)
            {
                this.n = x;
            }
            else this.n = 0;
        }

        public clsNatu(clsNatu t)
        {
            if (t.n >= 0)
            {
                this.n = t.n;
            }
            else this.n = 0;
        }

        // Funciones
        public int Cero()
        {
            return 0;
        }

        public bool EsCero(clsNatu x)
        {
            return (x.n == 0);
        }

        public clsNatu Sucesor(clsNatu x)
        {
            x.n = x.n + 1;
            return (x);
        }

        public clsNatu Predecesor(clsNatu x)
        {
            if (EsCero(x) == false)
            {
                x.n = x.n - 1;
            }
            return x;
        }


        public bool Igual(clsNatu x, clsNatu y)
        {
            if (EsCero(x) == true & EsCero(y) == false)
                return false;

            if (EsCero(x) == false & EsCero(y) == true)
                return false;

            if (x == y)
                return true;
            return false;
        }

        public clsNatu Suma(clsNatu a, clsNatu b)
        {
            if (EsCero(a) == true & EsCero(b) == false)
                return b;
            if (EsCero(a) == false & EsCero(b) == true)
                return a;
            clsNatu s = new clsNatu();
            s.n = a.n + b.n;
            return s;
        }


    }
}
