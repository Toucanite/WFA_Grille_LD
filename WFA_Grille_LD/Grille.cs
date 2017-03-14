using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Grille_LD
{
    class Grille
    {
        Point position;
        Size taille;
        float tailleCaseX, tailleCaseY; 
        int nbrCaseX, nbrCaseY;
        PointF[,] tPointsCaseX, tPointsCaseY;

        public Grille(Point position, Size taille, int nbrCaseX, int nbrCaseY)
        {
            this.position = position;
            this.taille = taille;
            this.tailleCaseX = taille.Width / (float)nbrCaseX;
            this.tailleCaseY = taille.Height / (float)nbrCaseY;
            this.nbrCaseX = nbrCaseX;
            this.nbrCaseY = nbrCaseY;
            this.tPointsCaseX = new PointF[nbrCaseX, 2];
            this.tPointsCaseY = new PointF[nbrCaseY, 2];

            for (int i = 0; i < nbrCaseX; i++)
            {
                this.tPointsCaseX[i, 0] = new PointF(position.X + i * tailleCaseX, position.Y);
                this.tPointsCaseX[i, 1] = new PointF(position.X + i * tailleCaseX, position.Y + taille.Height);
            }

            for (int i = 0; i < nbrCaseY; i++)
            {
                this.tPointsCaseY[i, 0] = new PointF(position.X, position.Y + i * tailleCaseY);
                this.tPointsCaseY[i, 1] = new PointF(position.X + taille.Width, position.Y + i * tailleCaseY);
            }

        }


        public void Paint(object sender, PaintEventArgs e)
        {
            Rectangle table = new Rectangle(position, taille);
            e.Graphics.DrawRectangle(Pens.Black, table);

            for (int i = 0; i < nbrCaseX; i++)
			{
                e.Graphics.DrawLine(Pens.Black, tPointsCaseX[i, 0], tPointsCaseX[i, 1]);
			}

            for (int i = 0; i < nbrCaseY; i++)
            {
                e.Graphics.DrawLine(Pens.Black, tPointsCaseY[i, 0], tPointsCaseY[i, 1]);
            }

        }
    }
}
