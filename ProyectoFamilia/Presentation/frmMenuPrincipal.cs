using ProyectoFamilia.FormsIncome;
using ProyectoFamilia.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFamilia.Presentation
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            hideSubMenu();



        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        private void tmFormulario_Tick(object sender, EventArgs e)
        {

            pbCargarFormularios.Value += 5;


            lblPbFormularios.Text = pbCargarFormularios.Value.ToString() + " % ";

            if (pbCargarFormularios.Value == 100)
            {
                tmFormulario.Stop();
                //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                //frmRegistrarMiembros frmMiembros = new frmRegistrarMiembros();
                //frmMiembros.Show();


                //se instancia el formulario a llamar

                openChildForm(new frmRegistrarMiembros());

                //frmMiembros.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        int lx, ly;

        /*private void btnCerrarFormularios_Click(object sender, EventArgs e)
        {
            pbCargarFormularios.Value = 0;
            lblPbFormularios.Text = "";
            if (this.Width > 900)
            {
                this.Size = new Size(254, Screen.PrimaryScreen.WorkingArea.Size.Height);
                this.Location = new Point(lx, ly);
            }
        }*/

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            ShowSubMenuIngresos(pIngresos);


            #region Codigo para llenar un panel contenedor a full scream
            /*if (pbCargarFormularios.Value == 100 && PanelMenu.Width == 254)
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }*/
            #endregion
        }

        #region PanelDinamico

        private void hideSubMenuIngresos()
        {
            pIngresos.Visible = false;
            if (pFamilia.Visible == false)
            {
                btnEgresos.Location = new Point(4, 381);
            }
        }
        private void hideSubMenu()
        {
            pFamilia.Visible = false;
            if (pFamilia.Visible == false)
            {
                btnIngresos.Location = new Point(3, 326);
            }
            //----------
           
            //panelPlaylistSubMenu.Visible = false;
            //panelToolsSubMenu.Visible = false;
        }

        private void ShowSubMenuIngresos(Panel SubMenuIngresos)
        {
            if (SubMenuIngresos.Visible == false)
            {
                hideSubMenu();
                btnEgresos.Location = new Point(2, 489);

                SubMenuIngresos.Visible = true;
            }
            else
            {
                SubMenuIngresos.Visible = false;
                btnIngresos.Location = new Point(2, 382);
            }
        }
        private void showSubMenu(Panel subMenu)
        {
           
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                btnIngresos.Location = new Point(3, 437);
                
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
                btnIngresos.Location = new Point(3, 326);
            }

            //----
           




        }

        public void fnResertProgressBar()
        {
            if (pbCargarFormularios.Value == 100 && lblPbFormularios.Text == "100" + " % ")
            {
                pbCargarFormularios.Value = 5;
                pbCargarFormularios.Visible = false;
                lblPbFormularios.Visible = false;

            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            //if (activeForm != null) activeForm.Close();
            //activeForm = childForm;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //PanelMenu.Controls.Add(childForm);
            //PanelMenu.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();

            frmRegistrarMiembros frmRegistrarFamilia = new frmRegistrarMiembros();
            frmRegistrarFamilia.Show();
            fnResertProgressBar();
        }

        #endregion
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            #region Panel

            btnIngresos.Location = new Point(3, 326);

            #endregion

            #region InicioFormulario

            pbCargarFormularios.Visible = false;

            #endregion


            #region Posicion del menu en la pantalla principal
            Rectangle AreaTrabajo = Screen.PrimaryScreen.WorkingArea;
            int taskbarHeight = Screen.PrimaryScreen.Bounds.Height - AreaTrabajo.Height;
            Point taskbarLocation = new Point(AreaTrabajo.Left, AreaTrabajo.Top);


            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Location.X, Screen.PrimaryScreen.WorkingArea.Location.Y);
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = new Size(242, Screen.PrimaryScreen.WorkingArea.Size.Height);
            #endregion
        }

        private void btnVolverLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            //Mostrar Panel Con formularios Hijos
            showSubMenu(pFamilia);
        }

        private void btnRegistrarMiembro_Click(object sender, EventArgs e)
        {
            //Abrir el Formulario
            if (openChildForm != null)
            {
                lblPbFormularios.Visible = true;
                pbCargarFormularios.Visible = true;
                tmFormulario.Start();
                hideSubMenu();
            }

        }


    }
}
