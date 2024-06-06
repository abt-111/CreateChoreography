using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int i = 0; // Pour parcourir moves dans la boucle while
        int repeatNumber = 1;
        string userInput = "";
        string choregraphy = "";
        string[] moves = new string[32];

        // Saisie de l'utilisateur
        Console.WriteLine("Crée ta chorégraphie (" + moves.Length + " pas max)\n");

        while(userInput != "done" && i < moves.Length)
        {
            Console.WriteLine("Entrez un pas de dance (entrez \"done\" pour terminer)");
            userInput = Console.ReadLine();

            if(userInput != "done")
            {
                moves[i] = userInput;
            }
            i++;
        }

        Console.WriteLine("Entrez le nombre de fois que les pas doivent être exécutés");
        repeatNumber = Convert.ToInt32(Console.ReadLine());

        // Affichage de la chorégraphie
        Console.WriteLine("\nTa chorégraphie");

        for (int j = 0; j < i; j++)
        {
            choregraphy += moves[j] + " ";
        }
        Console.WriteLine(choregraphy);
    }
}