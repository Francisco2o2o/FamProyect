using ProyectoFamilia.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFamilia.Notifications
{
    public partial class frmBienvenido : Form
    {
        public frmBienvenido()
        {
            InitializeComponent();
            lblBienvenido.Text = nombreUsuario;

        }
        static string nombreUsuario = "";
        public void fnPasardatos(String nom)
        {
            nombreUsuario = nom;

            this.Show();
        }
        private void frmBienvenido_Load(object sender, EventArgs e)
        {

            #region Pantalla bienvenido
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 50,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height - 50);

            #endregion

            lblBienvenido.Text = nombreUsuario;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBienvenido.Value += 2;
            if (pBienvenido.Value == 100)
            {
                timer1.Stop();
                pBienvenido.Value = 0;
                frmMenuPrincipal frmMenu = new frmMenuPrincipal();
                frmMenu.Show();
                this.Visible = false;
                //timer1.Start();
            }
            //else if (pBienvenido.Value == 0)
            //{
            //    timer1.Start();
            //}

        }


    }
}
