namespace ProyectoFamilia.FormsIncon
{
    partial class frmTCod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTCod));
            pRegistrarCodigos = new Panel();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtCodigo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtNombrecodigo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pRegistrarCodigos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pRegistrarCodigos
            // 
            pRegistrarCodigos.BackColor = Color.FromArgb(78, 214, 202);
            pRegistrarCodigos.Controls.Add(siticoneHtmlLabel3);
            pRegistrarCodigos.Dock = DockStyle.Top;
            pRegistrarCodigos.Location = new Point(0, 0);
            pRegistrarCodigos.Name = "pRegistrarCodigos";
            pRegistrarCodigos.Size = new Size(660, 44);
            pRegistrarCodigos.TabIndex = 0;
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(12, 12);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(174, 23);
            siticoneHtmlLabel3.TabIndex = 6;
            siticoneHtmlLabel3.Text = "REGISTRAR CODIGOS";
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(18, 64);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(61, 23);
            siticoneHtmlLabel1.TabIndex = 1;
            siticoneHtmlLabel1.Text = "Código";
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(285, 64);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(66, 23);
            siticoneHtmlLabel2.TabIndex = 2;
            siticoneHtmlLabel2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.DefaultText = "INGRESE CODIGO";
            txtCodigo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCodigo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCodigo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCodigo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCodigo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCodigo.Location = new Point(56, 90);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PlaceholderForeColor = Color.Black;
            txtCodigo.PlaceholderText = "";
            txtCodigo.SelectedText = "";
            txtCodigo.Size = new Size(179, 32);
            txtCodigo.TabIndex = 3;
            txtCodigo.Enter += txtCodigo_Enter;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // txtNombrecodigo
            // 
            txtNombrecodigo.DefaultText = "INGRESE NOMBRE CORRESPONDIENTE";
            txtNombrecodigo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombrecodigo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombrecodigo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombrecodigo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombrecodigo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombrecodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombrecodigo.ForeColor = Color.Black;
            txtNombrecodigo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombrecodigo.Location = new Point(328, 90);
            txtNombrecodigo.Margin = new Padding(3, 4, 3, 4);
            txtNombrecodigo.Name = "txtNombrecodigo";
            txtNombrecodigo.PasswordChar = '\0';
            txtNombrecodigo.PlaceholderForeColor = Color.Black;
            txtNombrecodigo.PlaceholderText = "";
            txtNombrecodigo.SelectedText = "";
            txtNombrecodigo.Size = new Size(311, 33);
            txtNombrecodigo.TabIndex = 4;
            txtNombrecodigo.Enter += txtNombrecodigo_Enter;
            txtNombrecodigo.Leave += txtNombrecodigo_Leave;
            // 
            // siticoneButton1
            // 
            siticoneButton1.BorderColor = Color.Gray;
            siticoneButton1.BorderRadius = 5;
            siticoneButton1.BorderThickness = 1;
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.White;
            siticoneButton1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.Black;
            siticoneButton1.Location = new Point(465, 130);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(174, 35);
            siticoneButton1.TabIndex = 5;
            siticoneButton1.Text = "Registrar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(290, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(633, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // frmTCod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(660, 186);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(siticoneButton1);
            Controls.Add(txtNombrecodigo);
            Controls.Add(txtCodigo);
            Controls.Add(siticoneHtmlLabel2);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(pRegistrarCodigos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTCod";
            Text = "frmTCod";
            pRegistrarCodigos.ResumeLayout(false);
            pRegistrarCodigos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pRegistrarCodigos;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCodigo;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNombrecodigo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl MoverCodigos;
    }
}