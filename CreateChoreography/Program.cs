class MainClass
{
    public const int MAX_MOVES = 32;
    public static void Main(string[] args)
    {
        int repeatNumber = 1;
        string choregraphy = "";
        string[] moves = new string[MAX_MOVES];

        Console.WriteLine("Crées ta chorégraphie (" + moves.Length + " pas max)\n");

        SetAllMoves(moves);

        // Saisie du nombre de répétition
        Console.Write("Entres le nombre de répétition des pas : ");
        repeatNumber = Convert.ToInt32(Console.ReadLine());

        // Affichage de la chorégraphie
        Console.WriteLine("\nTa chorégraphie");

        for (int i = 0; i < moves.Length && moves[i] != "done"; i++)
        {
            choregraphy += moves[i] + " ";
        }

        // Répétition
        for(int i = 0; i < repeatNumber; i++)
        {
            Console.WriteLine(choregraphy);
        }
    }

    public static bool ValidUserInput(string userInput)
    {
        // On vérifie si la valeur est vide ou composé uniquement de ' '
        if (userInput.Trim() != string.Empty)
        {
            foreach (char splitUserInput in userInput.Trim())
            {
                // On vérifie si chaque éléments de la chaîne n'est pas une lettre ou un chiffre
                if (!(Char.IsLetterOrDigit(splitUserInput)))
                {
                    Console.WriteLine("Le pas ne peut être composé que de lettres et de chiffres\n");
                    return false;
                }
            }
        }
        else
        {
            Console.WriteLine("Le pas doit être composé d'au moins une lettre\n");
            return false;
        }

        return true;
    }

    public static void SetAllMoves(string[] moves)
    {
        bool isValid;
        int index = 0;
        string userInput = "";

        while (index < moves.Length && userInput != "done")
        {
            Console.Write($"Entres le pas n°{index} (ou \"done\" pour terminer) : ");

            // Saisie de l'utilisateur
            userInput = Console.ReadLine();

            // Vérification de la saisie de l'utilisateur
            isValid = ValidUserInput(userInput);

            // Si la saisie de l'utilisateur est non valide on ne fait rien d'autre
            if (!isValid) continue;

            moves[index] = userInput;
            index++;
        }
    }
}