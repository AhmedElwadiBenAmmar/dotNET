using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormulaireAvecTableau
{
    public partial class Form1 : Form
    {
        // Une liste pour stocker les données des utilisateurs
        private List<Utilisateur> utilisateurs = new List<Utilisateur>();

        // Composants d'interface graphique
        private Label labelNom;
        private TextBox textBoxNom;
        private Label labelPrenom;
        private TextBox textBoxPrenom;
        private Label labelCIN;
        private TextBox textBoxCIN;
        private Label labelDateNaissance;
        private DateTimePicker dateTimePickerDateNaissance;
        private Label labelLieu;
        private TextBox textBoxLieu;
        private Label labelCodePostal;
        private TextBox textBoxCodePostal;
        private Button buttonAjouter;
        private DataGridView dataGridViewUtilisateurs;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            // Initialiser les composants générés par le concepteur Windows Forms
            // ...
            // Suite des composants d'interface graphique
            this.textBoxNom = new TextBox();
            this.textBoxPrenom = new TextBox();
            this.labelCIN = new Label();
            this.textBoxCIN = new TextBox();
            this.labelDateNaissance = new Label();
            this.dateTimePickerDateNaissance = new DateTimePicker();
            this.labelLieu = new Label();
            this.textBoxLieu = new TextBox();
            this.labelCodePostal = new Label();
            this.textBoxCodePostal = new TextBox();
            this.buttonAjouter = new Button();
            this.dataGridViewUtilisateurs = new DataGridView();
            // Ajouter ces lignes dans la méthode InitializeComponent ou ailleurs avant d'ajouter des lignes à votre DataGridView
            dataGridViewUtilisateurs.Columns.Add("Nom", "Nom");
            dataGridViewUtilisateurs.Columns.Add("Prenom", "Prénom");
            dataGridViewUtilisateurs.Columns.Add("CIN", "CIN");
            dataGridViewUtilisateurs.Columns.Add("DateNaissance", "Date de Naissance");
            dataGridViewUtilisateurs.Columns.Add("Lieu", "Lieu");
            dataGridViewUtilisateurs.Columns.Add("CodePostal", "Code Postal");
            this.dataGridViewUtilisateurs.BackgroundColor = System.Drawing.Color.White;


            // Configuration des composants graphiques
            ConfigureLabelAndTextBox(ref labelNom, "Nom", 20);
            ConfigureLabelAndTextBox(ref labelPrenom, "Prénom", 50);
            ConfigureLabelAndTextBox(ref labelCIN, "CIN", 80);
            // ConfigureLabelAndTextBox pour d'autres champs nécessaires

            labelDateNaissance = new Label();
            labelDateNaissance.AutoSize = true;
            labelDateNaissance.Location = new System.Drawing.Point(50, 110);
            labelDateNaissance.Text = "Date de Naissance :";
            this.Controls.Add(labelDateNaissance);

            dateTimePickerDateNaissance = new DateTimePicker();
            dateTimePickerDateNaissance.Location = new System.Drawing.Point(150, 110);
            dateTimePickerDateNaissance.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(dateTimePickerDateNaissance);

            ConfigureLabelAndTextBox(ref labelLieu, "Lieu", 140);
            ConfigureLabelAndTextBox(ref labelCodePostal, "Code Postal", 170);

            buttonAjouter = new Button();
            buttonAjouter.Location = new System.Drawing.Point(150, 200);
            buttonAjouter.Size = new System.Drawing.Size(75, 23);
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.Click += new EventHandler(buttonAjouter_Click);
            this.Controls.Add(buttonAjouter);

            dataGridViewUtilisateurs = new DataGridView();
            dataGridViewUtilisateurs.Location = new System.Drawing.Point(400, 20);
            dataGridViewUtilisateurs.Size = new System.Drawing.Size(400, 300);
            this.Controls.Add(dataGridViewUtilisateurs);


            // Initialisation des composants ajoutés
            InitializeInterfaceComponents();

            void InitializeInterfaceComponents()
            {
                // Configuration des composants graphiques
                ConfigureLabelAndTextBox(ref labelNom, "Nom", 20);
                ConfigureLabelAndTextBox(ref labelPrenom, "Prénom", 50);
                // ...

                buttonAjouter = new Button();
                buttonAjouter.Location = new System.Drawing.Point(150, 200);
                buttonAjouter.Size = new System.Drawing.Size(75, 23);
                buttonAjouter.Text = "Ajouter";
                buttonAjouter.Click += new EventHandler(buttonAjouter_Click);

                // ...

                this.dataGridViewUtilisateurs = new DataGridView();
                this.dataGridViewUtilisateurs.Location = new System.Drawing.Point(400, 20);
                this.dataGridViewUtilisateurs.Size = new System.Drawing.Size(400, 300);
               

                // Ajouter ces lignes pour configurer les colonnes du DataGridView
                this.dataGridViewUtilisateurs.Columns.Add("Nom", "Nom");
                this.dataGridViewUtilisateurs.Columns.Add("Prenom", "Prénom");
                this.dataGridViewUtilisateurs.Columns.Add("CIN", "CIN");
                this.dataGridViewUtilisateurs.Columns.Add("DateNaissance", "Date de Naissance");
                this.dataGridViewUtilisateurs.Columns.Add("Lieu", "Lieu");
                this.dataGridViewUtilisateurs.Columns.Add("CodePostal", "Code Postal");

                // Ajouter le DataGridView au formulaire
                this.Controls.Add(this.dataGridViewUtilisateurs);

                // ...

                // Ajouter ces lignes dans la méthode InitializeComponent ou ailleurs avant d'ajouter des lignes à votre DataGridView
                dataGridViewUtilisateurs.Columns.Add("Nom", "Nom");
                dataGridViewUtilisateurs.Columns.Add("Prenom", "Prénom");
                dataGridViewUtilisateurs.Columns.Add("CIN", "CIN");
                dataGridViewUtilisateurs.Columns.Add("DateNaissance", "Date de Naissance");
                dataGridViewUtilisateurs.Columns.Add("Lieu", "Lieu");
                dataGridViewUtilisateurs.Columns.Add("CodePostal", "Code Postal");


                this.Controls.Add(labelNom);
                this.Controls.Add(textBoxNom);
                this.Controls.Add(labelPrenom);
                this.Controls.Add(textBoxPrenom);
                this.Controls.Add(labelCIN);
                this.Controls.Add(textBoxCIN);
                this.Controls.Add(labelDateNaissance);
                this.Controls.Add(dateTimePickerDateNaissance);
                this.Controls.Add(labelLieu);
                this.Controls.Add(textBoxLieu);
                this.Controls.Add(labelCodePostal);
                this.Controls.Add(textBoxCodePostal);
                this.Controls.Add(buttonAjouter);
                this.Controls.Add(dataGridViewUtilisateurs);

            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // Logique pour ajouter un utilisateur
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string cin = textBoxCIN.Text;
            string dateNaissance = dateTimePickerDateNaissance.Text;
            string lieu = textBoxLieu.Text;
            string codePostal = textBoxCodePostal.Text;

            // Créer un objet Utilisateur
            Utilisateur nouvelUtilisateur = new Utilisateur(nom, prenom, cin, dateNaissance, lieu, codePostal);


            // Ajouter l'utilisateur à la liste
            utilisateurs.Add(nouvelUtilisateur);

            // Mettre à jour le tableau
            MettreAJourTableau();
            Console.WriteLine($"Nombre d'utilisateurs après l'ajout : {utilisateurs.Count}");

            // Effacer les champs du formulaire
            EffacerChampsFormulaire();
        }

        private void MettreAJourTableau()
        {
            // Logique pour mettre à jour le tableau
            dataGridViewUtilisateurs.Rows.Clear();

            foreach (Utilisateur utilisateur in utilisateurs)
            {
                dataGridViewUtilisateurs.Rows.Add(utilisateur.Nom, utilisateur.Prenom, utilisateur.CIN, utilisateur.DateNaissance, utilisateur.Lieu, utilisateur.CodePostal);
            }
        }

        private void EffacerChampsFormulaire()
        {
            // Logique pour effacer les champs du formulaire
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            // ...
        }

        private void ConfigureLabelAndTextBox(ref Label label, string labelText, int locationY)
        {
            label = new Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(50, locationY);
            label.Text = $"{labelText} :";
            this.Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(150, locationY);
            textBox.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(textBox);
        }

        // Classe pour représenter un utilisateur
        public class Utilisateur
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string CIN { get; set; }
            public string DateNaissance { get; set; }
            public string Lieu { get; set; }
            public string CodePostal { get; set; }

            public Utilisateur(string nom, string prenom, string cin, string dateNaissance, string lieu, string codePostal)
            {
                Nom = nom;
                Prenom = prenom;
                CIN = cin;
                DateNaissance = dateNaissance;
                Lieu = lieu;
                CodePostal = codePostal;
            }
        }
    }
}
