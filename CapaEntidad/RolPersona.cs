using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class RolPersona
    {
        public RolPersona() { }
        string nombreRol;
        int idRolPersona;
        DateTime rfechaRegistro;

        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public DateTime RfechaRegistro { get => rfechaRegistro; set => rfechaRegistro = value; }
        public int IdRolPersona { get => idRolPersona; set => idRolPersona = value; }

        public RolPersona(Int32 idRoles, String nombreroles)
        {

            NombreRol = nombreroles;
            IdRolPersona = idRoles;

        }

       
    }
}

