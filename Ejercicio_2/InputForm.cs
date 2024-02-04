using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class InputForm : Form
    {
        public string UserInput { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

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
