using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    public class BaseDatos
    {
        MySqlConnection connection;

        public BaseDatos()
        {
            connection = new MySqlConnection("datasource = localhost; port =; username = root; password =; database = trabajadores; SSLMode = none");

        }

        public string ejecutarSQL(string sql)
        {
            string resultado = "";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            int filasResultados = cmd.ExecuteNonQuery();
            if (filasResultados > -1)
            {
                resultado = "Correcto";
            }
            else
            {
                resultado = "Incorrecto";
            }

            connection.Close();
            return resultado;
        }

        public DataTable DsplayData(string sql)
        {
            DataTable dTable = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(dTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message);
            }

            connection.Close();
            return dTable;
        }

    }
}
