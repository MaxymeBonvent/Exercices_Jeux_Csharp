using System.ComponentModel;

namespace GéométrieN
{
    class GéométrieC
    {
        // 1. Périmètre d'un carré
        private static float PérimètreCarré(float côté)
        {
            // Calcul du périmètre
            float périmètre = côté * 4;

            // Affichage et récupération du périmètre
            Console.WriteLine($"Périmètre du carré: {périmètre}.");
            return périmètre;
        }

        // 2. Aire d'un carré
        private static float AireCarré(float côté)
        {
            // Calcul de l'aire
            float aire = côté * côté;

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du carré: {aire}.");
            return aire;
        }

        // 3. Diagonale d'un carré
        private static double DiagonaleCarré(float côté)
        {
            // Calcul de la diagonale
            double diagonale = côté * Math.Sqrt(2);

            // Affichage et récupération de la diagonale
            Console.WriteLine($"Diagonale du carré: {diagonale:00.00}.");
            return diagonale;
        }

        // 4. Périmètre d'un rectangle
        private static float PérimètreRectangle(float longeur, float largeur)
        {
            // Calcul du périmètre
            float périmètre = longeur * 2 + largeur * 2;

            // Affichage et récupération du périmètre
            Console.WriteLine($"Périmètre du rectangle: {périmètre}.");
            return périmètre;
        }

        // 5. Aire d'un rectangle
        private static float AireRectangle(float longeur, float largeur)
        {
            // Calcul de l'aire
            float aire = longeur * largeur;

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du rectangle: {aire}.");
            return aire;
        }

        // 6. Diagonale d'un rectangle
        private static double DiagonaleRectangle(float longeur, float largeur)
        {
            // Calcul de la diagonale
            double diagonale = Math.Sqrt(Math.Pow(longeur, 2) + Math.Pow(largeur, 2));

            // Affichage et récupération de la diagonale
            Console.WriteLine($"Diagonale du rectangle: {diagonale:00.00}.");
            return diagonale;
        }

        // 7. Périmètre d'un triangle
        private static float PérimètreTriangle(float côté1, float côté2, float côté3)
        {
            // Calcul du périmètre
            float périmètre = côté1 + côté2 + côté3;

            // Affichage et récupération du périmètre
            Console.WriteLine($"Périmètre du triangle: {périmètre}.");
            return périmètre;
        }

        // 8. Aire d'un triangle
        private static float AireTriangle(float _base, float hauteur)
        {
            // Calcul de l'aire
            float aire = _base*hauteur / 2;

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du triangle: {aire}.");
            return aire;
        }

        // 9. Hypothénuse d'un triangle
        private static double HypothénuseTriangle(float côté1, float côté2)
        {
            // Calcul de l'hypothénuse
            double hypothénuse = Math.Sqrt(Math.Pow(côté1, 2) + Math.Pow(côté2, 2));

            // Affichage et récupération de l'hypothénuse
            Console.WriteLine($"Hypothénuse du triangle: {hypothénuse:00.00}.");
            return hypothénuse;
        }

        // 10. Rayon d'un cercle
        private static float RayonCercle(float diamètre)
        {
            // Calcul du rayon
            float rayon = diamètre/2;

            // Affichage et récupération du rayon
            Console.WriteLine($"Rayon du cercle: {rayon}.");
            return rayon;
        }

        // 11. Diamètre d'un cercle
        private static float DiamètreCercle(float rayon)
        {
            // Calcul du diamètre
            float diamètre = rayon/2;

            // Affichage et récupération du diamètre
            Console.WriteLine($"Diamètre du cercle: {diamètre}.");
            return diamètre;
        }

        // 12. Circonférence d'un cercle
        private static double CirconférenceCercle(float rayon)
        {
            // Calcul de la circonférence
            double circonférence = 2 * Math.PI * rayon;

            // Affichage et récupération de la circonférence
            Console.WriteLine($"Circonférence du cercle: {circonférence:00.00}.");
            return circonférence;
        }

        // 13. Aire d'un cercle
        private static double AireCercle(float rayon)
        {
            // Calcul de l'aire
            double aire = Math.PI * Math.Pow(rayon, 2);

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du cercle: {aire:00.00}.");
            return aire;
        }

        // 14. Périmètre d'un trapèze
        private static float PérimètreTrapèze(float côté1, float côté2, float côté3, float côté4)
        {
            // Calcul du périmètre
            float périmètre = côté1 + côté2 + côté3 + côté4;

            // Affichage et récupération du périmètre
            Console.WriteLine($"Périmètre du trapèze: {périmètre}.");
            return périmètre;
        }

        // 15. Aire d'un trapèze
        private static float AireTrapèze(float petite_base, float grande_base, float hauteur)
        {
            // Calcul de l'aire
            float aire = ((petite_base + grande_base) * hauteur)/2;

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du trapèze: {aire:00.00}.");
            return aire;
        }

        // 16. Périmètre d'un cube
        private static float PérimètreCube(float côté)
        {
            // Calcul du périmètre
            float périmètre = côté * 12;

            // Affichage et récupération du périmètre
            Console.WriteLine($"Périmètre du cube: {périmètre}.");
            return périmètre;
        }

        // 17. Aire d'un cube
        private static float AireCube(float côté)
        {
            // Calcul de l'aire d'une face
            float aire_une_face = côté * côté;

            // Calcul de l'aire totale
            float aire_totale = aire_une_face * 6;

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du cube: {aire_totale}.");
            return aire_totale;
        }

        // 18. Volume d'un cube
        private static double VolumeCube(float côté)
        {
            // Calcul du volume
            double volume = Math.Pow(côté, 3);

            // Affichage et récupération du volume
            Console.WriteLine($"Volume du cube: {volume}.");
            return volume;
        }

