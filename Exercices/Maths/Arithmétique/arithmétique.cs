using Microsoft.Win32.SafeHandles;

namespace ArithmétiqueN
{
    class ArithmétiqueC
    {
        // 1. Classer des nombres dans l'ordre croissant
        private static List<float> OrdreCroissant(List<float> liste)
        {
            // Organisation de la liste de nombres du plus petit au plus grand
            liste.Sort();

            // Affichage et récupération de la liste
            foreach(float nb in liste)
            {
                Console.Write($"{nb} ");
            }

            return liste;
        }

        // 2. Classer des nombres dans l'ordre décroissant
        private static List<float> OrdreDécroissant(List<float> liste)
        {
            // Organisation de la liste de nombres du plus grand au plus petit
            liste.Sort();
            liste.Reverse();

            // Affichage et récupération de la liste
            foreach(float nb in liste)
            {
                Console.Write($"{nb} ");
            }

            return liste;
        }

        // 3. Addition de deux nombres
        private static float Addition(float nb1, float nb2)
        {
            // Calcul de la somme
            float somme = nb1 + nb2;

            // Affichage et récupération de la somme
            Console.WriteLine($"{nb1} + {nb2} = {somme:00.00}.");
            return somme;
        }

        // 4. Soustraction de deux nombres
        private static float Soustraction(float nb1, float nb2)
        {
            // Calcul de la différence
            float différence = nb1 - nb2;

            // Affichage et récupération de la différence
            Console.WriteLine($"{nb1} - {nb2} = {différence:00.00}.");
            return différence;
        }

        // 5. Multiplication de deux nombres
        private static float Multiplication(float nb1, float nb2)
        {
            // Calcul du produit
            float produit = nb1 * nb2;

            // Affichage et récupération du produit
            Console.WriteLine($"{nb1} x {nb2} = {produit:00.00}.");
            return produit;
        }

        // 6. Division de deux nombres
        private static float Division(float nb1, float nb2)
        {
            if(nb2 == 0)
            {
                // Affichage d'un message d'erreur
                Console.WriteLine($"Erreur : division par zéro.");
                return 0;
            }
            
            float quotient = nb1 / nb2;

            // Affichage et récupération du quotient
            Console.WriteLine($"{nb1} / {nb2} = {quotient:00.00}.");
            return quotient;
        }

        // 7. Table de multiplication
        private static List<float> TableMultiplication(int nbProduits, float facteur)
        {
            // Liste de produits
            List<float> produits = [];

            // Pour tous les entiers de 1 à nbProduits
            for(int i = 1; i <= nbProduits; i++)
            {
                // Multiplier facteur par i et stocker le produit
                float produit = facteur * i;
                Console.WriteLine($"{facteur} x {i} = {produit}.");

                // Ajouter le produit à la liste
                produits.Add(produit);
            }

            return produits;
        }

        // 8. Table de division
        private static List<float> TableDivision(int nbQuotients, float dividende)
        {
            // Liste de quotients
            List<float> quotients = [];

            // Pour tous les entiers de 1 à nbQuotients
            for(int i = 1; i <= nbQuotients; i++)
            {
                // Diviser le dividende par i et stocker le quotient
                float quotient = dividende/i;
                Console.WriteLine($"{dividende}/{i} = {quotient:00.00}.");

                // Ajouter le quotient à la liste
                quotients.Add(quotient);
            }

            return quotients;
        }

        // 9. Table de modulo
        private static List<float> TableModulo(int nbRestes, float dividende)
        {
            // Liste de restes
            List<float> restes = [];

            // Pour tous les entiers de 1 à nbRestes
            for(int i = 1; i <= nbRestes; i++)
            {
                // Diviser le dividende par i et stocker le reste
                float reste = i % dividende;
                Console.WriteLine($"{i} % {dividende} = {reste:00.00}.");

                // Ajouter le reste à la liste
                restes.Add(reste);
            }

            return restes;
        }

        // 10. Table de puissance
        private static List<double> TablePuissance(double nbPuissances, double _base)
        {
            // Liste de puissances
            List<double> puissances = [];

            // Pour tous les entiers de 1 à nbPuissances
            for(int i = 1; i <= nbPuissances; i++)
            {
                // Élever la base à l'exposant i et stocker la puissance
                double puissance = Math.Pow(_base, i);
                Console.WriteLine($"{_base}^{i} = {puissance:00.00}.");

                // Ajouter la puissance à la liste
                puissances.Add(puissance);
            }

            return puissances;
        }

