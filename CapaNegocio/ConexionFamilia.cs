using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ConexionFamilia
    {
        public SqlConnection BConexion;

        public SqlTransaction myTransa;
        private SqlConnection cmdComando;
        private Boolean bActiva = false;
        private String lsCadena = "";
        private int nTimeOurt;

        public ConexionFamilia(String pBaseDatos = "", int pnTimeOut = 7200)
        {
            //Despues de comprar si los datos estan llenados con el archivo text.
            LeerIni(pBaseDatos);

            //se realiza la conexion y se guarda en la variable BConexion 
            BConexion = new SqlConnection(lsCadena);
            //Se apertura la conexion
            BConexion.Open();
            nTimeOurt = pnTimeOut;
        }
        private Boolean LeerIni(string pBaseDatos)
        {
            Boolean bResult = false; //Variable
            String lsTxt;
            try
            {
                lsTxt = "Conex.txt"; //Nombre del Archivo

                //Enviar parametros a LeerArchivo
                lsCadena = LeerArchivo(pBaseDatos, lsTxt);
                bResult = true;
            }
            catch (Exception)
            {
                bResult = false;
            }
            return bResult;
        }

        //LeerArchvo Recibe los pararemos de LeerIni
        private String LeerArchivo(String pBaseDatos, String lsTxt)
        {

            int k = 0;
            String Pass = "";
            String Usuario = "";
            String BaseDatos = "";
            String lsCadenaCon = "";
            String cArchivo = "";
            String cClave1 = "";
            String cClave2 = "";
            String sLine = "";
            String Source = "";
            try
            {
                cArchivo = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

                if (cArchivo.Substring(cArchivo.Length - 1, 1) == "\\")
                {
                    cArchivo = cArchivo + lsTxt;
                }
                else
                {
                    cArchivo = cArchivo + @"\" + lsTxt;
                }

                StreamReader objReader = new StreamReader(cArchivo, Encoding.Default);
                do
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        k = sLine.IndexOf("=");
                        if (k > 0)
                        {
                            //Clave1 = nombre
                            //Clave2=Valor que se le da a la Clave1
                            cClave1 = sLine.Substring(0, k);
                            cClave2 = sLine.Substring(k + 1, sLine.Length - (k + 1));
                            if (cClave1 == "Server")
                            {
                                Source = cClave2;
                            }
                            else if (cClave1 == "DataBase")
                            {
                                if (pBaseDatos == "")
                                {
                                    pBaseDatos = cClave2;
                                }

                                BaseDatos = pBaseDatos;
                            }
                            else if (cClave1 == "Password")
                            {
                                Pass = cClave2;
                            }
                            else if (cClave1 == "User")
                            {
                                Usuario = cClave2;
                            }
                        }
                    }
                }
                while (sLine != null);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //arma la cadena de conexion
            if (Pass.Trim() == "" || Usuario.Trim() == "")
                lsCadena = "Integrated Security=True;INITIAL CATALOG=" + ((BaseDatos.Trim())) + ";DATA SOURCE=" + ((Source.Trim())) + "";
            else
                lsCadena = "User ID=" + ((Usuario.Trim())) + ";Password=" + ((Pass.Trim())) + ";INITIAL CATALOG=" + ((BaseDatos.Trim())) + ";DATA SOURCE=" + ((Source.Trim())) + "";

            lsCadenaCon = lsCadena;
            return lsCadenaCon;
        }
    }
}
