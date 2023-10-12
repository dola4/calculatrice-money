using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmWinCsProjet1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuStandard_Click(object sender, EventArgs e)
        {
            frmCalculatriceStandard fc = new frmCalculatriceStandard();
            fc.MdiParent = this;
            fc.Show();
        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            string message = "Êtes-vous sur de vouloir fermer cette application?";
            string titre = "fermeture du programme.";

            if (MessageBox.Show(message, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void manuelUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com/fr-fr/windows/calculatrice-de-windows-10-8dc0eb59-a45f-72b6-71bd-e752920f36c3#:~:text=Pour%20commencer%2C%20s%C3%A9lectionnez%20le%20bouton,pour%20basculer%20entre%20les%20modes.");
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fr.wikipedia.org/wiki/Calculatrice_(Windows)");
        }

        private void mnuChangeLocal_Click(object sender, EventArgs e)
        {
            frmBureauDeChange fc = new frmBureauDeChange();
            fc.MdiParent = this;
            fc.Show();
        }
    }
}
