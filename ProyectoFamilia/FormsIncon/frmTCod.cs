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
    public partial class frmTCod : Form
    {
        public frmTCod()
        {
            InitializeComponent();
        }

        private void txtNombrecodigo_Enter(object sender, EventArgs e)
        {
            if (txtNombrecodigo.Text == "INGRESE NOMBRE CORRESPONDIENTE")
            {
                txtNombrecodigo.Text = "";
                txtNombrecodigo.ForeColor = Color.Black;
            }
        }

        private void txtNombrecodigo_Leave(object sender, EventArgs e)
        {
            if (txtNombrecodigo.Text == "")
            {
                txtNombrecodigo.Text = "INGRESE NOMBRE CORRESPONDIENTE";
                txtNombrecodigo.ForeColor = Color.Silver;

            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "INGRESE CODIGO")
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.Black;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "INGRESE CODIGO";
                txtCodigo.ForeColor = Color.Silver;

            }
        }
    }
}
