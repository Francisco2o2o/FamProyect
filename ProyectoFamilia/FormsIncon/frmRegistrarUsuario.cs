
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

namespace ProyectoFamilia.FormsIncon
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }
        public void Alert(string mensaje, Notify.enmType type)
        {
            Notify frm = new Notify();
            frm.showAlert(mensaje, type);
        }

        public void fnGuardarUsuario()
        {
            //Usuario objUsuario = new Usuario(); //Clase persona , creamos
            //NeUsuario NEobjUsuario = new NeUsuario();
            //String lcValidar = "";

            //try
            //{
            //    //objpersona.DocPersona = Convert.ToString(txtDocumento.Text.Trim());
            //    objUsuario.User = Convert.ToString(txtUsuario.Text.Trim());
            //    objUsuario.Password = Convert.ToString(txtPassword.Text.Trim());
            //    objUsuario.FechaReg = DateTime.Now;

            //    lcValidar = NEobjUsuario.NeGuardarUsuario(objUsuario, 0).Trim();
            //    //fnLimpiarControles();
            //    //fnHabilitarControles(false);

            //    return lcValidar;
            //}
            //catch (Exception ex)
            //{

            //    return "NO";
            //}
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String lcResultado = "";
            //lcResultado = fnGuardarUsuario();
            fnGuardarUsuario();

            if (lcResultado == "OK")
            {
                // Mostrar una alerta informando que el usuario ha sido guardado
                this.Alert("Usuario Guardado", Notify.enmType.Info);
            }
            else
            {
                MessageFM.Show("Erro Al guardar datos de Usuario",
          "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Alert("Completar Campos", Notify.enmType.Error);
        }


    }

}



