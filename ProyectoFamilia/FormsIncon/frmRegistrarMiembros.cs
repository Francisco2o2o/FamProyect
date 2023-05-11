
using CapaEntidad;
using CapaNegocio;
using Microsoft.Identity.Client;
using ProyectoFamilia.FormsIncon;
using ProyectoFamilia.Notifications;
using Siticone.Desktop.UI.WinForms;
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

        BuscarPersona Api = new BuscarPersona();
        public frmRegistrarMiembros()
        {
            InitializeComponent();
            dgRegistrarPersona.Columns.Add("Numero", "N°");
            dgRegistrarPersona.Columns.Add("Id", "ID"); // nombre que se asignara a columna -  Texto de la columna
            dgRegistrarPersona.Columns.Add("IdRol", "IDRol");
            dgRegistrarPersona.Columns.Add("IdOcu", "IDOcu");
            dgRegistrarPersona.Columns.Add("Nom", "Nombre");
            dgRegistrarPersona.Columns.Add("ApePat", "Apellido Paterno");
            dgRegistrarPersona.Columns.Add("ApeMat", "Apellido Materno");
            dgRegistrarPersona.Columns.Add("Doc", "Documento");
            dgRegistrarPersona.Columns.Add("CorreoPer", "Correo");
            dgRegistrarPersona.Columns.Add("Ocu", "Ocupacion");
            dgRegistrarPersona.Columns.Add("Rol", "Rol Familiar");
        }


        //Variable para buscar
        static Boolean pasoLoad;
        static Int32 tabInicio = 0;

        public void Alert(string mensaje, Notify.enmType type)
        {
            Notify frm = new Notify();
            frm.showAlert(mensaje, type);
        }

        static Int16 lnTipoCon = 0;


        #region Formato imagen 
        private Byte[] ConvertirImg()
        {
            MemoryStream ms = new MemoryStream();

            if (ms.Length == 0)
            {
                imagePersona.Image = Properties.Resources.AvatarDefect;
            }
            ms = new MemoryStream();
            imagePersona.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }
        #endregion

        #region Funcion para guardarPersona
        public String fnGuardarPersona()
        {
            Persona objpersona = new Persona(); //Clase persona , creamos
            NePersona NEobjPersona = new NePersona();
            String lcValidar = "";

            try
            {
                objpersona.IdPersona = Convert.ToInt32(txtIdPersona.Text.Trim() == "" ? "0" : txtIdPersona.Text.Trim());
                objpersona.DocPersona = Convert.ToString(txtDocumento.Text.Trim());
                objpersona.NomPersona = Convert.ToString(txtNombre.Text.Trim());
                objpersona.ApePat = Convert.ToString(txtapePat.Text.Trim());
                objpersona.ApeMat = Convert.ToString(txtapeMat.Text.Trim());
                objpersona.Ocupacion = Convert.ToInt32(cboOcupacion.SelectedValue);
                objpersona.Rol = Convert.ToInt32(cboRol.SelectedValue);
                objpersona.CorreoPersona = Convert.ToString(txtCorreo.Text.Trim());
                objpersona.FotoPersona = ConvertirImg();
                objpersona.FechaNacimiento = Convert.ToDateTime(dtFechaNacimiento.Value);
                objpersona.RegPersona = DateTime.Now;
                lcValidar = NEobjPersona.NeGuardarPersona(objpersona, 0).Trim();
                //fnLimpiarControles();
                //fnHabilitarControles(false);

                return lcValidar;
            }
            catch (Exception ex)
            {

                return "NO";
            }

        }
        #endregion

        #region Formato Imagen
        private void btnFotoMiembroFamilia_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePersona.Image = new Bitmap(open.FileName);
            }
        }
        #endregion
        #region Llenar Rol Persona
        public static List<RolPersona> fnLLenarRol(ComboBox cbo, Int32 idRol, String nombreRol, Boolean buscar)
        {
            NeRolPersona objrol = new NeRolPersona();

            List<RolPersona> lstRol = new List<RolPersona>();

            try
            {
                lstRol = objrol.NeLLenarRol(idRol, nombreRol, buscar);
                cbo.ValueMember = "idRolPersona";
                cbo.DisplayMember = "nombreRol";
                cbo.DataSource = lstRol;

                return lstRol;
            }
            catch (Exception ex)
            {

                return lstRol;
            }
            finally
            {
                lstRol = null;
            }
        }
        #endregion
        #region Llenar ComboBox Ocupacion Persona
        public static List<OcupacionPersona> fnLLenarOcupacion(ComboBox cbo, Int32 idOcupacion, String nomOcupacion, Boolean buscar)
        {
            NeOcupacion objOcupacion = new NeOcupacion();

            List<OcupacionPersona> lstOcupacion = new List<OcupacionPersona>();

            try
            {
                lstOcupacion = objOcupacion.NeLLenarOcupacion(idOcupacion, nomOcupacion, buscar);
                // variables de la clase
                cbo.ValueMember = "IdOcupacion";//ValueMember ->Oculta
                cbo.DisplayMember = "NombreOcupacion";//DisplayMember ->Muestra
                cbo.DataSource = lstOcupacion;

                return lstOcupacion;
            }
            catch (Exception ex)
            {

                return lstOcupacion;
            }
            finally
            {
                lstOcupacion = null;
            }
        }

        #endregion
        private void frmRegistrarMiembros_Load(object sender, EventArgs e)

        {
            //Ocultar la barra de carga infeior
            pbCargaBuscarPersona.Visible = false;

            //dgRegistrarPersona.Columns["Numero"].Visible = false;

            //Oculatar las columnas creadas en el datagridview
            dgRegistrarPersona.Columns["Id"].Visible = false;
            dgRegistrarPersona.Columns["IdRol"].Visible = false;
            dgRegistrarPersona.Columns["IdOcu"].Visible = false;


            // Establece la posición del formulario en la parte izquierda de la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(280, 150);


            pasoLoad = false;
            fnLLenarRol(cboRol, 0, "", false);
            fnLLenarOcupacion(cboOcupacion, 0, "", false);
            dtRegistroPersona.Visible = false;


            //Buscar Persona

            Boolean bResult;
            pasoLoad = true;
        }

        #region TraerDatos Persona
        public void fnTrarDatosPersona()
        {
            string token = "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imh0dHBzLmZyYW56QGdtYWlsLmNvbSJ9.zZV6zWvLKoce0NNoVIN9wXnAYtx6ieduZET1ynUJgfM";
            try
            {
                if (txtDocumento.Text.Length == 8)
                {
                    //token
                    dynamic respuesta = Api.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDocumento.Text + token);
                    txtNombre.Text = respuesta.nombres.ToString();
                    txtapePat.Text = respuesta.apellidoPaterno.ToString();
                    txtapeMat.Text = respuesta.apellidoMaterno.ToString();
                    this.Alert("Datos Encontrados", Notify.enmType.Info);
                }

                else
                {
                    this.Alert("Error Al buscar DNI", Notify.enmType.Error);
                }
            }
            catch (Exception)
            {
                this.Alert("Ingrese documento valido", Notify.enmType.Error);

            }
        }
        #endregion

        public void fnValidadFecha()
        {
            DateTime fechaInicio = dtFechaInicio.Value;
            DateTime fechaReferencia = new DateTime(2023, 02, 21);
            int diasTranscurridos = (fechaInicio - fechaReferencia).Days;
            if (diasTranscurridos < 100)
            {
                MessageBox.Show("La fecha debe ser menos de 100", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Guardar Persona
        private void GuardarMiembroFamilia_Click_1(object sender, EventArgs e)
        {
            String lcResultado = "";
            lcResultado = fnGuardarPersona();
            //fnValidadFecha();

            if (lcResultado == "OK")
            {
                fnLimpiarControles();

                fnEnviarDatosFormulario();

                MessageBox.Show("Se Grabo Satisfactoriamente Personal Trabajador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Grabar Personal Trabajador. Comunicar a Administrador de Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion



        private void fnCalcularPaginacion(Int32 totalRegistros, Int32 filas, Int32 totalResultados /*, ComboBox cboPag, SiticoneCircleButton btnTotPag, SiticoneCircleButton btnNumFil, SiticoneCircleButton btnTotReg*/)
        {
            Int32 residuo;
            Int32 cantidadPaginas;
            residuo = totalRegistros % filas;
            if (residuo == 0)
            {
                cantidadPaginas = (totalRegistros / filas);
            }
            else
            {
                cantidadPaginas = (totalRegistros / filas) + 1;
            }
            cboPagina.Items.Clear();

            for (Int32 i = 1; i <= cantidadPaginas; i++)
            {
                cboPagina.Items.Add(i);

            }

            //cboPag.SelectedIndex = 0;
            //btnTotPag.Text = Convert.ToString(cantidadPaginas);
            //btnNumFil.Text = Convert.ToString(totalResultados);
            //btnTotReg.Text = Convert.ToString(totalRegistros);
            cboPagina.SelectedIndex = 0;
            btnTotalPaginas.Text = Convert.ToString(cantidadPaginas);
            btnNumFilas.Text = Convert.ToString(totalResultados);
            btnTotalReg.Text = Convert.ToString(totalRegistros);

        }
        private Boolean fnBuscarPersona(DataGridView dgv, Int32 numPagina)
        {
            NeBuscarPersona objper = new NeBuscarPersona();

            DataTable dtPersona = new DataTable();
            String nomPersona;
            Int32 filas = 15;
            Int32 totalResultados = 0;
            Int32 idTipoPersona;
            Int32 idTipoDocumento;
            String estado;
            DateTime fechaInicial = dtFechaInicio.Value;
            DateTime fechaFinal = dtFechaFin.Value;
            Boolean habilitarFechas = chkHabilitarFechas.Checked ? true : false;
            try
            {

                nomPersona = Convert.ToString(txtBuscarPersona.Text.ToString());

                dtPersona = objper.NeBuscarPer(habilitarFechas, fechaInicial, fechaFinal, nomPersona, numPagina);
                dgRegistrarPersona.Rows.Clear();
                totalResultados = dtPersona.Rows.Count;


                if (dtPersona.Rows.Count > 0)
                {
                    Int32 y;
                    if (numPagina == 0)
                    {
                        y = 0;
                    }
                    else
                    {
                        tabInicio = (numPagina - 1) * filas;
                        y = tabInicio;
                    }

                    //DataTable dt = new DataTable();
                    //dgRegistrarPersona.Columns.Clear();
                    foreach (DataRow item in dtPersona.Rows)
                    {
                        y++;
                        dgRegistrarPersona.Rows.Add(
                            y,
                            item["idPersona"],
                            item["idRol"],
                            item["idOcupacion"],
                            item["nomPersona"],
                            item["apePat"],
                            item["apeMat"],
                            item["docPersona"],
                            item["correoPersona"],
                            item["nomOcupacion"],
                            item["nomRol"]
                            );

                    }
                    dgRegistrarPersona.Columns[1].Visible = false;//Oculatra la segunda colummna, en este caso donde se encuentra la id
                    dgRegistrarPersona.Columns[2].Visible = false;
                    dgRegistrarPersona.Columns[3].Visible = false;


                }

                if (numPagina == 0)
                {
                    Int32 totalRegistros = Convert.ToInt32(dtPersona.Rows[0][0]);
                    fnCalcularPaginacion(
                            totalRegistros,
                            filas,
                            totalResultados
                            //cboPagina,
                            //btnTotalPaginas,
                            //btnNumFilas,
                            //btnTotalReg
                            );
                }
                //btnNumFilas.Text = Convert.ToString(filas);
                //btnTotalReg.Text = Convert.ToString(totalRegistros);


                return true;
            }


            catch (Exception ex)
            {

                return false;
            }
            finally
            {

                objper = null;

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boolean bResul;

            if (pasoLoad)
            {
                bResul = fnBuscarPersona(dgRegistrarPersona, 0);
                if (!bResul)
                {
                    MessageFM.Show("Error al Buscar Familiar. Comunicar a Administrador de Sistema",
          "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //MessageBox.Show("Error al Buscar Familiar. Comunicar a Administrador de Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            ///pbTraerClientes.Visible = true;

            pbCargaBuscarPersona.Visible = true;

            pbCargaBuscarPersona.Value = 0;
            if (pbCargaBuscarPersona.Value == 0)
            {
                tmTraerDatosPersona.Start();
            }
            //else
            //{
            //    //resetProgressBar();
            //}
            //fnTrarDatosPersona();
        }


        private void cboPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean bResul;

            Int32 numPagina = Convert.ToInt32(cboPagina.Text.ToString());
            if (pasoLoad)
            {
                bResul = fnBuscarPersona(dgRegistrarPersona, numPagina);
                if (!bResul)
                {
                    MessageFM.Show("Error al Buscar Familiar. Comunicar a Administrador de Sistema",
          "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        public void fnLimpiarControles()
        {
            txtNombre.Text = "";
            txtapePat.Text = "";
            txtapeMat.Text = "";
            txtCorreo.Text = "";

            // Limpiar la imagen del PictureBox1
            imagePersona.Image = null;
            dtFechaNacimiento.Value = DateTime.Now;

        }
        public void fnEnviarDatosFormulario()
        {
            lblNombre1.Text = txtNombre.Text + " " + txtapePat.Text + " " + txtapeMat.Text;
            lblCorreo1.Text = txtCorreo.Text;
            lblFecha.Text = dtFechaNacimiento.Value.ToString("dddd, dd' de 'MMMM' de 'yyyy");
            // Copiar la imagen del PictureBox1 al PictureBox2
            pbxImagenGuardada.Image = imagePersona.Image;
        }

        private void tmTraerDatosPersona_Tick(object sender, EventArgs e)
        {

            if (pbCargaBuscarPersona.Value < 90)
            {
                pbCargaBuscarPersona.Value += 10;
            }
            else if (pbCargaBuscarPersona.Value == 90)
            {
                pbCargaBuscarPersona.Value += 1;
                fnTrarDatosPersona();
            }
            else if (pbCargaBuscarPersona.Value > 90 && pbCargaBuscarPersona.Value < 100)
            {

                pbCargaBuscarPersona.Value += 1;
                pbCargaBuscarPersona.Value = 100;
                pbCargaBuscarPersona.Visible = false;
            }
            else
            {
                if (pbCargaBuscarPersona.Value >= 100)
                {
                    tmTraerDatosPersona.Stop();

                }

            }


        }

        private void btnCerrarFormularios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAsignarusuario_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario frmUsuario = new frmRegistrarUsuario();
            frmUsuario.Show();
        }

        private void dgRegistrarPersona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgRegistrarPersona.Rows[e.RowIndex];
                string data = row.Cells[1].Value.ToString(); // Cambia 0 por el índice de la 
                txtIdPersona.Text = data;
                string data2 = row.Cells[2].Value.ToString();
                cboRol.SelectedValue = Convert.ToInt32(data2);
                string data3 = row.Cells[3].Value.ToString();
                cboOcupacion.SelectedValue = Convert.ToInt32(data3);
                string data4 = row.Cells[4].Value.ToString();
                txtNombre.Text = data4;
                string data5 = row.Cells[5].Value.ToString();
                txtapePat.Text = data5;
                string data6 = row.Cells[6].Value.ToString();
                txtapeMat.Text = data6;
                string data7 = row.Cells[7].Value.ToString();
                txtDocumento.Text = data7;
                string data8 = row.Cells[8].Value.ToString();
                txtCorreo.Text = data8;
                tbPersona.SelectedIndex = 0;

            }



        }

        private void tbMiembros_Click(object sender, EventArgs e)
        {

        }
    }

}
