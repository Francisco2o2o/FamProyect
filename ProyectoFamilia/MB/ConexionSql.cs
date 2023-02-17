using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFamilia.Class
{
    class ConexionSql
    {
        public static SqlConnection conexion()
        {

            //Server = husat.database.windows.net
            //DataBase = Husat
            //User = husat
            //Password = hus@2022

            //string servidor = "localhost";
            //string bd = "Familia";
            //string usuario = "sa";
            //string password = "123456";

            string servidor = "husat.database.windows.net";
            string bd = "Familia";
            string usuario = "husat";
            string password = "hus@2022";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id= " + usuario + "; Password=" + password + "";

            try
            {
                SqlConnection conexionBD = new SqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
