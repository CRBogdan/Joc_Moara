using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.Json;

namespace Joc_Moara
{
    class PiesaAlba : Piesa
    {
        public PiesaAlba()
        {
            imagine.Size = new Size(70,70);
            imagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            imagine.BackColor = Color.Transparent;
            imagine.Image = new Bitmap(Properties.Resources.PiesaAlba);
        }
    }
}
