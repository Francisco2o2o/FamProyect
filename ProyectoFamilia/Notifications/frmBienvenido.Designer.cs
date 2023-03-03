namespace ProyectoFamilia.Notifications
{
    partial class frmBienvenido
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
            pBienvenido = new RJCodeAdvance.RJControls.RJProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblBienvenido = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SuspendLayout();
            // 
            // pBienvenido
            // 
            pBienvenido.ChannelColor = Color.LightSteelBlue;
            pBienvenido.ChannelHeight = 20;
            pBienvenido.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pBienvenido.ForeBackColor = Color.RoyalBlue;
            pBienvenido.ForeColor = Color.White;
            pBienvenido.Location = new Point(12, 50);
            pBienvenido.Name = "pBienvenido";
            pBienvenido.ShowMaximun = false;
            pBienvenido.ShowValue = RJCodeAdvance.RJControls.TextPosition.Right;
            pBienvenido.Size = new Size(444, 23);
            pBienvenido.SliderColor = Color.DodgerBlue;
            pBienvenido.SliderHeight = 10;
            pBienvenido.SymbolAfter = "";
            pBienvenido.SymbolBefore = "";
            pBienvenido.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblBienvenido
            // 
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(12, 21);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(66, 23);
            lblBienvenido.TabIndex = 1;
            lblBienvenido.Text = "Nombre";
            // 
            // frmBienvenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 83);
            Controls.Add(lblBienvenido);
            Controls.Add(pBienvenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBienvenido";
            Text = "frmBienvenido";
            Load += frmBienvenido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJCodeAdvance.RJControls.RJProgressBar pBienvenido;
        private System.Windows.Forms.Timer timer1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblBienvenido;
    }
}