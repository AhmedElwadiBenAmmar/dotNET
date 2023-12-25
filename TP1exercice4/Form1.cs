using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1exercice4
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

        private void btnExercice1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Clickk(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exercice1Form = new TP1exercice1.Form1();
            exercice1Form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var exercice2Form = new TP1exercice2.Form1();
            exercice2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var exercice3Form = new TP1exercice3.Form1();
            exercice3Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Code pour quitter l'application
            Application.Exit();
        }

    }
}



