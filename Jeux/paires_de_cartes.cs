namespace PairesCartesN
{
    class PairesCartesC
    {
        // Jeu de paires de cartes à trouver
        private static void PairesCartes()
        {
            // --- VARIABLES --- //

            // Objet de la classe Random
            Random rand = new();

            // Cartes face recto
            List<char> cartes = ['A', 'A', 'B', 'B', 'C', 'C', 'D', 'D', 'E', 'E'];
            // Console.WriteLine($"cartes.Count.GetType() == {cartes.Count.GetType()}.");

            // Nombre de pairs à trouver
            int nb_pairs = cartes.Count/2;
            // Console.WriteLine($"nb_pairs == {nb_pairs}.");

            // Cartes face verso
            List<char> cartes_verso = ['_', '_', '_', '_', '_', '_', '_', '_', '_', '_'];

            // Texte des cartes face verso
            string? txt_cartes_verso = "";

            // Pour chaque carte verso
            foreach(char carte in cartes_verso)
            {
                // Ajouter la carte suivi d'un espace à txt_cartes_verso
                txt_cartes_verso += $"{carte} ";
            }

            // Nombre d'échanges
            int nb_échanges = 10;

            // Entiers tirés
            int premier_entier;
            int deuxième_entier;

            // Lettre temporaire
            char temp;

            // --- MÉLANGE DES CARTES --- //

            // Tant qu'il y a encore des échanges à faire
            while(nb_échanges > 0)
            {
                // Tirer le 1er entier
                premier_entier = rand.Next(0, cartes.Count);
                // Console.WriteLine($"premier_entier == {premier_entier}.");

                // Assigner au 2ème entier la valeur du 1er
                deuxième_entier = premier_entier;

                // Tant que le 2ème entier est égal au 1er
                while(deuxième_entier == premier_entier)
                {
                    // Tirer le 2ème entier
                    deuxième_entier = rand.Next(0, cartes.Count);
                    // Console.WriteLine($"deuxième_entier == {deuxième_entier}.\n");   
                }

                // --- ÉCHANGE --- //

                // Lettre temporaire, celle du 1er entier
                temp = cartes[premier_entier]; // A

                // On assigne à la carte n°1er entier la lettre de la carte n°2ème entier
                cartes[premier_entier] = cartes[deuxième_entier]; // A -> B

                // On assigne à la carte n°2ème entier la lettre temporaire
                cartes[deuxième_entier] = temp; // B -> A 

                // Diminuer de 1 le nombre d'échanges restant
                nb_échanges--;
            }

            // Pour chaque carte
            // foreach(char carte in cartes)
            // {
            //     // Lancer un d5 équilibré
            //     numéro_lettre = rand.Next(0, 6);
            //     Console.WriteLine($"numéro_lettre == {numéro_lettre}.");

            //     // Si la lettre du numéro tiré apparait moins de deux fois
            //     if(lettres_comptes[lettres[numéro_lettre]] < 2)
            //     {
            //         // Attribuer cette lettre à la carte
            //         carte = lettres[numéro_lettre];
            //         // Compiler Error CS1656: Cannot assign to 'variable' because it is a 
            //         // 'read-only variable type'
            //     }
            // }

            // Réponse du joueur à "Rejouer ?"
            string? txt_réponse = "";

            // Saisi du joueur
            string? saisi_j;

            // Premier entier valide
            char char_premier_entier_j;
            byte premier_entier_j;

            // Deuxième entier valide
            char char_deuxième_entier_j;
            byte deuxième_entier_j;

            // Score du joueur
            byte score_j = 0;

            // Critères de saisi valide 1er entier
            bool un_caractère_1 = false;
            bool un_entier_1 = false;

            // Critères de saisi valide 2ème entier
            bool un_caractère_2 = false;
            bool un_entier_2 = false;
            bool entiers_diff = false;

            // --- AFFICHAGE DES LETTRES ET DES POSITIONS --- //

            // Pour chaque carte
            // Console.WriteLine("\nCartes:");
            // foreach(char carte in cartes)
            // {
            //     // Afficher sa lettre
            //     Console.Write($"{carte} ");
            // }

            // Console.WriteLine("\n");

            // // Pour toutes les cartes carte
            // for(int i = 0; i < cartes.Count; i++)
            // {
            //     // Afficher sa position
            //     Console.Write($"{i} ");
            // }

            // --- DÉBUT DU JEU --- //

            // Accueil du joueur
            Console.WriteLine($"\nBienvenu aux Paires de cartes. Voici les cartes face verso:\n{txt_cartes_verso}");

            // Tant que le joueur n'a pas répondu "n" à "Rejouer ?"
            while(txt_réponse != null && txt_réponse.ToLower() != "n")
            {
                // --- PREMIER ENTIER --- //

                // Tant que le joueur n'a pas saisi deux entiers à 1 chiffre
                while(!un_caractère_1 || !un_entier_1 || !un_caractère_2 || !un_entier_2 || !entiers_diff)
                {
                    // Demander au joueur une 1ère saisi valide
                    Console.WriteLine("Veuillez entrer un 1er entier entre 0 et 9 puis appuyer sur Entrer:");

                    // Obtenir la saisi du joueur
                    saisi_j = Console.ReadLine();

                    // On vérifie que la saisi du joueur est un unique caractère
                    un_caractère_1 = char.TryParse(saisi_j, out char_premier_entier_j);

                    // Si la saisi du joueur fait plus d'un caractère
                    if(!un_caractère_1)
                    {
                        // Lui dire
                        Console.WriteLine($"Erreur: {saisi_j} fait plus d'un caractère.");
                    }

                    // Si la saisi du joueur fait un caractère
                    else
                    {
                        // Afficher le critère valide
                        // Console.WriteLine($"un_caractère_1 == {un_caractère_1}.");

                        // On vérifie que la saisi du joueur est de type byte
                        un_entier_1 = byte.TryParse(saisi_j, out premier_entier_j);

                        // Si la saisi du joueur n'est pas de type byte
                        if(!un_entier_1)
                        {
                            // Lui dire
                            Console.WriteLine($"Erreur: {saisi_j} n'est pas un entier.");
                        } 

                        // Si la saisi du joueur est de type byte 
                        else
                        {
                            // Afficher le critère valide
                            // Console.WriteLine($"un_entier_1 == {un_entier_1}.");

                            // Si la carte du 1er entier saisi est déjà face recto
                            if(cartes_verso[premier_entier_j] != '_')
                            {
                                // Le dire au joueur
                                Console.WriteLine($"Erreur: la carte n°{premier_entier_j} est déjà face recto.");

                                // Reset des bools
                                un_caractère_1 = false;
                                un_entier_1 = false;
                            }

                            // Si la carte du 1er entier saisi est face verso
                            else
                            {
                                // --- DEUXIÈME ENTIER --- //

                                // Demander au joueur une 2ème saisi valide
                                Console.WriteLine("Veuillez entrer un 2ème entier entre 0 et 9 puis appuyer sur Entrer:");

                                // Obtenir la saisi du joueur
                                saisi_j = Console.ReadLine();

                                // On vérifie que la saisi du joueur est un unique caractère
                                un_caractère_2 = char.TryParse(saisi_j, out char_deuxième_entier_j);

                                // Si la saisi du joueur fait plus d'un caractère
                                if(!un_caractère_2)
                                {
                                    // Lui dire
                                    Console.WriteLine($"Erreur: {saisi_j} fait plus d'un caractère.");
                                }

                                // Si la saisi du joueur fait un caractère
                                else
                                {
                                    // Afficher le critère valide
                                    // Console.WriteLine($"un_caractère_2 == {un_caractère_2}.");

                                    // On vérifie que la saisi du joueur est de type byte
                                    un_entier_2 = byte.TryParse(saisi_j, out deuxième_entier_j);

                                    // Si la saisi du joueur n'est pas de type byte
                                    if(!un_entier_2)
                                    {
                                        // Lui dire
                                        Console.WriteLine($"Erreur: {saisi_j} n'est pas un entier.");
                                    }

                                    // Si la saisi du joueur est de type byte 
                                    else
                                    {
                                        // Afficher le critère valide
                                        // Console.WriteLine($"un_entier_2 == {un_entier_2}.");

                                        // Si la carte du 2ème entier saisi est déjà face recto
                                        if(cartes_verso[deuxième_entier_j] != '_')
                                        {
                                            // Le dire au joueur
                                            Console.WriteLine($"Erreur: la carte n°{deuxième_entier_j} est déjà face recto.");

                                            // Reset des bools
                                            un_caractère_2 = false;
                                            un_entier_2 = false;
                                        }

                                        // Si la carte du 2ème entier saisi est face verso
                                        else
                                        {
                                            // Si les deux entiers sont égaux
                                            if(premier_entier_j == deuxième_entier_j)
                                            {
                                                // Le dire au joueur
                                                Console.WriteLine($"Erreur: les entiers saisi sont identiques.");
                                            }

                                            // Si les deux entiers sont différents
                                            else
                                            {
                                                // Afficher le critère valide
                                                entiers_diff = true;
                                                // Console.WriteLine($"entiers_diff == {entiers_diff}.\n");

                                                // Afficher les entiers
                                                // Console.WriteLine($"1er entier == {premier_entier_j}.");
                                                // Console.WriteLine($"2ème entier == {deuxième_entier_j}.");

                                                // --- RÉVÉLATION --- //

                                                // On retourne les cartes n°1er entier et 2ème entier
                                                cartes_verso[premier_entier_j] = cartes[premier_entier_j];                                                    
                                                cartes_verso[deuxième_entier_j] = cartes[deuxième_entier_j];

                                                // Vidage de txt_cartes_verso
                                                txt_cartes_verso = "";

                                                // Pour chaque carte verso
                                                foreach(char carte in cartes_verso)
                                                {
                                                    // Ajouter la carte suivi d'un espace à txt_cartes_verso
                                                    txt_cartes_verso += $"{carte} ";
                                                }
                                                
                                                // On affiche les cartes face verso et celles retournées
                                                Console.WriteLine(txt_cartes_verso);   
                                                
                                                // Si les cartes retournées n'ont pas la même lettre
                                                if(cartes_verso[premier_entier_j] != cartes_verso[deuxième_entier_j]) 
                                                {
                                                    // On retourne les cartes tirées face verso
                                                    cartes_verso[premier_entier_j] = '_'; 
                                                    cartes_verso[deuxième_entier_j] = '_'; 

                                                    // Reset des bools du 1er entier
                                                    un_caractère_1 = false;
                                                    un_entier_1 = false;

                                                    // Reset des bools du 2ème entier
                                                    un_caractère_2 = false;
                                                    un_entier_2 = false;
                                                    entiers_diff = false;

                                                    // Le dire au joueur
                                                    Console.WriteLine("Les cartes retournées sont différentes.");

                                                    // On quitte la boucle du 2ème entier pour saisir un 1er entier à nouveau
                                                    break;
                                                } 

                                                // Si les cartes retournées ont la même lettre 
                                                else
                                                {
                                                    // Diminuer de 1 le nombre de pairs à trouver
                                                    nb_pairs--;

                                                    // Le dire au joueur
                                                    Console.WriteLine($"Les cartes retournées sont identiques.");

                                                    // S'il n'y a plus aucune pair à trouver
                                                    if(nb_pairs < 1)
                                                    {
                                                        // --- FIN DE JEU --- //

                                                        // Monter de 1 le score du joueur
                                                        score_j++;

                                                        // Le dire au joueur et afficher son score
                                                        Console.WriteLine($"Gagné. Vous avez {score_j} points.");

                                                        // Tant que le joueur ne répond ni "o" ni "n" à "Rejouer ?"
                                                        while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                                                        {
                                                            // Demander au joueur s'il veut rejouer
                                                            Console.WriteLine("Rejouer ? (Tapez 'o' ou 'n' et appuyez sur Entrer)");

                                                            // Obtention de la réponse du joueur
                                                            txt_réponse = Console.ReadLine();

                                                            // Si le joueur répond "o"
                                                            if(txt_réponse != null && txt_réponse.ToLower() == "o")
                                                            {
                                                                // --- RESET DES CARTES VERSO --- //
                                                                // Cartes face verso
                                                                cartes_verso = ['_', '_', '_', '_', '_', '_', '_', '_', '_', '_'];

                                                                // Texte des cartes face verso
                                                                txt_cartes_verso = "";

                                                                // Pour chaque carte verso
                                                                foreach(char carte in cartes_verso)
                                                                {
                                                                    // Ajouter la carte suivi d'un espace à txt_cartes_verso
                                                                    txt_cartes_verso += $"{carte} ";
                                                                }  

                                                                // Reset du nombre d'échanges
                                                                nb_échanges = 10;

                                                                // --- MÉLANGE DES CARTES --- //

                                                                // Tant qu'il y a encore des échanges à faire
                                                                while(nb_échanges > 0)
                                                                {
                                                                    // Tirer le 1er entier
                                                                    premier_entier = rand.Next(0, cartes.Count);
                                                                    // Console.WriteLine($"premier_entier == {premier_entier}.");

                                                                    // Assigner au 2ème entier la valeur du 1er
                                                                    deuxième_entier = premier_entier;

                                                                    // Tant que le 2ème entier est égal au 1er
                                                                    while(deuxième_entier == premier_entier)
                                                                    {
                                                                        // Tirer le 2ème entier
                                                                        deuxième_entier = rand.Next(0, cartes.Count);
                                                                        // Console.WriteLine($"deuxième_entier == {deuxième_entier}.\n");   
                                                                    }

                                                                    // --- ÉCHANGE --- //

                                                                    // Lettre temporaire, celle du 1er entier
                                                                    temp = cartes[premier_entier]; // A

                                                                    // On assigne à la carte n°1er entier la lettre de la carte n°2ème entier
                                                                    cartes[premier_entier] = cartes[deuxième_entier]; // A -> B

                                                                    // On assigne à la carte n°2ème entier la lettre temporaire
                                                                    cartes[deuxième_entier] = temp; // B -> A 

                                                                    // Diminuer de 1 le nombre d'échanges restant
                                                                    nb_échanges--;
                                                                }

                                                                // --- RESET DES BOOLS --- //

                                                                // 1er entier
                                                                un_caractère_1 = false;
                                                                un_entier_1 = false;

                                                                // 2ème entier
                                                                un_caractère_2 = false;
                                                                un_entier_2 = false;
                                                                entiers_diff = false;

                                                                // Reset de la réponse du joueur
                                                                txt_réponse = "";

                                                                // On quitte la boucle pour saisir un premier entier
                                                                break;
                                                            }

                                                            // Si le joueur répond "n"
                                                            else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                                                            {
                                                                // Dire au revoir
                                                                Console.WriteLine("Au revoir.");
                                                            }
                                                        }
                                                    }
                                                    
                                                    // S'il y a encore des pairs à trouver
                                                    else
                                                    {
                                                        // Le dire au joueur
                                                        Console.WriteLine($"Encore {nb_pairs} pairs à trouver.");

                                                        // Reset des bools du 1er entier
                                                        un_caractère_1 = false;
                                                        un_entier_1 = false;

                                                        // Reset des bools du 2ème entier
                                                        un_caractère_2 = false;
                                                        un_entier_2 = false;
                                                        entiers_diff = false;

                                                        // On quitte la boucle du 2ème entier pour saisir un 1er entier à nouveau
                                                        break;
                                                    }
                                                }                                             
                                            }
                                        } 
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
        }

        // private static void Main()
        // {
        //     PairesCartes();
        // }
    }
}