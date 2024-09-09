using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_2.polimorfismo.modelo
{
    public partial class polimorfismoForm : Form
    {
        private List<Computadora> computadores;

        public polimorfismoForm()
        {
            InitializeComponent();
            computadores = new List<Computadora>
            {
                new Computadora(),
                new ComputadoraPortatil(),
                new ComputadoraEscritorio()
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Computadora computadora in computadores)
            {
                computadora.Encender();
            }
        }
    }
}
