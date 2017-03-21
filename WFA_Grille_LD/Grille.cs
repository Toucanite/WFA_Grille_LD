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

        /// <summary>
        /// Créer une grille avec les valeurs par défaut 
        /// en position X   : 50
        ///             Y   : 50
        ///             
        /// Taille      Width   : 100px 
        ///             Height  : 100px
        ///             
        /// Cases       en largeur  : 10
        ///             en hauteur  : 10
        /// </summary>
        public Grille() : this(new Point(50,50), new Size(100,100), 10, 10)
        {
        }

        /// <summary>
        /// Créer une grille avec les valeurs données en paramètres
        /// </summary>
        /// <param name="posX">La position X du point d'ou sera déssiné la grille</param>
        /// <param name="posY">La position Y du point d'ou sera déssiné la grille</param>
        /// <param name="tailleWidth">La hauteur en pixel de la grille</param>
        /// <param name="tailleHeight">La largeur en pixel de la grille</param>
        /// <param name="nbrCaseX">Le nombre de case sur l'axe X</param>
        /// <param name="nbrCaseY">Le nombre de case sur l'axe Y</param>
        public Grille(int posX, int posY, int tailleWidth, int tailleHeight, int nbrCaseX, int nbrCaseY)
        {
            position.X = posX;
            position.Y = posY;
            taille.Width = tailleWidth;
            taille.Height = tailleHeight;
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

        /// <summary>
        /// Créer une grille avec les valeurs données en paramètres
        /// </summary>
        /// <param name="position">Utilise le point pour dessiner la grille</param>
        /// <param name="taille">Utilise la taille pour dessiner la grille</param>
        /// <param name="nbrCaseX">Le nombre de case sur l'axe X</param>
        /// <param name="nbrCaseY">Le nombre de case sur l'axe Y</param>
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

        /// <summary>
        /// Position de la grille
        /// </summary>
        public Point Position
        {
            get { 
                return position; 
            }
            set { 
                position = value;
                MajTables();
            }
        }

        /// <summary>
        /// Taille de la grille
        /// </summary>
        public Size Taille
        {
            get { 
                return taille; 
            }
            set { 
                taille = value;
                MajTables();
            }
        }

        /// <summary>
        /// Nombre de cases en largeur
        /// </summary>
        public int NombreCaseLargeur
        {
            get { 
                return nbrCaseX; 
            }
            set { 
                nbrCaseX = value;
                tPointsCaseX = new PointF[nbrCaseX, 2];
                MajTables();
            }
        }

        /// <summary>
        /// Nombre de cases en hauteur
        /// </summary>
        public int NombreCaseHauteur
        {
            get { 
                return nbrCaseY; 
            }
            set { 
                nbrCaseY = value;
                tPointsCaseY = new PointF[nbrCaseY, 2];
                MajTables();
            }
        }

        /// <summary>
        /// Met à jour les tables de points utilisée pour dessiner les traits qui divise la grille
        /// </summary>
        private void MajTables()
        {
            
            

            tailleCaseX = taille.Width / (float)nbrCaseX;
            tailleCaseY = taille.Height / (float)nbrCaseY;

            for (int i = 0; i < nbrCaseX; i++)
            {
                tPointsCaseX[i, 0] = new PointF(position.X + i * tailleCaseX, position.Y);
                tPointsCaseX[i, 1] = new PointF(position.X + i * tailleCaseX, position.Y + taille.Height);
            }

            for (int i = 0; i < nbrCaseY; i++)
            {
                tPointsCaseY[i, 0] = new PointF(position.X, position.Y + i * tailleCaseY);
                tPointsCaseY[i, 1] = new PointF(position.X + taille.Width, position.Y + i * tailleCaseY);
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
