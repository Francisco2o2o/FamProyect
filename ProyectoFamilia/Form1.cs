using System.Windows.Forms;
using System;
using ProyectoFamilia.Notifications;
using ProyectoFamilia.ColorForms;
using ProyectoFamilia.FormsIncon;

namespace ProyectoFamilia
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PanelTop.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelMenu.Controls.Add(childForm);
            this.PanelMenu.Tag = childForm;
            childForm.BringToFront();
            //childForm.Show();
            ///lblTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            //lblTitle.Text = "HOME";
            PanelTop.BackColor = Color.FromArgb(0, 150, 136);
            btnProductos.BackColor = Color.FromArgb(0, 150, 136);
            //panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnClose.Visible = false;
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
               "Error-Stop Icon", MessageBoxButtons.OK, MessageBoxIcon.Error);

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



        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {



        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Notify(), sender);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistrarUsuario(), sender);
        }
    }
}