using FundamentosCSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
     class Program
    {
        static void Main(string[] args)
        {
            CervezaDb cervezaDb = new CervezaDb();

            //Obtener todas las cervezas
            //obtenerCervezas();
            //insertarCervezas();
            //editarCervezas();
            eliminarCervezas();
        }

        static void eliminarCervezas()
        {
            CervezaDb cervezaDB = new CervezaDb();
            cervezaDB.Delete(5);
        }

        static void editarCervezas()
        {
            CervezaDb cervezaDb = new CervezaDb();
            Cerveza cerveza = new Cerveza(20, "Switch");
            cerveza.marca = "Cerveceria";
            cerveza.Alcohol = 10;
            cervezaDb.Edit(cerveza, 5);
            obtenerCervezas();

        }

        static void insertarCervezas()
        {
            CervezaDb cervezaDb = new CervezaDb();
            Cerveza cerveza = new Cerveza(15,"Switch");
            cerveza.marca = "Cerveceria";
            cerveza.Alcohol = 6;
            cervezaDb.Add(cerveza);
            Console.WriteLine("se inserto correctamente " + cerveza.nombreBebida);
            obtenerCervezas();
        }

        static void obtenerCervezas()
        {
            CervezaDb cervezaDb = new CervezaDb();

            List<Cerveza> cerveza = cervezaDb.Get();

            foreach (var item in cerveza)
            {
                Console.WriteLine(item.nombreBebida);

            }
        }
    }
}
