using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Comenzar_Click(object sender, EventArgs e)
        {
            {
                Liebre lieb = new Liebre(1);
                Tortuga tortu = new Tortuga(2);         
                do
                {
                    Resultado.Text += " Liebre: " + lieb.Iniciarcarrera().ToString() + Environment.NewLine + " Tortuga: " + tortu.Iniciarcarrera().ToString() + Environment.NewLine;
                }while (lieb.Posicion < 100 && tortu.Posicion <100);

                if (lieb.Posicion >= 100)
                {
                    Resultado.Text = "La liebre gano";
                }                  
                else if (tortu.Posicion >= 100)
                {
                    Resultado.Text = "La tortuga gano";
                }
                else
                {
                    Resultado.Text = "Empate";
                }
            }
        }
    }
}
