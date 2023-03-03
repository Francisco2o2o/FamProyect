using CapaConexion;
using CapaEntidad;
using CapaNegocio;
using CapDatos;
using ProyectoFamilia.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFamilia.Presentation
{
    public partial class frmLogin : Form
    {
        public string nombreUsuario;
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = false;
        }
        public void Alert(string mensaje, Notify.enmType type)
        {
            Notify frm = new Notify();
            frm.showAlert(mensaje, type);
        }

        public Boolean fnValidarUser()
        {
            NeValidarUsuario ObjUsuario = new NeValidarUsuario();
            Usuario objVusuario = new Usuario();

            DataTable GuardarDatos;
            try
            {
                //objpersona.DocPersona = Convert.ToString(txtDocumento.Text.Trim());
                objVusuario.User = Convert.ToString(txtUsuario.Text.Trim());
                objVusuario.Password = Convert.ToString(txtPassword.Text.Trim());

                GuardarDatos = ObjUsuario.NeValidarUser(objVusuario);

                if (GuardarDatos.Rows.Count > 0)
                {
                    Usuario clUsu = new Usuario();
                    Persona clPresona = new Persona();
                    RolPersona clRol = new RolPersona();
                    OcupacionPersona clOcupa = new OcupacionPersona();

                    foreach (DataRow row in GuardarDatos.Rows)
                    {
                        clUsu.IdUser = Convert.ToInt32(row["idUsuario"]);
                        clUsu.User = row["userUsuario"].ToString();
                        clPresona.IdPersona = Convert.ToInt32(row["idPersona"]);
                        clPresona.NomPersona = row["nomPersona"].ToString();
                        clPresona.ApePat = row["apePat"].ToString();
                        clPresona.ApeMat = row["apeMat"].ToString();
                        clPresona.CorreoPersona = row["correoPersona"].ToString();
                        clPresona.DocPersona = row["docPersona"].ToString();
                        clPresona.FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]);
                        clPresona.RegPersona = Convert.ToDateTime(row["fechaRegistro"]);
                        clPresona.FotoPersona = (byte[])row["fotoPersona"];
                        clPresona.Rol = Convert.ToInt32(row["idRol"]);
                        clPresona.Ocupacion = Convert.ToInt32(row["idOcupacion"]);



                        clRol.NombreRol = row["nomRol"].ToString();
                        clOcupa.NombreOcupacion = row["nomOcupacion"].ToString();



                        //GeneralClass.clsPersona.clsUsuario.IdUser =     
                        //GeneralClass.clsPersona.clsUsuario.User = row["userUsuario"].ToString();



                        //GeneralClass.clsPersona.NomPersona = row["nomPersona"].ToString();
                        //GeneralClass.clsPersona.ApePat = row["apePat"].ToString();
                        //GeneralClass.clsPersona.ApeMat = row["apeMat"].ToString();
                        //GeneralClass.clsPersona.CorreoPersona = row["correoPersona"].ToString();
                        //GeneralClass.clsPersona.DocPersona = row["docPersona"].ToString();
                        //GeneralClass.clsPersona.FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]);
                        //GeneralClass.clsPersona.RegPersona = Convert.ToDateTime(row["fechaRegistro"]);
                        //GeneralClass.clsPersona.FotoPersona = (byte[])row["fotoPersona"];
                        //GeneralClass.clsPersona.clsOcupa.NombreOcupacion = row["nomOcupacion"].ToString();
                        //GeneralClass.clsPersona.clsRol.NombreRol = row["nomRol"].ToString();
                        //GeneralClass.clsPersona.IdPersona = Convert.ToInt32(row["idPersona"]);
                        //GeneralClass.clsPersona.Rol = Convert.ToInt32(row["idRol"]);
                        //GeneralClass.clsPersona.Ocupacion = Convert.ToInt32(row["idOcupacion"]);
                        clPresona.clsUsuario = clUsu;
                        clPresona.clsRol = clRol;
                        clPresona.clsOcupa = clOcupa;

                    }
                    GeneralClass.clsPersona = clPresona;


                    MessageBox.Show("Bienvenido al Sistema");
                    return true;
                }
                else
                {

                    MessageBox.Show("Error");
                    return false;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos Incorrecto. Vuelva a ingresar nuevamente");
                return false;

            }

        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (fnValidarUser() == true)
            {
                nombreUsuario = "Bienvenido al Sistema " + txtUsuario.Text;
                frmBienvenido frmMenu = new frmBienvenido();
                frmMenu.fnPasardatos(nombreUsuario);
                this.Visible = false;
            }
            else
            {
                txtUsuario.Focus();
                //MessageBox.Show("Ingrese sus Datos Correctos");
            }



        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == "INGRESE USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "INGRESE USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text == "INGRESE PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar=false;
                txtPassword.Text = "INGRESE PASSWORD";
                txtPassword.ForeColor = Color.Silver;
            }
            else
            {
                // El TextBox tiene caracteres
            }


            //if (txtPassword.Text == "")
            //{

            //}
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
