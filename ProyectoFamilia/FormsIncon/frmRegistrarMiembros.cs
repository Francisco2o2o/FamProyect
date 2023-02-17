
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
        public frmRegistrarMiembros()
        {
            InitializeComponent();
        }

        private void GuardarMiembroFamilia_Click(object sender, EventArgs e)
        {
            //MiembrosFamilia MFamilia = new MimebrosFamilia();
            //MFamilia.NomFamilia = txtNombre.Text;
            //MFamilia.ApeFamilia = txtApellido.Text;
            //MFamilia.DocFamilia = txtDocumento.Text;
            //MFamilia.OcupacionFamilia = txtOcupacion.Text;
            //MFamilia.FotoFamilia = Convert.ToByte(picbFotoMiembroFamilia.ToString());
            //MFamilia.FechaFamilia=Convert.ToDateTime( dtFechaMiembroFamilia.ToString());
            



            //try
            //{
            //    SqlConnection c = ConexionSql.conexion();
            //    c.Open();
            //    //Nombre,Apellido = Campos de la tabla
            //    using (SqlCommand command = new SqlCommand("INSERT INTO RegistroFamilia (NomFamilia,ApeFamilia,DocFamilia,OcupacionFamilia,FotoFamilia,FechaFamilia,)" +
            //        " VALUES (@nomFamilia, @apeFamilia, @docFamilia, @ocupacionFamilia,@fotoFamilia,@fecFamilia)", c))
            //    {
            //        command.Parameters.AddWithValue("@nomFamilia", MFamilia.NomFamilia);
            //        command.Parameters.AddWithValue("@apeFamilia", MFamilia.ApeFamilia);
            //        command.Parameters.AddWithValue("@docFamilia", MFamilia.DocFamilia);
            //        command.Parameters.AddWithValue("@ocupacionFamilia", MFamilia.OcupacionFamilia);
            //        command.Parameters.AddWithValue("@fotoFamilia", MFamilia.FotoFamilia);
            //        command.Parameters.AddWithValue("@fecFamilia", MFamilia.FechaFamilia);

            //        command.ExecuteNonQuery();
            //        System.Windows.Forms.MessageBox.Show("Guardado");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show("Error al Guardar: " + ex.Message);
            //}
        }

        private void btnFotoMiembroFamilia_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picbFotoMiembroFamilia.Image = new Bitmap(open.FileName);
            }
        }
    }
}
