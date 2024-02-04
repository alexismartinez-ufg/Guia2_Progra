namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncender = new System.Windows.Forms.Button();
            this.bntApagar = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(93, 40);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(104, 42);
            this.btnEncender.TabIndex = 0;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // bntApagar
            // 
            this.bntApagar.Location = new System.Drawing.Point(93, 126);
            this.bntApagar.Name = "bntApagar";
            this.bntApagar.Size = new System.Drawing.Size(104, 42);
            this.bntApagar.TabIndex = 1;
            this.bntApagar.Text = "Apagar";
            this.bntApagar.UseVisualStyleBackColor = true;
            this.bntApagar.Click += new System.EventHandler(this.bntApagar_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(93, 212);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(104, 42);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Location = new System.Drawing.Point(93, 298);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(104, 42);
            this.btnEnviarMensaje.TabIndex = 3;
            this.btnEnviarMensaje.Text = "Enviar Mensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificacion.AutoEllipsis = true;
            this.lblNotificacion.Location = new System.Drawing.Point(12, 372);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(276, 95);
            this.lblNotificacion.TabIndex = 4;
            this.lblNotificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 476);
            this.Controls.Add(this.lblNotificacion);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.bntApagar);
            this.Controls.Add(this.btnEncender);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button bntApagar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnEnviarMensaje;
        public System.Windows.Forms.Label lblNotificacion;
    }
}

