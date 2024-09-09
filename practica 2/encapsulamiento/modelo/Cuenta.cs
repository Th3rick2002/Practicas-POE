using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2.encapsulamiento.modelo
{
    public class Cuenta
    {
        private double saldo {  get; set; }
        

        public void Depositar(double monto)
        {
            saldo += monto;
            MessageBox.Show("Deposito realizado con exito");
        }

        private void Retirar(double monto)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
                MessageBox.Show("Retiro realizado con exito");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        public void RealizarDeposito(double monto)
        {
            Depositar(monto);
        }

        public void RealizarRetiro(double monto)
        {
            Retirar(monto);
        }

        public void SaldoActual()
        {
            MessageBox.Show($"Su saldo actual es de {saldo}");
        }

    }
}
