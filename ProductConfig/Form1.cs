using System.Windows.Forms;

namespace ProductConfig
{
    public partial class Form1 : Form
    {

        /* Legenda:
         * Combo...: Combobox
         * ..._Click: Bottoni
         * ..._MouseHover: Mouse resta fermo su determinato oggetto
         */

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

        //Menù principale

        bool caratte=false;
        ToolTip ToolTip1 = new ToolTip();

        //Pannello dettagli

        private void Dettagli_Click(object sender, EventArgs e)
        {
            if (!caratte)
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

        //Hover per le foto nel pannello dettagli

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

        //Cambio pannello

        private void Inizia_Click(object sender, EventArgs e)
        {
            Caratteristiche.Visible = false;
            Conf_interni.Visible = true;
        }

        //Configurazione interni

        private void comboInterni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboInterni.SelectedIndex == 0)
            {
                F_interni.Image = Properties.Resources.In_Nero;
            }
            else if (comboInterni.SelectedIndex == 1)
            {
                F_interni.Image = Properties.Resources.In_Azzurro;
            }
            else if (comboInterni.SelectedIndex == 2)
            {
                F_interni.Image = Properties.Resources.In_Marrone;
            }
        }

        private void comboVolanti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVolanti.SelectedIndex == 0)
            {
                F_volante.Image = Properties.Resources.In_Volante_1;
            }
            else if (comboVolanti.SelectedIndex == 1)
            {
                F_volante.Image = Properties.Resources.In_Volante_2;
            }
        }

        //Cambio pannello

        private void Vai_a_Conf_esterni_Click(object sender, EventArgs e)
        {
            Menu.Visible = true;
            Conf_interni.Visible = false;
            Conf_esterni.Visible = true;
        }

        //Configurazione esterno

        private void comboColoCarr_SelectedIndexChanged(object sender, EventArgs e)
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

        private void checkTelo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTelo.Checked)
            {
                F_telo.Visible = true;
            }
            else
            {
                F_telo.Visible = false;
            }
        }

        private void comboCerchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCerchi.SelectedIndex == 0)
            {
                F_cerchi.Image = Properties.Resources.C_19_1;
            }
            else if (comboCerchi.SelectedIndex == 1)
            {
                F_cerchi.Image = Properties.Resources.C_19_2;
            }
            else if (comboCerchi.SelectedIndex == 2)
            {
                F_cerchi.Image = Properties.Resources.C_20;
            }
            else if (comboCerchi.SelectedIndex == 3)
            {
                F_cerchi.Image = Properties.Resources.C_21_1;
            }
            else if (comboCerchi.SelectedIndex == 4)
            {
                F_cerchi.Image = Properties.Resources.C_21_2;
            }
        }

        
    }
}