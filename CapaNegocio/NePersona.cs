using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapDatos;

namespace CapaNegocio
{
    public class NePersona
    {
        public String NeGuardarPersona(Persona objpersona, Int32 condicion)
        {

            daGuardarPersona objPersona = new daGuardarPersona(); // se crea una instancia para acceder a sus propiedades
            try
            {
                return objPersona.daGuardaPersona(objpersona, condicion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
    
}
