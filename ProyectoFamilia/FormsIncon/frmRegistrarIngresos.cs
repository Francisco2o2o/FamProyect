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

namespace ProyectoFamilia.FormsIncon
{
    public partial class frmRegistrarIngresos : Form
    {
        public frmRegistrarIngresos()
        {
            InitializeComponent();
        }

        public void Alert(string mensaje, Notify.enmType type)
        {
            Notify frm = new Notify();
            frm.showAlert(mensaje, type);
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            tmCargarIngresos.Start();
        }

        private void frmRegistrarIngresos_Load(object sender, EventArgs e)
        {
            dtRegistrarIngresos.Visible = false;
        }

        private void tmCargarIngresos_Tick(object sender, EventArgs e)
        {
            pbIngresos.Value += 10;

            if (pbIngresos.Value == 100)
            {
                tmCargarIngresos.Stop();
                pbIngresos.Value = 100;
                //MessageBox.Show("Ingresos Registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Alert("Ingreso Registrado", Notify.enmType.Info);
            }
        }
    }
}
