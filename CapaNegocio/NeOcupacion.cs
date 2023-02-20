using CapaEntidad;
using CapDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NeOcupacion
    {
        public List<OcupacionPersona> NeLLenarOcupacion(Int32 idOcupacion, String nomOcupacion, Boolean buscar)
        {

            daOcupacion daobjOcupacion = new daOcupacion();
            try
            {
                return daobjOcupacion.daLLenarOcupacion(idOcupacion, nomOcupacion, buscar);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
