using System.Windows.Forms;
using System;
using ProyectoFamilia.Notifications;

namespace ProyectoFamilia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region Mensaje de ok
            //DialogResult result = MessageFM.Show("Texto de la caja de mensaje",
            //    "TITULO DEL MENSAJE");
            #endregion

            #region Mensaje de Error / MessageBoxButtons.OK = boton /MessageBoxIcon.Error = icono Error

            MessageFM.Show("This is an example of an Error-Stop Icon Message Box.",
               "Error-Stop Icon",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            #endregion

        }
    }
}