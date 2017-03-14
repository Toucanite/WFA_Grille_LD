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
        Grille maGrille1 = new Grille(new Point(20, 20), new Size(100, 100), 10, 10);
        Grille maGrille2 = new Grille(new Point(150, 20), new Size(200, 100), 10, 10);
        Grille maGrille3 = new Grille(new Point(20, 150), new Size(330, 200), 45, 10);
        Grille maGrille4 = new Grille(new Point(370, 20), new Size(200, 330), 3, 80);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            maGrille1.Paint(sender, e);
            maGrille2.Paint(sender, e);
            maGrille3.Paint(sender, e);
            maGrille4.Paint(sender, e);
            Grille t = new Grille();
        }
    }
}
