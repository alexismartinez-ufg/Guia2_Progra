using Guia_2.Models;
using System;
using System.Windows.Forms;

namespace Guia_2
{
    public partial class Form1 : Form
    {
        public Empleado miEmpleado;
        public Salario miSalario;

        public Form1()
        {
            InitializeComponent();

            miEmpleado = new Empleado();
            miSalario = new Salario();
        }

        private void SetEmpleadoData()
        {
            miEmpleado.Nombre = txbNombre.Text;
            miEmpleado.Identificacion = txbIdentificacion.Text;
            miEmpleado.SalarioDiario = Convert.ToDecimal(txbSalarioDiario.Text);
            miSalario.DiasLaborados = int.Parse(txbDiasLaborados.Text);

            MessageBox.Show("Datos ingresados con éxito.");
        }

        private void CalcularSalario()
        {
            txbTotalDevengado.Text = miSalario
                .CalcularSalario(miSalario.DiasLaborados, miEmpleado.SalarioDiario)
                .ToString();
        }

        private void NuevoEmpleado()
        {
            txbNombre.Clear();
            txbIdentificacion.Clear();
            txbSalarioDiario.Clear();
            txbDiasLaborados.Clear();
            txbTotalDevengado.Clear();

            miEmpleado = new Empleado();
            miSalario = new Salario();
        }

        private void btnSalir_Click(object s, EventArgs e) => Application.Exit();

        private void btnGuardarEmpleado_Click(object s, EventArgs e) => SetEmpleadoData();

        private void btnCalcularSalario_Click(object s, EventArgs e) => CalcularSalario();

        private void btnNuevo_Click(object sender, EventArgs e) => NuevoEmpleado();
    }
}
