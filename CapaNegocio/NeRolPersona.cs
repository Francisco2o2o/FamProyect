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
        public List<RolPersona> NeLLenarRol(Int32 idRol, String nombreRol, Boolean buscar)
        {

            daTraerRol daobjUsuario = new daTraerRol();
            try
            {
                return daobjUsuario.daLLenarRol(idRol, nombreRol, buscar);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }


}
