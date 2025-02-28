namespace QuizN
{
    class QuizC
    {
        // Jeu de quiz
        private static void Quiz()
        {
            // --- VARIABLES --- //

            // Valeur de la première réponse de chaque question
            byte min = 0;

            // Valeur de la dernière réponse de chaque question
            byte max = 1;

            // Questions, leurs réponses et la valeur de vérité de ces réponses
            List<QuestionRéponse> questions_réponses = 
            [
               new QuestionRéponse 
               {
                    // Texte de la question
                    question = "Quelle pierre fait évoluer Évoli en Pyroli ?",
                    
                    // Réponses et leurs valeurs de vérités
                    réponses_vérités = new Dictionary<string, bool>() 
                    {
                        {"Pierre Feu", true},
                        {"Pierre Foudre", false}
                    }
               },

               new QuestionRéponse 
               {
                    // Texte de la question
                    question = "Quelle ennemi de Mega Man utilise l'électricité ?",
                    
                    // Réponses et leurs valeurs de vérités
                    réponses_vérités = new Dictionary<string, bool>() 
                    {
                        {"Quick Man", false},
                        {"Spark Man", true}
                    }
               },

               new QuestionRéponse 
               {
                    // Texte de la question
                    question = "Comment s'appelle la main à l'origine du monde de Smash ?",
                    
                    // Réponses et leurs valeurs de vérités
                    réponses_vérités = new Dictionary<string, bool>() 
                    {
                        {"Primainrdiale", false},
                        {"Créa-Main", true}
                    }
               },
            ];

            // Nombre de questions restantes
            int nb_questions_restantes = questions_réponses.Count;

            // Score du joueur
            byte score_j = 0;

            // Réponse à "Rejouer ?"
            string? txt_réponse = "";

            // Saisi du joueur
            string? saisi_j;
            byte nb_j;

            // Critère de saisi valide
            bool petit_entier = false;
            bool dans_interval = false;

            // Réponses du joueur
            List<byte> réponses_j = [];

            // Bonnes réponses
            List<byte> bonnes_réponses = [0, 1, 1];

            // --- AFFICHAGE DES QUESTIONS ET LEURS RÉPONSES --- //

            // Pour chaque objet question-réponse
            // foreach(QuestionRéponse question_réponse in questions_réponses)
            // {
            //     // Afficher la question
            //     Console.WriteLine(question_réponse.question);

            //     // S'il y a des réponses
            //     if(question_réponse.réponses_vérités != null)
            //     {
            //         // Pour chaque pair clé-valeur réponse-vérité de la question en cours
            //         foreach(KeyValuePair<string, bool> réponse_vérité in question_réponse.réponses_vérités)
            //         {
            //             // Afficher les réponses et leurs valeurs de vérité
            //             Console.WriteLine($"{réponse_vérité.Key}, {réponse_vérité.Value}");
            //         }
            //     }
                
            //     Console.WriteLine("\n");
            // }

            // --- DÉBUT DU JEU --- //

            // Accueil du joueur
            Console.WriteLine($"Bienvenu au quiz, il y a {nb_questions_restantes} questions.\n");

            // Tant que le joueur ne répond pas "n" à "Rejouer  ?"
            while(txt_réponse != null && txt_réponse.ToLower() != "n")
            {
                // Tant qu'il reste des questions et que le joueur n'a pas entré une saisi valide
                while(nb_questions_restantes > 0 && !petit_entier || !dans_interval)
                {
                    // S'il reste au moins une question
                    if(nb_questions_restantes > 0)
                    {
                        // Question-réponse en cours
                        QuestionRéponse question_rép_actu = questions_réponses[questions_réponses.Count-nb_questions_restantes];

                        // Afficher la question en cours
                        Console.WriteLine($"Question n°{questions_réponses.Count-nb_questions_restantes+1}:\n{question_rép_actu.question}");

                        // Si la question en cours existe et que ses réponses existent aussi
                        if(question_rép_actu != null && question_rép_actu.réponses_vérités != null)
                        {
                            // Pour chaque pair réponse-vérité de la question en cours
                            foreach(KeyValuePair<string, bool> réponse_vérité in question_rép_actu.réponses_vérités)
                            {
                                // Afficher la réponse
                                Console.WriteLine($"{réponse_vérité.Key}");
                            }
                        }
                    }

                    // Demander au joueur de saisir un entier dnas l'interval
                    Console.WriteLine($"\nEntrez un entier entre {min} et {max} et appuyez sur Entrer:");

                    // Obtention de la réponse du joueur
                    saisi_j = Console.ReadLine();

                    // On vérifie que la saisi du joueur est un petit entier
                    petit_entier = byte.TryParse(saisi_j, out nb_j);

                    // Si la saisi du joueur n'est pas un petit entier
                    if(!petit_entier)
                    {
                        // Lui dire
                        Console.WriteLine($"Erreur: {saisi_j} n'est pas un petit entier.\n");
                    }

                    // Si la saisi du joueur est un petit entier
                    else
                    {
                        // Confirmer la validité du critère
                        Console.WriteLine($"petit_entier == {petit_entier}.");

                        // Si la saisi du joueur est hors de l'interval
                        if(nb_j < min || nb_j > max)
                        {
                            // Le dire au joueur
                            Console.WriteLine($"Erreur: {nb_j} est hors de l'interval [{min}, {max}].\n");
                        }

                        // Si la saisi du joueur est dans l'interval 
                            // Valider le critère et le confirmer
                            dans_interval = true;
                            Console.WriteLine($"dans_interval == {dans_interval}.");
                            Console.WriteLine($"nb_j == {nb_j}.");

                            // Enregistrer la réponse du joueur
                            réponses_j.Add(nb_j);

                            // Pour chaque réponse du joueur
                            Console.WriteLine("Réponses du joueur:");
                            foreach(byte répponse in réponses_j)
                            {
                                // L'afficher
                                Console.Write($"{répponse} ");
                            }

                        // S'il reste au moins 1 question
                        if(nb_questions_restantes > 0)
                        {
                            // Reset des bools pour passer à la question suivante
                            petit_entier = false;
                            dans_interval = false;
                        }
                    }

                    // Descendre de 1 le nombre de questions restantes
                    nb_questions_restantes--;
                    Console.WriteLine($"\nnb_questions_restantes == {nb_questions_restantes}.\n");
                }

                // S'il ne reste aucune question
                if(nb_questions_restantes < 1)
                {
                    // Le dire
                    Console.WriteLine("Il ne reste aucune question.");

                    // --- COMPARAISON --- //

                    // Pour toutes les bonnes réponses
                    for(byte br = 0; br < bonnes_réponses.Count; br++)
                    {
                        // Si la réponse du joueur est identique à la bonne réponse
                        if(réponses_j[br] == bonnes_réponses[br])
                        {
                            // Augmenter le score du joueur de 1
                            score_j++;
                        }
                    }

                    // Pourcentage du score
                    float pourcent = (float) score_j/ (float) bonnes_réponses.Count * 100;

                    // Affichage du score et de son pourcentage
                    Console.WriteLine($"Score: {score_j}/{bonnes_réponses.Count} ({pourcent:00.00}%).");
                    
                    // Pour chaque objet question-réponse
                    Console.WriteLine("\nLes bonnes réponses étaient:");
                    foreach(QuestionRéponse question_réponse in questions_réponses)
                    {
                        // Si la question a des réponses
                        if(question_réponse.réponses_vérités != null)
                        {
                            // Pour chaque pair réponse-vérité
                            foreach(KeyValuePair<string, bool> réponse_vérité in question_réponse.réponses_vérités)
                            {
                                // Si la réponse est vrai
                                if(réponse_vérité.Value == true)
                                {
                                    // L'afficher
                                    Console.WriteLine(réponse_vérité.Key);
                                }
                            }
                        }
                    }

                    // --- FIN DE JEU --- //

                    // Tant que le joueur n'a répondu ni "o" ni "n" à "Rejouer ?"
                    while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                    {
                        // Demander au joueur s'il veut rejouer
                        Console.WriteLine("\nRejouer ? (Tapez 'o' ou 'n' et appuyez sur Entrer):");

                        // Réponse du joueur
                        txt_réponse = Console.ReadLine();

                        // Si le joueur répond "o"
                        if(txt_réponse != null && txt_réponse.ToLower() == "o")
                        {
                            // Vider la liste de réponses du joueur
                            réponses_j.Clear();

                            // Reset le nombre de questions restantes
                            nb_questions_restantes = questions_réponses.Count;

                            // Reset des bools  
                            petit_entier = false;
                            dans_interval = false;

                            // Reset de la réponse du joueur
                            txt_réponse = "";

                            // On quitte la boucle pour relancer le quiz
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
        }

        // private static void Main()
        // {
        //     Quiz();
        // }
    }

    // Classe QuestionRéponse
    class QuestionRéponse
    {
        // Texte de la question
        public string? question;

        // Dictionnaire réponse-vérité
        public Dictionary<string, bool>? réponses_vérités = [];
    }
}