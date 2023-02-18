
using CapaEntidad;
using CapaNegocio;
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


namespace ProyectoFamilia.FormsIncome
{
    public partial class frmRegistrarMiembros : Form
    {
        public frmRegistrarMiembros()
        {
            InitializeComponent();
        }
        static Int16 lnTipoCon = 0;

        private Byte[] ConvertirImg()
        {
            MemoryStream ms = new MemoryStream();

            if (ms.Length == 0)
            {
                imagePersona.Image = Properties.Resources.imgLoad;
            }
            ms = new MemoryStream();
            imagePersona.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }
        public void fnGuardarPersona()
        {
            Persona objpersona = new Persona(); //Clase persona , creamos
            NePersona NEobjPersona = new NePersona();
            String lcValidar = "";

            try
            {

                objpersona.NomPersona = Convert.ToString(txtNombre.Text.Trim());
                objpersona.ApePat = Convert.ToString(txtapePat.Text.Trim());
                objpersona.ApeMat = Convert.ToString(txtapeMat.Text.Trim());

                objpersona.OcupacionPersona = Convert.ToString(txtOcupacion.Text.Trim());

                //objpersona.Rol = Convert.ToInt32(cboRol.SelectedValue);

                objpersona.CorreoPersona = Convert.ToString(txtCorreo.Text.Trim());
                objpersona.DocPersona = Convert.ToString(txtDocumento.Text.Trim());
                objpersona.FotoPersona = ConvertirImg();
                objpersona.CumPersona = Convert.ToDateTime(dtCumPersona.Value);
                objpersona.RegPersona = DateTime.Now;
                lcValidar =NEobjPersona.NeGuardarPersona(objpersona, 0).Trim();
                //fnLimpiarControles();
                //fnHabilitarControles(false);
            }
            catch (Exception ex)
            {
              
                lcValidar = "NO";
            }
            
        }

        private void GuardarMiembroFamilia_Click(object sender, EventArgs e)
        {
            String lcResultado = "";
            fnGuardarPersona();
            if (lcResultado == "OK")
            {
                //MessageBox.Show("Se Grabo Satisfactoriamente Personal Trabajador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("Error al Grabar Personal Trabajador. Comunicar a Administrador de Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFotoMiembroFamilia_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePersona.Image = new Bitmap(open.FileName);
            }
        }

        public static List<RolPersona> fnLLenarRol(ComboBox cbo, Int32 idRol, Boolean buscar)
        {
            NeRolPersona objrol = new NeRolPersona();

            List<RolPersona> lstRol = new List<RolPersona>();

            try
            {
                lstRol = objrol.NeRolPer(0, buscar);
                cbo.ValueMember = "idMoneda";              
                cbo.DataSource = lstRol;

                return lstRol;
            }
            catch (Exception ex)
            {
                //objUtil.gsLogAplicativo("FrmRegistrarVehiculo", "fnLLenarClaseVehiculo", ex.Message);
                return lstRol;
            }
            finally
            {
                lstRol = null;
            }
        }


            private void frmRegistrarMiembros_Load(object sender, EventArgs e)
            {
            fnLLenarRol(cboRol, 0, false);
            } 
        
    }
}
