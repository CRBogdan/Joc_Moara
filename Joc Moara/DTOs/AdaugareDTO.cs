using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

namespace Joc_Moara
{
    [Serializable]
    public class AdaugareDTO
    {
        public string tip { get; set; }
        public Point point { get; set; }
        public string nume { get; set; }
        private PictureBox piesaObj;
        private string piesaStr;

        public AdaugareDTO()
        {

        }

        public AdaugareDTO(PictureBox piesa)
        {
            piesaObj = piesa;
            tip = "adaugare";
            point = piesa.Location;
            nume = piesa.Name;
            piesaStr = JsonSerializer.Serialize(this);
        }

        public AdaugareDTO(string piesa)
        {
            this.piesaStr = piesa;
            AdaugareDTO adaugareTemp = new AdaugareDTO();
            adaugareTemp = JsonSerializer.Deserialize<AdaugareDTO>(piesa);
            point = adaugareTemp.point;
            nume = adaugareTemp.nume;
            tip = adaugareTemp.tip;

        }

        public string getPiesaStr()
        {
            return piesaStr;
        }

        public Piesa getPiesaAlbaObj()
        {
            Piesa piesaTemp = new PiesaAlba();
            piesaTemp.imagine.Location = point;
            piesaTemp.imagine.Name = nume;

            return piesaTemp;
        }

        public Piesa getPiesaNeagraObj()
        {
            Piesa piesaTemp = new PiesaNeagra();
            piesaTemp.imagine.Location = point;
            piesaTemp.imagine.Name = nume;

            return piesaTemp;
        }
    }
}
