using CapaConexion;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDatos
{
    public class daBuscarPersona
    {
        public DataTable daBuscarPers(Boolean habilitarFechas, DateTime fechaInical, DateTime fechaFinal, String nomPersona, Int32 numPagina)
        {

            SqlParameter[] pa = new SqlParameter[5];
            DataTable dtPersona;
            ConexionSql objCnx = null;
            

            try
            {
                pa[0] = new SqlParameter("@peHabilitarFechas", SqlDbType.Bit) { Value = habilitarFechas };
                pa[1] = new SqlParameter("@peFechaInical", SqlDbType.DateTime) { Value = fechaInical };
                pa[2] = new SqlParameter("@peFechaFinal", SqlDbType.DateTime) { Value = fechaFinal };
                pa[3] = new SqlParameter("@NombreP", SqlDbType.NVarChar, 45) { Value = nomPersona };
                pa[4] = new SqlParameter("@peNumPagina", SqlDbType.Int) { Value = numPagina };
                objCnx = new ConexionSql("");
                dtPersona = objCnx.EjecutarProcedimientoDT("uspBuscarPersona", pa);

                return dtPersona;

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
                dtPersona = null;
            }

        }

    }
}
