class MainClass
{
    public const int MAX_MOVES = 2;
    public static void Main(string[] args)
    {
        int repeatNumber = 1;
        string userInput;
        string choregraphy = "";
        string[] moves = new string[MAX_MOVES];

        Console.WriteLine("Crées ta chorégraphie (" + moves.Length + " pas max)\n");

        // Saisie de pas de danse par l'utilisateur
        SetAllMoves(moves);

        bool isValid = false;

        // Saisie du nombre de répétition
        while (!isValid)
        {
            Console.Write("Entres le nombre de répétition des pas : ");
            userInput = Console.ReadLine();

            isValid = int.TryParse(userInput, out repeatNumber);

            if (!isValid)
            {
                Console.WriteLine($"Tu dois entrer un entier compris entre {Int32.MinValue} et {Int32.MaxValue} \n");
            }
        }

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

    public static bool ValidUserInputForMoves(string userInput)
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

            userInput = Console.ReadLine();

            // Vérification de la saisie de l'utilisateur
            isValid = ValidUserInputForMoves(userInput);

            // Si la saisie de l'utilisateur est non valide on ne fait rien d'autre
            if (!isValid) continue;

            moves[index] = userInput;
            index++;
        }
    }
}