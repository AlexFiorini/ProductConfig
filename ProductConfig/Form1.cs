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
        Audi audi = new Audi();
        String path = "Configurazione.txt";
        public Form1()
        {
            InitializeComponent();
            Menu.Width = 1256;
            Menu.Height = 761;
            Point p = new Point(0, 0);
            Menu.Location = p;
            Conf_interni.Size = Menu.Size;
            Conf_interni.Location = Menu.Location;
            Conf_interni.Visible = false;
            Conf_esterni.Size = Menu.Size;
            Conf_esterni.Location = Menu.Location;
            Conf_esterni.Visible = false;
            Riepilogo.Size = Menu.Size;
            Riepilogo.Location = Menu.Location;
            Riepilogo.Visible = false;
            loadAudi();
        }

        //Carica configurazione precedente
        void loadAudi()
        {
            audi.LeggiDaFile(path);
        }

        //Menù principale

        bool caratte = false;
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
            if(audi.interni=="null")
            {
                comboInterni.SelectedIndex = 0;
            } else
            {
                comboInterni.Text = audi.interni;
            }
            
            if(audi.volante=="null")
            {
                comboVolanti.SelectedIndex = 0;
            } else
            {
                comboVolanti.Text = audi.volante;
            }
        }

        //Configurazione interni

        private void comboInterni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboInterni.SelectedIndex == 0)
            {
                F_interni.Image = Properties.Resources.In_Nero;
                Prezzo_interni.Text = "2200,00 EUR";
            }
            else if (comboInterni.SelectedIndex == 1)
            {
                F_interni.Image = Properties.Resources.In_Azzurro;
                Prezzo_interni.Text = "11260,00 EUR";
            }
            else if (comboInterni.SelectedIndex == 2)
            {
                F_interni.Image = Properties.Resources.In_Marrone;
                Prezzo_interni.Text = "8250,00 EUR";
            }
        }

        private void comboVolanti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVolanti.SelectedIndex == 0)
            {
                F_volante.Image = Properties.Resources.In_Volante_1;
                Prezzo_volante.Text = "0,0 EUR";
            }
            else if (comboVolanti.SelectedIndex == 1)
            {
                F_volante.Image = Properties.Resources.In_Volante_2;
                Prezzo_volante.Text = "230,00 EUR";
            }
        }

        //Cambio pannello

        private void Vai_a_Conf_esterni_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            Conf_interni.Visible = false;
            Conf_esterni.Visible = true;
            if(audi.colo_car == "null")
            {
                comboColoCarr.SelectedIndex = 0;
            } else
            {
                comboColoCarr.Text = audi.colo_car;
            }
            if (audi.cerchi == "null")
            {
                comboCerchi.SelectedIndex = 0;
            }
            else
            {
                comboCerchi.Text = audi.cerchi;
            }
            checkTelo.Checked = audi.telo;
        }

        //Configurazione esterno

        private void comboColoCarr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboColoCarr.SelectedIndex == 0)
            {
                F_esterni.Image = Properties.Resources.Audi_bianca0;
                Prezzo_carr.Text = "0,0 EUR";
            }
            else if (comboColoCarr.SelectedIndex == 1)
            {
                F_esterni.Image = Properties.Resources.Audi_nera0;
                Prezzo_carr.Text = "1270,00 EUR";
            }
            else if (comboColoCarr.SelectedIndex == 2)
            {
                F_esterni.Image = Properties.Resources.Audi_rossa0;
                Prezzo_carr.Text = "1270,00 EUR";
            }
            else if (comboColoCarr.SelectedIndex == 3)
            {
                F_esterni.Image = Properties.Resources.Audi_grigia0;
                Prezzo_carr.Text = "1270,00 EUR";
            }
            else if (comboColoCarr.SelectedIndex == 4)
            {
                F_esterni.Image = Properties.Resources.Audi_blu0;
                Prezzo_carr.Text = "5310,00 EUR";
            }
        }

        private void checkTelo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTelo.Checked)
            {
                F_telo.Visible = true;
                Prezzo_telo.Visible = true;
            }
            else
            {
                F_telo.Visible = false;
                Prezzo_telo.Visible = false;

            }
        }

        private void comboCerchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCerchi.SelectedIndex == 0)
            {
                F_cerchi.Image = Properties.Resources.C_19_1;
                Prezzo_cerchi.Text = "0,0 EUR";
            }
            else if (comboCerchi.SelectedIndex == 1)
            {
                F_cerchi.Image = Properties.Resources.C_19_2;
                Prezzo_cerchi.Text = "370,00 EUR";
            }
            else if (comboCerchi.SelectedIndex == 2)
            {
                F_cerchi.Image = Properties.Resources.C_20;
                Prezzo_cerchi.Text = "2120,00 EUR";
            }
            else if (comboCerchi.SelectedIndex == 3)
            {
                F_cerchi.Image = Properties.Resources.C_21_1;
                Prezzo_cerchi.Text = "4130,00 EUR";
            }
            else if (comboCerchi.SelectedIndex == 4)
            {
                F_cerchi.Image = Properties.Resources.C_21_2;
                Prezzo_cerchi.Text = "4230,00 EUR";
            }
        }

        //Cambio pannello
        private void Vai_a_Riepilogo_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            Conf_interni.Visible = false;
            Conf_esterni.Visible = false;
            Riepilogo.Visible = true;
            loadTesti();
            loadF_finale();
            calcolaprezzo();
        }

        void loadTesti()
        {
            Int_scelta.Text = comboInterni.Text;
            Vol_scelta.Text = comboVolanti.Text;
            Carr_scelta.Text = comboColoCarr.Text;
            Cer_scelta.Text = comboCerchi.Text;
            if(checkTelo.Checked)
            {
                Tel_scelta.Text = checkTelo.Text;
            } else
            {
                Tel_scelta.Text = "";
            }
        }

        void loadF_finale()
        {
            if(comboColoCarr.SelectedIndex == 0 && comboCerchi.SelectedIndex == 0)    //Bianco
            {
                F_finale.Image = Properties.Resources.Audi_bianca0;
            }
            else if(comboColoCarr.SelectedIndex == 0 && comboCerchi.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_bianca1;
            }
            else if (comboColoCarr.SelectedIndex == 0 && comboCerchi.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_bianca2;
            }
            else if (comboColoCarr.SelectedIndex == 0 && comboCerchi.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_bianca3;
            }
            else if (comboColoCarr.SelectedIndex == 0 && comboCerchi.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_bianca4;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboCerchi.SelectedIndex == 0) //Nero
            {
                F_finale.Image = Properties.Resources.Audi_nera0;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboCerchi.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_nera1;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboCerchi.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_nera2;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboCerchi.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_nera3;
            }
            else if (comboColoCarr.SelectedIndex == 1 && comboCerchi.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_nera4;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboCerchi.SelectedIndex == 0) //Rosso
            {
                F_finale.Image = Properties.Resources.Audi_rossa0;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboCerchi.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_rossa1;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboCerchi.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_rossa2;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboCerchi.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_rossa3;
            }
            else if (comboColoCarr.SelectedIndex == 2 && comboCerchi.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_rossa4;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboCerchi.SelectedIndex == 0) //Grigia
            {
                F_finale.Image = Properties.Resources.Audi_grigia0;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboCerchi.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_grigia1;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboCerchi.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_grigia2;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboCerchi.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_grigia3;
            }
            else if (comboColoCarr.SelectedIndex == 3 && comboCerchi.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_grigia4;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboCerchi.SelectedIndex == 0) //Blu
            {
                F_finale.Image = Properties.Resources.Audi_blu0;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboCerchi.SelectedIndex == 1)
            {
                F_finale.Image = Properties.Resources.Audi_blu1;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboCerchi.SelectedIndex == 2)
            {
                F_finale.Image = Properties.Resources.Audi_blu2;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboCerchi.SelectedIndex == 3)
            {
                F_finale.Image = Properties.Resources.Audi_blu3;
            }
            else if (comboColoCarr.SelectedIndex == 4 && comboCerchi.SelectedIndex == 4)
            {
                F_finale.Image = Properties.Resources.Audi_blu4;
            }
        }

        void calcolaprezzo()
        {
            double prezzo = 111300;
            
            //Interni
            if (comboInterni.SelectedIndex == 0)
            {
                prezzo += 2200;
            }
            else if (comboInterni.SelectedIndex == 1)
            {
                prezzo += 11260;
            }
            else if (comboInterni.SelectedIndex == 2)
            {
                prezzo += 8250;
            }

            //Volante
            if (comboVolanti.SelectedIndex == 1)
            {
                prezzo += 230;
            }

            //Carrozzeria
            if (comboColoCarr.SelectedIndex == 1)
            {
                prezzo += 1270;
            }
            else if (comboColoCarr.SelectedIndex == 2)
            {
                prezzo += 1270;
            }
            else if (comboColoCarr.SelectedIndex == 3)
            {
                prezzo += 1270;
            }
            else if (comboColoCarr.SelectedIndex == 4)
            {
                prezzo += 5310;
            }

            //Telo
            if (checkTelo.Checked)
            {
                prezzo += 723; 
            }

            //Cerchi
            if (comboCerchi.SelectedIndex == 1)
            {
                prezzo += 370;
            }
            else if (comboCerchi.SelectedIndex == 2)
            {
                prezzo += 2120;
            }
            else if (comboCerchi.SelectedIndex == 3)
            {
                prezzo += 4130;
            }
            else if (comboCerchi.SelectedIndex == 4)
            {
                prezzo += 4230;
            }

            Totale_testo.Text = "Totale: " + prezzo.ToString() + " EUR";
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            audi = new Audi(comboInterni.Text, comboVolanti.Text, comboColoCarr.Text, comboCerchi.Text, checkTelo.Checked);
            audi.ScriviSuFile(path);
            MessageBox.Show(string.Format("Configurazione salvata correttamente"), "Salva file", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}