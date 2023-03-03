using CapaConexion;
using CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDatos
{
    public class daValidarUsuario
    {

        public DataTable daValidarUser(Usuario obVjusuario)
        {
            SqlParameter[] pa = new SqlParameter[2];
            DataTable GuardarDatos;//almacenar los datos que se comparan en la base de datos
            ConexionSql objCnx = null; // agregamos una variable a la conexion


            try
            {
               
                pa[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
                pa[0].Value = obVjusuario.User;
                pa[1] = new SqlParameter("@password", SqlDbType.VarChar, 250);
                pa[1].Value = obVjusuario.Password;
             

                objCnx = new ConexionSql("");//hacemos una nueva conexion

                GuardarDatos=objCnx.EjecutarProcedimientoDT("uspLoginUser", pa);//Llamamos al procedimiento que se encuentra en sql

                return GuardarDatos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                if (objCnx != null)
                    objCnx.CierraConexion();
                objCnx = null;
            }

        }
    }
}
