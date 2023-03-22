namespace ProyectoFamilia.FormsIncon
{
    partial class frmRegistrarIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarIngresos));
            btnRegistrarIngreso = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            cboTipoMoneda = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtMontoIngresos = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            pIngresos = new Panel();
            dtRegistrarIngresos = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnClose = new PictureBox();
            MoverIngresos = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            tmCargarIngresos = new System.Windows.Forms.Timer(components);
            pbIngresos = new RJCodeAdvance.RJControls.RJProgressBar();
            siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarIngreso
            // 
            btnRegistrarIngreso.BorderThickness = 1;
            btnRegistrarIngreso.DisabledState.BorderColor = Color.DarkGray;
            btnRegistrarIngreso.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegistrarIngreso.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegistrarIngreso.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegistrarIngreso.FillColor = Color.White;
            btnRegistrarIngreso.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarIngreso.ForeColor = Color.Black;
            btnRegistrarIngreso.Location = new Point(277, 204);
            btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            btnRegistrarIngreso.Size = new Size(142, 32);
            btnRegistrarIngreso.TabIndex = 0;
            btnRegistrarIngreso.Text = "Registrar";
            btnRegistrarIngreso.Click += btnRegistrarIngreso_Click;
            // 
            // cboTipoMoneda
            // 
            cboTipoMoneda.BackColor = Color.Transparent;
            cboTipoMoneda.BorderColor = Color.Silver;
            cboTipoMoneda.BorderRadius = 5;
            cboTipoMoneda.DrawMode = DrawMode.OwnerDrawFixed;
            cboTipoMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoMoneda.FocusedColor = Color.FromArgb(94, 148, 255);
            cboTipoMoneda.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboTipoMoneda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipoMoneda.ForeColor = Color.FromArgb(68, 88, 112);
            cboTipoMoneda.ItemHeight = 30;
            cboTipoMoneda.Location = new Point(59, 84);
            cboTipoMoneda.Name = "cboTipoMoneda";
            cboTipoMoneda.Size = new Size(200, 36);
            cboTipoMoneda.TabIndex = 1;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(12, 57);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(115, 23);
            siticoneHtmlLabel1.TabIndex = 2;
            siticoneHtmlLabel1.Text = "Tipo de Moneda";
            // 
            // txtMontoIngresos
            // 
            txtMontoIngresos.BorderThickness = 0;
            txtMontoIngresos.DefaultText = "";
            txtMontoIngresos.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMontoIngresos.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMontoIngresos.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMontoIngresos.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMontoIngresos.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMontoIngresos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoIngresos.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMontoIngresos.Location = new Point(60, 158);
            txtMontoIngresos.Margin = new Padding(4, 4, 4, 4);
            txtMontoIngresos.Name = "txtMontoIngresos";
            txtMontoIngresos.PasswordChar = '\0';
            txtMontoIngresos.PlaceholderText = "";
            txtMontoIngresos.SelectedText = "";
            txtMontoIngresos.Size = new Size(199, 38);
            txtMontoIngresos.TabIndex = 3;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(12, 128);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(126, 23);
            siticoneHtmlLabel2.TabIndex = 4;
            siticoneHtmlLabel2.Text = "Monto de Ingreso";
            // 
            // pIngresos
            // 
            pIngresos.BackColor = Color.FromArgb(78, 214, 202);
            pIngresos.Controls.Add(dtRegistrarIngresos);
            pIngresos.Controls.Add(siticoneHtmlLabel3);
            pIngresos.Dock = DockStyle.Top;
            pIngresos.Location = new Point(0, 0);
            pIngresos.Name = "pIngresos";
            pIngresos.Size = new Size(431, 42);
            pIngresos.TabIndex = 5;
            // 
            // dtRegistrarIngresos
            // 
            dtRegistrarIngresos.Checked = true;
            dtRegistrarIngresos.FillColor = Color.FromArgb(224, 224, 224);
            dtRegistrarIngresos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtRegistrarIngresos.Format = DateTimePickerFormat.Long;
            dtRegistrarIngresos.Location = new Point(228, 3);
            dtRegistrarIngresos.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtRegistrarIngresos.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtRegistrarIngresos.Name = "dtRegistrarIngresos";
            dtRegistrarIngresos.Size = new Size(200, 36);
            dtRegistrarIngresos.TabIndex = 8;
            dtRegistrarIngresos.Value = new DateTime(2023, 3, 20, 18, 20, 16, 29);
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(6, 9);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(162, 23);
            siticoneHtmlLabel3.TabIndex = 7;
            siticoneHtmlLabel3.Text = "REGISTRAR INGRESOS";
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(402, 46);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 6;
            btnClose.TabStop = false;
            // 
            // MoverIngresos
            // 
            MoverIngresos.DockIndicatorTransparencyValue = 0.6D;
            MoverIngresos.TargetControl = pIngresos;
            MoverIngresos.UseTransparentDrag = true;
            // 
            // tmCargarIngresos
            // 
            tmCargarIngresos.Tick += tmCargarIngresos_Tick;
            // 
            // pbIngresos
            // 
            pbIngresos.ChannelColor = Color.PaleTurquoise;
            pbIngresos.ChannelHeight = 6;
            pbIngresos.ForeBackColor = Color.DeepSkyBlue;
            pbIngresos.ForeColor = Color.White;
            pbIngresos.Location = new Point(12, 216);
            pbIngresos.Name = "pbIngresos";
            pbIngresos.ShowMaximun = false;
            pbIngresos.ShowValue = RJCodeAdvance.RJControls.TextPosition.Center;
            pbIngresos.Size = new Size(247, 20);
            pbIngresos.SliderColor = Color.FromArgb(0, 124, 150);
            pbIngresos.SliderHeight = 6;
            pbIngresos.SymbolAfter = "";
            pbIngresos.SymbolBefore = "";
            pbIngresos.TabIndex = 9;
            // 
            // siticoneSeparator1
            // 
            siticoneSeparator1.FillColor = Color.Black;
            siticoneSeparator1.Location = new Point(59, 186);
            siticoneSeparator1.Name = "siticoneSeparator1";
            siticoneSeparator1.Size = new Size(200, 10);
            siticoneSeparator1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // frmRegistrarIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 254);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(siticoneSeparator1);
            Controls.Add(pbIngresos);
            Controls.Add(btnClose);
            Controls.Add(pIngresos);
            Controls.Add(siticoneHtmlLabel2);
            Controls.Add(txtMontoIngresos);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(cboTipoMoneda);
            Controls.Add(btnRegistrarIngreso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistrarIngresos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistrarIngresos";
            Load += frmRegistrarIngresos_Load;
            pIngresos.ResumeLayout(false);
            pIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRegistrarIngreso;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboTipoMoneda;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMontoIngresos;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Panel pIngresos;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtRegistrarIngresos;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private PictureBox btnClose;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl MoverIngresos;
        private System.Windows.Forms.Timer tmCargarIngresos;
        private RJCodeAdvance.RJControls.RJProgressBar pbIngresos;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}