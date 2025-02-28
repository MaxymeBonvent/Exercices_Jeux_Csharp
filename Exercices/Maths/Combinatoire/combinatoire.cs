namespace CombinatoireN
{
    class CombinatoireC
    {
        // 0. Factorielle
        private static int Factorielle(int max)
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

        // 1. Trouver toutes les permutations d'une chaîne
        private static List<string> Permutations(string txt)
        {
            // Affichage du texte initial
            Console.WriteLine($"Texte intial: {txt}");

            // Affichage de la taille du texte
            Console.WriteLine($"Taille du texte: {txt.Length} caractères.\n");

            // Liste de caractères
            List<char> listeCaractères = txt.ToList<char>();

            // Pour chaque caractère de la liste
            Console.WriteLine("Caractères de la liste:");
            foreach(char cara in listeCaractères)
            {
                // Afficher celui-ci
                Console.Write($"{cara} ");
            }

            Console.WriteLine("\n");

            // Nombre initial de permutations
            int nbPermutations = 1;

            // Pour tous les entiers de 1 au nombre de caractères
            for(int i = 1; i <= listeCaractères.Count; i++)
            {
                // Multiplier nbPermutations par cet entier
                nbPermutations *= i;
            }

            // Afficher le nombre de permutations
            Console.WriteLine($"nbPermutations: {nbPermutations}.");

            // Liste de permutations
            List<string> permutations = [];
            permutations.Add(txt);

            // Pour tous les caractères de la liste
            for(int cara = 0; cara <= listeCaractères.Count; cara++)
            {
                // Permutation initial
                string permutation = "";
                


                // Ajouter cette permutation à la liste
                permutations.Add(permutation);
            }

            // Pour toutes les permutations
            Console.WriteLine("\nPermutations:");
            foreach(string permutation in permutations)
            {
                // Afficher celle-ci
                Console.WriteLine($"{permutation}");
            }

            return permutations;
        }

        // 4. Calculer le coefficient binomial de deux entiers
        private static int CoeffBinomial(int parti, int ensemble)
        {
            // Calcul du coefficient binomial
            int coeffBinomial = 
            Factorielle(ensemble)/(Factorielle(parti) * Factorielle(ensemble- parti));

            // Affichage et récupération du coefficient binomial
            Console.WriteLine($"{parti} parmi {ensemble}: {coeffBinomial}.\n");
            return coeffBinomial;
        }

        private static void Main()
        {
            
        }
    }
}