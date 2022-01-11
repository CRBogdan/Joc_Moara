using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Joc_Moara
{
    public partial class HostMenuPanel : UserControl,IConnectable
    {
        public gameForm gameForm;
        Connection connection = null;
        public HostMenuPanel(gameForm gameForm)
        {
            this.gameForm = gameForm;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            gameForm.afisareMainMenuPanel(this);
            connection.stopServer();
        }

        private void HostMenuPanel_Load(object sender, EventArgs e)
        {
            connection = new Connection(this);
            ipLabel.Text = "Waiting for another player... \n" + connection.getAdresa();
        }

        public void connected()
        {
            gameForm.afisareHostGamePanel(this,connection);
        }
    }
}
