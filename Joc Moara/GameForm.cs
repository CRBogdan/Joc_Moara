using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Joc_Moara;
using System.Resources;

namespace Joc_Moara
{
    public partial class gameForm : Form
    {

        public gameForm()
        {
            InitializeComponent();
        }

        private void mainMenuPanel1_Load(object sender, EventArgs e)
        {

        }

        private void gameForm_Load(object sender, EventArgs e)
        {
        }

        public void afisareHostGamePanel(UserControl control,Connection connection)
        {
            control.BringToFront();
            this.hostGamePanel.setConnection(connection);
            this.hostGamePanel.Show();
            control.Hide();
        }        
        
        public void afisareJoinGamePanel(UserControl control,Connection connection)
        {
            control.BringToFront();
            this.joinGamePanel.setConnection(connection);
            this.joinGamePanel.Show();
            control.Hide();
        }
        

        public void afisareHostMenuPanel(UserControl control)
        {
            control.Hide();
            this.hostMenuPanel.Show();
        }

        public void afisareJoinMenuPanel(UserControl control)
        {
            control.Hide();
            this.joinMenuPanel.Show();
        }

        public void afisareMainMenuPanel(UserControl control)
        {
            control.Hide();
            this.mainMenuPanel.Show();
        }
    }
}
