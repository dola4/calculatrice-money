using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frmWinCsProjet1
{
    public partial class frmBureauDeChange : Form
    {
        public frmBureauDeChange()
        {
            InitializeComponent();
        }

        struct devise
        {
            public string pays;
            public string nom;
            public float taux;
        }

        devise[] tabDevises;
        int nbDevises;

        private void frmBureauDeChange_Load(object sender, EventArgs e)
        {
            tabDevises = new devise[35];
            StreamReader fichier = new StreamReader("infoDevise.txt");

            int i = 0;
            while (fichier.EndOfStream == false)
            {
                tabDevises[i].pays = fichier.ReadLine();
                tabDevises[i].nom = fichier.ReadLine();
                tabDevises[i].taux = Convert.ToSingle(fichier.ReadLine());
                i++;
            }
            nbDevises = i;
            fichier.Close();
            for (i = 0; i < nbDevises; i++)
            {
                lstPays.Items.Add(tabDevises[i].pays);
            }

            btnConvertir.Enabled = btnEffacer.Enabled = false;
        }

        private void lstPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paysChoisis;
            paysChoisis = lstPays.SelectedItem.ToString();
            for (int i = 0; i < nbDevises; i++)
            {
                if (paysChoisis == tabDevises[i].pays)
                {
                    radUS.Text = "De Dollars US à " + tabDevises[i].nom;
                    radDevise.Text = "De " + tabDevises[i].nom + " à Dollars US";
                    lblInfoUs.Text = "1 Dollars US = " + Convert.ToString(Math.Round(1 * tabDevises[i].taux,2)) + " " + tabDevises[i].nom;
                    lblInfoDevise.Text = "1 " + tabDevises[i].nom + " = " + Convert.ToString(Math.Round(1 / tabDevises[i].taux,2)) + " US";
                }
            }
        }

        private void radUS_CheckedChanged(object sender, EventArgs e)
        {
            string paysChoisis;
            paysChoisis = lstPays.SelectedItem.ToString();
            txtChiffre.Text = lblResultat.Text = "";

            for (int i = 0; i < nbDevises; i++)
            {
                if (paysChoisis == tabDevises[i].pays)
                {
                    if (radUS.Checked == true)
                    {
                        lblDeviseChoisie.Text = "Dollars US";
                        lblAutreDevise.Text = tabDevises[i].nom + " = ";
                    }
                    else
                    {
                        lblDeviseChoisie.Text = tabDevises[i].nom;
                        lblAutreDevise.Text = "Dollars US = ";
                    }
                }
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtChiffre.Text = lblResultat.Text = "";
            btnConvertir.Enabled = btnEffacer.Enabled = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string paysChoisis;
            Single chiffre, resultat;
            chiffre = Convert.ToSingle(txtChiffre.Text);
            paysChoisis = lstPays.SelectedItem.ToString();


            for (int i = 0; i < nbDevises; i++)
            {
                if(paysChoisis == tabDevises[i].pays)
                {
                    if (radUS.Checked == true)
                    {
                        resultat = chiffre * tabDevises[i].taux;
                        lblResultat.Text = Convert.ToString(Math.Round(resultat,2));

                    }
                    else
                    {
                        resultat = chiffre / tabDevises[i].taux;
                        lblResultat.Text = Convert.ToString(Math.Round(resultat,2));
                    }
                }
            }
        }

        private void txtChiffre_TextChanged(object sender, EventArgs e)
        {
            btnConvertir.Enabled = btnEffacer.Enabled = true;
        }
    }
}
