using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D3.OOP_II
{
    internal class ContoCorrente
    {
        public double Saldo { get; set; } = 0;
        public double Versamento(double quantita) 
        {
            return Saldo += quantita;
        }
        public double Prelievo(double quantita)
        {
            return Saldo -= quantita;
        }
    }
}
