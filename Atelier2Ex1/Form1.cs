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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Atelier2Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(200, 30);
            textBox1.Location = new Point(250, 200);
            textBox1.BackColor = Color.White;
            textBox1.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Yellow;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Red;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Name = "button1";
            button1.Text = "Désactiver";
            button1.Size = new Size(100, 30);
            button1.Location = new Point(250, 290);
            button1.Click += button1_Click;
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton)
                {
                    ((RadioButton)control).Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 nouveauForm = new Form2();
            nouveauForm.Show();
        }

    }
}
