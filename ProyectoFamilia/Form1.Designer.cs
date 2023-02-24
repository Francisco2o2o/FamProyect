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
            this.btnClose = new System.Windows.Forms.Button();
            this.dtfecha1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.rjComboBox1 = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnProductos = new RJCodeAdvance.RJControls.RJButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnReport = new RJCodeAdvance.RJControls.RJButton();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(614, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtfecha1
            // 
            this.dtfecha1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtfecha1.BorderSize = 0;
            this.dtfecha1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtfecha1.Location = new System.Drawing.Point(318, 81);
            this.dtfecha1.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtfecha1.Name = "dtfecha1";
            this.dtfecha1.Size = new System.Drawing.Size(240, 35);
            this.dtfecha1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtfecha1.TabIndex = 1;
            this.dtfecha1.TextColor = System.Drawing.Color.White;
            this.dtfecha1.ValueChanged += new System.EventHandler(this.dtfecha_ValueChanged);
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(318, 122);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(228, 23);
            this.dtfecha.TabIndex = 2;
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox1.ItemHeight = 30;
            this.siticoneComboBox1.Items.AddRange(new object[] {
            "Hola",
            "Mundo",
            ":v"});
            this.siticoneComboBox1.Location = new System.Drawing.Point(318, 151);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.Size = new System.Drawing.Size(212, 36);
            this.siticoneComboBox1.TabIndex = 4;
            this.siticoneComboBox1.SelectedIndexChanged += new System.EventHandler(this.siticoneComboBox1_SelectedIndexChanged);
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(318, 193);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 5;
            this.rjComboBox1.Texts = "";
            this.rjComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox1_OnSelectedIndexChanged_1);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Black;
            this.btnProductos.BackgroundColor = System.Drawing.Color.Black;
            this.btnProductos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProductos.BorderRadius = 0;
            this.btnProductos.BorderSize = 0;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(12, 170);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(150, 40);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "rjButton1";
            this.btnProductos.TextColor = System.Drawing.Color.White;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(3, 216);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 7;
            this.siticoneButton1.Text = "siticoneButton1";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 73);
            this.PanelTop.TabIndex = 8;
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.btnReport);
            this.PanelMenu.Controls.Add(this.siticoneButton1);
            this.PanelMenu.Controls.Add(this.btnProductos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 73);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 377);
            this.PanelMenu.TabIndex = 9;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReport.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReport.BorderRadius = 0;
            this.btnReport.BorderSize = 0;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(12, 267);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(150, 40);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "rjButton1";
            this.btnReport.TextColor = System.Drawing.Color.White;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rjComboBox1);
            this.Controls.Add(this.siticoneComboBox1);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.dtfecha1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}