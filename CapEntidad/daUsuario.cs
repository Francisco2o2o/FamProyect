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
    public class daUsuario
    {
        public String daGuardaUsuario(Usuario objUsuario, Int32 condicion)
        {
            SqlParameter[] pa = new SqlParameter[10];
            ConexionSql objCnx = null; // agregamos una variable a la conexion


            try
            {
                pa[0] = new SqlParameter("@docPersona", SqlDbType.VarChar, 13);
                //pa[0].Value = objUsuario.DocPersona;




                objCnx = new ConexionSql("");//hacemos una nueva conexion
                objCnx.EjecutarProcedimiento("uspGuardarPersona", pa);//Llamamos al procedimiento que se encuentra en sql

                return "OK";
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
