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

        //private Image[] imageLogo = new Image[9];

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
                    Usuario clUsu = new Usuario(); // creamos una nueva instancia de clase
                    Persona clPresona = new Persona();
                    RolPersona clRol = new RolPersona();
                    OcupacionPersona clOcupa = new OcupacionPersona();

                    foreach (DataRow row in GuardarDatos.Rows) // agregamos los datos a un datatable
                    {
                        clUsu.IdUser = Convert.ToInt32(row["idUsuario"]); // asignamos el valor de las variales de las claseas a las  que vienen de la base de datos
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

                        clPresona.clsUsuario = clUsu; //agregamos las variables de las clases a una general
                        clPresona.clsRol = clRol;
                        clPresona.clsOcupa = clOcupa;

                    }
                    GeneralClass.clsPersona = clPresona;//clase general es igual a la variable donde se juntaron todos los datos


                    MessageFM.Show("Datos Ingresador Correctamente",
          "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //this.Alert("Los Datos son Correctos", Notify.enmType.Info);

                    //MessageBox.Show("Bienvenido al Sistema");
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
                MessageFM.Show("Datos Incorrectos.\nIngreses su Usuario y Password nuevamente",
          "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtPassword.UseSystemPasswordChar = true; // Modo contraseña oculata activado
                txtPassword.ForeColor = Color.Black;


            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text))//Si el textBox  no tiene ningun caracter que el modo contraseña de habilite
            {
                txtPassword.UseSystemPasswordChar = false; //-> Contraseña activada
                txtPassword.Text = "INGRESE PASSWORD";
                txtPassword.ForeColor = Color.Silver;

            }
            else
            {
                // El TextBox tiene caracteres
            }



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {


            CambioImagen.Interval = 1500;
            CambioImagen.Start();

            if (txtPassword.Text == "INGRESE PASSWORD")
            {
                pboxPassword.Visible = false;
            }
        }


        //Creamos una variable para el timer
        int inicio = 0;
        private void CambioImagen_Tick(object sender, EventArgs e)

        {
            //Creamos una lista para guardar las imagenes
            List<Image> ImageLogo = new List<Image>();
            //Agregamos las imagenes a la lista
            //ImageLogo.Add(Properties.Resources.lg);
            ImageLogo.Add(Properties.Resources.Logop1);
            ImageLogo.Add(Properties.Resources.Logop2);
            ImageLogo.Add(Properties.Resources.Logop3);
            ImageLogo.Add(Properties.Resources.Logop4);
            ImageLogo.Add(Properties.Resources.Logop5);
            ImageLogo.Add(Properties.Resources.Logop6);
            ImageLogo.Add(Properties.Resources.Logop7);
            ImageLogo.Add(Properties.Resources.Logop8);
            //ImageLogo.Add(Properties.Resources.lg);
            pbox.Image = ImageLogo[inicio];
            inicio++;

            //Si Inicio es mayor al de la lista, se reinicia a 0 para comenzar de nuevo
            if (inicio >= ImageLogo.Count)
            {
                inicio = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Cerrar Todos los formulario si alguno esta abierto y no es visible
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.Name != "MainForm")
            //    {
            //        form.Close();
            //    }
            //}

            //Usamos el metodo cast para convertir en un array Application.OpenForms
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in openForms)
            {
                form.Close();
            }

        }

        private void pboxPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                pboxPassword.Image = Properties.Resources.NoVer;
            }
            else if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                pboxPassword.Image = Properties.Resources.Ver;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                pboxPassword.Visible = true;
            }
            else
            {
                pboxPassword.Visible = false;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text== "INGRESE PASSWORD" && pboxPassword.Visible == true)
            {
                pboxPassword.Visible = false;
            }
            
        }
    }
}
