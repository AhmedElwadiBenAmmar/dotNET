using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ExerciceDataSource
{
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter employeesAdapter;
        OleDbDataAdapter salaryAdapter;
        DataSet dataSet;
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = "server=localhost;database=basetp;user=root;port=3306;"; ;
            connection = new MySqlConnection(connectionString);
            DataTable Employée = new DataTable("Employée");
            dataSet.DataTables.Add("Employée");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
