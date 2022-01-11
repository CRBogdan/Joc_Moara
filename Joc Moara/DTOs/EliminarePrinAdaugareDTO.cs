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
    public class EliminarePrinAdaugareDTO
    {
        public string tip { get; set; }
        public Point point { get; set; }
        public string numeAdaugat { get; set; }
        public string numeEliminat { get; set; }

        private PictureBox piesaObj;
        private string piesaStr;

        public EliminarePrinAdaugareDTO()
        {

        }

        public EliminarePrinAdaugareDTO(PictureBox piesa,string numeEliminat)
        {
            piesaObj = piesa;
            tip = "eliminarePrinAdaugare";
            point = piesa.Location;
            numeAdaugat = piesa.Name;
            this.numeEliminat = numeEliminat;
            piesaStr = JsonSerializer.Serialize(this);
        }

        public EliminarePrinAdaugareDTO(string piesa)
        {
            this.piesaStr = piesa;
            EliminarePrinAdaugareDTO eliminareTemp = new EliminarePrinAdaugareDTO();
            eliminareTemp = JsonSerializer.Deserialize<EliminarePrinAdaugareDTO>(piesa);
            point = eliminareTemp.point;
            numeAdaugat = eliminareTemp.numeAdaugat;
            numeEliminat = eliminareTemp.numeEliminat;
            tip = eliminareTemp.tip;
        }

        public string getPiesaStr()
        {
            return piesaStr;
        }

        public Piesa getPiesaAlbaObj(ref string numeEliminat)
        {
            Piesa piesaTemp = new PiesaAlba();
            piesaTemp.imagine.Location = point;
            piesaTemp.imagine.Name = numeAdaugat;

            numeEliminat = this.numeEliminat;

            return piesaTemp;
        }

        public Piesa getPiesaNeagraObj(ref string numeEliminat)
        {
            Piesa piesaTemp = new PiesaNeagra();
            piesaTemp.imagine.Location = point;
            piesaTemp.imagine.Name = numeAdaugat;

            numeEliminat = this.numeEliminat;

            return piesaTemp;
        }
    }
}
