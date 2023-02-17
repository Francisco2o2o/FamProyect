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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.PanelMenu = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.lblPbFormularios = new System.Windows.Forms.Label();
            this.pbCargarFormularios = new CircularProgressBar.CircularProgressBar();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolverLogin = new System.Windows.Forms.Button();
            this.btnAgregarMiembro = new System.Windows.Forms.Button();
            this.btnEgresos = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.PanelSupeior = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.PanelInfeior = new System.Windows.Forms.Panel();
            this.lblFechaFormulario = new System.Windows.Forms.Label();
            this.lblHoraFormulario = new System.Windows.Forms.Label();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblTipoMiembro = new System.Windows.Forms.Label();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.btnCerrarFormularios = new System.Windows.Forms.PictureBox();
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.tmFormulario = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSupeior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.PanelInfeior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.PanelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormularios)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelMenu.BorderThickness = 5;
            this.PanelMenu.Controls.Add(this.lblPbFormularios);
            this.PanelMenu.Controls.Add(this.pbCargarFormularios);
            this.PanelMenu.Controls.Add(this.lblFecha);
            this.PanelMenu.Controls.Add(this.lblHora);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Controls.Add(this.btnVolverLogin);
            this.PanelMenu.Controls.Add(this.btnAgregarMiembro);
            this.PanelMenu.Controls.Add(this.btnEgresos);
            this.PanelMenu.Controls.Add(this.btnIngresos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(254, 695);
            this.PanelMenu.TabIndex = 0;
            // 
            // lblPbFormularios
            // 
            this.lblPbFormularios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPbFormularios.Location = new System.Drawing.Point(108, 499);
            this.lblPbFormularios.Name = "lblPbFormularios";
            this.lblPbFormularios.Size = new System.Drawing.Size(50, 16);
            this.lblPbFormularios.TabIndex = 7;
            // 
            // pbCargarFormularios
            // 
            this.pbCargarFormularios.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbCargarFormularios.AnimationSpeed = 500;
            this.pbCargarFormularios.BackColor = System.Drawing.Color.White;
            this.pbCargarFormularios.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pbCargarFormularios.ForeColor = System.Drawing.Color.White;
            this.pbCargarFormularios.InnerColor = System.Drawing.Color.Transparent;
            this.pbCargarFormularios.InnerMargin = 2;
            this.pbCargarFormularios.InnerWidth = -1;
            this.pbCargarFormularios.Location = new System.Drawing.Point(81, 453);
            this.pbCargarFormularios.MarqueeAnimationSpeed = 2000;
            this.pbCargarFormularios.Name = "pbCargarFormularios";
            this.pbCargarFormularios.OuterColor = System.Drawing.Color.LightGray;
            this.pbCargarFormularios.OuterMargin = -25;
            this.pbCargarFormularios.OuterWidth = 25;
            this.pbCargarFormularios.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbCargarFormularios.ProgressWidth = 10;
            this.pbCargarFormularios.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pbCargarFormularios.Size = new System.Drawing.Size(100, 100);
            this.pbCargarFormularios.StartAngle = 270;
            this.pbCargarFormularios.SubscriptColor = System.Drawing.Color.Transparent;
            this.pbCargarFormularios.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbCargarFormularios.SubscriptText = ".23";
            this.pbCargarFormularios.SuperscriptColor = System.Drawing.Color.White;
            this.pbCargarFormularios.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbCargarFormularios.SuperscriptText = "°C";
            this.pbCargarFormularios.TabIndex = 1;
            this.pbCargarFormularios.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbCargarFormularios.Value = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(12, 627);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 20);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(101, 591);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 25);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFamilia.Properties.Resources.lg;
            this.pictureBox1.Location = new System.Drawing.Point(22, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolverLogin
            // 
            this.btnVolverLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVolverLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(128)))));
            this.btnVolverLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolverLogin.FlatAppearance.BorderSize = 2;
            this.btnVolverLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolverLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnVolverLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolverLogin.ForeColor = System.Drawing.Color.White;
            this.btnVolverLogin.Location = new System.Drawing.Point(3, 658);
            this.btnVolverLogin.Name = "btnVolverLogin";
            this.btnVolverLogin.Size = new System.Drawing.Size(248, 34);
            this.btnVolverLogin.TabIndex = 3;
            this.btnVolverLogin.Text = "Cerrar Sistema";
            this.btnVolverLogin.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMiembro
            // 
            this.btnAgregarMiembro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregarMiembro.FlatAppearance.BorderSize = 2;
            this.btnAgregarMiembro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMiembro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarMiembro.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMiembro.Image")));
            this.btnAgregarMiembro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMiembro.Location = new System.Drawing.Point(3, 381);
            this.btnAgregarMiembro.Name = "btnAgregarMiembro";
            this.btnAgregarMiembro.Size = new System.Drawing.Size(248, 48);
            this.btnAgregarMiembro.TabIndex = 2;
            this.btnAgregarMiembro.Text = "USUARIOS";
            this.btnAgregarMiembro.UseVisualStyleBackColor = true;
            // 
            // btnEgresos
            // 
            this.btnEgresos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEgresos.FlatAppearance.BorderSize = 2;
            this.btnEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgresos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEgresos.Image = ((System.Drawing.Image)(resources.GetObject("btnEgresos.Image")));
            this.btnEgresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEgresos.Location = new System.Drawing.Point(3, 327);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Size = new System.Drawing.Size(248, 48);
            this.btnEgresos.TabIndex = 1;
            this.btnEgresos.Text = "EGRESOS";
            this.btnEgresos.UseVisualStyleBackColor = true;
            // 
            // btnIngresos
            // 
            this.btnIngresos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIngresos.FlatAppearance.BorderSize = 2;
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresos.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresos.Image")));
            this.btnIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.Location = new System.Drawing.Point(3, 274);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(248, 48);
            this.btnIngresos.TabIndex = 0;
            this.btnIngresos.Text = "INGRESOS";
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // PanelSupeior
            // 
            this.PanelSupeior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            this.PanelSupeior.Controls.Add(this.btnMinimize);
            this.PanelSupeior.Controls.Add(this.btnClose);
            this.PanelSupeior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSupeior.Location = new System.Drawing.Point(254, 0);
            this.PanelSupeior.Name = "PanelSupeior";
            this.PanelSupeior.Size = new System.Drawing.Size(950, 39);
            this.PanelSupeior.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(893, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(919, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PanelInfeior
            // 
            this.PanelInfeior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(189)))), ((int)(((byte)(177)))));
            this.PanelInfeior.Controls.Add(this.lblFechaFormulario);
            this.PanelInfeior.Controls.Add(this.lblHoraFormulario);
            this.PanelInfeior.Controls.Add(this.imgUsuario);
            this.PanelInfeior.Controls.Add(this.lblNombreUsuario);
            this.PanelInfeior.Controls.Add(this.lblTipoMiembro);
            this.PanelInfeior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInfeior.Location = new System.Drawing.Point(254, 606);
            this.PanelInfeior.Name = "PanelInfeior";
            this.PanelInfeior.Size = new System.Drawing.Size(950, 89);
            this.PanelInfeior.TabIndex = 2;
            // 
            // lblFechaFormulario
            // 
            this.lblFechaFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFormulario.AutoSize = true;
            this.lblFechaFormulario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaFormulario.ForeColor = System.Drawing.Color.White;
            this.lblFechaFormulario.Location = new System.Drawing.Point(711, 59);
            this.lblFechaFormulario.Name = "lblFechaFormulario";
            this.lblFechaFormulario.Size = new System.Drawing.Size(55, 20);
            this.lblFechaFormulario.TabIndex = 8;
            this.lblFechaFormulario.Text = "Fecha";
            // 
            // lblHoraFormulario
            // 
            this.lblHoraFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraFormulario.AutoSize = true;
            this.lblHoraFormulario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoraFormulario.ForeColor = System.Drawing.Color.White;
            this.lblHoraFormulario.Location = new System.Drawing.Point(805, 21);
            this.lblHoraFormulario.Name = "lblHoraFormulario";
            this.lblHoraFormulario.Size = new System.Drawing.Size(60, 25);
            this.lblHoraFormulario.TabIndex = 7;
            this.lblHoraFormulario.Text = "Hora";
            // 
            // imgUsuario
            // 
            this.imgUsuario.Location = new System.Drawing.Point(11, 9);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(79, 70);
            this.imgUsuario.TabIndex = 0;
            this.imgUsuario.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(105, 12);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(122, 20);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "NombreUsuario";
            // 
            // lblTipoMiembro
            // 
            this.lblTipoMiembro.AutoSize = true;
            this.lblTipoMiembro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoMiembro.ForeColor = System.Drawing.Color.White;
            this.lblTipoMiembro.Location = new System.Drawing.Point(105, 37);
            this.lblTipoMiembro.Name = "lblTipoMiembro";
            this.lblTipoMiembro.Size = new System.Drawing.Size(103, 20);
            this.lblTipoMiembro.TabIndex = 0;
            this.lblTipoMiembro.Text = "TipoMiembro";
            // 
            // PanelCentral
            // 
            this.PanelCentral.Controls.Add(this.btnCerrarFormularios);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(254, 39);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(950, 567);
            this.PanelCentral.TabIndex = 3;
            // 
            // btnCerrarFormularios
            // 
            this.btnCerrarFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarFormularios.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarFormularios.Image")));
            this.btnCerrarFormularios.Location = new System.Drawing.Point(907, 6);
            this.btnCerrarFormularios.Name = "btnCerrarFormularios";
            this.btnCerrarFormularios.Size = new System.Drawing.Size(32, 32);
            this.btnCerrarFormularios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrarFormularios.TabIndex = 0;
            this.btnCerrarFormularios.TabStop = false;
            this.btnCerrarFormularios.Click += new System.EventHandler(this.btnCerrarFormularios_Click);
            // 
            // tmHoraFecha
            // 
            this.tmHoraFecha.Enabled = true;
            this.tmHoraFecha.Tick += new System.EventHandler(this.tmHoraFecha_Tick);
            // 
            // tmFormulario
            // 
            this.tmFormulario.Tick += new System.EventHandler(this.tmFormulario_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 695);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelInfeior);
            this.Controls.Add(this.PanelSupeior);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSupeior.ResumeLayout(false);
            this.PanelSupeior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.PanelInfeior.ResumeLayout(false);
            this.PanelInfeior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.PanelCentral.ResumeLayout(false);
            this.PanelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormularios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel PanelMenu;
        private Label lblFecha;
        private Label lblHora;
        private PictureBox pictureBox1;
        private Button btnVolverLogin;
        private Button btnAgregarMiembro;
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
        private Panel PanelCentral;
        private PictureBox btnCerrarFormularios;
        private System.Windows.Forms.Timer tmHoraFecha;
        private Label lblPbFormularios;
        private CircularProgressBar.CircularProgressBar pbCargarFormularios;
        private System.Windows.Forms.Timer tmFormulario;
    }
}