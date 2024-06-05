namespace Festival
{
    partial class Form1
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
            this.panelGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichagePetitesCartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageLargesCartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            

            this.panelGroups.AutoScroll = true;
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(0, 28);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(800, 422);
            this.panelGroups.TabIndex = 0;
            

            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            

            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichagePetitesCartesToolStripMenuItem,
            this.affichageLargesCartesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
           

            this.affichagePetitesCartesToolStripMenuItem.Name = "affichagePetitesCartesToolStripMenuItem";
            this.affichagePetitesCartesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.affichagePetitesCartesToolStripMenuItem.Text = "Affichage : petites cartes";
            this.affichagePetitesCartesToolStripMenuItem.Click += new System.EventHandler(this.affichagePetitesCartesToolStripMenuItem_Click);
            

            this.affichageLargesCartesToolStripMenuItem.Name = "affichageLargesCartesToolStripMenuItem";
            this.affichageLargesCartesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.affichageLargesCartesToolStripMenuItem.Text = "Affichage : larges cartes";
            this.affichageLargesCartesToolStripMenuItem.Click += new System.EventHandler(this.affichageLargesCartesToolStripMenuItem_Click);
            

            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Festival";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();


            this.affichagePetitesCartesToolStripMenuItem.Click += new System.EventHandler(this.affichagePetitesCartesToolStripMenuItem_Click);
            this.affichageLargesCartesToolStripMenuItem.Click += new System.EventHandler(this.affichageLargesCartesToolStripMenuItem_Click);
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelGroups;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichagePetitesCartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageLargesCartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
