namespace WFA_Grille_LD
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTailleGrille = new System.Windows.Forms.Timer(this.components);
            this.tmrPosGrille = new System.Windows.Forms.Timer(this.components);
            this.hsb_NbrCellulesHorizontal = new System.Windows.Forms.HScrollBar();
            this.vsb_NbrCellulesVertical = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // tmrTailleGrille
            // 
            this.tmrTailleGrille.Tick += new System.EventHandler(this.tmrTailleGrille_Tick);
            // 
            // tmrPosGrille
            // 
            this.tmrPosGrille.Tick += new System.EventHandler(this.tmrPosGrille_Tick);
            // 
            // hsb_NbrCellulesHorizontal
            // 
            this.hsb_NbrCellulesHorizontal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hsb_NbrCellulesHorizontal.Location = new System.Drawing.Point(0, 502);
            this.hsb_NbrCellulesHorizontal.Maximum = 500;
            this.hsb_NbrCellulesHorizontal.Name = "hsb_NbrCellulesHorizontal";
            this.hsb_NbrCellulesHorizontal.Size = new System.Drawing.Size(876, 17);
            this.hsb_NbrCellulesHorizontal.TabIndex = 0;
            this.hsb_NbrCellulesHorizontal.Value = 10;
            this.hsb_NbrCellulesHorizontal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_NbrCellulesHorizontal_Scroll);
            // 
            // vsb_NbrCellulesVertical
            // 
            this.vsb_NbrCellulesVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.vsb_NbrCellulesVertical.Location = new System.Drawing.Point(859, 0);
            this.vsb_NbrCellulesVertical.Maximum = 500;
            this.vsb_NbrCellulesVertical.Name = "vsb_NbrCellulesVertical";
            this.vsb_NbrCellulesVertical.Size = new System.Drawing.Size(17, 502);
            this.vsb_NbrCellulesVertical.TabIndex = 1;
            this.vsb_NbrCellulesVertical.Value = 10;
            this.vsb_NbrCellulesVertical.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsb_NbrCellulesVertical_Scroll);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 519);
            this.Controls.Add(this.vsb_NbrCellulesVertical);
            this.Controls.Add(this.hsb_NbrCellulesHorizontal);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTailleGrille;
        private System.Windows.Forms.Timer tmrPosGrille;
        private System.Windows.Forms.HScrollBar hsb_NbrCellulesHorizontal;
        private System.Windows.Forms.VScrollBar vsb_NbrCellulesVertical;
    }
}