        // 11. Pourcentage 
        private static float Pourcentage(float numérateur, float dénominateur)
        {
            // Calcul du pourcentage
            float pourcentage = (numérateur/dénominateur) * 100;

            // Affichage et récupération du pourcentage
            Console.WriteLine($"{numérateur} correspond à {pourcentage:00.00}% de {dénominateur}.");
            return pourcentage;
        }

        // 12. Somme d'un groupe de nombres
        private static float AdditionGroupe(float[] nbs)
        {
            // Somme initiale
            float somme = 0;

            // Pour chaque nombre du groupe
            foreach(float nb in nbs)
            {
                // Ajouter sa valeur à la somme
                somme += nb;
            }

            // Afficher le montant de la somme finale
            Console.WriteLine($"somme = {somme}.");

            return somme;
        }

        // 13. Produit d'un groupe de nombres
        private static float ProduitGroupe(float[] nbs)
        {
            // Produit initiale
            float produit = 1;

            // Pour chaque nombre du groupe
            foreach(float nb in nbs)
            {
                // Multiplier sa valeur par le produit
                produit *= nb;
            }

            // Afficher le montant du produit finale
            Console.WriteLine($"produit = {produit}.");

            return produit;
        }

        // 14. FizzBuzz
        private static void FizzBuzz(int max)
        {
            // Pour tous les entiers de 1 à max inclu
            for(int i = 0; i <= max; i++)
            {
                // Si l'entier est un multiple de 3 et non de 5
                if(i % 3 == 0 && i % 5 != 0)
                {
                    // Afficher "Fizz"
                    Console.WriteLine("Fizz");
                }

                // Si l'entier est un multiple de 5 et non de 3
                else if(i % 5 == 0 && i % 3 != 0)
                {
                    // Afficher "Buzz"
                    Console.WriteLine("Buzz");
                }

                // Si l'entier est un multiple de 3 et de 5
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    // Afficher "FizzBuzz"
                    Console.WriteLine("FizzBuzz");
                }

                // Si l'entier n'est un multiple ni de 3 ni de 5
                else
                {
                    // Afficher l'entier
                    Console.WriteLine(i);
                }
            }
        }

        // 15. Puissance
        private static double Puissance(double nbBase, double exposant)
        {
            // Calcul de la puissance
            double puissance = Math.Pow(nbBase, exposant);

            // Affichage et récupération de la puissance
            Console.WriteLine($"{nbBase:00.00}^{exposant} = {puissance:00.00}.");
            return puissance;
        }

        // 16. Factorielle
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

        // 17. Suite de Fibonacci
        private static List<int> Fibonacci(int nbTermes)
        {
            // Si nbTermes est inférieur à 1
            if(nbTermes < 1)
            {
                // Afficher un message d'erreur
                Console.WriteLine($"Erreur : {nbTermes} est inférieur à 1.");

                // Fin de la fonction
                return [];
            }

            // Si nbTermes vaut 1
            else if(nbTermes == 1)
            {
                // Afficher le premier terme de la suite
                Console.WriteLine("0");
                return [0];
            }

            // Si nbTermes vaut 2
            else if(nbTermes == 2)
            {
                // Afficher les deux premiers termes de la suite
                Console.WriteLine("0 1");
                return [0, 1];
            }

            // Si nbTermes dépasse 2
            else
            {
                // Deux premiers termes de la suite
                int premier = 0;
                int deuxième = 1;

                // Liste d'entiers contenant les deux premiers termes
                List<int> termes = new List<int>{premier, deuxième};

                // Pour tous les entiers de 2 à nbTermes
                for(int i = 2; i < nbTermes; i++)
                {
                    // Calculer la somme des deux termes précédents
                    int somme = termes[i - 1] + termes[i - 2];

                    // Ajouter la somme à la liste
                    termes.Add(somme);
                }

                // Affichage de la suite
                foreach(int terme in termes)
                {
                    Console.Write($"{terme} ");
                }

                // Récupération de la suite
                return termes;
            }
        }

