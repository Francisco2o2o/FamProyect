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
    public class daNomPersona
    {
        public List<NomPersona> daLLenarNomPersona(Int32 idnomPersona, String nomOcupacion, Boolean buscar)
        {


            SqlParameter[] pa = new SqlParameter[0];
            DataTable dtOcupacion = new DataTable();
            ConexionSql objCnx = null;


            try
            {

                objCnx = new ConexionSql("");
                dtOcupacion = objCnx.EjecutarProcedimientoDT("uspLlenarNomPersona", pa);

                List<NomPersona> nomPer = new List<NomPersona>();
                nomPer.Add(new NomPersona(
                        0,
                        Convert.ToString(buscar ? "TODOS" : "Selecc. opcion")

                        )
                    );


                foreach (DataRow drMenu in dtOcupacion.Rows)
                {
                    nomPer.Add(new NomPersona(
                         Convert.ToInt32(drMenu["idPersona"]),
                        Convert.ToString(drMenu["nomPersona"]) //campos de la tabla Ocupacion
                        )
                     );

                }

                return nomPer;

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
