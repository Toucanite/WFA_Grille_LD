using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Grille_LD
{
    public partial class frmMain : Form
    {
        Grille maGrille1 = new Grille(new Point(10, 10), new Size(100, 100), 10, 10);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            maGrille1.Paint(sender, e);
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tmrTailleGrille.Enabled = true;
            }
            if(e.Button == MouseButtons.Right)
            {
                tmrPosGrille.Enabled = true;
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            tmrTailleGrille.Enabled = false;
            tmrPosGrille.Enabled = false;
        }

        private void tmrTailleGrille_Tick(object sender, EventArgs e)
        {
            // Créer un point qui correspond à la position de la souris
            // la "-this.location" permet d'avoir la position sur la fenetre et non pas sur l'écran
            Point mp = new Point(MousePosition.X - this.Location.X - maGrille1.Position.X, MousePosition.Y - this.Location.Y - maGrille1.Position.Y);

            // Switch de gael
            // Permet de sortir les bordure du calcul de la fenetre
            switch (FormBorderStyle)
            {
                case FormBorderStyle.Fixed3D:
                    mp.Offset(-10, -32);
                    break;
                case FormBorderStyle.FixedDialog:
                    mp.Offset(-8, -30);
                    break;
                case FormBorderStyle.FixedSingle:
                    mp.Offset(-8, -30);
                    break;
                case FormBorderStyle.FixedToolWindow:
                    mp.Offset(-8, -26);
                    break;
                case FormBorderStyle.None:
                    mp.Offset(0, 0);
                    break;
                case FormBorderStyle.Sizable:
                    mp.Offset(-8, -30);
                    break;
                case FormBorderStyle.SizableToolWindow:
                    mp.Offset(-8, -26);
                    break;
                default:
                    break;
            }

            // Attribue le point ou l'utilisateur à cliqué en tant que taille de la grille
            maGrille1.Taille = new Size(mp.X, mp.Y);
            Invalidate();
        }

        private void tmrPosGrille_Tick(object sender, EventArgs e)
        {
            // Créer un point qui correspond à la position de la souris
            // la "-this.location" permet d'avoir la position sur la fenetre et non pas sur l'écran
            Point mp = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);

            // Switch de gael
            // Permet de sortir les bordure du calcul de la fenetre
            switch (FormBorderStyle)
            {
                case FormBorderStyle.Fixed3D:
                    mp.Offset(-10, -32);
                    break;
                case FormBorderStyle.FixedDialog:
                    mp.Offset(-8, -30);
                    break;
                case FormBorderStyle.FixedSingle:
                    mp.Offset(-8, -30);
                    break;
                case FormBorderStyle.FixedToolWindow:
                    mp.Offset(-8, -26);
                    break;
                case FormBorderStyle.None:
                    mp.Offset(0, 0);
                    break;
                case FormBorderStyle.Sizable:
                    mp.Offset(-8, -30);
                    break;
                case FormBorderStyle.SizableToolWindow:
                    mp.Offset(-8, -26);
                    break;
                default:
                    break;
            }

            // Attribue le point ou l'utilisateur à cliqué en tant que taille de la grille
            maGrille1.Position = mp;
            Invalidate();
        }

        private void hsb_NbrCellulesHorizontal_Scroll(object sender, ScrollEventArgs e)
        {
            maGrille1.NombreCaseLargeur = e.NewValue;
            Invalidate();
        }

        private void vsb_NbrCellulesVertical_Scroll(object sender, ScrollEventArgs e)
        {
            maGrille1.NombreCaseHauteur = e.NewValue;
            Invalidate();
        }
    }
}
