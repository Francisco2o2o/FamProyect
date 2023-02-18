
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //SqlParameter[] pa = new SqlParameter[34];
            //ConexionFamilia1 objCnx = null;
            ////tmGuardarUsuario.Start();

            ////refreshTimer();
            //string usuario = "";
            //string password = "";
            ////recibe los parametros del los textbox
            //usuario = txtUsuario.Text;
            //password = txtPassword.Text;

            //if (txtUsuario.Text != "" && txtPassword.Text != "")
            //{
            //try
            //{
            //    objCnx = new  ConexionFamilia("");

            //    //using (SqlCommand command = new SqlCommand("INSERT INTOo Logino (usuario,password) VALUES (@usuario, @password)", c))
            //   //objCnx.EjecutarProcedimiento("uspGuardarCliente", pa); Consulta
            //    {
            //        // Añadir los parámetros al comando SqlCommand
            //        pa[0] = new SqlParameter("@peidCliente", SqlDbType.Int);
            //        pa[0].Value = objCliente.idCliente;

            //        // Ejecutar la consulta INSERT

            //        //if (pbGuardarUsuario.Value == 100)
            //        //{
            //        command.ExecuteNonQuery();
            //            // Mostrar una alerta informando que el usuario ha sido guardado
            //            this.Alert("Usuario Guardado", Notify.enmType.Info);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageFM.Show("Erro Al guardar datos de Usuario",
            //  "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //}
            //else
            //{
            //    this.Alert("Completar Campos", Notify.enmType.Error);
        }


    }

}



