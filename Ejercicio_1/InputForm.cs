using System.Windows.Forms;

namespace Ejercicio_1
{
    /// <summary>
    /// EL MOTIVO DE ESTE FORM ES SOLICITAR DATOS DE ENTRADA
    /// AL USUARIO Y PODER SER REUTILIZADO, YA SEA PARA PEDIR 
    /// DATOS NUMERICOS, TEXTO O CUALQUIER OTRA COSA :D
    /// 
    /// PERMITE MOSTRAR UN MENSAJE PERSONALIZADO
    /// </summary>
    public partial class InputForm : Form
    {
        public string UserInput { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este constructor en especifico permite mostrar texto personalizado en el "modal" echizo
        /// </summary>
        /// <param name="_text">texto a mostrar en el label del modal</param>
        public InputForm(string _text)
        {
            InitializeComponent();
            text.Text = _text;
        }

        private void aceptar_Click(object sender, System.EventArgs e)
        {
            UserInput = input.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelar_Click(object sender, System.EventArgs e)
        {
            UserInput = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
