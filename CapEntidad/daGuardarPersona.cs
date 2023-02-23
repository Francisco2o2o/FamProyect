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
    public class daGuardarPersona
    {
        public String daGuardaPersona(Persona objpersona, Int32 condicion)
        {
            SqlParameter[] pa = new SqlParameter[10];
            ConexionSql objCnx = null; // agregamos una variable a la conexion


            try
            {
                pa[0] = new SqlParameter("@docPersona", SqlDbType.VarChar, 13);
                pa[0].Value = objpersona.DocPersona;
                pa[1] = new SqlParameter("@nombre", SqlDbType.VarChar, 150);
                pa[1].Value = objpersona.NomPersona;
                pa[2] = new SqlParameter("@apePat", SqlDbType.VarChar, 150);
                pa[2].Value = objpersona.ApePat;
                pa[3] = new SqlParameter("@apeMat", SqlDbType.VarChar, 150);
                pa[3].Value = objpersona.ApeMat;
                pa[4] = new SqlParameter("@rol", SqlDbType.Int);
                pa[4].Value = objpersona.Rol;
                pa[5] = new SqlParameter("@ocupacion", SqlDbType.Int);
                pa[5].Value = objpersona.Ocupacion;
                pa[6] = new SqlParameter("@correo", SqlDbType.VarChar, 100);
                pa[6].Value = objpersona.CorreoPersona;
                pa[7] = new SqlParameter("@fotoPersona", SqlDbType.Image);
                pa[7].Value = objpersona.FotoPersona;
                pa[8] = new SqlParameter("@fechaRegistro", SqlDbType.Date);
                pa[8].Value = objpersona.RegPersona;
                pa[9] = new SqlParameter("@fechaNacimiento", SqlDbType.Date);
                pa[9].Value = objpersona.FechaNacimiento;
                pa[10] = new SqlParameter("@idPersona", SqlDbType.Int);
                pa[10].Value = objpersona.IdPersona;




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
