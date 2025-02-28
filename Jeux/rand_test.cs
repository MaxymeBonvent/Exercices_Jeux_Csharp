namespace RandTestN
{
    class RandTestC
    {
        // Fonction pour savoir si l'on peut générer un entier aléatoire entre N et N
        private static uint RandTest()
        {
            // Objet de la classe Random
            Random rand = new();

            // Petit entier positif ou nul minimum et maximum
            byte borne = 0;

            // Génération d'un entier positif ou nul aléaoire entre N et N
            uint nb = (uint) rand.Next(borne, borne);

            // Affichage et récupération de l'entier généré
            Console.WriteLine($"nb == {nb}.");
            return nb;
        }   

        // private static void Main()
        // {
        //     // for(byte i = 0; i < 10; i++)
        //     // {
        //     //     RandTest();
        //     // }

        //     RandTest();
        // }
    }
}