﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
     public class Usuario
    {
        int idPersona;
        string user,password;
        DateTime fechaReg;


        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public DateTime FechaReg { get => fechaReg; set => fechaReg = value; }
        
    }
}
