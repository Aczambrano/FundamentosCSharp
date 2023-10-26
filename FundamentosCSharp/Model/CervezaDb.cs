using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.Model
{
    class CervezaDb
    {
        private string connectionString = "Data Source=DESKTOP-KS0PHCL\\SQLEXPRESS;Initial Catalog=Bebidas;" +
            "User=sa;Password=root";


        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select nombre,marca,alcohol, cantidad from cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int cantidad = reader.GetInt32(3);
                    string nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(cantidad,nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.marca = reader.GetString(1);
                    cervezas.Add(cerveza);

                }
                reader.Close();
                connection.Close();
            }

            return cervezas;
        }

        public void Add(Cerveza cerveza)
        {
            if (cerveza != null)
            {
                string query = "insert into cerveza(nombre,marca,alcohol,cantidad) values(@nombre,@marca,@alcohol,@cantidad)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", cerveza.nombreBebida);
                    command.Parameters.AddWithValue("@marca", cerveza.marca);
                    command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                    command.Parameters.AddWithValue("@cantidad", cerveza.cantidadStock);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();

                }
            }
        }

        public void Edit(Cerveza cerveza, int id)
        {
            if (cerveza != null)
            {
                string query = "update cerveza set nombre=@nombre,marca=@marca, alcohol=@alcohol, cantidad=@cantidad " +
                    "where idCerveza=@id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", cerveza.nombreBebida);
                    command.Parameters.AddWithValue("@marca", cerveza.marca);
                    command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                    command.Parameters.AddWithValue("@cantidad", cerveza.cantidadStock);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();

                }
            }
        }


        public void Delete(int id)
        {
            if (id != null)
            {
                string query = "delete from cerveza where idCerveza=@id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();

                }
            }
        }


    }

}
