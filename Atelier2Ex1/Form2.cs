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

namespace Atelier2Ex1
{
    public partial class Form2 : Form
    {
        
        private double prixBase = 100; 
        private double prixHt = 100.0;

        public Form2()
        {
            InitializeComponent();

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String a = (String)listBox2.SelectedItem;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)

        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }






        private void CalculateTotalCost()
        {
            string classe = listBox2.SelectedItem as string;

            if (classe != null)
            {
                MessageBox.Show($"Classe sélectionnée : {classe}");

                string carteType = listBox1.SelectedItem as string;

                if (double.TryParse(textBox1.Text, out double prixBase))
                {
                    double prixHt = classe.Equals("premiere classe") ? prixBase * 1.2 : prixBase;

                    if (carteType != null)
                    {
                        switch (carteType)
                        {
                            case "carte famille":
                                prixHt /= 2;
                                break;
                            case "carte jeune":
                                prixHt *= 0.6;
                                break;
                            case "carte adulte":
                                prixHt *= 0.7;
                                break;
                        }


                    }

                    double ttc = prixHt * 1.2;

                    textBox3.Text = prixHt.ToString();
                    textBox4.Text = "20%";
                    textBox5.Text = ttc.ToString();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un prix de base  valide.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe.");
            }

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
