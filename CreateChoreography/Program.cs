using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool isValid = false;
        int i = 0; // Pour parcourir moves dans la boucle while
        int repeatNumber = 1;
        string userInput = "";
        string choregraphy = "";
        string[] moves = new string[32];

        Console.WriteLine("Crées ta chorégraphie (" + moves.Length + " pas max)\n");

        while(userInput != "done" && i < moves.Length)
        {
            Console.Write("Entres un pas de danse (entres \"done\" pour terminer) : ");
            // Saisie de l'utilisateur
            userInput = Console.ReadLine();

            // Prototype de fonction pour contrôler les entrées de l'utilisateur
            if (userInput.Trim() != string.Empty)
            {
                foreach (char splitUserInput in userInput)
                {
                    if (!(Char.IsLetterOrDigit(splitUserInput)))
                    {
                        //throw NotLetterOrDigit
                    }
                    else
                    {
                        Console.WriteLine("Valide");
                    }
                }
            }
            else
            {
                //trow EmptyString
            }

            if (userInput != "done")
            {
                moves[i] = userInput;
                i++;
            }
        }

        // Saisie du nombre de répétition
        Console.WriteLine("Entres le nombre de répétition des pas");
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