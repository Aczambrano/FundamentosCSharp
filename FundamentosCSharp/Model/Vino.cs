using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.Model
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public Vino(int cantidad, string nombre = "Vino") : base(nombre, cantidad)
        {

        }

        public int Alcohol { get; set; }

        public void maximoPermitido()
        {
            Console.WriteLine("el maximo permitido es 5 copas");
        }
    }
}
