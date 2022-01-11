using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.Json;

namespace Joc_Moara
{
    [Serializable]
    public abstract class Piesa
    {
        public PictureBox imagine { get; set; } = new PictureBox();
    }
}
