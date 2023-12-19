using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MySqlproject
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = "server=localhost;database=basetp;user=root;port=3306;";
            connection = new MySqlConnection(connectionString);
            timer1.Interval = 5000;
            // Gérer l'événement Tick du timer.
            timer1.Tick += timer1_Tick;

            // Activer le timer.
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void button1_Click(object sender, EventArgs e)
        {


            {
                try
                {
                    connection.Open();
                    MessageBox.Show("connecté");
                }
                catch
                {
                    MessageBox.Show("echec");
                }



            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Assurez-vous d'avoir une connexion à votre base de données
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Récupérez le CIN à partir du champ de texte
                    int cin = Convert.ToInt32(textBox1.Text);

                    // Écrivez votre requête SQL pour la suppression
                    string query = $"DELETE FROM Personne WHERE CIN = {cin}";

                    // Exécutez votre requête SQL en utilisant votre connexion à la base de données
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Rafraîchissez les données affichées dans le DataGridView
                    if (dataTable != null)
                    {
                        dataTable.Clear();
                        dataAdapter.Fill(dataTable);
                    }





                    // Affichez un message de succès
                    MessageBox.Show("Personne supprimée avec succès !");
                }
                catch (Exception ex)
                {
                    // En cas d'erreur, affichez un message d'erreur
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Assurez-vous d'avoir une connexion à votre base de données
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Récupérez les valeurs des champs de l'interface
                    int cin = Convert.ToInt32(textBox1.Text);
                    string nouveauPrenom = textBox3.Text;
                    string nouveauNom = textBox2.Text;

                    // Écrivez votre requête SQL pour la mise à jour
                    string query = $"UPDATE Personne SET prenom = '{nouveauPrenom}', nom = '{nouveauNom}' WHERE CIN = {cin}";

                    // Exécutez votre requête SQL en utilisant votre connexion à la base de données
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Rafraîchissez les données affichées dans le DataGridView
                    if (dataTable != null)
                    {
                        dataTable.Clear();
                        dataAdapter.Fill(dataTable);
                    }
                    // Affichez un message de succès
                    MessageBox.Show("Personne mise à jour avec succès !");
                }
                catch (Exception ex)
                {
                    // En cas d'erreur, affichez un message d'erreur
                    MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Initialisez le DataTable et le DataAdapter
            dataTable = new DataTable();
            dataAdapter = new MySqlDataAdapter("SELECT * FROM personne", connection);

            // Remplissez le DataTable avec les données de la base de données
            dataAdapter.Fill(dataTable);

            // Affectez le DataTable au DataGridView
            dataGridView1.DataSource = dataTable;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Assurez-vous d'avoir une connexion à votre base de données
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    // Récupérez les valeurs des champs de l'interface
                    int cin = Convert.ToInt32(textBox1.Text);
                    string prenom = textBox2.Text;
                    string nom = textBox3.Text;

                    // Écrivez votre requête SQL pour l'ajout
                    string query = $"INSERT INTO Personne (CIN, prenom, nom) VALUES ({cin}, '{prenom}', '{nom}')";

                    // Exécutez votre requête SQL en utilisant votre connexion à la base de données
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    // Affichez un message de succès
                    MessageBox.Show("Personne ajoutée avec succès !");

                    // Effacez les champs de l'interface après l'ajout
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                finally
                {
                    // Fermez la connexion à la base de données
                    connection.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Initialisez le DataTable et le DataAdapter
            dataTable = new DataTable();
            dataAdapter = new MySqlDataAdapter("SELECT * FROM personne", connection);

            // Remplissez le DataTable avec les données de la base de données
            dataAdapter.Fill(dataTable);

            // Affectez le DataTable au DataGridView
            dataGridView1.DataSource = dataTable;

            dataGridView1.Refresh();
        }
    }
}

