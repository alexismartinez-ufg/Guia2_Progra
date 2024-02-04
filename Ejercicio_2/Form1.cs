using Ejercicio_2.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Cliente currentClient;

        public Form1()
        {
            InitializeComponent();
            SetTiposCuentas();
            SetSucursales();
        }   
        
        /// <summary>
        /// Setea las opciones disponibles de tipos de cuenta
        /// </summary>
        private void SetTiposCuentas()
        {
            tbxTipoCuenta.Items.AddRange(new string[] { "Corriente", "De Ahorros", "A Plazos" });
        }
        
        /// <summary>
        /// Setea las sucursales disponibles
        /// </summary>
        private void SetSucursales()
        {
            tbxSucursal.Items.AddRange(new string[] { "Antiguo Cuscatlan", "San Salvador", "Santa Tecla", "Soyapango", "Mejicanos" });
        }

        /// <summary>
        /// Obtiene del formulario 1 la informacion de los textbox
        /// </summary>
        /// <returns>Retorna la entidad del cliente para poder ser validada y manipulada</returns>
        private Cliente GetFormClientData()
        {
            if (!string.IsNullOrEmpty(tbxMontoDisponible.Text) && decimal.TryParse(tbxMontoDisponible.Text, out decimal montoDisponible))
                return new Cliente(tbxDui.Text, tbxNombre.Text, tbxApellido.Text, tbxTipoCuenta.Text, tbxNit.Text, tbxNumeroCuenta.Text, montoDisponible, tbxSucursal.Text);
            else
                return null;
        }

        /// <summary>
        /// La información actualizada de la entidad Cliente 
        /// es mostrada en los textbox del formulario 1
        /// </summary>
        private void ShowCurrentClientData()
        {
            tbxDui.Text = currentClient.DUI;
            tbxNombre.Text = currentClient.Nombre;
            tbxApellido.Text = currentClient.Apellidos;
            tbxTipoCuenta.Text = currentClient.TipoCuenta;
            tbxNit.Text = currentClient.NIT;
            tbxNumeroCuenta.Text = currentClient.NumeroCuenta;
            tbxMontoDisponible.Text = currentClient.MontoDisponible.ToString();
            tbxSucursal.Text = currentClient.Sucursal;
        }

        /// <summary>
        /// Permite habilitad/deshabilitar todos los textbox 
        /// del formulario 1, es reutilizable
        /// </summary>
        /// <param name="enable">indica si se van a habilitar o no los textbox</param>
        private void EnableClientForm(bool enable)
        {
            tbxDui.Enabled = 
            tbxNombre.Enabled = 
            tbxApellido.Enabled = 
            tbxTipoCuenta.Enabled = 
            tbxNit.Enabled = 
            tbxNumeroCuenta.Enabled = 
            tbxMontoDisponible.Enabled = 
            tbxSucursal.Enabled = enable;
        }

        /// <summary>
        /// limpia todos los inputs del tiron
        /// </summary>
        private void ClearClientForm()
        {
            tbxDui.Text = 
            tbxNombre.Text = 
            tbxApellido.Text = 
            tbxTipoCuenta.Text = 
            tbxNit.Text = 
            tbxNumeroCuenta.Text = 
            tbxMontoDisponible.Text = 
            tbxSucursal.Text = "";
        }

        /// <summary>
        /// Valida si el cliente existe o esta seteado
        /// este metodo es super reutilizable y evita repetir
        /// codigo como el messagebox, que sueño tengo
        /// </summary>
        /// <returns>retorna si existe o esta seteado</returns>
        private bool ValidateIfClientExist()
        {
            var exist = currentClient != null;

            if (!exist)
                MessageBox.Show("No hay ningun cliente agregado.");

            return exist;
        }

        /// <summary>
        /// Esto lo use y explique en el ejercicio 1 :)
        /// 
        /// de hecho lo pude reutilizar desde el proyecto
        /// del ejercicio 1, bueno hoy ya estuvo, así se va.
        /// </summary>
        /// <param name="text">ejercicio 1 :))</param>
        /// <returns></returns>
        private string MostrarInputBox(string text)
        {
            using (var inputForm = new InputForm(text))
            {
                return inputForm.ShowDialog() == DialogResult.OK ? inputForm.UserInput : "";
            }
        }

        // AQUI ESTA TODA LA LOGICA DE LOS EVENTOS
        // CREO QUE EL CODIGO ES LO SUFICIENTE LIMPIO
        // COMO PARA DOCUMENTAR SU FUNCIONAMIENTO
        // SI CREE LO CONTRARIO HAGAMELO SABER :D


        private void btnEliminarCliente_Click(object s, EventArgs e)
        {
            if (!ValidateIfClientExist())
                return;

            ClearClientForm();
            EnableClientForm(true);
            currentClient = null;

            MessageBox.Show("Cliente eliminado exitosamente.");
        }

        private void btnAgregarCliente_Click(object s, EventArgs e)
        {
            var client = GetFormClientData();

            if (Cliente.IsModelComplete(client))
            {
                currentClient = client;
                ShowCurrentClientData();
                EnableClientForm(false);
                MessageBox.Show("Cliente agregado exitosamente.");
            }
            else
            {
                currentClient = null;
                MessageBox.Show("Cliente no fue agregado, por favor ingresa todos los valores");
            }
        }

        private void btnIngresarDinero_Click(object sender, EventArgs e)
        {
            if (!ValidateIfClientExist())
                return;

            var input = MostrarInputBox("Digite la cantidad a ingresar a la cuenta");

            if(decimal.TryParse(input, out decimal cantidad) && cantidad > 0)
            {
                currentClient.MontoDisponible += cantidad;
                ShowCurrentClientData();
                MessageBox.Show("Ingreso realizado exitosamente.");
            }
            else if(cantidad <= 0)
            {
                MessageBox.Show("Por que va a querer ingresar nada o numeros negativos?");
                MessageBox.Show("Pal CECOT por bayunc@");
            }
            else
                MessageBox.Show("Por favor ingrese un monto valido.");
        }

        private void btnRetiroDinero_Click(object sender, EventArgs e)
        {
            if (!ValidateIfClientExist())
                return;

            var input = MostrarInputBox("Digite la cantidad a retirar de la cuenta");

            if (decimal.TryParse(input, out decimal cantidad) && currentClient.MontoDisponible > cantidad)
            {
                currentClient.MontoDisponible -= cantidad;
                ShowCurrentClientData();
                MessageBox.Show("Retiro realizado exitosamente.");
            }
            else if (currentClient.MontoDisponible < cantidad)
            {
                MessageBox.Show("Fondos no son suficientes");
                MessageBox.Show("No vuelva a intentarlo hasta tener fondos");
                MessageBox.Show("Caso contrario lo meteremos al CECOT");
            }
            else
                MessageBox.Show("Por favor ingrese un monto valido.");
        }
    }
}
