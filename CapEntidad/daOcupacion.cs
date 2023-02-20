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
    public class daOcupacion
    {
        public List<OcupacionPersona> daLLenarOcupacion(Int32 idOcupacion, String nomOcupacion, Boolean buscar)
        {


            SqlParameter[] pa = new SqlParameter[0];
            DataTable dtOcupacion = new DataTable();
            ConexionSql objCnx = null;


            try
            {

                objCnx = new ConexionSql("");
                dtOcupacion = objCnx.EjecutarProcedimientoDT("uspLlenarOcupacion", pa);

                List<OcupacionPersona> ocupa = new List<OcupacionPersona>();
                ocupa.Add(new OcupacionPersona(
                        0,
                        Convert.ToString(buscar ? "TODOS" : "Selecc. opcion")

                        )
                    );


                foreach (DataRow drMenu in dtOcupacion.Rows)
                {
                    ocupa.Add(new OcupacionPersona(
                         Convert.ToInt32(drMenu["idOcupacion"]),
                        Convert.ToString(drMenu["nomOcupacion"]) //campos de la tabla Ocupacion
                        )
                     );

                }

                return ocupa;

            }
            catch (Exception ex)
            {
                //objUtil.gsLogAplicativo("DACargo.cs", "daDevolverTablaCod", ex.Message);
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
