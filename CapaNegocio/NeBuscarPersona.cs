using CapDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NeBuscarPersona
    {
        public DataTable NeBuscarPer(Boolean habilitarFechas, DateTime fechaInical, DateTime fechaFinal, String nomPersona, Int32 numPagina)
        {

            daBuscarPersona objPersona = new daBuscarPersona();
            try
            {
                return objPersona.daBuscarPers(habilitarFechas, fechaInical, fechaFinal, nomPersona, numPagina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
