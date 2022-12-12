using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConfig
{
    public class Audi
    {
        public string interni { get; set; }
        public string volante { get; set; }
        public string colo_car { get; set; }
        public string cerchi { get; set; }
        public Boolean telo { get; set; }


        public Audi(String interni, String volante, String colo_car, String cerchi, Boolean telo)
        {
            this.interni = interni;
            this.volante = volante;
            this.colo_car = colo_car;
            this.cerchi=cerchi;
            this.telo = telo;
        }

        public Audi()
        {
            this.interni = "null";
            this.volante = "null";
            this.colo_car = "null";
            this.cerchi = "null";
            this.telo = false;
        }

        public override string ToString()
        {
            return string.Format("Iterni={0};Volante={1};Colore_Carrozzeria={2};Cerchi={3};Telo={4}", interni, volante, colo_car, cerchi, telo);
        }

        public void Parse(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                string[] elenco = s.Split(";");
                foreach (string p in elenco)
                {
                    string[] coppiaNomeValore = p.Split("=");
                    string nomeProprieta = coppiaNomeValore[0];
                    string valoreProprieta = coppiaNomeValore[1];
                    switch (nomeProprieta)
                    {
                        case "Iterni":
                            interni = valoreProprieta;
                            break;
                        case "Volante":
                            volante = valoreProprieta;
                            break;
                        case "Colore_Carrozzeria":
                            colo_car = valoreProprieta;
                            break;
                        case "Cerchi":
                            cerchi = valoreProprieta;
                            break;
                        case "Telo":
                            telo = Convert.ToBoolean(valoreProprieta);
                            break;
                    }
                }
            }
        }

        public void ScriviSuFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(this);
            }
        }

        public bool LeggiDaFile(string path)
        {
            if (File.Exists(path))
            {
                string s = File.ReadAllText(path);
                Parse(s);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
