class MainClass
{
    public static void Main(string[] args)
    {
        bool isNotLetterOrDigit;
        int i = 0; // Pour parcourir moves dans la boucle while
        int repeatNumber = 1;
        string userInput = "";
        string choregraphy = "";
        string[] moves = new string[32];

        Console.WriteLine("Crées ta chorégraphie (" + moves.Length + " pas max)\n");

        while(i < moves.Length && userInput != "done")
        {
            Console.Write($"Entres le pas n°{i} (ou \"done\" pour terminer) : ");
            // Saisie de l'utilisateur
            userInput = Console.ReadLine();

            // * On vérifie si la valeur est vide ou composé uniquement de ' '
            if (userInput.Trim() != string.Empty)
            {
                isNotLetterOrDigit = false;

                foreach (char splitUserInput in userInput.Trim())
                {
                    // ** On vérifie si chaque éléments de la chaîne n'est pas une lettre ou un chiffre
                    if (!(Char.IsLetterOrDigit(splitUserInput)))
                    {
                        Console.WriteLine("Le pas ne peut être composé que de lettre et de chiffre\n");
                        isNotLetterOrDigit = true;
                        break;
                    }
                }

                // ** Si c'est le cas on passe à l'itération suivante
                if (isNotLetterOrDigit)
                {
                    continue;
                }
            }
            // * Si c'est le cas on passe à l'itération suivante
            else
            {
                Console.WriteLine("Le pas doit être composé d'au moins une lettre\n");
                continue;
            }

            // Si l'utilisateur n'a pas taper "done"
            if (userInput != "done")
            {
                moves[i] = userInput;
                i++;
            }
        }

        // Saisie du nombre de répétition
        Console.Write("Entres le nombre de répétition des pas : ");
        repeatNumber = Convert.ToInt32(Console.ReadLine());

        // Affichage de la chorégraphie
        Console.WriteLine("\nTa chorégraphie");

        for (int j = 0; j < i; j++)
        {
            choregraphy += moves[j] + " ";
        }

        // Répétition
        for(int j = 0; j < repeatNumber; j++)
        {
            Console.WriteLine(choregraphy);
        }
    }
}