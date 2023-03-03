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

namespace ProyectoFamilia.Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public void Alert(string mensaje, Notify.enmType type)
        {
            Notify frm = new Notify();
            frm.showAlert(mensaje, type);
        }

        public void fnValidarUser()
        {
            NeValidarUsuario ObjUsuario = new NeValidarUsuario();
            Usuario objVusuario = new Usuario();
            DataTable GuardarDatos ;
            try
            {
                //objpersona.DocPersona = Convert.ToString(txtDocumento.Text.Trim());
                objVusuario.User = Convert.ToString(txtUsuario.Text.Trim());
                objVusuario.Password = Convert.ToString(txtPassword.Text.Trim());

                GuardarDatos=ObjUsuario.NeValidarUser(objVusuario);

                foreach (DataRow row in GuardarDatos.Rows)
                {

                    //GeneralClass.clsPersona.IdUser = row[""].ToString();
                    GeneralClass.clsPersona.IdUser =Convert.ToInt32( row["IdUsuario"]);
                    ;                }
               

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Al Ingresar");
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            fnValidarUser();
            
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
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "INGRESE PASSWORD";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
