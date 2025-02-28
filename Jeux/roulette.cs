namespace RouletteN
{
    class RouletteC
    {
        // Jeu de la roulette russe
        private static void RouletteRusse()
        {
            // --- VARIABLES --- //

            // Objet de la classe Random
            Random rand = new();

            // Réponse du joueur à "Rejouer ?"
            string? txt_réponse = "";

            // Entier aléatoire
            int nb = -1;

            // Nombre de victoires et défaites
            byte victoires = 0;
            byte défaites = 0;

            // --- DÉBUT DU JEU --- //

            // Accueil du joueur
            Console.WriteLine("Bienvenu à la Roulette Russe.");

            // Tant que le joueur n'a pas répondu "n" à "Rejouer ?"
            while(txt_réponse != null && txt_réponse.ToLower() != "n")
            {
                // Tourner le revolver
                nb = rand.Next(0, 6);

                // Afficher le chiffre tiré
                Console.WriteLine($"{nb}");

                // Si la roulette tombe sur 0
                if(nb == 0)
                {
                    // Monter de 1 le nombre de défaites
                    défaites++;

                    // Dire au joueur qu'il a perdu
                    Console.WriteLine("Perdu.");
                }

                // Si la roulette tombe sur un chiffre autre que 0
                else
                {
                    // Monter de 1 le nombre de victoires
                    victoires++;

                    // Dire au joueur qu'il a gagné
                    Console.WriteLine("Gagné.");   
                }

                // Montrer les résultats au joueur
                Console.WriteLine($"Vous avez {victoires} victoires et {défaites} défaites.");

                // Tant que le joueur ne répond ni "o" ni "n"
                while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                {
                    // Demander au joueur s'il veut rejouer
                    Console.WriteLine("Rejouer ? (Tapez 'o' ou 'n' et appuyez sur Entrer)");

                    // Obtention de la réponse du joueur
                    txt_réponse = Console.ReadLine();

                    // Si le joueur répond "o"
                    if(txt_réponse != null && txt_réponse.ToLower() == "o")
                    {
                        // Reset de nb
                        nb = -1;

                        // Reset de la réponse du joueur
                        txt_réponse = "";

                        // Sortir de cette boucle pour revenir au début du jeu
                        break;
                    }

                    // Si le joueur répond "n"
                    else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                    {
                        // Dire au revoir au joueur
                        Console.WriteLine("Au revoir.");
                    }
                }
            }
        }       

        // private static void Main()
        // {
        //     RouletteRusse();
        // }
    }
}