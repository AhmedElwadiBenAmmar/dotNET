using System;
using System.Windows.Forms;

namespace CalculSurfaceTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculerButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(BaseTextBox.Text, out double baseTriangle) && double.TryParse(HauteurTextBox.Text, out double hauteurTriangle))
            {
                double surface = (baseTriangle * hauteurTriangle) / 2;
                ResultatLabel.Text = "La surface du triangle est : " + surface;
            }
            else
            {
                ResultatLabel.Text = "Veuillez entrer des valeurs numériques valides pour la base et la hauteur.";
            }
        }
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}
