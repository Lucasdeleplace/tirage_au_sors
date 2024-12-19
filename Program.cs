List<string> personnesRestante = [ "Jean",
            "Marie",
            "Paul",
            "Alice",
            "Luc",
            "Sophie",
            "Julien",
            "Camille",
            "Antoine",
            "Claire",
            "Émile",
            "Hélène",
            "Thomas",
            "Julie",
            "Mathieu",
            "Laura",
            "Adrien",
            "Chloé",
            "Nicolas",
            "Emma",
            "Léo",
            "Manon",
            "Arthur",
            "Élise",
            "Maxime",
            "Charlotte",
            "Alexandre",
            "Sarah",
            "Victor",
            "Anna" ];
List<string> personnesTirer = [];
Random aleatoire = new();


do
{
    Console.Write("--- Le grand tirage au sort ---\n" +
        "\n" +
        "1 --- Effectuer un tirage\n" +
        $"2 --- Voir la liste des personne déja tirées ({personnesTirer.Count})\n" +
        $"3 --- Voir la liste des personne restantes ({personnesRestante.Count})\n" +
        "0 --- Quitter\n" +
        "\n" +
        "Faites votres choix : ");

    if (int.TryParse(Console.ReadLine(), out int choix))
    {

        switch (choix)
        {
            case 0:
                Environment.Exit(0);
                break;

            case 1:
                Console.Clear();

                if (personnesRestante.Count == 0)
                {
                    foreach (string personneTirer in personnesTirer)
                    {
                        personnesRestante.Add(personneTirer);
                    };
                    personnesTirer.Clear();
                }

                int tempsSleep = 0;

                while (tempsSleep < 1000)
                {
                    Console.Clear();
                    int nombreMystereAttante = aleatoire.Next(0, personnesRestante.Count);
                    Console.WriteLine(personnesRestante[nombreMystereAttante]);
                    Thread.Sleep(tempsSleep);
                    tempsSleep += 30;
                };

                Console.Clear();

                int nombreMystere = aleatoire.Next(0, personnesRestante.Count);
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                string texte = $"L'heureux(se) gagnant(e) est {personnesRestante[nombreMystere]}";
                int largeur = texte.Length + 2;

                Console.WriteLine("╔" + new string('═', largeur) + "╗");
                Console.WriteLine("║ " + texte + " ║");
                Console.WriteLine("╚" + new string('═', largeur) + "╝");
                Console.ResetColor();
                personnesTirer.Add(personnesRestante[nombreMystere]);
                personnesRestante.Remove(personnesRestante[nombreMystere]);
                break;

            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═════════════════════════════════╗");
                Console.WriteLine("\u2551 Liste des personnes déjà tirées \u2551");
                Console.WriteLine("╚═════════════════════════════════╝");
                Console.ResetColor();
                foreach (string personneTirer in personnesTirer)
                {
                    Console.WriteLine($"{personneTirer}");
                };
                break;

            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\u2554═══════════════════════════════\u2557");
                Console.WriteLine("\u2551 Liste des personnes restantes \u2551");
                Console.WriteLine("\u255A═══════════════════════════════\u255D");
                Console.ResetColor();
                foreach (string personneRestante in personnesRestante)
                {
                    Console.WriteLine($"{personneRestante}");
                };
                break;
            default:
                Console.WriteLine("Entrer une valeur correct");
                break;

        }
    }
    else
    {
        Console.WriteLine("Entrer un nombre");
    }
} while (true);
