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
            SqlParameter[] pa = new SqlParameter[9];
            ConexionSql objCnx = null; // agregamos una variable a la conexion


            try
            {
                pa[0] = new SqlParameter("@nomPersona", SqlDbType.VarChar, 150);
                pa[0].Value = objpersona.NomPersona;
                pa[1] = new SqlParameter("@apePat", SqlDbType.VarChar, 150);
                pa[1].Value = objpersona.ApePat;
                pa[2] = new SqlParameter("@apeMat", SqlDbType.VarChar, 150);
                pa[2].Value = objpersona.ApeMat;
                pa[3] = new SqlParameter("@docPersona", SqlDbType.VarChar, 13);
                pa[3].Value = objpersona.DocPersona;
                pa[4] = new SqlParameter("@ocupacionPersona", SqlDbType.VarChar, 100);
                pa[4].Value = objpersona.DocPersona;
                pa[5] = new SqlParameter("@correoPersona", SqlDbType.VarChar, 200);
                pa[5].Value = objpersona.CorreoPersona;
                pa[6] = new SqlParameter("@fotoPersona", SqlDbType.Image);
                pa[6].Value = objpersona.FotoPersona;
                pa[7] = new SqlParameter("@cumPersona", SqlDbType.DateTime);
                pa[7].Value = objpersona.CumPersona;
                pa[8] = new SqlParameter("@regPersona", SqlDbType.DateTime);
                pa[8].Value = objpersona.RegPersona;
                

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
