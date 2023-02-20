using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OcupacionPersona
    {
        int idOcupacion,idUsuario; //variable
        string nombreOcupacion;//variable
        DateTime ofechaReg;//variable

        public int IdOcupacion { get => idOcupacion; set => idOcupacion = value; }
        public string NombreOcupacion { get => nombreOcupacion; set => nombreOcupacion = value; }
        public DateTime OfechaReg { get => ofechaReg; set => ofechaReg = value; }
        public OcupacionPersona(Int32 idOcupa, String nombreOcupa)
        {
            IdOcupacion = idOcupa;
            NombreOcupacion = nombreOcupa;
            

        }
    }
}
