using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Carrera
    {
        private int _numerocorredor;
        public int _posicion;
        private static Random random = new Random();

        public Carrera(int x)
        {
            _numerocorredor = x;
            _posicion = 0;
        }

        public int Numerocorredor
        {
            get { return _numerocorredor; }
        }

        public int Posicion
        {
            get { return _posicion; }
        }
           
    
        public int Iniciarcarrera()
        {

            if (Numerocorredor == 1)           
            {
                int c = random.Next(3,6);
                int d = random.Next(1,4);

                if (c==4)
                {
                    if (d==1)
                    {
                        _posicion += 0;
                    }
                    else if (d==2)
                    {
                        _posicion += 5;
                    }
                    else
                    {
                        _posicion -= 8;
                    }
                }

                else if (c==3)
                {
                    _posicion -= 4;
                }
                else
                {
                    _posicion += 12;
                }
            }

                else
                {
                    {
                        int e = random.Next(1,3);
                        int f = random.Next(1,4);

                    if (e==1)
                    {
                        _posicion += 3;
                    }
                    else
                    {
                        if (f==1)
                        {
                            _posicion += 6;
                        }
                        else if (f==2)
                        {
                            _posicion -= 5;
                        }
                        else
                        {
                            _posicion -= 9;
                        }
                    }

                }

            }

 return _posicion;

        }
    }
}
