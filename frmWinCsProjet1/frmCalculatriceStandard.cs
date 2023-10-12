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
    public partial class frmCalculatriceStandard : Form
    {

        private Single memoire;

        public frmCalculatriceStandard()
        {
            InitializeComponent();
            btnMC.Enabled = btnMR.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "1";
            }
            else
            {
                lblResultat.Text += "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "2";
            }
            else
            {
                lblResultat.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "3";
            }
            else
            {
                lblResultat.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "4";
            }
            else
            {
                lblResultat.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "5";
            }
            else
            {
                lblResultat.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "6";
            }
            else
            {
                lblResultat.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "7";
            }
            else
            {
                lblResultat.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "8";
            }
            else
            {
                lblResultat.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "9";
            }
            else
            {
                lblResultat.Text += "0";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = "0";
            }
            else
            {
                lblResultat.Text += "0";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            lblResultat.Text += ",";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblResultat.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblResultat.Text = "0";
            lblCalcul.Text = "0";
        }

        private void btmPlus_Click(object sender, EventArgs e)
        {
            float calcul;
            if (lblResultat.Text.Substring(0, 1) == "0")
            {
                lblResultat.Text = lblResultat.Text.Remove(0, 1);
            }

            if (lblCalcul.Text == "0" || lblCalcul.Text == "")
            {
                lblCalcul.Text = lblResultat.Text + "+";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("+") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                calcul += Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "+";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("-") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("-")));
                calcul -= Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "+";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("*") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                calcul *= Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "+";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("/") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                calcul += Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "+";
                lblResultat.Text = "";
            }
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            float calcul;
            if (lblResultat.Text.Substring(0, 1) == "0")
            {
                lblResultat.Text = lblResultat.Text.Remove(0, 1);
            }

            if (lblCalcul.Text == "0" || lblCalcul.Text == "")
            {
                lblCalcul.Text = lblResultat.Text + "-";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("+") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                calcul += Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "-";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("-") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("-")));
                calcul -= Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "-";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("*") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                calcul *= Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "-";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("/") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                calcul += Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "-";
                lblResultat.Text = "";
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            float calcul;

            if (lblResultat.Text.Substring(0, 1) == "0")
            {
                lblResultat.Text = lblResultat.Text.Remove(0, 1);
            }

            if (lblCalcul.Text == "0" || lblCalcul.Text == "")
            {
                lblCalcul.Text = lblResultat.Text + "*";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("+") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                calcul += Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "*";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("-") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("-")));
                calcul -= Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "*";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("*") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                calcul *= Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "*";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("/") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                calcul += Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "*";
                lblResultat.Text = "";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            float calcul;

            if (lblResultat.Text.Substring(0, 1) == "0")
            {
                lblResultat.Text = lblResultat.Text.Remove(0, 1);
            }

            if (lblCalcul.Text == "0" || lblCalcul.Text == "")
            {
                lblCalcul.Text = lblResultat.Text + "/";
                lblResultat.Text = "";
            }

            else if (lblCalcul.Text.Contains("+") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                calcul += Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "/";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("-") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("-")));
                calcul -= Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "/";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("*") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                calcul *= Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "/";
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("/") == true)
            {
                calcul = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                calcul += Convert.ToSingle(lblResultat.Text);
                lblCalcul.Text = Convert.ToString(calcul) + "/";
                lblResultat.Text = "";
            }
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            float premier, deuxieme, calcul;
            if (lblCalcul.Text == "0" || lblCalcul.Text == "")
            {
                lblCalcul.Text = lblResultat.Text;
                lblResultat.Text = "";
            }
            else if (lblCalcul.Text.Contains("+") == true)
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                deuxieme = Convert.ToSingle(lblResultat.Text);
                calcul = premier + deuxieme;
                lblCalcul.Text = Convert.ToString(premier) + "+" + Convert.ToString(deuxieme) + "=";
                lblResultat.Text = Convert.ToString(calcul);
            }
            else if (lblCalcul.Text.Contains("-") == true)
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("-")));
                deuxieme = Convert.ToSingle(lblResultat.Text);
                calcul = premier - deuxieme;
                lblCalcul.Text = Convert.ToString(premier) + "-" + Convert.ToString(deuxieme) + "=";
                lblResultat.Text = Convert.ToString(calcul);
            }
            else if (lblCalcul.Text.Contains("*") == true)
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                deuxieme = Convert.ToSingle(lblResultat.Text);
                calcul = premier * deuxieme;
                lblCalcul.Text = Convert.ToString(premier) + "*" + Convert.ToString(deuxieme) + "=";
                lblResultat.Text = Convert.ToString(calcul);
            }
            else if (lblCalcul.Text.Contains("/") == true)
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                deuxieme = Convert.ToSingle(lblResultat.Text);
                calcul = premier / deuxieme;
                lblCalcul.Text = Convert.ToString(premier) + "/" + Convert.ToString(deuxieme) + "=";
                lblResultat.Text = Convert.ToString(calcul);
            }
        }

        private void btnPlusMoins_Click(object sender, EventArgs e)
        {
            string chiffre, moins = "-";
            chiffre = lblResultat.Text;

            if (chiffre.Contains("-"))
            {
                chiffre = chiffre.Remove(0, 1);
                lblResultat.Text = chiffre;

            }
            else
            {
                lblResultat.Text = moins + chiffre;
            }


        }

        private void btnPourcent_Click(object sender, EventArgs e)
        {
            float premier, deuxieme, pourcent, resultat;

            if (lblResultat.Text.Substring(0, 1) == "0")
            {
                lblResultat.Text = lblResultat.Text.Remove(0, 1);
            }

            deuxieme = Convert.ToSingle(lblResultat.Text);

            if (lblCalcul.Text.Contains("+") == true)
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                pourcent = premier / 100 * deuxieme;
                resultat = premier + pourcent;
                lblResultat.Text = Convert.ToString(pourcent);
                lblCalcul.Text = Convert.ToString(premier) + "+" + Convert.ToString(pourcent);
            }
            else if (lblCalcul.Text.Contains("-") == true)
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("-")));
                pourcent = premier / 100 * deuxieme;
                resultat = premier - pourcent;
                lblResultat.Text = Convert.ToString(pourcent);
                lblCalcul.Text = Convert.ToString(premier) + "-" + Convert.ToString(pourcent);
            }
            else if (lblCalcul.Text.Contains("*") == true)
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                pourcent = premier / 100;
                resultat = premier * pourcent;
                lblResultat.Text = Convert.ToString(pourcent);
                lblCalcul.Text = Convert.ToString(premier) + "*" + Convert.ToString(pourcent);
            }
            if (lblCalcul.Text.Contains("/") == true)
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                pourcent = premier / 100;
                resultat = premier / pourcent;
                lblResultat.Text = Convert.ToString(pourcent);
                lblCalcul.Text = Convert.ToString(premier) + "/" + Convert.ToString(pourcent);
            }
        }

        private void btnXe2_Click(object sender, EventArgs e)
        {
            float chiffre, premier, resultat, resultatFinal;

            if (lblResultat.Text.Substring(0, 1) == "0")
            {
                lblResultat.Text = lblResultat.Text.Remove(0, 1);
            }

            chiffre = Convert.ToSingle(lblResultat.Text);
            resultat = chiffre * chiffre;

            if (lblCalcul.Text == "0")
            {
                lblCalcul.Text = "sqr (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("+"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                resultatFinal = premier + resultat;
                lblCalcul.Text += "sqr (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("-"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(1, lblCalcul.Text.IndexOf("-")));
                resultatFinal = premier - resultat;
                lblCalcul.Text += "sqr (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("*"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                resultatFinal = premier * resultat;
                lblCalcul.Text += "sqr (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("/"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                resultatFinal = premier / resultat;
                lblCalcul.Text += "sqr (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            };
        }

        private void btn1SurX_Click(object sender, EventArgs e)
        {
            float chiffre, resultat, premier, resultatFinal;
            chiffre = Convert.ToSingle(lblResultat.Text);
            resultat = 1 / chiffre;

            if (lblCalcul.Text.Length == 0 || lblCalcul.Text == "0")
            {
                lblCalcul.Text = "1/(" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("+"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                resultatFinal = premier + resultat;
                lblCalcul.Text += " 1/(" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("-"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(1, lblCalcul.Text.IndexOf("-")));
                resultatFinal = premier - resultat;
                lblCalcul.Text += " 1/(" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("*"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                resultatFinal = premier * resultat;
                lblCalcul.Text += " 1/(" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("/"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                resultatFinal = premier / resultat;
                lblCalcul.Text += " 1/(" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblResultat.Text.Length > 1)
            {
                lblResultat.Text = lblResultat.Text.Remove(lblResultat.Text.Length - 1);
            }
            else
            {
                lblResultat.Text = "0";
            }
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memoire = Convert.ToSingle(lblResultat.Text);
            btnMC.Enabled = btnMR.Enabled = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            lblResultat.Text = Convert.ToString(memoire);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            lblResultat.Text = "0";
            memoire = 0;
            btnMR.Enabled = btnMC.Enabled = false;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memoire += Convert.ToSingle(lblResultat.Text);
        }

        private void btnMMoin_Click(object sender, EventArgs e)
        {
            memoire -= Convert.ToSingle(lblResultat.Text);
        }

        private void btnCarre_Click(object sender, EventArgs e)
        {
            Single chiffre, resultat, premier, resultatFinal;
            chiffre = Convert.ToSingle(lblResultat.Text);
            resultat = (float)Math.Sqrt(chiffre);


            if (lblCalcul.Text == "0")
            {
                lblCalcul.Text = "rac (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("+"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("+")));
                resultatFinal = premier + resultat;
                lblCalcul.Text += "rac (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("-"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("-")));
                resultatFinal = premier - resultat;
                lblCalcul.Text += "rac (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("*"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("*")));
                resultatFinal = premier * resultat;
                lblCalcul.Text += "rac (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
            else if (lblCalcul.Text.Contains("/"))
            {
                premier = Convert.ToSingle(lblCalcul.Text.Substring(0, lblCalcul.Text.IndexOf("/")));
                resultatFinal = premier / resultat;
                lblCalcul.Text += "rac (" + Convert.ToString(chiffre) + ")";
                lblResultat.Text = Convert.ToString(resultat);
            }
        }
    }
}
