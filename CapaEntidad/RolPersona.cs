using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class RolPersona
    {
        string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public RolPersona(String nombre)
        {

            nombre = nombre;
        }
    }
}

