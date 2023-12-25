namespace Exercice1TP1
{

    using System;

    class SurfaceTriangle
    {
        static void Main(string[] args)
        {
            //  saisir la base
            Console.WriteLine("Entrez la base du triangle : ");
            int basee = Convert.ToInt32(Console.ReadLine());

            // saisir d' Hauteur
            Console.WriteLine("Entrez la hauteur du triangle : ");
            int hauteur = Convert.ToInt32(Console.ReadLine());

            // Calcule la surface
            float surface = (basee * hauteur) / 2;

            // Affiche la surface
            Console.WriteLine("La surface du triangle est de {0}.", surface);
        }
    }
}