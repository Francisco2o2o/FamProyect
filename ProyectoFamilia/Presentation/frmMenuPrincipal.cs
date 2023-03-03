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
            hideSubMenuFamilia();
            hideSubMenuIngresos();
            hideSubMenuEgresos();

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
        #region PANEL INGRESOS
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            //pFamilia.Visible = false;
            showSubMenuIngresos(pIngresos);
            if (pFamilia.Visible == true || pEgresos.Visible == true)
            {
                pFamilia.Visible = false;
                pEgresos.Visible = false;
                btnIngresos.Location = new Point(3, 327);
                btnIngresos.Visible = true;

            }
            else
            {
                btnIngresos.Visible = true;
            }

            #region Codigo para llenar un panel contenedor a full scream
            /*if (pbCargarFormularios.Value == 100 && PanelMenu.Width == 254)
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }*/
            #endregion
        }



        private void hideSubMenuIngresos()
        {
            pIngresos.Visible = false;
            if (pIngresos.Visible == false)
            {
                btnEgresos.Location = new Point(2, 379);
            }
        }


        private void showSubMenuIngresos(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                hideSubMenuIngresos();

                btnEgresos.Location = new Point(2, 486);


                subMenu.Visible = true;
                subMenu.Location = new Point(3, 375);
            }
            else
            {
                subMenu.Visible = false;

                btnEgresos.Location = new Point(2, 379);
            }
        }

        #endregion

        #region MenuFamilia
        private void hideSubMenuFamilia()
        {
            pFamilia.Visible = false;
            if (pFamilia.Visible == false)
            {
                btnIngresos.Location = new Point(2, 327);
                btnEgresos.Location = new Point(2, 382);

            }
        }


        private void showSubMenuFamilia(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                hideSubMenuFamilia();
                btnIngresos.Location = new Point(2, 430);
                btnEgresos.Location = new Point(3, 483);


                subMenu.Visible = true;
                subMenu.Location = new Point(2, 323);
            }
            else
            {
                subMenu.Visible = false;
                btnIngresos.Location = new Point(2, 327);
                btnEgresos.Location = new Point(2, 382);
            }

        }
        #endregion
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

            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();

        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            //Mostrar Panel Con formularios Hijos

            showSubMenuFamilia(pFamilia);
            if (pIngresos.Visible == true || pEgresos.Visible == true)
            {
                pIngresos.Visible = false;
                pEgresos.Visible = false;
                btnFamilia.Location = new Point(3, 274);
                btnFamilia.Visible = true;


            }
            else
            {
                btnFamilia.Visible = true;
            }
        }

        private void btnRegistrarMiembro_Click(object sender, EventArgs e)
        {
            //Abrir el Formulario
            if (openChildForm != null)
            {
                lblPbFormularios.Visible = true;
                pbCargarFormularios.Visible = true;
                tmFormulario.Start();
                hideSubMenuFamilia();
            }

        }

        #region PANEL INGRESOS
        private void btnEgresos_Click(object sender, EventArgs e)
        {
            showSubMenuEgresos(pEgresos);
            if (pIngresos.Visible == true || pFamilia.Visible == true)
            {
                pFamilia.Visible = false;
                pIngresos.Visible = false;
                btnEgresos.Location = new Point(3, 382);
                btnIngresos.Visible = true;

            }
            else
            {
                btnIngresos.Visible = true;
            }
        }
        private void hideSubMenuEgresos()
        {
            pEgresos.Visible = false;
            if (pEgresos.Visible == false)
            {
                btnEgresos.Location = new Point(3, 382);
            }
        }


        private void showSubMenuEgresos(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                hideSubMenuEgresos();

                btnEgresos.Location = new Point(3, 382);


                subMenu.Visible = true;
                subMenu.Location = new Point(3, 429);
            }
            else
            {
                subMenu.Visible = false;

                btnEgresos.Location = new Point(3, 382);
            }
        }
        #endregion

    }
}
