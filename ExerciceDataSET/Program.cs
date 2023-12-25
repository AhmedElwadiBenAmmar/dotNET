using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace YourConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
             MySqlConnection connection;
        string connectionString = "Data Source=YourDatabase.db;Version=3;";
            Connection connection = new SQLiteConnection(connectionString);

            // Créer la table EmployéesDetaille
            string createEmployeesTableSQL = "CREATE TABLE IF NOT EXISTS EmployéesDetaille (EmployeID INTEGER PRIMARY KEY AUTOINCREMENT, EmployerName TEXT, EmployMobile TEXT)";
            ExecuteNonQuery(createEmployeesTableSQL, connection);

            // Créer la table Salarydetaillé
            string createSalaryTableSQL = "CREATE TABLE IF NOT EXISTS Salarydetaillé (SalaryID INTEGER PRIMARY KEY AUTOINCREMENT, EmployeID INTEGER, Salary REAL)";
            ExecuteNonQuery(createSalaryTableSQL, connection);

            // Afficher les données de la table EmployéesDetaille
            string selectEmployeesSQL = "SELECT * FROM EmployéesDetaille";
            DataTable employeesTable = ExecuteQuery(selectEmployeesSQL, connection);
            DisplayData(employeesTable);

            // Afficher les données de la table Salarydetaillé
            string selectSalarySQL = "SELECT * FROM Salarydetaillé";
            DataTable salaryTable = ExecuteQuery(selectSalarySQL, connection);
            DisplayData(salaryTable);

            connection.Close();
        }

        static void ExecuteNonQuery(string sql, SQLiteConnection connection)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        static DataTable ExecuteQuery(string sql, SQLiteConnection connection)
        {
            connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        static void DisplayData(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}