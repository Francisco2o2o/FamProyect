namespace ProyectoFamilia.Presentation
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            btnIngresar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            siticoneSeparator2 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            PanelLogin = new Panel();
            MoverLogin = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            pbox = new PictureBox();
            CambioImagen = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(393, 125);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(255, 20);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "INGRESE USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(393, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(255, 20);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "INGRESE PASSWORD";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(312, 128);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(309, 168);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(400, 249);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(136, 17);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvide mi contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(264, 211);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(384, 36);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(279, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(279, 168);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(423, 67);
            label3.Name = "label3";
            label3.Size = new Size(90, 30);
            label3.TabIndex = 9;
            label3.Text = "LOGIN";
            // 
            // siticoneSeparator1
            // 
            siticoneSeparator1.Location = new Point(393, 144);
            siticoneSeparator1.Name = "siticoneSeparator1";
            siticoneSeparator1.Size = new Size(255, 10);
            siticoneSeparator1.TabIndex = 10;
            // 
            // siticoneSeparator2
            // 
            siticoneSeparator2.Location = new Point(393, 182);
            siticoneSeparator2.Name = "siticoneSeparator2";
            siticoneSeparator2.Size = new Size(255, 10);
            siticoneSeparator2.TabIndex = 11;
            // 
            // PanelLogin
            // 
            PanelLogin.BackColor = Color.FromArgb(0, 192, 192);
            PanelLogin.Dock = DockStyle.Top;
            PanelLogin.Location = new Point(0, 0);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(660, 44);
            PanelLogin.TabIndex = 12;
            // 
            // MoverLogin
            // 
            MoverLogin.DockIndicatorTransparencyValue = 0.6D;
            MoverLogin.TargetControl = PanelLogin;
            MoverLogin.UseTransparentDrag = true;
            // 
            // pbox
            // 
            pbox.Image = Properties.Resources.Logop2;
            pbox.Location = new Point(10, 54);
            pbox.Name = "pbox";
            pbox.Size = new Size(235, 230);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.TabIndex = 13;
            pbox.TabStop = false;
            // 
            // CambioImagen
            // 
            CambioImagen.Tick += CambioImagen_Tick;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(660, 301);
            Controls.Add(pbox);
            Controls.Add(PanelLogin);
            Controls.Add(siticoneSeparator2);
            Controls.Add(siticoneSeparator1);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnIngresar);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button btnIngresar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private Panel PanelLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl MoverLogin;
        public TextBox txtUsuario;
        private PictureBox pbox;
        private System.Windows.Forms.Timer CambioImagen;
    }
}