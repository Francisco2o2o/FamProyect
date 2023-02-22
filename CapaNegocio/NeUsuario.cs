using CapaEntidad;
using CapDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NeUsuario
    {
        public String NeGuardarUsuario(Usuario objusuario, Int32 condicion)
        {

            daUsuario objUsuario = new daUsuario(); // se crea una instancia para acceder a sus propiedades
            try
            {
                return objUsuario.daGuardaUsuario(objusuario, condicion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
