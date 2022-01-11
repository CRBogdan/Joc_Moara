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
    public partial class MainMenuPanel : UserControl
    {
        public gameForm gameForm;
        public MainMenuPanel(gameForm gameForm)
        {
            this.gameForm = gameForm;
            InitializeComponent();
        }

        private void exitBotton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            gameForm.afisareHostMenuPanel(this);
        }

        private void MainMenuPanel_Load(object sender, EventArgs e)
        {
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            gameForm.afisareJoinMenuPanel(this);
        }
    }
}
