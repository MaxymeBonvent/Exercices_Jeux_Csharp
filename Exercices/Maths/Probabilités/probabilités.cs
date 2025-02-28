using System.Data;

namespace ProbaN
{
    class ProbaC
    {
        // -1. Factorielle
        private static double Factorielle(double max)
        {
            // Si l'argument est 0
            if(max == 0)
            {
                // Affichage et récupération de la valeur
                Console.WriteLine("0! = 1.");
                return 1;
            }

            // Si l'argument n'est pas 0
            else
            {
                // Produit initiale
                int produit = 1;

                // Si l'argument est négatif
                if(max < 0)
                {
                    // Pour tous les entiers de -1 à max
                    for(int i = -1; i >= max; i--)
                    {
                        // Multiplier le produit par l'entier
                        produit *= i;
                    }
                } 

                // Si l'argument est positif
                else
                {
                   // Pour tous les entiers de 1 à max
                    for(int i = 1; i <= max; i++)
                    {
                        // Multiplier le produit par l'entier
                        produit *= i;
                    } 
                }

                // Affichage et récupération du produit final
                Console.WriteLine($"{max}! = {produit}.");
                return produit;
            }
        }

        // 0. Calculer le coefficient binomial de deux entiers
        private static double CoeffBinomial(double parti, double ensemble)
        {
            // Calcul du coefficient binomial
            double coeffBinomial = 
            Factorielle(ensemble)/(Factorielle(parti) * Factorielle(ensemble- parti));

            // Affichage et récupération du coefficient binomial
            Console.WriteLine($"{parti} parmi {ensemble}: {coeffBinomial}.\n");
            return coeffBinomial;
        }

        // 1. Probabilités de tirer chaque élément d'un groupe une fois
        private static Dictionary<float, float> ProbaTirageUnique(float[] nbs)
        {
            // Taille du groupe
            float taille = nbs.Length;
            Console.WriteLine($"Taille du groupe: {taille}.");

            // Nombres et leur compte
            Dictionary<float, int> nb_compte = [];

            // Pour tous les nombres du groupe
            for(int i = 0; i < nbs.Length; i++)
            {
                // Si ce nombre n'est pas dans le dictionnaire
                if(!nb_compte.ContainsKey(nbs[i]))
                {
                    // Ajouter une paire nombre-compte comptant ce nombre 1 fois
                    nb_compte.Add(nbs[i], 1);
                }

                // Si ce nombre est dans le dictionnaire
                else
                {
                    // Monter son compte de 1
                    nb_compte[nbs[i]]++;
                }
            }

            // Dictionnaire de nombres et de leur probabilités d'être tirés
            Dictionary<float, float> nb_proba = [];

            // Pour chaque paire nombre-compte
            Console.WriteLine("\nPaires nombre-compte:");
            foreach(KeyValuePair<float, int> nb_co in nb_compte)
            {
                // Afficher la paire
                Console.WriteLine(nb_co);

                // Calcul de la probabilité de tirer le nombre de la paire
                float proba = nb_co.Value/taille * 100;

                // Ajouter cette proba aux probas
                nb_proba.Add(nb_co.Key, proba);
            }

            // Pour chaque paire nombre-proba
            Console.WriteLine("\nPaires nombre-proba:");
            foreach(KeyValuePair<float, float> nb_pb in nb_proba)
            {
                // Afficher la paire
                Console.WriteLine($"[{nb_pb.Key}, {nb_pb.Value:00.00}%]");
            }

            return nb_proba;
        }

        // 2. Proba d'obtenir un nombre de 2 à 12 pour deux lancers de dés à 6 faces
        private static Dictionary<int, float> ProbaDeuxDés()
        {
            // Sommes et leur compte
            Dictionary<int, int> somme_compte = [];

            // Pour chaque face du premier dé
            for(int p = 1; p < 7; p++)
            {
                // Pour chaque face du deuxième dé
                for(int d = 1; d < 7; d++)
                {
                    // Calculer la somme
                    int somme = p + d;

                    // Si la somme n'est pas dans le dictionnaire
                    if(!somme_compte.ContainsKey(somme))
                    {
                        // Ajouter une paire comptant cette somme 1 fois
                        somme_compte.Add(somme, 1);
                    }

                    // Si la somme est dans le dictionnaire
                    else
                    {
                        // Monter son compte de 1
                        somme_compte[somme]++;
                    }
                }
            }

            // Taille de somme_compte
            float taille = somme_compte.Count;
            Console.WriteLine($"Taille de somme-compte: {taille} paires.");

            // Paires somme-proba
            Dictionary<int, float> somme_proba = [];

            // Pour chaque paire somme-compte
            Console.WriteLine("\nPaires somme-compte:");
            foreach(KeyValuePair<int, int> s_c in somme_compte)
            {
                // Afficher la paire
                Console.WriteLine(s_c);

                // Calculer la proba de la somme
                float proba = s_c.Value/taille * 100;

                // Ajouter cette proba au dictionnaire somme-proba
                somme_proba.Add(s_c.Key, proba);
            }

            // Pour chaque paire somme-proba
            Console.WriteLine("\nPaires somme-proba:");
            foreach(KeyValuePair<int, float> s_p in somme_proba)
            {
                // Afficher la paire
                Console.WriteLine($"[{s_p.Key}, {s_p.Value:00.00}%]");
            }

            return somme_proba;
        }

        // 3. Probabilités de tirer un élément N fois de suite dans N tirages succ. avec remise
        private static double ProbaTiragesSuccAR(double parti, double ensemble, double tirages_gagnant, double tirages)
        {
            // Proba de succès et échec
            double succes = parti/ensemble;
            double echec = (ensemble - parti)/ensemble;

            // Proba d'avoir exactement S succès en T tirages
            double proba_S_succes = CoeffBinomial(tirages_gagnant, tirages) * Math.Pow(succes, tirages_gagnant) * Math.Pow(echec, tirages - tirages_gagnant);
            Console.WriteLine($"Proba d'avoir {tirages_gagnant} tirages gagnant en {tirages} tirages: {proba_S_succes:0.000}.");

            // Calcul du pourcentage de succès
            double pourcentage = proba_S_succes * 100;

            // Affichage et récupération du pourcentage de chance d'avoir G tirages gagnant
            Console.WriteLine($"Pourcentage de succès: {pourcentage:00.00}%.");
            return pourcentage;
        }

        // 4. Problème de Monty Hall
        private static float MontyHall(bool changement)
        {
            // Probas de victoire
            float probas = (1f/3f) * 100f;

            // Si le joueur change de porte
            if(changement)
            {
                // Ses probas de victoires passes à 2/3
                probas = (2f/3f) * 100f;
                Console.WriteLine($"Vos chances de victoire passent à {probas:00.00}%.");
            }

            // Si le joueur ne change pas de porte
            else
            {
                // Ses probas restent les mêmes
                Console.WriteLine($"Vos chances de victoire restent à {probas:00.00}%.");
            }

            return probas;
        }

        private static void Main()
        {
            MontyHall(true);
        }
    }
}