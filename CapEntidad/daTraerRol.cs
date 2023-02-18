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
    public class daTraerRol
    {

        public List<RolPersona> daTraeRol(Int32 idRol,  Boolean buscar)
        {


            SqlParameter[] pa = new SqlParameter[1];
            DataTable dtUsuario = new DataTable();
            ConexionSql objCnx = null;
            

            try
            {

                pa[0] = new SqlParameter("@peidMoneda", SqlDbType.Int) { Value = idRol };

                objCnx = new ConexionSql("");
                dtUsuario = objCnx.EjecutarProcedimientoDT("uspLlenarRol", pa);

                List<RolPersona> rol = new List<RolPersona>();
                rol.Add(new RolPersona(

                        Convert.ToString(buscar ? "TODOS" : "Selecc. opcion")));
                        

                foreach (DataRow drMenu in dtUsuario.Rows)
                {
                    rol.Add(new RolPersona(

                        Convert.ToString(drMenu["cNombre"])));
                        
                }

                return rol;

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
