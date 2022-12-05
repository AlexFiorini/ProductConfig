using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProductConfig
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }
    }
}