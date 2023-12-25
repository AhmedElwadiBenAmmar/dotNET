using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
         <summary>
         Point d'entrée principal de l'application.
         </summary>
        [STAThread]
        static void Main()


{

/*        class Factoriel
    {
        static void Main(string[] args)
        {
            // Demande à l'utilisateur de saisir un entier
            Console.WriteLine("Entrez un entier : ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Initialise la variable qui contiendra la factorielle
            int fact = 1;

            // Calcul de la factorielle
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }

            // Affichage de la factorielle
            Console.WriteLine("La factorielle de {0} est {1}", n, fact);
        }
    }

    */
/*class Division
{
static void Main(string[] args)
{
    // Demande à l'utilisateur de saisir les deux entiers
    Console.WriteLine("Entrez le premier entier : ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Entrez le deuxième entier : ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    // Vérifie si la division est possible
    if (n2 == 0)
    {
        Console.WriteLine("La division par zéro n'est pas possible.");
    }
    else
    {
        // Calcule la division
        int quotient = n1 / n2;

        // Affiche le résultat
        Console.WriteLine("La division de {0} par {1} est {2}.", n1, n2, quotient);
    }
}
}*/
/*
 using System;

class AdditionChiffres
    {
        static void Main(string[] args)
        {
            // Demande à l'utilisateur de saisir un entier
            Console.WriteLine("Entrez un entier entre 0 et 1000 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Initialise la variable qui contiendra la somme
            int somme = 0;

            // Récupère les chiffres du nombre
            string nStr = n.ToString();
            for (int i = 0; i < nStr.Length; i++)
            {
                // Convertit chaque chiffre en entier
                int chiffre = Convert.ToInt32(nStr[i]);

                // Ajoute le chiffre à la somme
                somme += chiffre;
            }

            // Affiche la somme
            Console.WriteLine("La somme des chiffres de {0} est {1}.", n, somme);
        }
    }

    //Application.EnableVisualStyles();
    // Application.SetCompatibleTextRenderingDefault(false);
    // Application.Run(new Form1());
}
}

