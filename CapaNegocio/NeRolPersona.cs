using CapaEntidad;
using CapDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NeRolPersona
    {
        public List<RolPersona> NeRolPer(Int32 idMoneda, Boolean buscar)
        {

            daTraerRol daobjUsuario = new daTraerRol();
            try
            {
                return daobjUsuario.daTraeRol(idMoneda, buscar);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }


}