        // 18. Savoir si un nombre est premier
        private static bool Premier(float nb)
        {
            // Réponse à la question "nb est-il premier ?"
            bool premier = nb % 2 != 0;

            // Si nb est premier
            if(premier)
            {
                // Afficher la réponse
                Console.WriteLine($"{nb} est premier.");
            }

            // Si nb n'est  pas premier
            else
            {
                // Afficher la réponse
                Console.WriteLine($"{nb} n'est pas premier.");
            }

            // Récupérer la réponse
            return premier;
        }

        // 19. Somme des chiffres d'un nombre
        private static double SommeChiffres(int nb)
        {
            // Convertir le nombre en chaîne
            string txtNb = nb.ToString();
            // Console.WriteLine($"txtNb == {txtNb}.");

            // Convertir la chaîne en groupe de lettres
            char[] lettresTxtNb = txtNb.ToCharArray();

            // Liste de chiffres
            List<double> chiffres = [];

            // Pour chaque lettre du groupe de lettres du texte du nombre
            // Console.WriteLine("Liste de lettres:");
            foreach(char lettre in lettresTxtNb)
            {
                // Afficher la lettre
                // Console.Write($"{lettre} ");

                // Convertir la lettre en nombre entier
                double entierLettre = char.GetNumericValue(lettre);

                // Ajouter le chiffre à la liste
                chiffres.Add(entierLettre);
            }

            // Console.WriteLine("\n");

            // Pour chaque chiffre dans la liste de chiffre
            // Console.WriteLine("Liste de chiffres:");
            // foreach(double chiffre in chiffres)
            // {
            //     // Afficher le chiffre
            //     Console.Write($"{chiffre} ");
            // }

            // Console.WriteLine("\n");

            // Calcul de la somme de la liste de chiffres
            double somme = chiffres.Sum();

            // Affichage et récupération de la somme
            Console.WriteLine($"Somme des chiffres de {nb}: {somme}.");
            return somme;
        }

        // 20. Produit des chiffres d'un nombre
        private static double ProduitChiffres(int nb)
        {
            // Convertir le nombre en chaîne
            string txtNb = nb.ToString();
            // Console.WriteLine($"txtNb == {txtNb}.");

            // Convertir la chaîne en groupe de lettres
            char[] lettresTxtNb = txtNb.ToCharArray();

            // Liste de chiffres
            List<double> chiffres = [];

            // Pour chaque lettre du groupe de lettres du texte du nombre
            // Console.WriteLine("Liste de lettres:");
            foreach(char lettre in lettresTxtNb)
            {
                // Afficher la lettre
                // Console.Write($"{lettre} ");

                // Convertir la lettre en nombre entier
                double entierLettre = char.GetNumericValue(lettre);

                // Ajouter le chiffre à la liste
                chiffres.Add(entierLettre);
            }

            // Console.WriteLine("\n");

            // Pour chaque chiffre dans la liste de chiffre
            // Console.WriteLine("Liste de chiffres:");
            // foreach(double chiffre in chiffres)
            // {
            //     // Afficher le chiffre
            //     Console.Write($"{chiffre} ");
            // }

            // Console.WriteLine("\n");

            // Produit initial
            double produit = 1;

            // Pour chaque chiffre de la liste de chiffres
            foreach(double chiffre in chiffres)
            {
                // Multiplier le produit par ce chiffre
                produit *= chiffre;
            }
            
            // Affichage et récupération du produit
            Console.WriteLine($"Produit des chiffres de {nb}: {produit}.");
            return produit;
        }

