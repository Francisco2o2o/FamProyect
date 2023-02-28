namespace ProyectoFamilia.FormsIncon
{
    partial class frmRegistrarUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarUsuario));
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnGuardar = new Button();
            label3 = new Label();
            pSuperior = new Panel();
            dtFechaRegistroUsuario = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tmGuardarUsuario = new System.Windows.Forms.Timer(components);
            siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            siticoneSeparator2 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            MoverFormulario = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            cboNombrePersona = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 58);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 94);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(169, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(264, 20);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(169, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 20);
            txtPassword.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(38, 178);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(395, 31);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 6);
            label3.Name = "label3";
            label3.Size = new Size(187, 22);
            label3.TabIndex = 5;
            label3.Text = "REGISTRO USUARIO";
            // 
            // pSuperior
            // 
            pSuperior.BackColor = Color.FromArgb(78, 214, 202);
            pSuperior.Controls.Add(label3);
            pSuperior.Controls.Add(dtFechaRegistroUsuario);
            pSuperior.Dock = DockStyle.Top;
            pSuperior.Location = new Point(0, 0);
            pSuperior.Name = "pSuperior";
            pSuperior.Size = new Size(464, 36);
            pSuperior.TabIndex = 6;
            // 
            // dtFechaRegistroUsuario
            // 
            dtFechaRegistroUsuario.Checked = true;
            dtFechaRegistroUsuario.FillColor = Color.White;
            dtFechaRegistroUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaRegistroUsuario.Format = DateTimePickerFormat.Long;
            dtFechaRegistroUsuario.Location = new Point(213, 0);
            dtFechaRegistroUsuario.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtFechaRegistroUsuario.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtFechaRegistroUsuario.Name = "dtFechaRegistroUsuario";
            dtFechaRegistroUsuario.Size = new Size(220, 36);
            dtFechaRegistroUsuario.TabIndex = 6;
            dtFechaRegistroUsuario.Value = new DateTime(2023, 2, 21, 17, 58, 42, 79);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // siticoneSeparator1
            // 
            siticoneSeparator1.FillColor = Color.Black;
            siticoneSeparator1.FillThickness = 2;
            siticoneSeparator1.Location = new Point(168, 72);
            siticoneSeparator1.Name = "siticoneSeparator1";
            siticoneSeparator1.Size = new Size(265, 10);
            siticoneSeparator1.TabIndex = 10;
            // 
            // siticoneSeparator2
            // 
            siticoneSeparator2.FillColor = Color.Black;
            siticoneSeparator2.FillThickness = 2;
            siticoneSeparator2.Location = new Point(168, 108);
            siticoneSeparator2.Name = "siticoneSeparator2";
            siticoneSeparator2.Size = new Size(265, 10);
            siticoneSeparator2.TabIndex = 11;
            // 
            // MoverFormulario
            // 
            MoverFormulario.DockIndicatorTransparencyValue = 0.6D;
            MoverFormulario.TargetControl = pSuperior;
            MoverFormulario.UseTransparentDrag = true;
            // 
            // cboNombrePersona
            // 
            cboNombrePersona.BackColor = Color.Transparent;
            cboNombrePersona.BorderColor = Color.FromArgb(64, 64, 64);
            cboNombrePersona.BorderRadius = 5;
            cboNombrePersona.DrawMode = DrawMode.OwnerDrawFixed;
            cboNombrePersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNombrePersona.FocusedColor = Color.FromArgb(94, 148, 255);
            cboNombrePersona.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboNombrePersona.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboNombrePersona.ForeColor = Color.FromArgb(68, 88, 112);
            cboNombrePersona.ItemHeight = 30;
            cboNombrePersona.Location = new Point(168, 124);
            cboNombrePersona.Name = "cboNombrePersona";
            cboNombrePersona.Size = new Size(265, 36);
            cboNombrePersona.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 139);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 13;
            label4.Text = "Nombre";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.family;
            pictureBox3.Location = new Point(38, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // frmRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(464, 236);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(cboNombrePersona);
            Controls.Add(siticoneSeparator2);
            Controls.Add(siticoneSeparator1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pSuperior);
            Controls.Add(btnGuardar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistrarUsuario";
            StartPosition = FormStartPosition.Manual;
            Text = "frmRegistrarUsuario";
            Load += frmRegistrarUsuario_Load;
            pSuperior.ResumeLayout(false);
            pSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnGuardar;
        private Label label3;
        private Panel pSuperior;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmGuardarUsuario;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl MoverFormulario;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtFechaRegistroUsuario;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboNombrePersona;
        private Label label4;
        private PictureBox pictureBox3;
    }
}