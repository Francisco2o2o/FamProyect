using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapEntidad
{
    internal class MiembrosFamilia
    {
        string nomFamilia, apeFamilia, docFamilia, ocupacionFamilia;
        byte fotoFamilia;
        DateTime fechaFamilia;

        public string NomFamilia { get => nomFamilia; set => nomFamilia = value; }
        public string ApeFamilia { get => apeFamilia; set => apeFamilia = value; }
        public string DocFamilia { get => docFamilia; set => docFamilia = value; }
        public string OcupacionFamilia { get => ocupacionFamilia; set => ocupacionFamilia = value; }
        public byte FotoFamilia { get => fotoFamilia; set => fotoFamilia = value; }
        public DateTime FechaFamilia { get => fechaFamilia; set => fechaFamilia = value; }
        public MiembrosFamilia()
        {

        }
    }
}
