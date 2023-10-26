using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FundamentosCSharp.Model
{
    class Bebida
    {
        public int stockBebida { get; set; }
        public string nombreBebida { get; set; }
        public int cantidadBebio { get; set; }

        public Bebida(string nombreBebida, int stockBebida)
        { 
            this.stockBebida = stockBebida;
            this.nombreBebida = nombreBebida;
            this.cantidadBebio = 0;
        }

        public void Beber(int bebio)
        {
            this.cantidadBebio += bebio;
            this.stockBebida -= bebio;
        }

        public void Imprmir()
        {
            Console.WriteLine("La bebida es "+this.nombreBebida+", hay "+this.stockBebida+" en stock"
                +" y usted bebió "+this.cantidadBebio + " de cantidad");
        }
    }
}
