using System;
using System.Configuration;
using System.Data.OleDb;
using System.Web.UI;

namespace Exercice2Atelier4
{
    public partial class Partie_B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cette méthode est appelée lorsque la page est chargée
            // Vous avez déjà une connexion à la base de données ici, mais il est préférable de l'utiliser uniquement lorsque nécessaire
            // La connexion sera fermée automatiquement à la fin de cette méthode
            // Vous pouvez également ajouter une vérification pour voir si la connexion est déjà ouverte avant de l'ouvrir à nouveau

            // OleDbConnection connect = new OleDbConnection();
            // connect.ConnectionString = ConfigurationManager.ConnectionStrings["oConnectionString"].ConnectionString;
            // connect.Open();
            // Label1.Text = "Vous êtes connecté";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs saisies par l'utilisateur
            string nom = TextBox1.Text;
            string prenom = TextBox2.Text;
            string email = TextBox3.Text;
            DateTime dateNaissance;

            // Vérifier si la date est valide avant de la parser
            if (DateTime.TryParse(TextBox4.Text, out dateNaissance))
            {
                string motDePasse = TextBox5.Text;

                // Appeler une méthode pour enregistrer l'employé dans la base de données
                EnregistrerNouvelEmploye(nom, prenom, email, dateNaissance, motDePasse);

                // Ajoutez d'autres logiques si nécessaire (par exemple, redirection vers une autre page)
            }
            else
            {
                // Gérer le cas où la date de naissance n'est pas valide
                Label1.Text = "La date de naissance n'est pas valide.";
            }
        }

        private void EnregistrerNouvelEmploye(string nom, string prenom, string email, DateTime dateNaissance, string motDePasse)
        {
            // Code pour enregistrer les détails de l'employé dans la base de données
            // Utilisez une connexion à la base de données (OleDb, MySQL, etc.) et une requête d'insertion SQL.
            // Assurez-vous de gérer les erreurs et exceptions.

            // Exemple avec OleDb
            using (OleDbConnection connect = new OleDbConnection())
            {
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["oConnectionString"].ConnectionString;

                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = connect;
                    connect.Open();
                    Label8.Text = "vous etes connecté";

                    // Exemple de requête d'insertion (ajustez selon votre structure de base de données)
                    cmd.CommandText = "INSERT INTO Employe (First_name, Last_name, Email, DateofB, Password) VALUES (?, ?, ?, ?, ?)";
                    cmd.Parameters.AddWithValue("First_name", prenom);
                    cmd.Parameters.AddWithValue("Last_name", nom);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("DateofB", dateNaissance);
                    cmd.Parameters.AddWithValue("Password", motDePasse);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Label1.Text = "Enregistrement réussi.";
                    }
                    catch (Exception ex)
                    {
                        Label1.Text = "Erreur lors de l'enregistrement : " + ex.Message;
                        // Vous pouvez ajouter plus de logique ici pour gérer l'erreur
                    }
                }
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            // Cette méthode est appelée lorsque le texte du TextBox5 change
            // Vous pouvez ajouter une logique ici si nécessaire
        }
    }
}
