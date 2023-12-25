using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excice3TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculer_Click(object sender, EventArgs e)
        {
            // Vérification des saisies
            if (textBoxTp1.Text.Length == 0 || textBoxTp2.Text.Length == 0 ||
                textBoxTp3.Text.Length == 0 || textBoxPratique.Text.Length == 0 ||
                textBoxFinal.Text.Length == 0)
            {
                MessageBox.Show("Veuillez saisir toutes les notes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conversion des notes en nombres
            int tp1 = Convert.ToInt32(textBox1.Text);
            int tp2 = Convert.ToInt32(textBox2.Text);
            int tp3 = Convert.ToInt32(textBox3.Text);
            int pratique = Convert.ToInt32(textBox4.Text);
            int final = Convert.ToInt32(textBox6.Text);

            // Calcul de la note globale
            int totalTp = tp1 + tp2 + tp3;
            double noteGlobale = (float)totalTp * 0.4 + (float)pratique * 0.2 + (float)final * 0.4;

            // Calcul de la lettre
            char lettre;
            if (noteGlobale < 50)
            {
                lettre = 'E';
            }
            else if (noteGlobale < 60)
            {
                lettre = 'D';
            }
            else if (noteGlobale < 70)
            {
                lettre = 'C';
            }
            else if (noteGlobale < 80)
            {
                lettre = 'B';
            }
            else
            {
                lettre = 'A';
            }

            // Affichage de la note globale et de la lettre
            labelNoteGlobale.Text = noteGlobale.ToString();
            labelLettre.Text = lettre.ToString();
        }
    }
}
