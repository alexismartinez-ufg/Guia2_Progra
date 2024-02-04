using System.Windows.Forms;

namespace Ejercicio_1.Models
{
    public class Celular
    {

        // Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }
        public bool Encendido { get; private set; }

        // Constructor
        public Celular(string marca, string modelo, string color, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Precio = precio;
            Encendido = false;
        }

        // Métodos

        /// <summary>
        /// Valida si se puede encender el dispositivo
        /// </summary>
        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
                var msg = "El celular está encendido.";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
            else
            {
                var msg = "El celular ya está encendido.";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
        }

        /// <summary>
        /// Valida si se puede apagar o no el dispositivo
        /// </summary>
        public void Apagar()
        {
            if (Encendido)
            {
                Encendido = false;
                var msg = "El celular está apagado.";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
            else
            {
                var msg = "El celular ya está apagado.";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
        }

        /// <summary>
        /// Realiza una llamada al numero ingresado por el usuario 
        /// y valida que sea un numero
        /// </summary>
        public void Llamar()
        {
            string numero = Form1.Instance.MostrarInputBox("Ingrese el número");

            if (Encendido && !string.IsNullOrEmpty(numero))
            {
                var msg = $"Llamando al número: {numero}...";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
            else if (string.IsNullOrEmpty(numero))
            {
                var msg = "Ingrese un número por favor";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
            else
            {
                var msg = "No se puede llamar porque el celular está apagado.";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
        }

        /// <summary>
        /// Envia un mensaje y valida que el numero receptor es valido
        /// y valida que se envie un mensaje
        /// </summary>
        public void EnviarMensaje()
        {
            var numero = Form1.Instance.MostrarInputBox("Ingrese el número");
            var mensaje = Form1.Instance.MostrarInputBox("Ingrese el mensaje");

            if (Encendido 
                && !string.IsNullOrEmpty(numero) 
                && !string.IsNullOrEmpty(mensaje))
            {
                var msg = $"Enviando mensaje a {numero}: {mensaje}";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
            else if (string.IsNullOrEmpty(numero))
            {
                var msg = "Ingrese un número por favor";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
            else if (string.IsNullOrEmpty(mensaje))
            {
                var msg = "Ingrese un mensaje por favor";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
            else
            {
                var msg = "No se puede enviar el mensaje porque el celular está apagado.";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificacion.Text = msg;
            }
        }
    }

}

