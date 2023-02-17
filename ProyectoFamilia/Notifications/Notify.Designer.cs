namespace ProyectoFamilia.Notifications
{
    partial class Notify
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
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.ShowNotificacion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcono
            // 
            this.picIcono.Image = global::ProyectoFamilia.Properties.Resources.NotifySuccess;
            this.picIcono.Location = new System.Drawing.Point(12, 13);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(47, 49);
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Image = global::ProyectoFamilia.Properties.Resources.NotifyClose;
            this.picClose.Location = new System.Drawing.Point(298, 22);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(26, 30);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(65, 22);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(57, 21);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "label1";
            // 
            // ShowNotificacion
            // 
            this.ShowNotificacion.Tick += new System.EventHandler(this.ShowNotificacion_Tick);
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(347, 74);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picIcono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notify";
            this.Text = "Notify";
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picIcono;
        private PictureBox picClose;
        private Label lblMensaje;
        private System.Windows.Forms.Timer ShowNotificacion;
    }
}