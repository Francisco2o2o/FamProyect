
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

        public String fnGuardarUsuario()
        {
            Usuario objusuario = new Usuario(); //Clase persona , creamos
            NeUsuario NEobjUsuario = new NeUsuario();//Nombre de la clase CapaNegocio
            String lcValidar = "";

            try
            {
                //objpersona.DocPersona = Convert.ToString(txtDocumento.Text.Trim());
                objusuario.User = Convert.ToString(txtUsuario.Text.Trim());
                objusuario.Password = Convert.ToString(txtPassword.Text.Trim());
                objusuario.IdUser = Convert.ToInt32(cboNombrePersona.SelectedValue);
                objusuario.FechaReg = DateTime.Now;

                lcValidar = NEobjUsuario.NeGuardarUsuario(objusuario, 0).Trim();
                //fnLimpiarControles();
                //fnHabilitarControles(false);

                return lcValidar;
            }
            catch (Exception ex)
            {

                return "NO";
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String lcResultado = "";
            //lcResultado = fnGuardarUsuario();

            lcResultado = fnGuardarUsuario();

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

            //this.Alert("Completar Campos", Notify.enmType.Error);
        }

        public static List<NomPersona> fnLLenarNomPersona(ComboBox cbo, Int32 idnomPersona, String nomPersona, Boolean buscar)
        {
            NeNomPersona objnompersona = new NeNomPersona();

            List<NomPersona> lstNomPersona = new List<NomPersona>();

            try
            {
                lstNomPersona = objnompersona.NeLLenarNomPersona(idnomPersona, nomPersona, buscar);
                // variables de la clase
                cbo.ValueMember = "idPers";//ValueMember ->Oculta
                cbo.DisplayMember = "nombPers";//DisplayMember ->Muestra
                cbo.DataSource = lstNomPersona;

                return lstNomPersona;
            }
            catch (Exception ex)
            {


                return lstNomPersona;
            }
            finally
            {
                lstNomPersona = null;
            }
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            // Establece la posición del formulario en la parte derecha de la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 150);
            fnLLenarNomPersona(cboNombrePersona, 50, "", false);
            dtFechaRegistroUsuario.Visible = false;
        }
    }

}



