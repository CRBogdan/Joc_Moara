using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joc_Moara
{
    public partial class JoinMenuPanel : UserControl,IConnectable
    {
        Connection connection = null;
        gameForm gameForm;
        public JoinMenuPanel(gameForm gameForm)
        {
            this.gameForm = gameForm;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            gameForm.afisareMainMenuPanel(this);
            connection.disconnectClient();
        }

        private void JoinMenuPanel_Load(object sender, EventArgs e)
        {
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            connection = new Connection(adressText.Text, this);
        }

        public void connected()
        {
            gameForm.afisareJoinGamePanel(this,connection);
        }
    }
}
