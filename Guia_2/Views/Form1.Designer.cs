namespace Guia_2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.txbDiasLaborados = new System.Windows.Forms.TextBox();
            this.txbSalarioDiario = new System.Windows.Forms.TextBox();
            this.txbIdentificacion = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblDiaslaborados = new System.Windows.Forms.Label();
            this.lblAsignacion = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.lblDevengado = new System.Windows.Forms.Label();
            this.txbTotalDevengado = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(415, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calculo de salario de trabajadores";
            // 
            // grpEmpleado
            // 
            this.grpEmpleado.Controls.Add(this.btnGuardarEmpleado);
            this.grpEmpleado.Controls.Add(this.txbDiasLaborados);
            this.grpEmpleado.Controls.Add(this.txbSalarioDiario);
            this.grpEmpleado.Controls.Add(this.txbIdentificacion);
            this.grpEmpleado.Controls.Add(this.txbNombre);
            this.grpEmpleado.Controls.Add(this.lblDiaslaborados);
            this.grpEmpleado.Controls.Add(this.lblAsignacion);
            this.grpEmpleado.Controls.Add(this.lblIdentificacion);
            this.grpEmpleado.Controls.Add(this.lblNombre);
            this.grpEmpleado.Location = new System.Drawing.Point(12, 77);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Size = new System.Drawing.Size(529, 225);
            this.grpEmpleado.TabIndex = 1;
            this.grpEmpleado.TabStop = false;
            this.grpEmpleado.Text = "Empleado";
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(363, 101);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(151, 52);
            this.btnGuardarEmpleado.TabIndex = 8;
            this.btnGuardarEmpleado.Text = "Guardar el registro de empleado";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // txbDiasLaborados
            // 
            this.txbDiasLaborados.Location = new System.Drawing.Point(211, 174);
            this.txbDiasLaborados.Name = "txbDiasLaborados";
            this.txbDiasLaborados.Size = new System.Drawing.Size(137, 22);
            this.txbDiasLaborados.TabIndex = 7;
            // 
            // txbSalarioDiario
            // 
            this.txbSalarioDiario.Location = new System.Drawing.Point(211, 135);
            this.txbSalarioDiario.Name = "txbSalarioDiario";
            this.txbSalarioDiario.Size = new System.Drawing.Size(137, 22);
            this.txbSalarioDiario.TabIndex = 6;
            // 
            // txbIdentificacion
            // 
            this.txbIdentificacion.Location = new System.Drawing.Point(211, 96);
            this.txbIdentificacion.Name = "txbIdentificacion";
            this.txbIdentificacion.Size = new System.Drawing.Size(137, 22);
            this.txbIdentificacion.TabIndex = 5;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(211, 57);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(137, 22);
            this.txbNombre.TabIndex = 4;
            // 
            // lblDiaslaborados
            // 
            this.lblDiaslaborados.AutoSize = true;
            this.lblDiaslaborados.Location = new System.Drawing.Point(37, 177);
            this.lblDiaslaborados.Name = "lblDiaslaborados";
            this.lblDiaslaborados.Size = new System.Drawing.Size(100, 16);
            this.lblDiaslaborados.TabIndex = 3;
            this.lblDiaslaborados.Text = "Dias laborados";
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Location = new System.Drawing.Point(37, 137);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(155, 16);
            this.lblAsignacion.TabIndex = 2;
            this.lblAsignacion.Text = "Asignación salario diario";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(37, 97);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(85, 16);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(223, 314);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(137, 40);
            this.btnCalcularSalario.TabIndex = 2;
            this.btnCalcularSalario.Text = "Calcular salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // lblDevengado
            // 
            this.lblDevengado.AutoSize = true;
            this.lblDevengado.Location = new System.Drawing.Point(55, 372);
            this.lblDevengado.Name = "lblDevengado";
            this.lblDevengado.Size = new System.Drawing.Size(140, 16);
            this.lblDevengado.TabIndex = 3;
            this.lblDevengado.Text = "Valor total devengado";
            // 
            // txbTotalDevengado
            // 
            this.txbTotalDevengado.Location = new System.Drawing.Point(223, 372);
            this.txbTotalDevengado.Name = "txbTotalDevengado";
            this.txbTotalDevengado.Size = new System.Drawing.Size(137, 22);
            this.txbTotalDevengado.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(379, 413);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(463, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txbTotalDevengado);
            this.Controls.Add(this.lblDevengado);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.grpEmpleado);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpEmpleado.ResumeLayout(false);
            this.grpEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpEmpleado;
        private System.Windows.Forms.Label lblDiaslaborados;
        private System.Windows.Forms.Label lblAsignacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbDiasLaborados;
        private System.Windows.Forms.TextBox txbSalarioDiario;
        private System.Windows.Forms.TextBox txbIdentificacion;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label lblDevengado;
        private System.Windows.Forms.TextBox txbTotalDevengado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
    }
}