        // 19. Diagonale d'un cube
        private static double DiagonaleCube(float côté)
        {
            // Calcul de la diagonale
            double diagonale = côté * Math.Sqrt(3);

            // Affichage et récupération de la diagonale
            Console.WriteLine($"Diagonale du cube: {diagonale:00.00}.");
            return diagonale;
        }

        // 20. Périmètre d'un pavé droit
        private static float PérimètrePavéDroit(float longueur, float largeur, float hauteur)
        {
            // Calcul du périmètre
            float périmètre = 4 * (longueur + largeur + hauteur);

            // Affichage et récupération du périmètre
            Console.WriteLine($"Périmètre du pavé droit: {périmètre}.");
            return périmètre;
        }

        // 21. Aire d'un pavé droit
        private static float AirePavéDroit(float longueur, float largeur, float hauteur)
        {
            // Calcul de l'aire
            float aire = 2 * (longueur * largeur + largeur * hauteur + hauteur * longueur);

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du pavé droit: {aire}.");
            return aire;
        }

        // 22. Volume d'un pavé droit
        private static float VolumePavéDroit(float longueur, float largeur, float hauteur)
        {
            // Calcul du volume
            float volume = longueur * largeur * hauteur;

            // Affichage et récupération du volume
            Console.WriteLine($"Volume du pavé droit: {volume}.");
            return volume;
        }

        // 23. Diagonale d'un pavé droit
        private static double DiagonalePavéDroit(float longueur, float largeur, float hauteur)
        {
            // Calcul de la diagonale
            double diagonale = Math.Sqrt(Math.Pow(longueur, 2) + Math.Pow(largeur, 2) + Math.Pow(hauteur, 2));

            // Affichage et récupération de la diagonale
            Console.WriteLine($"Diagonale du pavé droit: {diagonale:00.00}.");
            return diagonale;
        }

        // 24. Aire d'une pyramide carrée
        private static double AirePyramideCarré(double _base)
        {
            // Calcul de l'aire
            double aire = (1 + Math.Sqrt(3)) * Math.Pow(_base, 2);

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire de la pyramide carrée: {aire:00.00}.");
            return aire;
        }

        // 25. Volume d'une pyramide carrée
        private static double VolumePyramideCarré(double _base)
        {
            // Calcul du volume
            double volume = Math.Sqrt(2)/6 * Math.Pow(_base, 3);

            // Affichage et récupération du volume
            Console.WriteLine($"Volume de la pyramide carrée: {volume:00.00}.");
            return volume;
        }

        // 26. Aire d'un cylindre de révolution
        private static double AireCylindre(float rayon, float hauteur)
        {
            // Calcul de l'aire
            double aire = 2 * Math.PI * rayon * rayon + 2 * Math.PI * rayon * hauteur;

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du cylindre: {aire:00.00}.");
            return aire;
        }

        // 27. Volume d'un cylindre de révolution
        private static double VolumeCylindre(float rayon, float hauteur)
        {
            // Calcul du volume
            double volume = Math.PI * rayon * rayon * hauteur;

            // Affichage et récupération du volume
            Console.WriteLine($"Volume du cylindre: {volume:00.00}.");
            return volume;
        }

        // 28. Aire d'un cône de révolution
        private static double AireCone(float rayon, float hauteur)
        {
            // Calcul de l'aire
            double aire = Math.PI * rayon * Math.Sqrt(rayon * rayon + hauteur * hauteur);

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du cône: {aire:00.00}.");
            return aire;
        }

        // 29. Volume d'un cône de révolution
        private static double VolumeCone(float rayon, float hauteur)
        {
            // Calcul du volume
            double volume = Math.PI * rayon * rayon * hauteur/3;

            // Affichage et récupération du volume
            Console.WriteLine($"Volume du cône: {volume:00.00}.");
            return volume;
        }

        // 30. Aire d'un prisme triangulaire
        private static float AirePrismeTriangle(float _base, float hauteur, float longueur, float largeur)
        {
            // Aire d'un triangle
            float aire_triangle = _base * hauteur/2;

            // Aire d'un rectangle latérale
            float aire_rectangle = longueur * largeur;

            // Aire du rectangle adjacent à la base du triangle
            float aire_rect_base = longueur * _base;

            // Aire totale
            float aire_totale = aire_triangle * 2 + aire_rectangle * 2 + aire_rect_base;

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire du prisme triangulaire: {aire_totale:00.00}.");
            return aire_totale;
        }

        // 31. Volume d'un prisme triangulaire
        private static float VolumePrismeTriangle(float _base, float hauteur, float longueur)
        {
            // Calcul du volume
            float volume = _base * hauteur * longueur/2;

            // Affichage et récupération du volume
            Console.WriteLine($"Volume du prisme triangulaire: {volume:00.00}.");
            return volume;
        }

        // 32. Aire d'une sphère
        private static double AireSphère(float rayon)
        {
            // Calcul de l'aire
            double aire = 4 * Math.PI * rayon * rayon;

            // Affichage et récupération de l'aire
            Console.WriteLine($"Aire de la sphère: {aire:00.00}.");
            return aire;
        }

        // 33. Volume d'une sphère
        private static double VolumeSphère(float rayon)
        {
            // Calcul du volume
            double volume = 4/3 * Math.PI * Math.Pow(rayon, 3);

            // Affichage et récupération du volume
            Console.WriteLine($"Volume de la sphère: {volume:00.00}.");
            return volume;
        }

        // Exécution
        private static void Main()
        {
            VolumeSphère(2);
        }
    }
}