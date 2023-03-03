using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {

        string nomPersona, apePat, apeMat, docPersona, correoPersona;
        Byte[] fotoPersona;
        int rol, ocupacion,idPersona;
        DateTime fechaNacimiento, regPersona;

        public string NomPersona { get => nomPersona; set => nomPersona = value; }
        public string ApePat { get => apePat; set => apePat = value; }
        public string ApeMat { get => apeMat; set => apeMat = value; }
        public string DocPersona { get => docPersona; set => docPersona = value; }
        public int Ocupacion { get => ocupacion; set => ocupacion = value; }
        public int Rol { get => rol; set => rol = value; }
        public string CorreoPersona { get => correoPersona; set => correoPersona = value; }
        public byte[] FotoPersona { get => fotoPersona; set => fotoPersona = value; }
        public DateTime RegPersona { get => regPersona; set => regPersona = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public  Usuario clsUsuario { get; set; }
        public RolPersona clsRol { get; set; }
        public OcupacionPersona clsOcupa { get; set; }
    }
}
