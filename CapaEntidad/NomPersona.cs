using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class NomPersona
    {
        int idPers;
        string nombPers;

        public int IdPers { get => idPers; set => idPers = value; }
        public string NombPers { get => nombPers; set => nombPers = value; }

        public NomPersona(Int32 idnomPers, String nomPers)
        {

            nombPers = nomPers;
            idPers = idnomPers;

        }
    }
}
