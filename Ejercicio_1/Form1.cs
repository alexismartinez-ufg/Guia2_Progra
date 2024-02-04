using System;
using System.Windows.Forms;
using Ejercicio_1.Models;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        private Celular miCelular;
        public Form1()
        {
            InitializeComponent();
            miCelular = new Celular("Mate 20 PRO", "Huawei", "Azul", 1000.00);
            Instance = this;
            lblNotificacion.Text = "El celular está encendido.";
        }

        /// <summary>
        /// Esto permite mostrar un modal y 
        /// ser reutilizado par aun sin fin de usos
        /// </summary>
        /// <param name="text">Este parametro indica el texto a mostrar en el modal</param>
        /// <returns></returns>
        public string MostrarInputBox(string text)
        {
            using (var inputForm = new InputForm(text))
            {
                return inputForm.ShowDialog() == DialogResult.OK ? inputForm.UserInput : "";
            }
        }

        //ESTOS SOLO SON EVENTOS :V
        private void bntApagar_Click(object sender, EventArgs e) => miCelular.Apagar();

        private void btnEncender_Click(object sender, EventArgs e) => miCelular.Encender();

        private void btnLlamar_Click(object sender, EventArgs e) => miCelular.Llamar();

        private void btnEnviarMensaje_Click(object sender, EventArgs e) => miCelular.EnviarMensaje();
    }
}
