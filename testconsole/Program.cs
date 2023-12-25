namespace testconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Entrez votre nom");
            myName = Console.ReadLine();
            Console.WriteLine("Bonjour {0}", myName);
        }
    }
}