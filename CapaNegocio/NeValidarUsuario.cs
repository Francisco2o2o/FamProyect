using CapaEntidad;
using CapDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NeValidarUsuario
    {
        public DataTable NeValidarUser(Usuario objVusuario)
        {

            daValidarUsuario objUsuario = new daValidarUsuario(); // se crea una instancia para acceder a sus propiedades
            try
            {
                return objUsuario.daValidarUser(objVusuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
