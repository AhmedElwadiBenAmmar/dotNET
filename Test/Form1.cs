using System;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private Button btnTest;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialisation du formulaire
            Text = "Mon premier formulaire";
            Size = new System.Drawing.Size(300, 100);

            // Création du bouton
            btnTest = new Button();
            btnTest.Location = new System.Drawing.Point(110, 20);
            btnTest.Size = new System.Drawing.Size(80, 30);
            btnTest.Text = "Test";

            // Ajout du bouton au formulaire
            Controls.Add(btnTest);

            // Gestion de l'événement Click
            btnTest.Click += btnTest_Click;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Affiche une boîte de dialogue
            MessageBox.Show("Clic sur bouton", "Clic sur bouton", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}