using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class modulo
    {
        public static MySqlConnection conexion;
        public static void AbrirConexion()
        {
            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString = "Server=localhost;" +
                                              "Database=EscFutA4;" +
                                              "Uid=root;" +
                                              "Pwd=;";
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void CerraConexion()
        {
            try
            {
                conexion = new MySqlConnection();
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