        // 21. PPCM entre deux entiers
        private static int PPCM(int nb1, int nb2)
        {
            // Si l'un des arguments vaut 0
            if(nb1 == 0 || nb2 == 0)
            {
                // Affichage et récupération du PPCM
                Console.WriteLine($"PPCM({nb1}, {nb2}) = 0.");
                return 0;
            }

            // Si aucun argument ne vaut 0
            else
            {
                // Liste des multiples de nb1 et nb2
                List<int> multiples_nb1 = [];
                List<int> multiples_nb2 = [];

                // Pour tous les entiers de 1 à 100
                for(int i = 1; i <= 100; i++)
                {
                    // Multiplier nb1 par i
                    int produit_nb1 = nb1 * i;
                    // Console.WriteLine($"{nb1} x {i} = {produit_nb1}.");

                    // Ajouter le produit à multiples_nb1
                    multiples_nb1.Add(produit_nb1);

                    // Multiplier nb2 par i
                    int produit_nb2 = nb2 * i;
                    // Console.WriteLine($"{nb2} x {i} = {produit_nb2}.\n");

                    // Ajouter le produit à multiples_nb2
                    multiples_nb2.Add(produit_nb2);
                }

                // Pour tous les multiples de nb1
                // Console.WriteLine($"Multiples de {nb1}:");
                // foreach(int multiple in multiples_nb1)
                // {
                //     // Afficher le multiple
                //     Console.WriteLine($"{multiple}");
                // }

                // Console.WriteLine("\n");

                // Pour tous les multiples de nb2
                // Console.WriteLine($"Multiples de {nb2}:");
                // foreach(int multiple in multiples_nb2)
                // {
                //     // Afficher le multiple
                //     Console.WriteLine($"{multiple}");
                // }

                // Console.WriteLine("\n");

                // Liste de multiples communs à nb1 et nb2
                List<int> multiples_communs = [];

                // Pour tous les multiples de nb1
                foreach(int multiple_nb1 in multiples_nb1)
                {
                    // Pour tous les multiples de nb2
                    foreach(int multiple_nb2 in multiples_nb2)
                    {
                        // Si multiple_nb2 est égale à multiple_nb1
                        if(multiple_nb2 == multiple_nb1)
                        {
                            // Message
                            // Console.WriteLine($"{multiple_nb2} de {nb2} == {multiple_nb1} de {nb1}.");

                            // Ajouter ce multiple à la liste de multiples communs
                            multiples_communs.Add(multiple_nb2);
                        }
                    }
                }

                // Console.WriteLine("\n");

                // Pour tous les multiples communs
                // Console.WriteLine($"Multiples communs de {nb1} et {nb2}:");
                // foreach(int multiple_commun in multiples_communs)
                // {
                //     // Afficher le multiple commun
                //     Console.Write($"{multiple_commun} ");
                // }

                // S'il existe au moins 1 multiple commun
                if(multiples_communs.Count > 0)
                {
                    // Définir le PPCM comme le premier membre de la liste des multiples communs
                    int ppcm = multiples_communs[0];

                    // Affichage et récupération du PPCM
                    Console.WriteLine($"PPCM({nb1}, {nb2}) = {ppcm}.");
                    return ppcm;
                } 

                // S'il n'existe aucun multiple commun  
                else
                {
                    // Afficher la non-existence du PPCM
                    Console.WriteLine($"Il n'existe aucun PPCM entre {nb1} et {nb2}.");
                    return 0;
                }
            }
        }

