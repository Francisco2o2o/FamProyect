using CapaEntidad;
using CapDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NeNomPersona
    {
       
            public List<NomPersona> NeLLenarNomPersona(Int32 idnomPersona, String nomPersona, Boolean buscar)
            {

            daNomPersona daobjNomPersona = new daNomPersona();
                try
                {
                    return daobjNomPersona.daLLenarNomPersona(idnomPersona, nomPersona, buscar);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        
    }
}
