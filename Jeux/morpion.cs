namespace MorpionN
{
    class MorpionC
    {
        // Jeu du morpion
        private static void Morpion()
        {
            // --- VARIABLES --- //

            // Scores
            byte score_j = 0;
            byte score_o = 0;

            // Résultats
            byte égalités = 0;
            byte rounds = 0;

            // Lettres
            char lettre_j;
            char lettre_o;

            // Déclarations de victoire (pour tester la présence d'une égalité sans réécrire tous les trio gagnants)
            bool victoireJoueur = false;
            bool victoireOrdi = false;

            // Objet de classe Random
            Random rand = new();

            // Entier aléatoire entre 0 et 1 pour décider des lettres
            int lettres = rand.Next(0, 2); // Random.Next retourne un int

            // Si lettres vaut 0
            if(lettres == 0)
            {
                // Le joueur joue X et l'ordi joue O
                lettre_j = 'x';
                lettre_o = 'o';
            }

            // Si lettres vaut 1
            else
            {
                // Le joueur joue O et l'ordi joue X
                lettre_j = 'o';
                lettre_o = 'x';
            }

            // Dire qui joue quoi
            // Console.WriteLine($"le joueur joue {lettre_j}, l'ordi joue {lettre_o}.");

            // Entier aléatoire entre 0 et 1 pour décider du tour
            int tour = rand.Next(0, 2); // Random.Next retourne un int

            // Tour en cours
            bool tourJoueur = tour == 0;
            // bool tourJoueur = true;

            // Dire qui commence
            string txtPremierTour = tourJoueur ? "Vous commencez.\n" : "L'ordi commence.\n";
            // Console.WriteLine(txtPremierTour);

            // Caractères de la grille
            List<char> caractères_grille = ['_', '_', '_', '_', '_', '_', '_', '_', '_'];
            string grille;

            // Réponse à "Rejouer ?"
            string? txt_réponse = "";

            // Saisi du joueur
            string? saisi_joueur = "";
            char caractère_joueur;

            // Critères de saisi valide du joueur
            bool un_caractère = false;
            bool un_chiffre = false;
            bool chiffre_case_vide = false;

            // Chiffre du joueur
            byte chiffre_joueur;

            // Cases vides
            List<byte> cases_vides = [0, 1, 2, 3, 4, 5, 6, 7, 8];

            // Case chosi par l'ordi
            int case_choisi_o;

            // Numéro sur la case choisi par l'ordi
            byte choix_ordi;

            // --- DÉBUT DU JEU --- //

            // Accueil du joueur
            Console.WriteLine($"Bienvenu au Morpion. Vous jouez {lettre_j} et l'ordi joue {lettre_o}. {txtPremierTour}.");

            // Tant que le joueur ne répond pas Non à "Rejouer ?"
            while(txt_réponse != null && txt_réponse.ToLower() != "n")
            {
                // Si c'est le tour de l'ordi
                if(!tourJoueur)
                {
                    // L'ordi choisit une case parmi celles disponibles
                    case_choisi_o = rand.Next(0, cases_vides.Count-1);
                    choix_ordi = cases_vides[case_choisi_o];

                    Console.WriteLine($"L'ordi a choisi la case {case_choisi_o}, soit le numéro {choix_ordi}.");

                    // Le caractère n°choix_ordi de la grille devient la lettre de l'ordi
                    caractères_grille[choix_ordi] = lettre_o;

                    // On retire la case n°case_choisi des cases vides
                    cases_vides.Remove(choix_ordi);

                    // --- TEST VICTOIRE DE L'ORDI --- //

                    // Si trois cases alignées ont la lettre de l'ordi
                    if( // RANGÉES
                        lettre_o == caractères_grille[0] && caractères_grille[0] == caractères_grille[1] && caractères_grille[1] == caractères_grille[2]
                        || 
                        lettre_o == caractères_grille[3] && caractères_grille[3] == caractères_grille[4] && caractères_grille[4] == caractères_grille[5]
                        || 
                        lettre_o == caractères_grille[6] && caractères_grille[6] == caractères_grille[7] && caractères_grille[7] == caractères_grille[8]
                        || 
                        // COLONNES
                        lettre_o == caractères_grille[0] && caractères_grille[0] == caractères_grille[3] && caractères_grille[3] == caractères_grille[6]
                        || 
                        lettre_o == caractères_grille[1] && caractères_grille[1] == caractères_grille[4] && caractères_grille[4] == caractères_grille[7]
                        || 
                        lettre_o == caractères_grille[2] && caractères_grille[2] == caractères_grille[5] && caractères_grille[5] == caractères_grille[8]
                        // DIAGONALES
                        || 
                        lettre_o == caractères_grille[0] && caractères_grille[0] == caractères_grille[4] && caractères_grille[4] == caractères_grille[8]
                        || 
                        lettre_o == caractères_grille[2] && caractères_grille[2] == caractères_grille[4] && caractères_grille[4] == caractères_grille[6]
                    )
                    {
                        // --- FIN DE JEU --- //

                        // On augmente de 1 le score de l'ordinateur et le nombre de rounds
                        score_o++;
                        rounds++;

                        // Déclarer la victoire de l'ordi
                        victoireOrdi = true;

                        // Vider l'affichage de la grille
                        grille = "";

                        // Pour tous les caractères de la grille
                        for(byte i = 0; i < caractères_grille.Count; i++)
                        {
                            // Ajouter "|" suivi du caractère à la grille
                            grille += $"|{caractères_grille[i]}";

                            // Si le caractère est le numéro 2, 5 ou 8
                            if(i == 2 || i == 5 || i == 8)
                            {
                                // Ajouter "|" suivi d'une mise à la ligne
                                grille += "|\n";
                            }
                        }

                        // Afficher la grille
                        Console.WriteLine(grille);

                        // On affiche le gagnant et les résultats
                        Console.WriteLine($"\nL'ordinateur a gagné. Vous avez {score_j} points, l'ordi a {score_o} points. Vous avez joué {rounds} rounds.");

                        // Tant que le joueur ne répond ni "o" ni "n"
                        while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                        {
                            // On demande au joueur s'il veut rejouer
                            Console.WriteLine("Rejouer ? (Tapez 'o' ou 'n' et appuyez sur Entrer)");

                            // Réponse du joueur
                            txt_réponse = Console.ReadLine();    
                        }

                        // Si le joueur répond "o"
                        if(txt_réponse != null && txt_réponse.ToLower() == "o")
                        {
                            // Reset des cases vides
                            cases_vides = [0, 1, 2, 3, 4, 5, 6, 7, 8];

                            // Vidage de la grille
                            caractères_grille = ['_', '_', '_', '_', '_', '_', '_', '_', '_'];

                            // Nombre aléatoire entre 0 et 1 pour décider des lettres
                            lettres = rand.Next(0, 2); // Random.Next retourne un int

                            // Si lettres vaut 0
                            if(lettres == 0)
                            {
                                // Le joueur joue X et l'ordi joue O
                                lettre_j = 'x';
                                lettre_o = 'o';
                            }

                            // Si lettres vaut 1
                            else
                            {
                                // Le joueur joue O et l'ordi joue X
                                lettre_j = 'o';
                                lettre_o = 'x';
                            }

                            // Nombre aléatoire entre 0 et 1 pour décider du tour
                            tour = rand.Next(0, 2); // Random.Next retourne un int

                            // Tour en cours
                            tourJoueur = tour == 0;

                            // Dire qui commence
                            txtPremierTour = tourJoueur ? "Vous commencez.\n" : "L'ordi commence.\n";
                            
                            // Reset de la réponse du joueur
                            txt_réponse = "";

                            // Dire au joueur qui commence
                            Console.WriteLine(txtPremierTour);

                            // Reset des bools
                            un_caractère = false;
                            un_chiffre = false;
                            chiffre_case_vide = false;
                            victoireOrdi = false;
                        }

                        // Si le joueur répond "n"
                        else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                        {
                            // Dire au revoir au joueur
                            Console.WriteLine("Au revoir.");
                        }
                    }

                    // --- TEST ÉGALITÉ --- //

                    // S'il ne reste aucune case vide et que aucun trio de cases n'a la lettre de l'ordi ni du joueur
                    else if(cases_vides.Count < 1 && !victoireOrdi && !victoireJoueur)
                    {
                        // Monter de 1 le nombre d'égalités
                        égalités++;

                        // Vider l'affichage de la grille
                        grille = "";

                        // Pour tous les caractères de la grille
                        for(byte i = 0; i < caractères_grille.Count; i++)
                        {
                            // Ajouter "|" suivi du caractère à la grille
                            grille += $"|{caractères_grille[i]}";

                            // Si le caractère est le numéro 2, 5 ou 8
                            if(i == 2 || i == 5 || i == 8)
                            {
                                // Ajouter "|" suivi d'une mise à la ligne
                                grille += "|\n";
                            }
                        }

                        // Afficher la grille
                        Console.WriteLine(grille);

                        // Dire qu'il y a égalité et afficher les résultats
                        Console.WriteLine($"\nÉgalité. Vous avez {score_j}, l'ordi a {score_o} et vous avez joué {rounds} rounds.");

                        // Tant que le joueur ne répond ni "o" ni "n"
                        while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                        {
                            // On demande au joueur s'il veut rejouer
                            Console.WriteLine("Rejouer ? (Tapez 'o' ou 'n' et appuez sur Entrer)");

                            // Réponse du joueur
                            txt_réponse = Console.ReadLine();    
                        }

                        // Si le joueur répond "o"
                        if(txt_réponse != null && txt_réponse.ToLower() == "o")
                        {
                            // Reset des cases vides
                            cases_vides = [0, 1, 2, 3, 4, 5, 6, 7, 8];

                            // Vidage de la grille
                            caractères_grille = ['_', '_', '_', '_', '_', '_', '_', '_', '_'];

                            // Nombre aléatoire entre 0 et 1 pour décider des lettres
                            lettres = rand.Next(0, 2); // Random.Next retourne un int

                            // Si lettres vaut 0
                            if(lettres == 0)
                            {
                                // Le joueur joue X et l'ordi joue O
                                lettre_j = 'x';
                                lettre_o = 'o';
                            }

                            // Si lettres vaut 1
                            else
                            {
                                // Le joueur joue O et l'ordi joue X
                                lettre_j = 'o';
                                lettre_o = 'x';
                            }

                            // Nombre aléatoire entre 0 et 1 pour décider du tour
                            tour = rand.Next(0, 2); // Random.Next retourne un int

                            // Tour en cours
                            tourJoueur = tour == 0;

                            // Dire qui commence
                            txtPremierTour = tourJoueur ? "Vous commencez.\n" : "L'ordi commence.\n";

                            // Reset des bools
                            un_caractère = false;
                            un_chiffre = false;
                            chiffre_case_vide = false;
                            victoireJoueur = false;
                            victoireOrdi = false;

                            // Reset de la réponse du joueur
                            txt_réponse = "";

                            // Dire au joueur qui commence
                            Console.WriteLine(txtPremierTour);
                        }

                        // Si le joueur répond "n"
                        else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                        {
                            // Dire au revoir au joueur
                            Console.WriteLine("Au revoir.");
                        }
                    }

                    // Si aucun trio de cases n'a la lettre de l'ordi
                    else
                    {
                        // Changement de tour
                        tourJoueur = true;  
                        Console.WriteLine($"tourJoueur == {tourJoueur}.\n");
                    }
                }

                // Si c'est le tour du joueur
                else if(tourJoueur)
                {
                    // Vider l'affichage de la grille
                    grille = "";

                    // Pour tous les caractères de la grille
                    for(byte i = 0; i < caractères_grille.Count; i++)
                    {
                        // Ajouter "|" suivi du caractère à la grille
                        grille += $"|{caractères_grille[i]}";

                        // Si le caractère est le numéro 2, 5 ou 8
                        if(i == 2 || i == 5 || i == 8)
                        {
                            // Ajouter "|" suivi d'une mise à la ligne
                            grille += "|\n";
                        }
                    } 

                    // Tant que le joueur ne rentre pas un unique caractère étant chiffre qui correspond à une case vide
                    while(!un_caractère || !un_chiffre || !chiffre_case_vide)
                    {
                        // Afficher la grille
                        Console.WriteLine(grille);   

                        // Demander au joueur d'entrer un chiffre valide
                        Console.WriteLine("Veuillez entrer un chiffre correspondant à une case vide et appuyez sur Entrer (0 en haut à gauche, 8 en bas à droite)"); 

                        // Obtention de la saisi du joueur
                        saisi_joueur = Console.ReadLine();

                        // On vérifie que la saisi est un caractère unique
                        un_caractère = char.TryParse(saisi_joueur, out caractère_joueur);

                        // Si la saisi du joueur n'est pas un caractère unique
                        if(!un_caractère)
                        {
                            // Le dire au joueur
                            Console.WriteLine($"{saisi_joueur} n'est pas un caractère unique.");
                        }

                        // Si la saisi du joueur est un caractère unique
                        else
                        {
                            // Affichage du critère valide
                            Console.WriteLine($"un_caractère == {un_caractère}.");

                            // On vérifie que la saisi du joueur est un entier
                            un_chiffre = byte.TryParse(saisi_joueur, out chiffre_joueur);

                            // Si la saisi du joueur n'est pas un chiffre
                            if(!un_chiffre)
                            {
                              // Le dire au joueur
                                Console.WriteLine($"{saisi_joueur} n'est pas un chiffre.");  
                            }

                            // Si la saisi est un chiffre
                            else
                            {
                                // Affichage du critère valide
                                Console.WriteLine($"un_chiffre == {un_chiffre}.");

                                // Variable de type byte de la saisi du joueur
                                chiffre_joueur = Convert.ToByte(saisi_joueur);

                                // Pour chaque case vide
                                foreach(byte _case in cases_vides)
                                {
                                    // Si le chiffre saisi par le joueur est une case vide
                                    if(chiffre_joueur == _case)
                                    {
                                        // Déclarer que le chiffre saisi correspond à une case vide
                                        chiffre_case_vide = true;

                                        // Affichage du critère valide
                                        Console.WriteLine($"chiffre_case_vide == {chiffre_case_vide}.");
                                    }
                                }

                                // Si le chiffre rentré ne correspond à aucune case vide
                                if(!chiffre_case_vide)
                                {
                                    // Le dire au joueur
                                    Console.WriteLine($"{chiffre_joueur} ne correspond à aucune case vide.");
                                }
                            }
                        }
                    }

                    // --- TRAITEMENT DU CHIFFRE DU JOUEUR --- //

                    // Variable de type byte de la saisi du joueur
                    chiffre_joueur = Convert.ToByte(saisi_joueur);

                    // On assigne à la case n°chiffre_joueur la lettre du joueur
                    caractères_grille[chiffre_joueur] = lettre_j;

                    // On retire la case n°chiffre_joueur des cases vides
                    cases_vides.Remove(chiffre_joueur);

                    // --- TEST VICTOIRE DU JOUEUR --- //

                    // Si trois cases alignées ont la lettre du joueur
                    if( // RANGÉES
                        lettre_j == caractères_grille[0] && caractères_grille[0] == caractères_grille[1] && caractères_grille[1] == caractères_grille[2]
                        || 
                        lettre_j == caractères_grille[3] && caractères_grille[3] == caractères_grille[4] && caractères_grille[4] == caractères_grille[5]
                        || 
                        lettre_j == caractères_grille[6] && caractères_grille[6] == caractères_grille[7] && caractères_grille[7] == caractères_grille[8]
                        || 
                        // COLONNES
                        lettre_j == caractères_grille[0] && caractères_grille[0] == caractères_grille[3] && caractères_grille[3] == caractères_grille[6]
                        || 
                        lettre_j == caractères_grille[1] && caractères_grille[1] == caractères_grille[4] && caractères_grille[4] == caractères_grille[7]
                        || 
                        lettre_j == caractères_grille[2] && caractères_grille[2] == caractères_grille[5] && caractères_grille[5] == caractères_grille[8]
                        // DIAGONALES
                        || 
                        lettre_j == caractères_grille[0] && caractères_grille[0] == caractères_grille[4] && caractères_grille[4] == caractères_grille[8]
                        || 
                        lettre_j == caractères_grille[2] && caractères_grille[2] == caractères_grille[4] && caractères_grille[4] == caractères_grille[6]
                    )
                    {
                        // --- FIN DE JEU --- //

                        // On augmente de 1 le score du joueur et le nombre de rounds
                        score_j++;
                        rounds++;

                        // Déclarer la victoire du joueur
                        victoireJoueur = true;

                        // Vider l'affichage de la grille
                        grille = "";

                        // Pour tous les caractères de la grille
                        for(byte i = 0; i < caractères_grille.Count; i++)
                        {
                            // Ajouter "|" suivi du caractère à la grille
                            grille += $"|{caractères_grille[i]}";

                            // Si le caractère est le numéro 2, 5 ou 8
                            if(i == 2 || i == 5 || i == 8)
                            {
                                // Ajouter "|" suivi d'une mise à la ligne
                                grille += "|\n";
                            }
                        }

                        // Afficher la grille
                        Console.WriteLine($"\n{grille}");

                        // On affiche le gagnant et les résultats
                        Console.WriteLine($"\nVous avez gagné. Vous avez {score_j} points, l'ordi a {score_o} points. Vous avez joué {rounds} rounds.");

                        // Tant que le joueur ne répond ni "o" ni "n"
                        while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                        {
                            // On demande au joueur s'il veut rejouer
                            Console.WriteLine("Rejouer ? (Tapez 'o' ou 'n' et appuez sur Entrer)");

                            // Réponse du joueur
                            txt_réponse = Console.ReadLine();    
                        }

                        // Si le joueur répond "o"
                        if(txt_réponse != null && txt_réponse.ToLower() == "o")
                        {
                            // Reset des cases vides
                            cases_vides = [0, 1, 2, 3, 4, 5, 6, 7, 8];

                            // Vidage de la grille
                            caractères_grille = ['_', '_', '_', '_', '_', '_', '_', '_', '_'];

                            // Nombre aléatoire entre 0 et 1 pour décider des lettres
                            lettres = rand.Next(0, 2); // Random.Next retourne un int

                            // Si lettres vaut 0
                            if(lettres == 0)
                            {
                                // Le joueur joue X et l'ordi joue O
                                lettre_j = 'x';
                                lettre_o = 'o';
                            }

                            // Si lettres vaut 1
                            else
                            {
                                // Le joueur joue O et l'ordi joue X
                                lettre_j = 'o';
                                lettre_o = 'x';
                            }

                            // Nombre aléatoire entre 0 et 1 pour décider du tour
                            tour = rand.Next(0, 2); // Random.Next retourne un int

                            // Tour en cours
                            tourJoueur = tour == 0;

                            // Dire qui commence
                            txtPremierTour = tourJoueur ? "Vous commencez.\n" : "L'ordi commence.\n";

                            // Reset des bools
                            un_caractère = false;
                            un_chiffre = false;
                            chiffre_case_vide = false;
                            victoireJoueur = false;

                            // Reset de la réponse du joueur
                            txt_réponse = "";

                            // Dire au joueur qui commence
                            Console.WriteLine(txtPremierTour);
                        }

                        // Si le joueur répond "n"
                        else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                        {
                            // Dire au revoir au joueur
                            Console.WriteLine("Au revoir.");
                        }
                    }

                    // --- TEST ÉGALITÉ --- //

                    // S'il ne reste aucune case vide et que aucun trio de cases n'a la lettre de l'ordi ni du joueur
                    else if(cases_vides.Count < 1 && !victoireOrdi && !victoireJoueur)
                    {
                        // Monter de 1 le nombre d'égalités
                        égalités++;

                        // Vider l'affichage de la grille
                        grille = "";

                        // Pour tous les caractères de la grille
                        for(byte i = 0; i < caractères_grille.Count; i++)
                        {
                            // Ajouter "|" suivi du caractère à la grille
                            grille += $"|{caractères_grille[i]}";

                            // Si le caractère est le numéro 2, 5 ou 8
                            if(i == 2 || i == 5 || i == 8)
                            {
                                // Ajouter "|" suivi d'une mise à la ligne
                                grille += "|\n";
                            }
                        }

                        // Afficher la grille
                        Console.WriteLine(grille);

                        // Dire qu'il y a égalité et afficher les résultats
                        Console.WriteLine($"\nÉgalité. Vous avez {score_j}, l'ordi a {score_o} et vous avez joué {rounds} rounds.");

                        // Tant que le joueur ne répond ni "o" ni "n"
                        while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                        {
                            // On demande au joueur s'il veut rejouer
                            Console.WriteLine("Rejouer ? (Tapez 'o' ou 'n' et appuez sur Entrer)");

                            // Réponse du joueur
                            txt_réponse = Console.ReadLine();    
                        }

                        // Si le joueur répond "o"
                        if(txt_réponse != null && txt_réponse.ToLower() == "o")
                        {
                            // Reset des cases vides
                            cases_vides = [0, 1, 2, 3, 4, 5, 6, 7, 8];

                            // Vidage de la grille
                            caractères_grille = ['_', '_', '_', '_', '_', '_', '_', '_', '_'];

                            // Nombre aléatoire entre 0 et 1 pour décider des lettres
                            lettres = rand.Next(0, 2); // Random.Next retourne un int

                            // Si lettres vaut 0
                            if(lettres == 0)
                            {
                                // Le joueur joue X et l'ordi joue O
                                lettre_j = 'x';
                                lettre_o = 'o';
                            }

                            // Si lettres vaut 1
                            else
                            {
                                // Le joueur joue O et l'ordi joue X
                                lettre_j = 'o';
                                lettre_o = 'x';
                            }

                            // Nombre aléatoire entre 0 et 1 pour décider du tour
                            tour = rand.Next(0, 2); // Random.Next retourne un int

                            // Tour en cours
                            tourJoueur = tour == 0;

                            // Dire qui commence
                            txtPremierTour = tourJoueur ? "Vous commencez.\n" : "L'ordi commence.\n";

                            // Reset des bools
                            un_caractère = false;
                            un_chiffre = false;
                            chiffre_case_vide = false;
                            victoireJoueur = false;
                            victoireOrdi = false;

                            // Reset de la réponse du joueur
                            txt_réponse = "";

                            // Dire au joueur qui commence
                            Console.WriteLine(txtPremierTour);
                        }

                        // Si le joueur répond "n"
                        else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                        {
                            // Dire au revoir au joueur
                            Console.WriteLine("Au revoir.");
                        }
                    }

                    // Si aucun trio de cases n'a la lettre du joueur
                    else
                    {
                        // Reset des bools
                        un_caractère = false;
                        un_chiffre = false;
                        chiffre_case_vide = false;

                        // Changement de tour
                        tourJoueur = false;
                        Console.WriteLine($"tourJoueur == {tourJoueur}.\n");
                    }
                }
            }
        }

        // private static void Main()
        // {
        //     Morpion();
        // }
    }
}