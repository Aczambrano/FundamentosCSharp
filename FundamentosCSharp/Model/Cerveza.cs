using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.Model
{
    class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int cantidadStock { get; set; }
        public Cerveza(int cantidad,string nombre ="Cerveza") : base(nombre,cantidad)
        { 
            this.cantidadStock = cantidad;
        }

        public int Alcohol { get; set; }
        public string marca { get; set; }
        public void maximoPermitido()
        {
            Console.WriteLine("el maximo permitido es 10");
        }
       
    }
}
