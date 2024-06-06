using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int i = 0; // Pour parcourir moves dans la boucle while
        string userInput = "";
        string[] moves = new string[32];

        // Saisie de l'utilisateur

        Console.WriteLine("Crée ta chorégraphie (" + moves.Length + " pas max)\n");

        while(userInput != "done" && i < moves.Length)
        {
            Console.WriteLine("Entrez un pas de dance (entrez \"done\" pour terminer)\n");
            userInput = Console.ReadLine();
            i++;
        }
    }
}