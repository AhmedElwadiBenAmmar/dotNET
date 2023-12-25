using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;

namespace Exercice2Atelier4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            try
            {
                double prixUnitaire, qtt, tva;

                if (double.TryParse(TextBox2.Text, out prixUnitaire) &&
                    double.TryParse(TextBox3.Text, out qtt) &&
                    double.TryParse(TextBox4.Text, out tva))
                {
                    double ht = prixUnitaire * qtt;
                    double ttc = ht * (100 + tva) / 100;
                    Label5.Text = "Nom de la commande : " + TextBox1.Text + "<br/>" +
                                  "Prix HT : " + ht.ToString() + "<br/>" +
                                  "Prix TTC : " + ttc.ToString() + "<br/>";
                }
                else
                {
                    Label5.Text = "Veuillez saisir des valeurs numériques valides.";
                }
            }
            catch (Exception ex)
            {
                Label5.Text = "Une erreur s'est produite : " + ex.Message;
            }
        }
    }
}