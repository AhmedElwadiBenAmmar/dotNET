using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            class Factoriel
        {
            static void Main(string[] args)
            {
              
                Console.WriteLine("Entrez un entier : ");
                int n = Convert.ToInt32(Console.ReadLine());

           
                int fact = 1;

                
                for (int i = 2; i <= n; i++)
                {
                    fact *= i;
                }

          
                Console.WriteLine("La factorielle de {0} est {1}", n, fact);
            }
        }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

