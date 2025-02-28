namespace PierreFeuilleCiseauxN
{
    class PierreFeuilleCiseauxC
    {
        // Jeu du Pierre-Feuille-Ciseaux
        private static void PierreFeuilleCiseaux()
        {
            // --- VARIABLES --- //

            // Scores
            byte score_j = 0;
            byte score_o = 0;

            // Résultats
            byte égalités = 0;
            byte rounds = 0;

            // Groupe de lettres valides
            char[] lettres_valides = ['p', 'f', 'c'];

            // Critère de saisi valide du joueur
            bool une_lettre = false;
            bool lettre_valide = false;

            // Saisi et lettre du joueur
            string? saisi_j = "_";
            char lettre_j = '_';

            // Réponse du joueur à "Rejouer ?"
            string? txt_réponse = "";

            // Objet de la classe Random
            Random rand = new();

            // Choix possibles de l'ordi
            Dictionary<int, char> choix_pos_o = new() {{0, 'p'}, {1, 'f'}, {2, 'c'}};

            // Choix de l'ordi
            int numéro_o;
            char lettre_o;

            // --- DÉBUT DU JEU --- //

            // Accueil du joueur
            Console.WriteLine("Bienvenu au Pierre-Feuille-Ciseaux.");

            // Tant que le joueur ne répond pas Non à "Rejouer ?"
            while(txt_réponse != null && txt_réponse.ToLower() != "n")
            {
                // Tant que le joueur ne saisi pas une unique lettre valide
                while(!une_lettre || !lettre_valide)
                {
                    // Demander au joueur de saisir une unique lettre valide
                    Console.WriteLine("Veuillez écrire 'p', 'f' ou 'c' et appuyer sur Entrer:");

                    // Obtention de la saisi du joueur
                    saisi_j = Console.ReadLine();

                    // On vérifie que le joueur a saisi une unique lettre
                    une_lettre = char.TryParse(saisi_j, out lettre_j);

                    // Si le joueur a saisi plus d'un caractère
                    if(!une_lettre)
                    {
                        // Lui dire
                        Console.WriteLine($"Erreur: {saisi_j} fait plus d'une lettre.");
                    } 

                    // Si le joueur a saisi un unique caractère
                    else
                    {
                        // Valider le critère
                        // Console.WriteLine($"une_lettre == {une_lettre}.");

                        // Si le joueur a saisi quelque chose
                        if(saisi_j != null)
                        {
                            // Variable de type char de la saisi du joueur
                            lettre_j = Convert.ToChar(saisi_j);
                            // Console.WriteLine($"lettre_j == {lettre_j}.");
                        }

                        // On vérifie que le joueur a saisi une lettre valide
                        foreach(char lettre in lettres_valides)
                        {
                            // Si le caractère du joueur est une lettre valide
                            if(lettre_j == lettre)
                            {
                                // Déclarer que la lettre du joueur est valide
                                lettre_valide = true;

                                // Confirmation du critère
                                // Console.WriteLine($"lettre_valide == {lettre_valide}.");
                            }
                        }

                        // Si le caractère du joueur n'est pas une lettre valide
                        if(!lettre_valide)
                        {
                            // Lui dire
                            Console.WriteLine($"Erreur: {saisi_j} n'est pas une lettre valide.");
                        }

                        // Si le caractère du joueur est une lettre valide
                        else
                        {
                            // Confirmation du critère
                            // Console.WriteLine($"lettre_valide == {lettre_valide}.");

                            // Numéro de l'ordi
                            numéro_o = rand.Next(0, 3);
                            // Console.WriteLine($"numéro_o == {numéro_o}.");

                            // Lettre de l'ordi
                            lettre_o = choix_pos_o[numéro_o];
                            // Console.WriteLine($"lettre_o == {lettre_o}.");

                            // Donner la lettre de chaque joueur
                            Console.WriteLine($"\nVous avez choisi {lettre_j} et l'ordi a choisi {lettre_o}.");

                            // --- DÉFAITE DU JOUEUR --- //

                            if( lettre_j == 'p' && lettre_o == 'f' ||
                                lettre_j == 'f' && lettre_o == 'c' ||
                                lettre_j == 'c' && lettre_o == 'p')
                            {
                                // Monter de 1 le score de l'ordi et le nombre de rounds
                                score_o++;
                                rounds++;

                                // Dire au joueur qu'il a perdu
                                Console.WriteLine($"Vous avez perdu.");
                            }

                            // --- ÉGALITÉ --- //

                            else if(lettre_j == lettre_o)
                            {
                                // Monter de 1 le nombre d'égalités et de rounds
                                égalités++;
                                rounds++;

                                // Dire qu'il y a égalité
                                Console.WriteLine($"Égalité.");  
                            }

                            // --- VICTOIRE DU JOUEUR --- //

                            else
                            {
                                // Monter de 1 le score du joueur et le nombre de rounds
                                score_j++;
                                rounds++;

                                // Dire au joueur qu'il a gagné
                                Console.WriteLine($"Vous avez gagné."); 
                            }

                            // --- FIN DE JEU --- //

                            // Tant que le joueur ne répond ni "o" ni "n"
                            while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                            {   
                                // Afficher les résultats et demander au joueur s'il veut rejouer
                                Console.WriteLine($"Vous avez {score_j} points, l'ordi a {score_o} points, il y a {égalités} égalités et vous avez joué {rounds} rounds.\nRejouer ? (écrivez sur 'o' ou 'n' et appuyez sur Entrer)");

                                // Obtention de la saisi du joueur
                                txt_réponse = Console.ReadLine();

                                // Si le joueur répond "o"
                                if(txt_réponse != null && txt_réponse.ToLower() == "o")
                                {
                                    // Reset du choix du joueur
                                    saisi_j = "";
                                    lettre_j = '_';

                                    // Reset des bools
                                    une_lettre = false;
                                    lettre_valide = false;

                                    // Reset de la réponse du joueur
                                    txt_réponse = "";

                                    // Sorti de la boucle
                                    break;
                                }

                                // Si le joueur répond "n"
                                else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                                {
                                    // Lui dire au revoir
                                    Console.WriteLine("Au revoir.");
                                }
                            }
                        }
                    }
                }
            }
        }

        // private static void Main()
        // {
        //   PierreFeuilleCiseaux();
        // }
    }
}