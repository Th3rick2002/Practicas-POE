using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2.polimorfismo.modelo
{
    public class Computadora
    {
        public virtual void Encender()
        {
            MessageBox.Show("Encendiento computadora");
        }
    }

    public class ComputadoraPortatil : Computadora
    {
        public override void Encender()
        {
            MessageBox.Show("Encendiendo computadora portatil");
        }
    }

    public class ComputadoraEscritorio : Computadora
    {
        public override void Encender()
        {
            MessageBox.Show("Encendiendo computadora de escritorio");
        }
    }
}
