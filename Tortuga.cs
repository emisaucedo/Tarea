using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Tortuga : Carrera
    {
        public Tortuga(int x) : base(x)
        {
            _posicion = 0;
        }

        public int Iniciar()
        {
            int init;
            init = base.Iniciarcarrera();
            return init;
        }
    }
}
