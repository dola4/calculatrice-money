namespace frmWinCsProjet1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScientifique = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.versionEnLigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmesToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            this.programmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatriceToolStripMenuItem,
            this.bureauChangeToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnuQuitter});
            this.programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            this.programmesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.programmesToolStripMenuItem.Text = "Programmes";
            // 
            // calculatriceToolStripMenuItem
            // 
            this.calculatriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStandard,
            this.mnuScientifique});
            this.calculatriceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatriceToolStripMenuItem.Image")));
            this.calculatriceToolStripMenuItem.Name = "calculatriceToolStripMenuItem";
            this.calculatriceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculatriceToolStripMenuItem.Text = "Calculatrice";
            // 
            // mnuStandard
            // 
            this.mnuStandard.Name = "mnuStandard";
            this.mnuStandard.Size = new System.Drawing.Size(177, 22);
            this.mnuStandard.Text = "Version Standard";
            this.mnuStandard.Click += new System.EventHandler(this.mnuStandard_Click);
            // 
            // mnuScientifique
            // 
            this.mnuScientifique.Name = "mnuScientifique";
            this.mnuScientifique.Size = new System.Drawing.Size(177, 22);
            this.mnuScientifique.Text = "Version Scientifique";
            // 
            // bureauChangeToolStripMenuItem
            // 
            this.bureauChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangeLocal,
            this.versionEnLigneToolStripMenuItem});
            this.bureauChangeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bureauChangeToolStripMenuItem.Image")));
            this.bureauChangeToolStripMenuItem.Name = "bureauChangeToolStripMenuItem";
            this.bureauChangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bureauChangeToolStripMenuItem.Text = "Bureau Change";
            // 
            // mnuChangeLocal
            // 
            this.mnuChangeLocal.Name = "mnuChangeLocal";
            this.mnuChangeLocal.Size = new System.Drawing.Size(180, 22);
            this.mnuChangeLocal.Text = "Version Local";
            this.mnuChangeLocal.Click += new System.EventHandler(this.mnuChangeLocal_Click);
            // 
            // versionEnLigneToolStripMenuItem
            // 
            this.versionEnLigneToolStripMenuItem.Enabled = false;
            this.versionEnLigneToolStripMenuItem.Name = "versionEnLigneToolStripMenuItem";
            this.versionEnLigneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionEnLigneToolStripMenuItem.Text = "Version En Ligne";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.Size = new System.Drawing.Size(180, 22);
            this.mnuQuitter.Text = "Quitter Programme";
            this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewsToolStripMenuItem.Text = "View";
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.Checked = true;
            this.toolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.toolbarToolStripMenuItem.Text = "Toolbar";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelUtilisateurToolStripMenuItem,
            this.toolStripSeparator2,
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // manuelUtilisateurToolStripMenuItem
            // 
            this.manuelUtilisateurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manuelUtilisateurToolStripMenuItem.Image")));
            this.manuelUtilisateurToolStripMenuItem.Name = "manuelUtilisateurToolStripMenuItem";
            this.manuelUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manuelUtilisateurToolStripMenuItem.Text = "Manuel Utilisateur";
            this.manuelUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.manuelUtilisateurToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aProposToolStripMenuItem.Text = "A propos ...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(805, 496);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStandard;
        private System.Windows.Forms.ToolStripMenuItem bureauChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeLocal;
        private System.Windows.Forms.ToolStripMenuItem versionEnLigneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuScientifique;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}