        // 22. PGCD entre deux entiers
        private static int PGCD(int nb1, int nb2)
        {
            // Si l'un des arguments vaut 0
            if(nb1 == 0 || nb2 == 0)
            {
                // Affichage et récupération du PGCD
                Console.WriteLine($"PGCD({nb1}, {nb2}) = 0.");
                return 0;
            }

            // Si aucun argument ne vaut 0
            else
            {
                // Liste des diviseurs de nb1 et nb2
                List<int> diviseurs_nb1 = [];
                List<int> diviseurs_nb2 = [];

                // Pour tous les entiers de 1 à 100
                for(int i = 1; i < 100; i++)
                {
                    // Calculer le quotient de nb1 divisé par i
                    int quotient_nb1 = nb1/i;

                    // Si le reste de nb1 divisé par i vaut 0
                    if(nb1 % i == 0)
                    {
                        // Ajouter le quotient à la liste des diviseurs
                        diviseurs_nb1.Add(quotient_nb1);
                    }

                    // Calculer le quotient de nb2 divisé par i
                    int quotient_nb2 = nb2/i;

                    // Si le reste de nb2 divisé par i vaut 0
                    if(nb2 % i == 0)
                    {
                        // Ajouter le quotient à la liste des diviseurs
                        diviseurs_nb2.Add(quotient_nb2);
                    }
                }

                // Pour tous les diviseurs de nb1
                // Console.WriteLine($"Diviseurs de {nb1}:");
                // foreach(int diviseur in diviseurs_nb1)
                // {
                //     // Afficher le diviseur
                //     Console.WriteLine($"{diviseur}");
                // }

                // Console.WriteLine("\n");

                // Pour tous les diviseurs de nb2
                // Console.WriteLine($"Diviseurs de {nb2}:");
                // foreach(int diviseur in diviseurs_nb2)
                // {
                //     // Afficher le diviseur
                //     Console.WriteLine($"{diviseur}");
                // }

                // Console.WriteLine("\n");

                // Liste de diviseurs communs
                List<int> diviseurs_communs = [];

                // Pour tous les diviseurs de nb1
                foreach(int diviseur_nb1 in diviseurs_nb1)
                {
                    // Pour tous les diviseurs de nb2
                    foreach(int diviseur_nb2 in diviseurs_nb2)
                    {
                        // Si le diviseur de nb2 est égal au diviseur de nb1
                        if(diviseur_nb2 == diviseur_nb1)
                        {   
                            // Confirmation
                            // Console.WriteLine($"{diviseur_nb2} de {nb2} == {diviseur_nb1} de {nb1}.");

                            // Ajout de ce nombre à la liste des diviseurs communs
                            diviseurs_communs.Add(diviseur_nb2);
                        }
                    }
                }

                // Console.WriteLine("\n");

                // Pour tous les diviseurs communs
                // Console.WriteLine($"Diviseurs communs de {nb1} et {nb2}:");
                // foreach(int diviseur_commun in diviseurs_communs)
                // {
                //     // Afficher le diviseur commun
                //     Console.WriteLine($"{diviseur_commun}");
                // }

                // Console.WriteLine("\n");

                // S'il existe au moins 1 diviseur commun
                if(diviseurs_communs.Count > 0)
                {
                    // Définir le PGCD comme le premier diviseur de la liste des diviseurs communs
                    int pgcd = diviseurs_communs[0];

                    // Affichage et récupération du PGCD
                    Console.WriteLine($"PGCD({nb1}, {nb2}) = {pgcd}.");
                    return pgcd;
                }

                // S'il n'y a aucun diviseur commun
                else
                {
                    // Afficher la non-existence du PGCD
                    Console.WriteLine($"Il n'existe aucun PGCD entre {nb1} et {nb2}.");
                    return 0;
                }
            }
        }

        // 23. Somme d'un groupe de nombres
        private static float SommeNombres(float[] nbs)
        {
            // Somme initiale
            float somme = 0;

            // Pour tous les nombres du groupe
            for(int i = 0; i < nbs.Length; i++)
            {
                // Ajouter ce nombre à la somme
                somme += nbs[i];
            }

            // Affichage et récupération de la somme
            Console.WriteLine($"Somme des nombres: {somme:00.00}.");
            return somme;
        }

        // 24. Produit d'un groupe de nombres
        private static float ProduitNombres(float[] nbs)
        {
            // Produit initiale
            float produit = 1;

            // Pour tous les nombres du groupe
            for(int i = 0; i < nbs.Length; i++)
            {
                // Multiplier le produit par ce nombre
                produit *= nbs[i];
            }

            // Affichage et récupération du produit
            Console.WriteLine($"Produit des nombres: {produit:00.00}.");
            return produit;
        }

        // 25. Somme de tous les entiers de 0 à N
        private static int SommeEntiersConsécutifs(int max)
        {
            // Somme initiale
            int somme = 0;

            // Pour tous les entiers de 0 à max inclus
            for(int i = 0; i <= max; i++)
            {
                // Ajouter i à la somme
                somme += i;
            }

            // Affichage et récupération de la somme
            Console.WriteLine($"Somme de tous les entiers de 0 à {max}: {somme}.");
            return somme;
        }

        // 26. Moyenne d'un groupe de nombres
        private static float Moyenne(float[] nbs)
        {
            // Taille du groupe
            int taille = nbs.Length;
            Console.WriteLine($"Taille du groupe: {taille}.");

            // Somme initiale
            float somme = 0;

            // Pour tous les nombres du groupe
            for(int i = 0; i < nbs.Length; i++)
            {
                // Ajouter ce nombre à la somme
                somme += nbs[i];
            }

            // Somme du groupe
            Console.WriteLine($"Somme du groupe: {somme}.");

            // Calcul de la moyenne
            float moyenne = somme/taille;

            // Affichage et récupération de la moyenne
            Console.WriteLine($"Moyenne du groupe: {moyenne}.");
            return moyenne;
        }

        // Exécution
        private static void Main()
        {
            Moyenne([0, 1, 2, 3]);
        }
    }   
}