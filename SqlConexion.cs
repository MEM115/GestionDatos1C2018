using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    public class SqlConexion
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private static SqlCommand command;

        public static int ejecutarQuery(string query)
        {
            int respuesta;
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            respuesta = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return respuesta;
        }
        public static DataTable consultaQuery(string query)
        {
            DataTable dataTable = new DataTable();
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter
            {
                SelectCommand = command
            };
            
            da.Fill(dataTable);
            da.Dispose();
            command.Dispose();
            connection.Close();
            return dataTable;
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
