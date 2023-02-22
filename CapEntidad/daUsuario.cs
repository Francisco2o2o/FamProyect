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
        public String daGuardaUsuario(Usuario objusuario, Int32 condicion)
        {
            SqlParameter[] pa = new SqlParameter[4];
            ConexionSql objCnx = null; // agregamos una variable a la conexion


            try
            {
                pa[0] = new SqlParameter("@idPersona", SqlDbType.Int);
                pa[0].Value = objusuario.IdPersona;
                pa[1] = new SqlParameter("@usuario", SqlDbType.VarChar, 50);
                pa[1].Value = objusuario.User;              
                pa[2] = new SqlParameter("@passUsuario", SqlDbType.VarChar, 250);
                pa[2].Value = objusuario.Password;
                pa[3] = new SqlParameter("@fechaReg", SqlDbType.DateTime);
                pa[3].Value = objusuario.FechaReg;

                objCnx = new ConexionSql("");//hacemos una nueva conexion
                objCnx.EjecutarProcedimiento("uspGuardarUsuario", pa);//Llamamos al procedimiento que se encuentra en sql

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
