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
            Conf_interni.Size = Menu.Size;
            Conf_interni.Location = Menu.Location;
            Conf_interni.Visible = false;
            panel4.Size = Menu.Size;
            panel4.Location = Menu.Location;
            panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Caratteristiche.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Caratteristiche.Visible = false;
            Conf_interni.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex == 0)
            {
                F_interni.Image = Properties.Resources.In_Nero;
            } 
            else if(comboBox1.SelectedIndex == 1)
            {
                F_interni.Image = Properties.Resources.In_Azzurro;
            } 
            else if(comboBox1.SelectedIndex == 2)
            {
                F_interni.Image = Properties.Resources.In_Marrone;
            }
        
                    
        }
    }
}