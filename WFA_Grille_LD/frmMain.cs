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
        Grille maGrille = new Grille(new Point(20, 20), new Size(300, 200), 45, 5);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            maGrille.Paint(sender, e);
        }
    }
}
