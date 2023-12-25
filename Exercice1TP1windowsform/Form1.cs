using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice1TP1windowsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            
                InitializeComponent();

                // Définit le texte du bouton
                button1.Text = "Surface d'un rectangle";

                // Définit l'événement Click du bouton
                button1.Click += new EventHandler(this.buttonSurface_Click);
            }

            private void buttonSurface_Click(object sender, EventArgs e)
            {
                // Récupère les valeurs saisies par l'utilisateur
                int largeur = Convert.ToInt32(textBox2.Text);
                int hauteur = Convert.ToInt32(textBox1.Text);

            // Calcule la surface
            float surface = (largeur * hauteur);

                // Affiche la surface
                label3.Text = surface.ToString();
            }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
