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

namespace Joc_Moara
{
    public partial class HostGamePanel : UserControl, IWaitable
    {
        public bool inAsteptare;
        public int selectarePiesa = 0;
        public bool selectareNod = true;
        private int pieseAlbePeTabla = 0;
        private int pieseAlbeAdaugate = 0;
        private int pieseNegrePeTabla = 0;
        private int pieseNegreAdaugate = 0;
        public Piesa piesaSelectata = null;
        private PictureBox[,,] noduri = new PictureBox[3, 3, 3];
        private Piesa[,,] piese = new Piesa[3, 3, 3];

        gameForm gameForm;
        Connection conexiune = null;

        public HostGamePanel(gameForm gameForm)
        {
            this.gameForm = gameForm;

            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (!(j == 1 && k == 1))
                        {
                            noduri[i, j, k] = new PictureBox();
                            this.Controls.Add(noduri[i, j, k]);

                            noduri[i, j, k].Image = null;
                            noduri[i, j, k].Location = new System.Drawing.Point((int)((i * 100 + k * 350 + 20 - i * k * 100)), (int)((i * 100 + j * 350 + 20 - i * j * 100)));
                            this.noduri[i, j, k].Name = "nod" + i + j + k;
                            this.noduri[i, j, k].Size = new System.Drawing.Size(60, 60);
                            this.noduri[i, j, k].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            noduri[i, j, k].BackColor = Color.Transparent;
                            noduri[i, j, k].Anchor = AnchorStyles.None;

                            noduri[i, j, k].MouseMove += new System.Windows.Forms.MouseEventHandler(this.nodMouseMove);
                            noduri[i, j, k].MouseLeave += new System.EventHandler(this.nodMouseLeave);
                            noduri[i, j, k].MouseClick += new System.Windows.Forms.MouseEventHandler(this.nodMouseClick);
                        }
                    }
                }
            }
        }

        private void HostGamePanel_Load(object sender, EventArgs e)
        {

        }

        public void setConnection(Connection conexiune)
        {
            this.conexiune = conexiune;
        }

        private void nodMouseMove(object sender, EventArgs e)
        {
            if (inAsteptare == false && selectareNod)
                if (pieseAlbeAdaugate < 9)
                    ((PictureBox)(sender)).Image = global::Joc_Moara.Properties.Resources.SelectareNod;
        }

        private void nodMouseLeave(object sender, EventArgs e)
        {
            if (inAsteptare == false && selectareNod)
                if (pieseAlbeAdaugate < 9)
                    ((PictureBox)(sender)).Image = null;
        }

        private void nodMouseClick(object sender, EventArgs e)
        {
            if (inAsteptare == false && pieseAlbeAdaugate < 9 && selectareNod)
            {
                Piesa piesaTemp = new PiesaAlba();
                piese[((PictureBox)(sender)).Name[3] - 48, ((PictureBox)(sender)).Name[4] - 48, ((PictureBox)(sender)).Name[5] - 48] = piesaTemp;
                piesaTemp.imagine.Location = new Point(((PictureBox)sender).Location.X - 5, ((PictureBox)sender).Location.Y - 5);
                piesaTemp.imagine.Name = "piesaAlba" + (((PictureBox)(sender)).Name[3] - 48) + (((PictureBox)(sender)).Name[4] - 48) + (((PictureBox)(sender)).Name[5] - 48);
                piesaTemp.imagine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.piesaMouseClick);
                this.Controls.Add(piesaTemp.imagine);
                piesaTemp.imagine.BringToFront();

                if (verificareMoara(piesaTemp))
                {
                    piesaSelectata = piesaTemp;
                    selectareNod = false;
                    pieseNegrePeTabla--;
                    selectarePiesa = -1;
                }
                else
                {
                    AdaugareDTO adaugare = new AdaugareDTO(piesaTemp.imagine);
                    conexiune.sendObject(adaugare.getPiesaStr());
                    conexiune.waitForPlayer(this);
                    inAsteptare = true;
                }

                pieseAlbePeTabla++;
                pieseAlbeAdaugate++;
                if (pieseAlbeAdaugate == 9)
                    selectareNod = false;
            }
        }

        private void piesaMouseClick(object sender, EventArgs e)
        {
            if (selectarePiesa != 0 && inAsteptare == false)
            {
                if (selectarePiesa == -1 && ((PictureBox)(sender)).Name.Contains("Neagra"))
                {
                    EliminarePrinAdaugareDTO eliminare = new EliminarePrinAdaugareDTO(piesaSelectata.imagine, ((PictureBox)sender).Name);
                    conexiune.sendObject(eliminare.getPiesaStr());
                    conexiune.waitForPlayer(this);
                    inAsteptare = true;
                    selectareNod = true;
                    piesaSelectata = null;
                    selectarePiesa = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (piese[i, j, k] != null)
                                    if (piese[i, j, k].imagine == ((PictureBox)sender))
                                        piese[i, j, k] = null;
                            }
                        }
                    }
                    ((PictureBox)sender).Dispose();
                }
                else if (selectarePiesa == 1 && ((PictureBox)(sender)).Name.Contains("Alba"))
                {

                }
            }
            else if (pieseAlbeAdaugate == 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (piese[i, j, k] != null)
                                if (piese[i, j, k].imagine == ((PictureBox)sender))
                                {
                                    piesaSelectata = piese[i, j, k];
                                    piesaSelectata.imagine.Location = new Point(piesaSelectata.imagine.Location.X - 5, piesaSelectata.imagine.Location.Y - 5);
                                    piesaSelectata.imagine.Size = new Size(piesaSelectata.imagine.Size.Width + 10, piesaSelectata.imagine.Size.Height + 10);
                                    if (j != 0)
                                        noduri[i, j - 1, k].Image = ((PictureBox)(sender)).Image = global::Joc_Moara.Properties.Resources.SelectareNod;
                                    if (k != 0)
                                        noduri[i, j, k - 1].Image = ((PictureBox)(sender)).Image = global::Joc_Moara.Properties.Resources.SelectareNod;
                                    if (j != 2)
                                        noduri[i, j + 1, k].Image = ((PictureBox)(sender)).Image = global::Joc_Moara.Properties.Resources.SelectareNod;
                                    if (k != 2)
                                        noduri[i, j, k + 1].Image = ((PictureBox)(sender)).Image = global::Joc_Moara.Properties.Resources.SelectareNod;
                                    if (k == 1 || j == 1)
                                    {
                                        if (i != 0)
                                            noduri[i - 1, j, k].Image = ((PictureBox)(sender)).Image = global::Joc_Moara.Properties.Resources.SelectareNod;
                                        if (i != 2)
                                            noduri[i + 1, j, k].Image = ((PictureBox)(sender)).Image = global::Joc_Moara.Properties.Resources.SelectareNod;
                                    }
                                    selectareNod = true;
                                }
                        }
                    }
                }
            }
        }

        public void answere(string raspuns)
        {
            if (raspuns.Contains("adaugare"))
            {
                inAsteptare = false;
                AdaugareDTO adaugare = new AdaugareDTO(raspuns);
                Piesa piesaTemp = adaugare.getPiesaNeagraObj();
                piese[piesaTemp.imagine.Name[11] - 48, piesaTemp.imagine.Name[12] - 48, piesaTemp.imagine.Name[13] - 48] = piesaTemp;
                pieseNegreAdaugate++;
                pieseNegrePeTabla++;
                Action action = delegate
                {
                    this.Controls.Add(piesaTemp.imagine);
                    piesaTemp.imagine.BringToFront();
                    piesaTemp.imagine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.piesaMouseClick);
                };
                Invoke(action);
            }
            else if (raspuns.Contains("eliminarePrinAdaugare"))
            {
                inAsteptare = false;
                EliminarePrinAdaugareDTO eliminare = new EliminarePrinAdaugareDTO(raspuns);
                string piesaEliminata = null;
                Piesa piesaEliminataTemp = null;
                Piesa piesaAdaugataTemp = eliminare.getPiesaNeagraObj(ref piesaEliminata);
                piese[piesaAdaugataTemp.imagine.Name[11] - 48, piesaAdaugataTemp.imagine.Name[12] - 48, piesaAdaugataTemp.imagine.Name[13] - 48] = piesaAdaugataTemp;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (piese[i, j, k] != null)
                                if (piese[i, j, k].imagine.Name == piesaEliminata)
                                {
                                    piesaEliminataTemp = piese[i, j, k];
                                    break;
                                }
                        }
                    }
                }
                piese[piesaEliminataTemp.imagine.Name[9] - 48, piesaEliminataTemp.imagine.Name[10] - 48, piesaEliminataTemp.imagine.Name[11] - 48] = null;
                pieseNegreAdaugate++;
                pieseNegrePeTabla++;
                pieseAlbePeTabla--;
                Action action = delegate
                {
                    this.Controls.Add(piesaAdaugataTemp.imagine);
                    piesaEliminataTemp.imagine.Dispose();
                    piesaAdaugataTemp.imagine.BringToFront();
                    piesaAdaugataTemp.imagine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.piesaMouseClick);
                };
                Invoke(action);
            }

            /*MessageBox.Show("pieseAlbeAdaugate:" + pieseAlbeAdaugate.ToString() + "\npieseAlbePeTabla:" + pieseAlbePeTabla.ToString() +
                "\npieseNegreAdaugate:" + pieseNegreAdaugate.ToString() + "\npieseNegrePeTabla:" + pieseNegrePeTabla.ToString());*/
        }

        private bool verificareMoara(Piesa piesa)
        {
            int i = piesa.imagine.Name[9] - 48;
            int j = piesa.imagine.Name[10] - 48;
            int k = piesa.imagine.Name[11] - 48;

            bool ok = true;
            for (int i0 = 0; i0 < 3; i0++)
                if ((j == 1 || k == 1) && piese[i0, j, k] != null)
                {
                    if (!piese[i0, j, k].imagine.Name.Contains(piesa.imagine.Name.Substring(0, 9)))
                    {
                        ok = false;
                        break;
                    }
                }
                else
                {
                    ok = false;
                    break;
                }
            if (ok == true)
                return ok;

            ok = true;
            for (int j0 = 0; j0 < 3; j0++)
                if (piese[i, j0, k] != null)
                {
                    if (!piese[i, j0, k].imagine.Name.Contains(piesa.imagine.Name.Substring(0, 9)))
                    {
                        ok = false;
                        break;
                    }
                }
                else
                {
                    ok = false;
                    break;
                }
            if (ok == true)
                return ok;

            ok = true;
            for (int k0 = 0; k0 < 3; k0++)
                if (piese[i, j, k0] != null)
                {
                    if (!piese[i, j, k0].imagine.Name.Contains(piesa.imagine.Name.Substring(0, 9)))
                    {
                        ok = false;
                        break;
                    }
                }
                else
                {
                    ok = false;
                    break;
                }
            if (ok == true)
                return ok;

            return false;
        }
    }
}
