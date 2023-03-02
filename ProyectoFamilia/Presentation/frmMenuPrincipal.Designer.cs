namespace ProyectoFamilia.Presentation
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            PanelMenu = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();
            pIngresos = new Panel();
            btnRegistrarIngresos = new Button();
            btnAhorro = new Button();
            btnEgresos = new Button();
            lblPbFormularios = new Label();
            pbCargarFormularios = new CircularProgressBar.CircularProgressBar();
            lblFecha = new Label();
            lblHora = new Label();
            pictureBox1 = new PictureBox();
            btnVolverLogin = new Button();
            btnFamilia = new Button();
            btnIngresos = new Button();
            pFamilia = new Panel();
            btnRegistrarMiembro = new Button();
            btnRegistraUsuario = new Button();
            PanelSupeior = new Panel();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            PanelInfeior = new Panel();
            lblFechaFormulario = new Label();
            lblHoraFormulario = new Label();
            imgUsuario = new PictureBox();
            lblNombreUsuario = new Label();
            lblTipoMiembro = new Label();
            tmHoraFecha = new System.Windows.Forms.Timer(components);
            tmFormulario = new System.Windows.Forms.Timer(components);
            PanelMenu.SuspendLayout();
            panel2.SuspendLayout();
            pIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pFamilia.SuspendLayout();
            PanelSupeior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            PanelInfeior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BorderColor = Color.FromArgb(0, 192, 192);
            PanelMenu.BorderThickness = 5;
            PanelMenu.Controls.Add(panel2);
            PanelMenu.Controls.Add(btnEgresos);
            PanelMenu.Controls.Add(lblPbFormularios);
            PanelMenu.Controls.Add(pbCargarFormularios);
            PanelMenu.Controls.Add(lblFecha);
            PanelMenu.Controls.Add(lblHora);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(btnVolverLogin);
            PanelMenu.Controls.Add(btnFamilia);
            PanelMenu.Controls.Add(btnIngresos);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(241, 1000);
            PanelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(3, 648);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 108);
            panel2.TabIndex = 12;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 5);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(236, 48);
            button3.TabIndex = 10;
            button3.Text = "Registrar Ingreso";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-1, 56);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 20, 0);
            button4.Size = new Size(236, 48);
            button4.TabIndex = 9;
            button4.Text = "Ahorro";
            button4.UseVisualStyleBackColor = true;
            // 
            // pIngresos
            // 
            pIngresos.BackColor = Color.LightGray;
            pIngresos.Controls.Add(btnRegistrarIngresos);
            pIngresos.Controls.Add(btnAhorro);
            pIngresos.Location = new Point(355, 442);
            pIngresos.Name = "pIngresos";
            pIngresos.Size = new Size(235, 108);
            pIngresos.TabIndex = 11;
            // 
            // btnRegistrarIngresos
            // 
            btnRegistrarIngresos.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnRegistrarIngresos.FlatAppearance.BorderSize = 2;
            btnRegistrarIngresos.FlatStyle = FlatStyle.Flat;
            btnRegistrarIngresos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarIngresos.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarIngresos.Location = new Point(0, 5);
            btnRegistrarIngresos.Name = "btnRegistrarIngresos";
            btnRegistrarIngresos.Padding = new Padding(30, 0, 0, 0);
            btnRegistrarIngresos.Size = new Size(236, 48);
            btnRegistrarIngresos.TabIndex = 10;
            btnRegistrarIngresos.Text = "Registrar Ingreso";
            btnRegistrarIngresos.UseVisualStyleBackColor = true;
            // 
            // btnAhorro
            // 
            btnAhorro.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnAhorro.FlatAppearance.BorderSize = 2;
            btnAhorro.FlatStyle = FlatStyle.Flat;
            btnAhorro.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAhorro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAhorro.Location = new Point(-1, 56);
            btnAhorro.Name = "btnAhorro";
            btnAhorro.Padding = new Padding(30, 0, 20, 0);
            btnAhorro.Size = new Size(236, 48);
            btnAhorro.TabIndex = 9;
            btnAhorro.Text = "Ahorro";
            btnAhorro.UseVisualStyleBackColor = true;
            // 
            // btnEgresos
            // 
            btnEgresos.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnEgresos.FlatAppearance.BorderSize = 2;
            btnEgresos.FlatStyle = FlatStyle.Flat;
            btnEgresos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEgresos.Image = (Image)resources.GetObject("btnEgresos.Image");
            btnEgresos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEgresos.Location = new Point(4, 381);
            btnEgresos.Name = "btnEgresos";
            btnEgresos.Size = new Size(236, 48);
            btnEgresos.TabIndex = 1;
            btnEgresos.Text = "EGRESOS";
            btnEgresos.UseVisualStyleBackColor = true;
            // 
            // lblPbFormularios
            // 
            lblPbFormularios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPbFormularios.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPbFormularios.Location = new Point(87, 836);
            lblPbFormularios.Name = "lblPbFormularios";
            lblPbFormularios.Size = new Size(50, 16);
            lblPbFormularios.TabIndex = 7;
            // 
            // pbCargarFormularios
            // 
            pbCargarFormularios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbCargarFormularios.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            pbCargarFormularios.AnimationSpeed = 500;
            pbCargarFormularios.BackColor = Color.White;
            pbCargarFormularios.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            pbCargarFormularios.ForeColor = Color.White;
            pbCargarFormularios.InnerColor = Color.Transparent;
            pbCargarFormularios.InnerMargin = 2;
            pbCargarFormularios.InnerWidth = -1;
            pbCargarFormularios.Location = new Point(58, 793);
            pbCargarFormularios.MarqueeAnimationSpeed = 2000;
            pbCargarFormularios.Name = "pbCargarFormularios";
            pbCargarFormularios.OuterColor = Color.LightGray;
            pbCargarFormularios.OuterMargin = -25;
            pbCargarFormularios.OuterWidth = 25;
            pbCargarFormularios.ProgressColor = Color.FromArgb(0, 192, 192);
            pbCargarFormularios.ProgressWidth = 10;
            pbCargarFormularios.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            pbCargarFormularios.Size = new Size(100, 100);
            pbCargarFormularios.StartAngle = 270;
            pbCargarFormularios.SubscriptColor = Color.Transparent;
            pbCargarFormularios.SubscriptMargin = new Padding(10, -35, 0, 0);
            pbCargarFormularios.SubscriptText = ".23";
            pbCargarFormularios.SuperscriptColor = Color.White;
            pbCargarFormularios.SuperscriptMargin = new Padding(10, 35, 0, 0);
            pbCargarFormularios.SuperscriptText = "°C";
            pbCargarFormularios.TabIndex = 1;
            pbCargarFormularios.TextMargin = new Padding(8, 8, 0, 0);
            pbCargarFormularios.Value = 5;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(5, 932);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 19);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(87, 896);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(60, 25);
            lblHora.TabIndex = 5;
            lblHora.Text = "Hora";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lg;
            pictureBox1.Location = new Point(13, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnVolverLogin
            // 
            btnVolverLogin.Anchor = AnchorStyles.Bottom;
            btnVolverLogin.BackColor = Color.FromArgb(26, 129, 128);
            btnVolverLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnVolverLogin.FlatAppearance.BorderSize = 2;
            btnVolverLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVolverLogin.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnVolverLogin.FlatStyle = FlatStyle.Flat;
            btnVolverLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolverLogin.ForeColor = Color.White;
            btnVolverLogin.Location = new Point(-4, 963);
            btnVolverLogin.Name = "btnVolverLogin";
            btnVolverLogin.Size = new Size(248, 34);
            btnVolverLogin.TabIndex = 3;
            btnVolverLogin.Text = "Cerrar Sistema";
            btnVolverLogin.UseVisualStyleBackColor = false;
            btnVolverLogin.Click += btnVolverLogin_Click;
            // 
            // btnFamilia
            // 
            btnFamilia.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnFamilia.FlatAppearance.BorderSize = 2;
            btnFamilia.FlatStyle = FlatStyle.Flat;
            btnFamilia.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFamilia.Image = (Image)resources.GetObject("btnFamilia.Image");
            btnFamilia.ImageAlign = ContentAlignment.MiddleLeft;
            btnFamilia.Location = new Point(3, 274);
            btnFamilia.Name = "btnFamilia";
            btnFamilia.Size = new Size(236, 48);
            btnFamilia.TabIndex = 2;
            btnFamilia.Text = "FAMILIA";
            btnFamilia.UseVisualStyleBackColor = true;
            btnFamilia.Click += btnFamilia_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnIngresos.FlatAppearance.BorderSize = 2;
            btnIngresos.FlatStyle = FlatStyle.Flat;
            btnIngresos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresos.Image = (Image)resources.GetObject("btnIngresos.Image");
            btnIngresos.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresos.Location = new Point(3, 328);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(236, 48);
            btnIngresos.TabIndex = 0;
            btnIngresos.Text = "INGRESOS";
            btnIngresos.UseVisualStyleBackColor = true;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // pFamilia
            // 
            pFamilia.BackColor = Color.LightGray;
            pFamilia.Controls.Add(btnRegistrarMiembro);
            pFamilia.Controls.Add(btnRegistraUsuario);
            pFamilia.Location = new Point(309, 260);
            pFamilia.Name = "pFamilia";
            pFamilia.Size = new Size(235, 108);
            pFamilia.TabIndex = 8;
            // 
            // btnRegistrarMiembro
            // 
            btnRegistrarMiembro.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnRegistrarMiembro.FlatAppearance.BorderSize = 2;
            btnRegistrarMiembro.FlatStyle = FlatStyle.Flat;
            btnRegistrarMiembro.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarMiembro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarMiembro.Location = new Point(0, 5);
            btnRegistrarMiembro.Name = "btnRegistrarMiembro";
            btnRegistrarMiembro.Padding = new Padding(30, 0, 0, 0);
            btnRegistrarMiembro.Size = new Size(236, 48);
            btnRegistrarMiembro.TabIndex = 10;
            btnRegistrarMiembro.Text = "Registrar Miembro";
            btnRegistrarMiembro.UseVisualStyleBackColor = true;
            btnRegistrarMiembro.Click += btnRegistrarMiembro_Click;
            // 
            // btnRegistraUsuario
            // 
            btnRegistraUsuario.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnRegistraUsuario.FlatAppearance.BorderSize = 2;
            btnRegistraUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistraUsuario.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistraUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistraUsuario.Location = new Point(-1, 56);
            btnRegistraUsuario.Name = "btnRegistraUsuario";
            btnRegistraUsuario.Padding = new Padding(30, 0, 20, 0);
            btnRegistraUsuario.Size = new Size(236, 48);
            btnRegistraUsuario.TabIndex = 9;
            btnRegistraUsuario.Text = "Registra Usuario";
            btnRegistraUsuario.UseVisualStyleBackColor = true;
            // 
            // PanelSupeior
            // 
            PanelSupeior.BackColor = Color.FromArgb(1, 255, 205);
            PanelSupeior.Controls.Add(btnMinimize);
            PanelSupeior.Controls.Add(btnClose);
            PanelSupeior.Dock = DockStyle.Top;
            PanelSupeior.Location = new Point(241, 0);
            PanelSupeior.Name = "PanelSupeior";
            PanelSupeior.Size = new Size(202, 39);
            PanelSupeior.TabIndex = 1;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(145, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 24);
            btnMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(171, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // PanelInfeior
            // 
            PanelInfeior.BackColor = Color.FromArgb(37, 189, 177);
            PanelInfeior.Controls.Add(lblFechaFormulario);
            PanelInfeior.Controls.Add(lblHoraFormulario);
            PanelInfeior.Controls.Add(imgUsuario);
            PanelInfeior.Controls.Add(lblNombreUsuario);
            PanelInfeior.Controls.Add(lblTipoMiembro);
            PanelInfeior.Dock = DockStyle.Bottom;
            PanelInfeior.Location = new Point(241, 911);
            PanelInfeior.Name = "PanelInfeior";
            PanelInfeior.Size = new Size(202, 89);
            PanelInfeior.TabIndex = 2;
            // 
            // lblFechaFormulario
            // 
            lblFechaFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFechaFormulario.AutoSize = true;
            lblFechaFormulario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaFormulario.ForeColor = Color.White;
            lblFechaFormulario.Location = new Point(-37, 59);
            lblFechaFormulario.Name = "lblFechaFormulario";
            lblFechaFormulario.Size = new Size(55, 20);
            lblFechaFormulario.TabIndex = 8;
            lblFechaFormulario.Text = "Fecha";
            // 
            // lblHoraFormulario
            // 
            lblHoraFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblHoraFormulario.AutoSize = true;
            lblHoraFormulario.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoraFormulario.ForeColor = Color.White;
            lblHoraFormulario.Location = new Point(57, 21);
            lblHoraFormulario.Name = "lblHoraFormulario";
            lblHoraFormulario.Size = new Size(60, 25);
            lblHoraFormulario.TabIndex = 7;
            lblHoraFormulario.Text = "Hora";
            // 
            // imgUsuario
            // 
            imgUsuario.Location = new Point(11, 9);
            imgUsuario.Name = "imgUsuario";
            imgUsuario.Size = new Size(79, 70);
            imgUsuario.TabIndex = 0;
            imgUsuario.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(105, 12);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(122, 20);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "NombreUsuario";
            // 
            // lblTipoMiembro
            // 
            lblTipoMiembro.AutoSize = true;
            lblTipoMiembro.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoMiembro.ForeColor = Color.White;
            lblTipoMiembro.Location = new Point(105, 37);
            lblTipoMiembro.Name = "lblTipoMiembro";
            lblTipoMiembro.Size = new Size(103, 20);
            lblTipoMiembro.TabIndex = 0;
            lblTipoMiembro.Text = "TipoMiembro";
            // 
            // tmHoraFecha
            // 
            tmHoraFecha.Enabled = true;
            tmHoraFecha.Tick += tmHoraFecha_Tick;
            // 
            // tmFormulario
            // 
            tmFormulario.Tick += tmFormulario_Tick;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 1000);
            Controls.Add(PanelInfeior);
            Controls.Add(pIngresos);
            Controls.Add(PanelSupeior);
            Controls.Add(PanelMenu);
            Controls.Add(pFamilia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            Load += frmMenuPrincipal_Load;
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            panel2.ResumeLayout(false);
            pIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pFamilia.ResumeLayout(false);
            PanelSupeior.ResumeLayout(false);
            PanelSupeior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            PanelInfeior.ResumeLayout(false);
            PanelInfeior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel PanelMenu;
        private Label lblFecha;
        private Label lblHora;
        private PictureBox pictureBox1;
        private Button btnVolverLogin;
        private Button btnFamilia;
        private Button btnEgresos;
        private Button btnIngresos;
        private Panel PanelSupeior;
        private PictureBox btnMinimize;
        private PictureBox btnClose;
        private Panel PanelInfeior;
        private Label lblFechaFormulario;
        private Label lblHoraFormulario;
        private PictureBox imgUsuario;
        private Label lblNombreUsuario;
        private Label lblTipoMiembro;
        private System.Windows.Forms.Timer tmHoraFecha;
        private Label lblPbFormularios;
        private CircularProgressBar.CircularProgressBar pbCargarFormularios;
        private System.Windows.Forms.Timer tmFormulario;
        private Panel pFamilia;
        private Button btnRegistrarMiembro;
        private Button btnRegistraUsuario;
        private Panel panel2;
        private Button button3;
        private Button button4;
        private Panel pIngresos;
        private Button btnRegistrarIngresos;
        private Button btnAhorro;
    }
}