using System.Windows.Forms;

namespace ProductConfig
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Menu.Width = 1256;
            Menu.Height = 761;
            Point p = new Point(-6, -5);
            Menu.Location = p;
            Conf_interni.Size = Menu.Size;
            Conf_interni.Location = Menu.Location;
            Conf_interni.Visible = false;
            Conf_esterni.Size = Menu.Size;
            Conf_esterni.Location = Menu.Location;
            Conf_esterni.Visible = false;
        }

        bool caratte=false;
        ToolTip ToolTip1 = new ToolTip();
        private void button2_Click(object sender, EventArgs e)
        {
            if(!caratte)
            {
                Caratteristiche.Visible = true;
                caratte = true;
            }
            else
            {
                Caratteristiche.Visible = false;
                caratte = false;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Menu.Visible = true;
            Conf_interni.Visible = false;
            Conf_esterni.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboColoCarr.SelectedIndex == 0)
            {
                F_esterni.Image = Properties.Resources.Es_Bianco;
            }
            else if (comboColoCarr.SelectedIndex == 1)
            {
                F_esterni.Image = Properties.Resources.Es_Nero;
            }
            else if (comboColoCarr.SelectedIndex == 2)
            {
                F_esterni.Image = Properties.Resources.Es_Rosso;
            }
            else if (comboColoCarr.SelectedIndex == 3)
            {
                F_esterni.Image = Properties.Resources.Es_Grigio;
            }
            else if (comboColoCarr.SelectedIndex == 4)
            {
                F_esterni.Image = Properties.Resources.Es_Blu;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                F_telo.Visible = true;
            }
            else
            {
                F_telo.Visible = false;
            }
        }

        private void Accelerazione_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.Show("Da 0 a 100 km/h", Accelerazione);
        }

        private void Emissioni_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.Show("Emissioni di CO2 per ogni km percorso", Emissioni);
        }

        private void Consumi_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.Show("Consumi in kWh ogni 100 km", Consumi);
        }

        private void Potenza_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.Show("Potenza massima generata dal motore", Potenza);
        }
    }
}