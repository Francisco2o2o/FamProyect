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
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
        }
        int lx, ly;

        private void btnCerrarFormularios_Click(object sender, EventArgs e)
        {
            pbCargarFormularios.Value =0;
            lblPbFormularios.Text = "";
            if (this.Width > 900)
            {
                this.Size = new Size(254, Screen.PrimaryScreen.WorkingArea.Size.Height);
                this.Location = new Point(lx, ly);
            }
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            tmFormulario.Start();
            if(pbCargarFormularios.Value==100&& PanelMenu.Width == 254)
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
        }
        

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
            
            Rectangle AreaTrabajo = Screen.PrimaryScreen.WorkingArea;
            int taskbarHeight = Screen.PrimaryScreen.Bounds.Height - AreaTrabajo.Height;
            Point taskbarLocation = new Point(AreaTrabajo.Left, AreaTrabajo.Top);


            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Location.X, Screen.PrimaryScreen.WorkingArea.Location.Y);
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = new Size(254, Screen.PrimaryScreen.WorkingArea.Size.Height);
        }
    }
}
