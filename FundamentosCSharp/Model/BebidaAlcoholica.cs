using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.Model
{
    interface IBebidaAlcoholica
    {
        int Alcohol { get; set; }

        void maximoPermitido();
    }
}
