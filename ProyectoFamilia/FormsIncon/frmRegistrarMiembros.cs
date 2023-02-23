﻿
using CapaEntidad;
using CapaNegocio;
using Microsoft.Identity.Client;
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
                imagePersona.Image = Properties.Resources.imgLoad;
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
                objpersona.IdPersona = Convert.ToInt32(txtIdPersona.Text.Trim());
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
            fnValidadFecha();

            if (lcResultado == "OK")
            {
                MessageBox.Show("Se Grabo Satisfactoriamente Personal Trabajador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Grabar Personal Trabajador. Comunicar a Administrador de Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion



        private void fnCalcularPaginacion(Int32 totalRegistros, Int32 filas, Int32 totalResultados, ComboBox cboPag, SiticoneCircleButton btnTotPag, SiticoneCircleButton btnNumFil, SiticoneCircleButton btnTotReg)
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

            cboPag.Items.Clear();

            for (Int32 i = 1; i <= cantidadPaginas; i++)
            {
                cboPag.Items.Add(i);

            }

            cboPag.SelectedIndex = 0;
            btnTotPag.Text = Convert.ToString(cantidadPaginas);
            btnNumFil.Text = Convert.ToString(totalResultados);
            btnTotReg.Text = Convert.ToString(totalRegistros);

        }
        private Boolean fnBuscarPersona(DataGridView dgv, Int32 numPagina)
        {
            NeBuscarPersona objper = new NeBuscarPersona();

            DataTable dtPersona = new DataTable();
            String nomPersona;
            Int32 filas = 15;
            Int32 idTipoPersona;
            Int32 idTipoDocumento;
            String estado;
            try
            {

                nomPersona = Convert.ToString(txtBuscarPersona.Text.ToString());

                dtPersona = objper.NeBuscarPer(nomPersona, numPagina);

                Int32 totalResultados = dtPersona.Rows.Count;


                if (totalResultados > 0)
                {

                    DataTable dt = new DataTable();

                    dgRegistrarPersona.Columns.Add("ID", "ID"); // nombre que se asignara a columna -  Texto de la columna
                    dgRegistrarPersona.Columns.Add("Nom", "Nombre");
                    dgRegistrarPersona.Columns.Add("ApePat", "Apellido Paterno");
                    dgRegistrarPersona.Columns.Add("ApeMat", "Apellido Materno");
                    dgRegistrarPersona.Columns.Add("Doc", "Documento");
                    dgRegistrarPersona.Columns.Add("CorreoPer", "Correo");
                    dgRegistrarPersona.Columns.Add("Ocu", "Ocupacion");
                    dgRegistrarPersona.Columns.Add("Rol", "Rol Familiar");

                }
                foreach (DataRow item in dtPersona.Rows)
                {
                    dgRegistrarPersona.Rows.Add(
                        item["idPersona"],
                        item["nomPersona"],
                        item["apePat"],
                        item["apeMat"],
                        item["docPersona"],
                        item["correoPersona"],
                        item["nomOcupacion"],
                        item["nomRol"]
                        );
                    Int32 totalRegistros = Convert.ToInt32(dtPersona.Rows[0][7]);
                    fnCalcularPaginacion(
                        totalRegistros,
                        filas,
                        totalResultados,
                        cboPagina,
                        btnTotalPaginas,
                        btnNumFilas,
                        btnTotalReg
                        );
                    btnNumFilas.Text = Convert.ToString(totalResultados);
                }
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
                bResul = fnBuscarPersona(dgRegistrarPersona,0);
                if (!bResul)
                {
                    MessageBox.Show("Error al Buscar Familiar. Comunicar a Administrador de Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            fnTrarDatosPersona();
        }

        private void rjProgressBar1_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Error al Buscar Cliente. Comunicar a Administrador de Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
