using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {
        string nomPersona, apePat, apeMat, docPersona, ocupacionPersona, correoPersona;
        Byte[] fotoPersona;
        int rol;
        DateTime cumPersona, regPersona;

        public string NomPersona { get => nomPersona; set => nomPersona = value; }
        public string ApePat { get => apePat; set => apePat = value; }
        public string ApeMat { get => apeMat; set => apeMat = value; }
        public string DocPersona { get => docPersona; set => docPersona = value; }
        public string OcupacionPersona { get => ocupacionPersona; set => ocupacionPersona = value; }
        public int Rol { get => rol; set => rol = value; }
        public string CorreoPersona { get => correoPersona; set => correoPersona = value; }
        public byte[] FotoPersona { get => fotoPersona; set => fotoPersona = value; }
        public DateTime CumPersona { get => cumPersona; set => cumPersona = value; }
        public DateTime RegPersona { get => regPersona; set => regPersona = value; }

    }
}
