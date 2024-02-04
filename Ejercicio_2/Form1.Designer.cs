namespace Ejercicio_2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbClienteData = new System.Windows.Forms.GroupBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tbxMontoDisponible = new System.Windows.Forms.TextBox();
            this.lblMontoDisponible = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.tbxNumeroCuenta = new System.Windows.Forms.MaskedTextBox();
            this.tbxDui = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnIngresarDinero = new System.Windows.Forms.Button();
            this.btnRetiroDinero = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.tbxNit = new System.Windows.Forms.MaskedTextBox();
            this.tbxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.tbxSucursal = new System.Windows.Forms.ComboBox();
            this.grbClienteData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(330, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Banco Alexis";
            // 
            // grbClienteData
            // 
            this.grbClienteData.Controls.Add(this.tbxSucursal);
            this.grbClienteData.Controls.Add(this.tbxTipoCuenta);
            this.grbClienteData.Controls.Add(this.tbxNit);
            this.grbClienteData.Controls.Add(this.lblSucursal);
            this.grbClienteData.Controls.Add(this.tbxMontoDisponible);
            this.grbClienteData.Controls.Add(this.lblMontoDisponible);
            this.grbClienteData.Controls.Add(this.lblNit);
            this.grbClienteData.Controls.Add(this.lblTipoCuenta);
            this.grbClienteData.Controls.Add(this.tbxNumeroCuenta);
            this.grbClienteData.Controls.Add(this.tbxDui);
            this.grbClienteData.Controls.Add(this.lblNumeroCuenta);
            this.grbClienteData.Controls.Add(this.tbxApellido);
            this.grbClienteData.Controls.Add(this.lblApellido);
            this.grbClienteData.Controls.Add(this.tbxNombre);
            this.grbClienteData.Controls.Add(this.lblNombre);
            this.grbClienteData.Controls.Add(this.lblDui);
            this.grbClienteData.Location = new System.Drawing.Point(23, 77);
            this.grbClienteData.Name = "grbClienteData";
            this.grbClienteData.Size = new System.Drawing.Size(470, 589);
            this.grbClienteData.TabIndex = 1;
            this.grbClienteData.TabStop = false;
            this.grbClienteData.Text = "Cliente";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(40, 520);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(59, 16);
            this.lblSucursal.TabIndex = 16;
            this.lblSucursal.Text = "Sucursal";
            // 
            // tbxMontoDisponible
            // 
            this.tbxMontoDisponible.Location = new System.Drawing.Point(231, 450);
            this.tbxMontoDisponible.Name = "tbxMontoDisponible";
            this.tbxMontoDisponible.Size = new System.Drawing.Size(191, 22);
            this.tbxMontoDisponible.TabIndex = 7;
            // 
            // lblMontoDisponible
            // 
            this.lblMontoDisponible.AutoSize = true;
            this.lblMontoDisponible.Location = new System.Drawing.Point(40, 453);
            this.lblMontoDisponible.Name = "lblMontoDisponible";
            this.lblMontoDisponible.Size = new System.Drawing.Size(112, 16);
            this.lblMontoDisponible.TabIndex = 14;
            this.lblMontoDisponible.Text = "Monto Disponible";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(40, 319);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(29, 16);
            this.lblNit.TabIndex = 12;
            this.lblNit.Text = "NIT";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(40, 252);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(97, 16);
            this.lblTipoCuenta.TabIndex = 10;
            this.lblTipoCuenta.Text = "Tipo de cuenta";
            // 
            // tbxNumeroCuenta
            // 
            this.tbxNumeroCuenta.Location = new System.Drawing.Point(231, 383);
            this.tbxNumeroCuenta.Mask = "AA-00000";
            this.tbxNumeroCuenta.Name = "tbxNumeroCuenta";
            this.tbxNumeroCuenta.Size = new System.Drawing.Size(191, 22);
            this.tbxNumeroCuenta.TabIndex = 6;
            // 
            // tbxDui
            // 
            this.tbxDui.Location = new System.Drawing.Point(231, 48);
            this.tbxDui.Mask = "00000000-0";
            this.tbxDui.Name = "tbxDui";
            this.tbxDui.Size = new System.Drawing.Size(191, 22);
            this.tbxDui.TabIndex = 1;
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Location = new System.Drawing.Point(40, 386);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(117, 16);
            this.lblNumeroCuenta.TabIndex = 6;
            this.lblNumeroCuenta.Text = "Número de cuenta";
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(231, 182);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(191, 22);
            this.tbxApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(40, 185);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(231, 115);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(191, 22);
            this.tbxNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(40, 51);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(30, 16);
            this.lblDui.TabIndex = 0;
            this.lblDui.Text = "DUI";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(547, 138);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(125, 45);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnIngresarDinero
            // 
            this.btnIngresarDinero.Location = new System.Drawing.Point(547, 248);
            this.btnIngresarDinero.Name = "btnIngresarDinero";
            this.btnIngresarDinero.Size = new System.Drawing.Size(125, 45);
            this.btnIngresarDinero.TabIndex = 10;
            this.btnIngresarDinero.Text = "Nuevo Ingreso";
            this.btnIngresarDinero.UseVisualStyleBackColor = true;
            this.btnIngresarDinero.Click += new System.EventHandler(this.btnIngresarDinero_Click);
            // 
            // btnRetiroDinero
            // 
            this.btnRetiroDinero.Location = new System.Drawing.Point(547, 365);
            this.btnRetiroDinero.Name = "btnRetiroDinero";
            this.btnRetiroDinero.Size = new System.Drawing.Size(125, 45);
            this.btnRetiroDinero.TabIndex = 11;
            this.btnRetiroDinero.Text = "Nuevo Retiro";
            this.btnRetiroDinero.UseVisualStyleBackColor = true;
            this.btnRetiroDinero.Click += new System.EventHandler(this.btnRetiroDinero_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(547, 473);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(125, 45);
            this.btnEliminarCliente.TabIndex = 12;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // tbxNit
            // 
            this.tbxNit.Location = new System.Drawing.Point(231, 313);
            this.tbxNit.Mask = "00000000-0";
            this.tbxNit.Name = "tbxNit";
            this.tbxNit.Size = new System.Drawing.Size(191, 22);
            this.tbxNit.TabIndex = 17;
            // 
            // tbxTipoCuenta
            // 
            this.tbxTipoCuenta.FormattingEnabled = true;
            this.tbxTipoCuenta.Location = new System.Drawing.Point(231, 248);
            this.tbxTipoCuenta.Name = "tbxTipoCuenta";
            this.tbxTipoCuenta.Size = new System.Drawing.Size(191, 24);
            this.tbxTipoCuenta.TabIndex = 4;
            // 
            // tbxSucursal
            // 
            this.tbxSucursal.FormattingEnabled = true;
            this.tbxSucursal.Location = new System.Drawing.Point(231, 516);
            this.tbxSucursal.Name = "tbxSucursal";
            this.tbxSucursal.Size = new System.Drawing.Size(191, 24);
            this.tbxSucursal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 691);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnRetiroDinero);
            this.Controls.Add(this.btnIngresarDinero);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.grbClienteData);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio_2";
            this.grbClienteData.ResumeLayout(false);
            this.grbClienteData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbClienteData;
        private System.Windows.Forms.MaskedTextBox tbxNumeroCuenta;
        private System.Windows.Forms.MaskedTextBox tbxDui;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblMontoDisponible;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnIngresarDinero;
        private System.Windows.Forms.Button btnRetiroDinero;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.TextBox tbxMontoDisponible;
        private System.Windows.Forms.MaskedTextBox tbxNit;
        private System.Windows.Forms.ComboBox tbxTipoCuenta;
        private System.Windows.Forms.ComboBox tbxSucursal;
    }
}

