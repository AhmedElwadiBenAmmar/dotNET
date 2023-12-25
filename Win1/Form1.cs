using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Win1
    {
        public partial class Form1 : Form
        {
            private Label labelBase;
            private Label labelHauteur;
            private TextBox baseTextBox;
            private TextBox hauteurTextBox;
            private Button calculerButton;
            private Label resultatLabel;

            public Form1()
            {
              

             void InitializeComponent()
            {
                this.labelBase = new Label();
                this.labelHauteur = new Label();
                this.baseTextBox = new TextBox();
                this.hauteurTextBox = new TextBox();
                this.calculerButton = new Button();
                this.resultatLabel = new Label();

                this.labelBase.Text = "Base du triangle :";
                this.labelBase.Location = new System.Drawing.Point(10, 10);

                this.labelHauteur.Text = "Hauteur du triangle :";
                this.labelHauteur.Location = new System.Drawing.Point(10, 40);

                this.baseTextBox.Location = new System.Drawing.Point(150, 10);
                this.hauteurTextBox.Location = new System.Drawing.Point(150, 40);

                this.calculerButton.Text = "Calculer";
                this.calculerButton.Location = new System.Drawing.Point(10, 70);
                this.calculerButton.Click += CalculerButton_Click;

                this.resultatLabel.Text = "";
                this.resultatLabel.Location = new System.Drawing.Point(10, 100);

                this.Controls.Add(this.labelBase);
                this.Controls.Add(this.labelHauteur);
                this.Controls.Add(this.baseTextBox);
                this.Controls.Add(this.hauteurTextBox);
                this.Controls.Add(this.calculerButton);
                this.Controls.Add(this.resultatLabel);

                this.Size = new System.Drawing.Size(300, 200);
                this.Text = "Calcul de la surface d'un triangle";
            }

             void CalculerButton_Click(object sender, EventArgs e)
            {
                if (double.TryParse(baseTextBox.Text, out double baseTriangle) && double.TryParse(hauteurTextBox.Text, out double hauteurTriangle))
                {
                    double surface = (baseTriangle * hauteurTriangle) / 2;
                    resultatLabel.Text = "La surface du triangle est : " + surface;
                }
                else
                {
                    resultatLabel.Text = "Veuillez entrer des valeurs numériques valides pour la base et la hauteur.";
                }
            }

            
             void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }


}
