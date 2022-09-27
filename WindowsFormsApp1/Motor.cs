using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Motor
    {
        private int potencia;

        public int Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }

        public int CargarPotencia(int pot)
        {
            potencia = pot;
            return potencia;
        }
    }
}
