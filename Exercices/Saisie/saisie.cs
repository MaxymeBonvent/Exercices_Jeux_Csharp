namespace SaisieN
{
    class SaisieC
    {
        // 1. Présentation
        private static string Présentation()
        {
            // Demande et obtention du prénom de l'utilisateur
            Console.WriteLine("Bonjour, quel est votre prénom ? (Écrivez votre prénom puis appuyez sur Entrer)");
            string? prénom = Console.ReadLine();

            // Demande et obtention du nom de l'utilisateur
            Console.WriteLine("Quel est votre nom ? (Écrivez votre nom puis appuyez sur Entrer)");
            string? nom = Console.ReadLine();

            // Message de bienvenu
            string? bienvenu = $"Bienvenu {prénom} {nom}.";
            
            // Affichage et récupération du message de bienvenu
            Console.WriteLine(bienvenu);
            return bienvenu;
        }

        // 2. Âge
        private static int Age(int année_actuelle)
        {
            // Valeurs de l'année de naissance
            string? txt_anné_naissance;
            int année_naissance;
            bool année_naissance_valide = false;

            // Validité du passage de l'anniversaire
            string? txt_anniv_passé; // 'o' ou 'n'

            // Tant que l'utilisateur n'a pas entré de nombre entier
            do
            {
                // Demande et obtention de l'année de naissance de l'utilisateur
                Console.WriteLine("Bonjour, en quelle année êtes-vous né ? (Tapez votre année de naissance en chiffres puis appuyez sur Entrer)");
                txt_anné_naissance = Console.ReadLine();

                // On vérifie que l'utilisateur a bien entré un nombr entier
                année_naissance_valide = int.TryParse(txt_anné_naissance, out année_naissance);
            }
            while(!année_naissance_valide);

            do
            {
                // Demande et obtention du passage de l'anniversaire de l'utilisateur
                Console.WriteLine("Avez-vous déjà eu votre anniversaire cette année ? (Tapez 'o' ou 'n' puis appuyez sur Entrer)");
                txt_anniv_passé = Console.ReadLine();
            }
            while(txt_anniv_passé != "o" && txt_anniv_passé != "n");

            // Si l'anniv n'est pas encore passé
            if(txt_anniv_passé == "n")
            {
                // Calcul de l'âge
                int âge = année_actuelle - année_naissance - 1;

                // Affichage et récupération de l'âge de l'utilisateur
                Console.WriteLine($"Vous avez {âge} ans.");
                return âge;
            }

            // Si l'anniv est déjà passé
            else
            {
                // Calcul de l'âge
                int âge = année_actuelle - année_naissance;

                // Affichage et récupération de l'âge de l'utilisateur
                Console.WriteLine($"Vous avez {âge} ans.");
                return âge;  
            }
        }

        private static void Main()
        {
           Age(2025);
        }
    }
}