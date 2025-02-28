namespace DevineNombreN
{
    class DevineNombreC 
    {
        // Jeu de devinette d'un nombre
        private static void DevineNombre()
        {
            // --- VARIABLES --- //

            // Bornes de l'interval de nombres possible
            int min = 0;
            int max = 100;

            // Objet de la classe Random
            Random rand = new();

            // Génération d'un entier entre min et max
            int nombre = rand.Next(min, max+1);

            // Tentatives initiales et restantes du joueur
            int essaisInit = 10;
            int essaisRest = essaisInit;

            // Caractères saisis par le joueur
            string? txt_saisi = "";
            bool saisi_valide = false;
            int saisi = -9999999;

            // Réponse à "Voulez-vous rejouer ?"
            string? txt_réponse = "";

            // --- DÉBUT DU JEU --- //

            // Accueil du joueur
            Console.WriteLine($"Bienvenu, vous allez jouer à un jeu qui consiste à deviner un nombre entre {min} et {max}.");

            // Tant que le joueur ne répond pas Non à "Rejouer ?"
            while(txt_réponse != "n")
            {
                // Tant que le joueur a au moins 1 essai restant
                while(essaisRest > 0)
                {
                    // --- SAISI DU JOUEUR --- //

                    // Tant que la valeur saisi n'est pas un nombre, ou est un nombre 
                    // inférieur à min ou supérieur à max
                    while(!saisi_valide || saisi_valide && saisi < min || saisi > max)
                    {
                        // Demander au joueur de saisir un entier
                        Console.WriteLine($"Veuillez saisir un nombre entier entre {min} et {max}: ({essaisRest} essai restant)");
                        txt_saisi = Console.ReadLine();

                        // Évaluation de la saisi
                        saisi_valide = int.TryParse(txt_saisi, out saisi);
                    }

                    // --- COMPARAISON AVEC LE NOMBRE À DEVINER --- //

                    // Le joueur perd un essai
                    essaisRest--;

                    // Si le joueur a au moins 1 essai restant
                    if(essaisRest > 0)
                    {
                        // Si le nombre saisi est plus petit que le nombre à deviner
                        if(saisi < nombre)
                        {
                            // Le dire au joueur et lui demander un nouveau nombre
                            Console.WriteLine($"Trop petit. Entrez un autre nombre : ({essaisRest} essais restant)");
                            txt_saisi = Console.ReadLine();

                            // Évaluation de la saisi
                            saisi_valide = int.TryParse(txt_saisi, out saisi);
                        }

                        // Si le nombre saisi est plus grand que le nombre à deviner
                        else if(saisi > nombre)
                        {
                            // Le dire au joueur et lui demander un nouveau nombre
                            Console.WriteLine($"Trop grand. Entrez un autre nombre : ({essaisRest} essais restant)");
                            txt_saisi = Console.ReadLine();

                            // Évaluation de la saisi
                            saisi_valide = int.TryParse(txt_saisi, out saisi);
                        }

                        // Si le nombre saisi est juste
                        else
                        {
                            // Calculer le nb d'essais pris
                            int essaisPris = essaisInit - essaisRest;

                            // --- FIN DE JEU --- //

                            // Dire au joueur qu'il a gagné et lui demandeer s'il veut rejouer
                            Console.WriteLine($"\nGagné! vous avez trouvé le nombre juste en {essaisPris} essais.\nRejouer ? (Tapez 'o' ou 'n' puis appuyez sur Entrer)");

                            // Obtention de la réponse du joueur
                            txt_réponse = Console.ReadLine();

                            // Tant que la réponse n'est pas valide
                            while(txt_réponse != "o" && txt_réponse != "n")
                            {
                                // Nouvelle demande de jeu
                                Console.WriteLine($"Rejouer ? (Tapez 'o' ou 'n' puis appuyez sur Entrer)");

                                // Obtention de la réponse du joueur
                                txt_réponse = Console.ReadLine();  
                            }

                            // Si la réponse est o
                            if(txt_réponse == "o")
                            {
                                // Reset des essais restant
                                essaisRest = essaisInit;

                                // Reset de la saisi du joueur
                                saisi_valide = false;
                                saisi = -9999999;

                                // Choix d'un nouveau nombre
                                nombre = rand.Next(min, max+1);
                            }

                            // Si la réponse est n
                            if(txt_réponse == "n")
                            {
                                // Dire au revoir au joueur et mettre fin au programme
                                Console.WriteLine("Au revoir.");
                                return;
                            }
                        }
                    }

                    // Si le joueur n'a plus d'essais
                    else
                    {
                        // --- FIN DE JEU --- //

                        // Dire au joueur qu'il a perdu et lui demandeer s'il veut rejouer
                        Console.WriteLine($"\nVous n'avez plus essai. Perdu.\nRejouer ? (Tapez 'o' ou 'n' puis appuyez sur Entrer)");

                        // Obtention de la réponse du joueur
                        txt_réponse = Console.ReadLine();

                        // Tant que la réponse n'est pas valide
                        while(txt_réponse != "o" && txt_réponse != "n")
                        {
                            // Nouvelle demande de jeu
                            Console.WriteLine($"Rejouer ? (Tapez 'o' ou 'n' puis appuyez sur Entrer)");

                            // Obtention de la réponse du joueur
                            txt_réponse = Console.ReadLine();  
                        }

                        // Si la réponse est o
                        if(txt_réponse == "o")
                        {
                            // Reset des essais restant
                            essaisRest = essaisInit;

                            // Reset de la saisi du joueur
                            saisi_valide = false;
                            saisi = -9999999;

                            // Choix d'un nouveau nombre
                            nombre = rand.Next(min, max+1);
                        }

                        // Si la réponse est n
                        if(txt_réponse == "n")
                        {
                            // Dire au revoir au joueur et mettre fin au programme
                            Console.WriteLine("Au revoir.");
                            return;
                        }
                    }
                }
            }
        }
        
        // private static void Main()
        // {
        //     DevineNombre();
        // }
    }
}