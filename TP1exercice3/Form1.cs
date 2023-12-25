using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1exercice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


   

        }

        private void button4_Click(object sender, EventArgs e)

        {
            // Vérifier et convertir les notes saisies
            if (double.TryParse(textBox1.Text, out double tp1) &&
                double.TryParse(textBox2.Text, out double tp2) &&
                double.TryParse(textBox3.Text, out double tp3) &&
                double.TryParse(textBox4.Text, out double pratique) &&
                double.TryParse(textBox5.Text, out double final))
            {
                // Vérifier que les notes sont dans la plage autorisée
                if (tp1 >= 0 && tp2 >= 0 && tp3 >= 0 && pratique >= 0 && final >= 0 &&
                    tp1 <= 25 && tp2 <= 35 && tp3 <= 40 && pratique <= 100 && final <= 100)
                {
                    // Calcul de la note globale
                    double totalTP = tp1 + tp2 + tp3;
                    double noteGlobale = (totalTP * 0.4) + (pratique * 0.2) + (final * 0.4);
                    label11.Text = $" {totalTP:F2}";
                    // Affichage de la lettre correspondante
                    if (noteGlobale < 50)
                        label12.Text = "E";
                    else if (noteGlobale < 60)
                        label12.Text = "D";
                    else if (noteGlobale < 70)
                        label12.Text = "C";
                    else if (noteGlobale < 80)
                        label12.Text = "B";
                    else
                        label12.Text = "A";

                    label10.Text = $" {noteGlobale:F2}";
                }
                else
                    MessageBox.Show("Veuillez saisir des notes dans la plage autorisée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Veuillez saisir des valeurs numériques valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                // Code pour quitter l'application
                Application.Exit();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Supprimer le contenu des champs texte
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            // Réinitialiser les labels
            label10.Text = "Note Globale :";
            label11.Text = "totalTP :";
            label12.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exercice4Form = new TP1exercice4.Form1();
            exercice4Form.Show();
        }
    }
}
        
    

