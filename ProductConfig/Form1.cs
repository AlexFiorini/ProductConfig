using System.Diagnostics;
using System.Security.Policy;
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
            Riepilogo.Visible = false;
        }

        //Menù principale

        bool caratte=false;
        ToolTip ToolTip1 = new ToolTip();


        private void Info_Click(object sender, EventArgs e)
        {
            String url = "https://www.audi.it/it/web/it/modelli/e-tron-gt/audi-e-tron-gt.html";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }
        

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
            comboInterni.SelectedIndex = 0;
            comboVolanti.SelectedIndex = 0;
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
            Menu.Visible = false;
            Conf_interni.Visible = false;
            Conf_esterni.Visible = true;
            comboColoCarr.SelectedIndex = 0;
            comboCerchi.SelectedIndex = 0;
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

        //Cambio pannello
        private void Vai_a_Riepilogo_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            Conf_interni.Visible = false;
            Conf_esterni.Visible = false;
            Riepilogo.Visible = true;
            loadF_finale();
        }

        void loadF_finale()
        {
            if(comboColoCarr.SelectedIndex == 0 && comboColoCarr.SelectedIndex == 0)    //Bianco
            {
                F_finale.Image = Properties.Resources.Audi_Bianco;
            }
            else if(comboColoCarr.SelectedIndex == 0 && comboColoCarr.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_Bianco2;
            }
            else if (comboColoCarr.SelectedIndex == 0 && comboColoCarr.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_bianco3;
            }
            else if (comboColoCarr.SelectedIndex == 0 && comboColoCarr.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_bianco4;
            }
            else if (comboColoCarr.SelectedIndex == 0 && comboColoCarr.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_bianco5;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboColoCarr.SelectedIndex == 0) //Nero
            {
                F_finale.Image = Properties.Resources.Audi_nera;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboColoCarr.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_nera1;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboColoCarr.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_nera2;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboColoCarr.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_nera3;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboColoCarr.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_nera4;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboColoCarr.SelectedIndex == 0) //Rosso
            {
                F_finale.Image = Properties.Resources.Audi_rossa;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboColoCarr.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_rossa1;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboColoCarr.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_rossa2;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboColoCarr.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_rossa3;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboColoCarr.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_rossa4;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboColoCarr.SelectedIndex == 0) //Grigia
            {
                F_finale.Image = Properties.Resources.Audi_grigia;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboColoCarr.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_grigia1;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboColoCarr.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_grigia2;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboColoCarr.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_grigia3;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboColoCarr.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_grigia4;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboColoCarr.SelectedIndex == 0) //Blu
            {
                F_finale.Image = Properties.Resources.Audi_Blu;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboColoCarr.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_blu1;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboColoCarr.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_blu2;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboColoCarr.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_blu3;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboColoCarr.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_blu4;
            }

        }


    }
        
            

}