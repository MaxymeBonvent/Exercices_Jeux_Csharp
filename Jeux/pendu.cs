using System.Security.Cryptography.X509Certificates;

namespace PenduN
{
    class PenduC
    {
        // Jeu du pendu
        private static void Pendu()
        {
            // --- VARIABLES --- //

            // Mots
            string[] mots = ["banane","croissance", "tennis", "console", "petit", "araignee", "bateau", "ecarlate", "emeraude", "riviere", "rouge", "vert", "bleu", "jaune", "violet", "noir", "gris", "blanc", "rose", "magenta", "cyan", "epaule", "elegant"];

            // Nombre de mots
            int nb_mots = mots.Length;
            // Console.WriteLine($"Nombre de mots : {nb_mots}.");

            // Objet de classe Random
            Random rand = new();

            // Entier aléatoire entre 0 et nb_mots
            int numMot = rand.Next(0, nb_mots);

            // Mot à deviner
            string? mot = mots[numMot];
            // Console.WriteLine($"Mot à deviner: {mot}. Taille: {mot.Length}.");

            // Mot en pointillé initial
            string? mot_pointillés = "";

            // Pour chaque lettre du mot à deviner
            foreach(char cara in mot)
            {
                // Ajouter un pointillé
                mot_pointillés += "-";
            }

            // Console.WriteLine($"Mot en pointillés: {mot_pointillés}. Taille: {mot_pointillés.Length}.");
            
            // Alphabet
            char[] alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z','-'];

            // Lettres déjà rentrées
            List<char> lettresTestées = [];

            // Nombre d'essais initiaux et restant
            int essaisInit = mot.Length + 3;
            int essaisRest = essaisInit;

            // Réponse à "Rejouer ?"
            string? txt_réponse = "";

            // Saisi du joueur
            string? saisi_joueur = "";

            // Lettre du joueur
            char lettre_joueur = '0';

            // Vérification que le joueur n'a entré qu'un caractère
            bool un_caractère = false;

            // Vérification que le caractère est une lettre
            bool est_une_lettre = false;

            // --- DÉBUT DU JEU --- //

            // Accueil du joueur
            Console.WriteLine($"\nBienvenu au Pendu, voici le mot à deviner: {mot_pointillés}.\n");

            // Tant que le joueur ne répond pas Non à "Rejouer ?"
            while(txt_réponse != null && txt_réponse.ToLower() != "n")
            {
                // Tant que le joueur n'a pas saisi une unique lettre
                while(!un_caractère || !est_une_lettre)
                {
                    // Afficher les lettres testées
                    foreach(char lettre in lettresTestées)
                    {
                        Console.Write($"{lettre} ");
                    }

                    // Demander au joueur de saisir une lettre
                    Console.WriteLine($"\n\n{mot_pointillés} Veuillez saisir une lettre et appuyer sur Entrer : ({essaisRest} essais restant)");

                    saisi_joueur = Console.ReadLine();

                    // On vérifie que le joueur n'a entré qu'un caractère
                    un_caractère = char.TryParse(saisi_joueur, out lettre_joueur);

                    // Si le joueur entre plus d'un caractère
                    if(!un_caractère)
                    {
                        // Lui dire
                        Console.WriteLine($"{saisi_joueur} fait plus d'un caractère.");
                    }

                    // Si le joueur entre un caractère
                    else
                    {
                        // Pour chaque lettre de l'alphabet
                        foreach(char lettre in alphabet)
                        {
                            // Si la lettre de l'alphabet est identique au caractère du joueur
                            if(lettre == lettre_joueur)
                            {
                                // Déclarer que la saisi du joueur est une lettre
                                est_une_lettre = true;
                            }
                        }

                        // Si le joueur entre un caractère qui n'est pas une lettre
                        if(!est_une_lettre)
                        {
                            // Lui dire
                            Console.WriteLine($"{saisi_joueur} n'est pas une lettre.");
                        }

                        // Si le joueur entre une lettre
                        else
                        {
                            // Si la saisie du joueur n'est pas null
                            if(saisi_joueur != null)
                            {
                                // Variable de type char de la saisi_joueur
                                char char_saisi_joueur = saisi_joueur[0];

                                // Si le joueur a entré une lettre déjà testée
                                if(lettresTestées.Contains(char_saisi_joueur))
                                {
                                    // Lui dire
                                    Console.WriteLine($"Vous avez déjà essayé {char_saisi_joueur}.");

                                    // Reset des bools
                                    un_caractère = false;
                                    est_une_lettre = false;
                                }

                                // Si le joueur a entré une nouvelle lettre
                                else
                                {
                                    // Ajouter cette lettre à la liste des lettres testées
                                    lettresTestées.Add(char_saisi_joueur);
                                }
                            }
                        }
                    }
                }

                // --- ÉVALUATION DE LA LETTRE --- //

                // Si la saisi du joueur n'est pas null
                if(saisi_joueur != null)
                {
                    // Si la lettre entrée ne fait pas parti du mot
                    if(!mot.Contains(saisi_joueur))
                    {
                        // Le joueur perd un essai
                        essaisRest--;

                        // Si le joueur n'a plus d'essai
                        if(essaisRest < 1)
                        {
                            // --- FIN DE JEU --- //

                            // Dire au joueur qu'il a perdu, lui donner le mot et lui demander un autre round
                            Console.WriteLine($"Perdu, le mot était « {mot} ». Rejouer ? (Tapez 'o' ou 'n' et appuyez sur Entrer)");

                            // Obtenir la réponse du joueur
                            txt_réponse = Console.ReadLine();

                            // Tant que la réponse n'est ni "o" ni "n"
                            while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                            {
                                // Lui demander un autre round
                                Console.WriteLine($"Rejouer ? (Tapez 'o' ou 'n' et appuyez sur Entrer)");

                                // Obtenir la réponse du joueur
                                txt_réponse = Console.ReadLine();
                            }

                            // Si le joueur répond "o"
                            if(txt_réponse == "o")
                            {
                                // Reset des essais
                                essaisRest = essaisInit;

                                // Vidage de la liste de lettres testées
                                lettresTestées.Clear();

                                // Génération d'un nouveau mot
                                // Entier aléatoire entre 0 et nb_mots
                                numMot = rand.Next(0, nb_mots);

                                // Mot à deviner
                                mot = mots[numMot];
                                // Console.WriteLine($"Mot à deviner: {mot}. Taille: {mot.Length}.");

                                // Mot en pointillé initial
                                mot_pointillés = "";

                                // Pour chaque lettre du mot à deviner
                                foreach(char cara in mot)
                                {
                                    // Ajouter un pointillé
                                    mot_pointillés += "-";
                                }

                                // Reset des bools
                                un_caractère = false;
                                est_une_lettre = false;
                            }

                            // Si le joueur répond "n"
                            else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                            {
                                // Dire au revoir au joueur
                                Console.WriteLine("Au revoir.");
                            }
                        }

                        // S'il a encore des essais
                        else
                        {
                            // Reset des bools
                            un_caractère = false;
                            est_une_lettre = false;
                        }
                    }

                    // Si la lettre entrée fait parti du mot
                    else
                    {
                        // Variable de type char de la saisi du joueur
                        char char_saisi_joueur = saisi_joueur[0];

                        // Groupe de tirets du moit en pointillés
                        char[] chars_mot_pointillés = mot_pointillés.ToCharArray();

                        // Pour toutes les lettres du mot à deviner
                        for(int lettre = 0; lettre < mot.Length; lettre++)
                        {
                            // Si la lettre du mot est égale à celle saisi par le joueur
                            if(mot[lettre] == char_saisi_joueur)
                            {
                                // Remplacer le - n°lettre par la saisi du joueur
                                chars_mot_pointillés[lettre] = char_saisi_joueur;
                            }
                        }

                        // Le mot en pointillé est changé
                        mot_pointillés = new string(chars_mot_pointillés);

                        // Si le mot est terminé
                        if(mot_pointillés == mot)
                        {
                            // --- FIN DE JEU --- //

                            // Afficher le mot complet
                            Console.WriteLine(mot_pointillés);
                            
                            // Dire au joueur qu'il a gagné et lui demander un autre round
                            Console.WriteLine($"Vous avez gagné. Rejouer ? (Tapez 'o' ou 'n' et appuyez sur Entrer)");

                            // Obtenir la réponse du joueur
                            txt_réponse = Console.ReadLine();

                            // Tant que la réponse n'est ni "o" ni "n"
                            while(txt_réponse != null && txt_réponse.ToLower() != "o" && txt_réponse.ToLower() != "n")
                            {
                                // Lui demander un autre round
                                Console.WriteLine($"Rejouer ? (Tapez 'o' ou 'n' et appuyez sur Entrer)");

                                // Obtenir la réponse du joueur
                                txt_réponse = Console.ReadLine();
                            }

                            // Si le joueur répond "o"
                            if(txt_réponse == "o")
                            {
                                // Reset des essais
                                essaisRest = essaisInit;

                                // Vidage de la liste de lettres testées
                                lettresTestées.Clear();

                                // Génération d'un nouveau mot
                                // Entier aléatoire entre 0 et nb_mots
                                numMot = rand.Next(0, nb_mots);

                                // Mot à deviner
                                mot = mots[numMot];
                                Console.WriteLine($"Mot à deviner: {mot}. Taille: {mot.Length}.");

                                // Mot en pointillé initial
                                mot_pointillés = "";

                                // Pour chaque lettre du mot à deviner
                                foreach(char cara in mot)
                                {
                                    // Ajouter un pointillé
                                    mot_pointillés += "-";
                                }

                                // Reset des bools
                                un_caractère = false;
                                est_une_lettre = false;
                            }

                            // Si le joueur répond "n"
                            else if(txt_réponse != null && txt_réponse.ToLower() == "n")
                            {
                                // Dire au revoir au joueur
                                Console.WriteLine("Au revoir.");
                            }
                        }

                        // Si le mot n'est pas terminé
                        else
                        {
                            // Reset des bools
                            un_caractère = false;
                            est_une_lettre = false;
                        }
                    }
                }
            }
        }

        // private static void Main()
        // {
        //     Pendu();
        // }
    }
}