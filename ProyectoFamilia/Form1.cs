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
            rjComboBox1.SelectedItem = siticoneComboBox1.SelectedText;


            #region Mensaje de ok
            //DialogResult result = MessageFM.Show("Texto de la caja de mensaje",
            //    "TITULO DEL MENSAJE");
            #endregion

            #region Mensaje de Error / MessageBoxButtons.OK = boton /MessageBoxIcon.Error = icono Error

            MessageFM.Show("This is an example of an Error-Stop Icon Message Box.",
               "Error-Stop Icon",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            #endregion

        }

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Subtract(dtfecha.Value).TotalDays / 365.25 > 100)
            {
                MessageBox.Show("La fecha seleccionada es inválida. Por favor, elija una fecha que no sea mayor a 100 años a partir de la fecha actual.");
                dtfecha.Focus();
                return;
            }

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rjComboBox1_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            rjComboBox1.SelectedItem = siticoneComboBox1.SelectedItem;
            

        }
    }
}