namespace ProyectoFamilia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            dtfecha1 = new RJCodeAdvance.RJControls.RJDatePicker();
            dtfecha = new DateTimePicker();
            siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            rjComboBox1 = new RJCodeAdvance.RJControls.RJComboBox();
            btnProductos = new RJCodeAdvance.RJControls.RJButton();
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            PanelTop = new Panel();
            PanelMenu = new Panel();
            btnReport = new RJCodeAdvance.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(173, 112);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 46);
            btnClose.TabIndex = 0;
            btnClose.Text = "button1";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // dtfecha1
            // 
            dtfecha1.BorderColor = Color.PaleVioletRed;
            dtfecha1.BorderSize = 0;
            dtfecha1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtfecha1.Location = new Point(318, 81);
            dtfecha1.MinimumSize = new Size(0, 35);
            dtfecha1.Name = "dtfecha1";
            dtfecha1.Size = new Size(240, 35);
            dtfecha1.SkinColor = Color.MediumSlateBlue;
            dtfecha1.TabIndex = 1;
            dtfecha1.TextColor = Color.White;
            dtfecha1.ValueChanged += dtfecha_ValueChanged;
            // 
            // dtfecha
            // 
            dtfecha.Location = new Point(318, 122);
            dtfecha.Name = "dtfecha";
            dtfecha.Size = new Size(228, 23);
            dtfecha.TabIndex = 2;
            // 
            // siticoneComboBox1
            // 
            siticoneComboBox1.BackColor = Color.Transparent;
            siticoneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            siticoneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            siticoneComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            siticoneComboBox1.ItemHeight = 30;
            siticoneComboBox1.Items.AddRange(new object[] { "Hola", "Mundo", ":v" });
            siticoneComboBox1.Location = new Point(318, 151);
            siticoneComboBox1.Name = "siticoneComboBox1";
            siticoneComboBox1.Size = new Size(212, 36);
            siticoneComboBox1.TabIndex = 4;
            siticoneComboBox1.SelectedIndexChanged += siticoneComboBox1_SelectedIndexChanged;
            // 
            // rjComboBox1
            // 
            rjComboBox1.BackColor = Color.WhiteSmoke;
            rjComboBox1.BorderColor = Color.MediumSlateBlue;
            rjComboBox1.BorderSize = 1;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rjComboBox1.ForeColor = Color.DimGray;
            rjComboBox1.IconColor = Color.MediumSlateBlue;
            rjComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            rjComboBox1.ListTextColor = Color.DimGray;
            rjComboBox1.Location = new Point(318, 193);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.Padding = new Padding(1);
            rjComboBox1.Size = new Size(200, 30);
            rjComboBox1.TabIndex = 5;
            rjComboBox1.Texts = "";
            rjComboBox1.OnSelectedIndexChanged += rjComboBox1_OnSelectedIndexChanged_1;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Black;
            btnProductos.BackgroundColor = Color.Black;
            btnProductos.BorderColor = Color.PaleVioletRed;
            btnProductos.BorderRadius = 0;
            btnProductos.BorderSize = 0;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(12, 170);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(150, 40);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "rjButton1";
            btnProductos.TextColor = Color.White;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // siticoneButton1
            // 
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.White;
            siticoneButton1.Location = new Point(3, 216);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(180, 45);
            siticoneButton1.TabIndex = 7;
            siticoneButton1.Text = "siticoneButton1";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // PanelTop
            // 
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1085, 73);
            PanelTop.TabIndex = 8;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(btnReport);
            PanelMenu.Controls.Add(siticoneButton1);
            PanelMenu.Controls.Add(btnProductos);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 73);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(200, 638);
            PanelMenu.TabIndex = 9;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.MediumSlateBlue;
            btnReport.BackgroundColor = Color.MediumSlateBlue;
            btnReport.BorderColor = Color.PaleVioletRed;
            btnReport.BorderRadius = 0;
            btnReport.BorderSize = 0;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(12, 267);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 40);
            btnReport.TabIndex = 8;
            btnReport.Text = "rjButton1";
            btnReport.TextColor = Color.White;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lg;
            pictureBox1.Location = new Point(230, 451);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 129, 128);
            panel1.Location = new Point(720, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 79);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 254, 254);
            panel2.Location = new Point(799, 340);
            panel2.Name = "panel2";
            panel2.Size = new Size(79, 79);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(53, 224, 254);
            panel3.Location = new Point(878, 339);
            panel3.Name = "panel3";
            panel3.Size = new Size(79, 79);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(78, 214, 202);
            panel4.Location = new Point(799, 418);
            panel4.Name = "panel4";
            panel4.Size = new Size(79, 79);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 255, 205);
            panel5.Location = new Point(878, 418);
            panel5.Name = "panel5";
            panel5.Size = new Size(79, 79);
            panel5.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(1, 156, 184);
            panel6.Location = new Point(720, 418);
            panel6.Name = "panel6";
            panel6.Size = new Size(79, 79);
            panel6.TabIndex = 14;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(174, 255, 255);
            panel7.Location = new Point(799, 497);
            panel7.Name = "panel7";
            panel7.Size = new Size(79, 79);
            panel7.TabIndex = 18;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(37, 189, 177);
            panel8.Location = new Point(878, 497);
            panel8.Name = "panel8";
            panel8.Size = new Size(79, 79);
            panel8.TabIndex = 19;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 124, 150);
            panel9.Location = new Point(720, 497);
            panel9.Name = "panel9";
            panel9.Size = new Size(79, 79);
            panel9.TabIndex = 17;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(174, 255, 255);
            panel10.Location = new Point(530, 399);
            panel10.Name = "panel10";
            panel10.Size = new Size(79, 79);
            panel10.TabIndex = 27;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(37, 189, 177);
            panel11.Location = new Point(609, 400);
            panel11.Name = "panel11";
            panel11.Size = new Size(79, 79);
            panel11.TabIndex = 28;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(0, 124, 150);
            panel12.Location = new Point(451, 399);
            panel12.Name = "panel12";
            panel12.Size = new Size(79, 79);
            panel12.TabIndex = 26;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(78, 214, 202);
            panel13.Location = new Point(530, 321);
            panel13.Name = "panel13";
            panel13.Size = new Size(79, 79);
            panel13.TabIndex = 24;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(0, 254, 254);
            panel14.Location = new Point(530, 243);
            panel14.Name = "panel14";
            panel14.Size = new Size(79, 79);
            panel14.TabIndex = 21;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(1, 255, 205);
            panel15.Location = new Point(609, 321);
            panel15.Name = "panel15";
            panel15.Size = new Size(79, 79);
            panel15.TabIndex = 25;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(53, 224, 254);
            panel16.Location = new Point(609, 243);
            panel16.Name = "panel16";
            panel16.Size = new Size(79, 79);
            panel16.TabIndex = 22;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(1, 156, 184);
            panel17.Location = new Point(451, 322);
            panel17.Name = "panel17";
            panel17.Size = new Size(79, 79);
            panel17.TabIndex = 23;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(26, 129, 128);
            panel18.Location = new Point(451, 243);
            panel18.Name = "panel18";
            panel18.Size = new Size(79, 79);
            panel18.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 711);
            Controls.Add(panel15);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel4);
            Controls.Add(panel14);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel16);
            Controls.Add(panel3);
            Controls.Add(panel17);
            Controls.Add(panel6);
            Controls.Add(panel18);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(PanelMenu);
            Controls.Add(PanelTop);
            Controls.Add(btnClose);
            Controls.Add(rjComboBox1);
            Controls.Add(siticoneComboBox1);
            Controls.Add(dtfecha);
            Controls.Add(dtfecha1);
            Name = "Form1";
            Text = "Form1";
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private RJCodeAdvance.RJControls.RJDatePicker dtfecha1;
        private DateTimePicker dtfecha;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private RJCodeAdvance.RJControls.RJComboBox rjComboBox1;
        private RJCodeAdvance.RJControls.RJButton btnProductos;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Panel PanelTop;
        private Panel PanelMenu;
        private RJCodeAdvance.RJControls.RJButton btnReport;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
    }
}