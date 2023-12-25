using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
            
        {
            
               
            
            double resultat = Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox2.Text);
            textBox1.Text = resultat.ToString();
        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double resultat = Convert.ToDouble(textBox3.Text) + Convert.ToDouble( textBox2.Text);
            textBox1.Text = resultat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultat = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox2.Text);
            textBox1.Text = resultat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double resultat = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox2.Text);

            textBox1.Text = resultat.ToString();
        }
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Quitter", MessageBoxButtons.YesNo);

            // Si l'utilisateur clique sur Oui, fermez la fenêtre
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double resultat = Convert.ToDouble(textBox3.Text) % Convert.ToDouble(textBox2.Text);
            textBox1.Text = resultat.ToString();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
