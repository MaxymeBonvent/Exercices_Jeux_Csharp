namespace ConversionsN
{
    class ConversionsC
    {
        // 1. Convertir les degrés Celsius en degrés Fahrenheit et vice-versa
        private static float CelsiusFahrenheit(float température, bool versFahrenheit = true)
        {
            // Si la conversion est de Celsius à Fahrenheit
            if(versFahrenheit)
            {
                // Calcul de la température en degré Fahrenheit
                float fahrenheit = température * 1.8f + 32;

                // Affichage et récupération de la température en degrés Fahrenheit
                Console.WriteLine($"{température}°C = {fahrenheit:00.00}°F.");
                return fahrenheit;
            }

            // Si la conversion est de Fahrenheit à Celsius
            else
            {
                // Calcul de la température en degré Celsius
                float celsius = (température - 32)/1.8f; 

                // Affichage et récupération de la température en degrés Celsius
                Console.WriteLine($"{température}°F = {celsius:00.00}°C.");
                return celsius;  
            }
        }

        // 2. Convertir les secondes en minutes et vice-versa
        private static float SecondesMinutes(float durée, bool versMinutes = true)
        {
            // Si la conversion est de seconde vers minute
            if(versMinutes)
            {
                // Calculer le nombre de minutes
                float minutes = durée/60;

                // Affichage et récupération du nombre de minutes
                Console.WriteLine($"{durée} secondes = {minutes:00.00} minutes.");
                return minutes;
            }

            // Si la conversion est de minute vers seconde
            else
            {
                // Calculer le nombre de secondes
                float secondes = durée * 60;

                // Affichage et récupération du nombre de secondes
                Console.WriteLine($"{durée} minutes = {secondes:00.00} secondes.");
                return secondes;
            }
        }

        // 3. Convertir les minutes en heures et vice-versa
        private static float MinutesHeures(float durée, bool versHeures = true)
        {
            // Si la conversion est de minutes vers heures
            if(versHeures)
            {
                // Calculer le nombre d'heures
                float heures = durée/60;

                // Affichage et récupération du nombre d'heures
                Console.WriteLine($"{durée} minutes = {heures:00.00} heures.");
                return heures;
            }

            // Si la conversion est de heures vers minutes
            else
            {
               // Calculer le nombre de minutes
                float minutes = durée * 60; 

                // Affichage et récupération du nombre de minutes
                Console.WriteLine($"{durée} heures = {minutes:00.00} minutes.");
                return minutes;
            }
        }

        // 4. Convertir les heures en jours et vice-versa
        private static float HeuresJours(float durée, bool versJours = true)
        {
            // Si la conversion est de heures vers jours
            if(versJours)
            {
                // Calcul du nombre de jours
                float jours = durée/24;

                // Affichage et récupération du nombre de jours
                Console.WriteLine($"{durée} heures = {jours:00.00} jours.");
                return jours;
            }

            // Si la conversion est de jours vers heures
            else
            {
                // Calcul du nombre d'heures
                float heures = durée * 24;

                // Affichage et récupération du nombre d'heures
                Console.WriteLine($"{durée} jours = {heures:00.00} heures.");
                return heures;
            }
        }

        // 5. Convertir les jours en semaines et vice-versa
        private static float JoursSemaines(float durée, bool versSemaines = true)
        {
            // Si la conversion est de jours à semaines
            if(versSemaines)
            {
                // Calculer le nombre de semaines
                float semaines = durée/7;

                // Affichage et récupération du nombre de semaines
                Console.WriteLine($"{durée} jours = {semaines:00.00} semaines.");
                return semaines;
            }

            // Si la conversion est de semaines à jours
            else
            {
                // Calculer le nombre de jours
                float jours = durée * 7;

                // Affichage et récupération du nombre de jours
                Console.WriteLine($"{durée} semaines = {jours:00.00} jours.");
                return jours;
            }
        }

        // 6. Convertir les semaines en mois et vice-versa
        private static float SemainesMois(float durée, bool versMois = true)
        {
            // Si la conversion est de semaines à mois
            if(versMois)
            {
                // Calcul du nombre de mois
                float mois = durée/4;

                // Affichage et récupération du nombre de mois
                Console.WriteLine($"{durée} semaines = {mois:00.00} mois.");
                return mois;
            }

            // Si la conversion est de mois à semaines
            else
            {
               // Calcul du nombre de semaines
                float semaines = durée * 4; 

                // Affichage et récupération du nombre de semaines
                Console.WriteLine($"{durée} mois = {semaines:00.00} semaines.");
                return semaines;
            }
        }

        // 7. Convertir les mois en années et vice-versa
        private static float MoisAnnées(float durée, bool versAnnées = true)
        {
            // Si la conversion est de mois vers années
            if(versAnnées)
            {
                // Calcul du nombre d'années
                float années = durée/12;

                // Affichage et récupération du nombre d'années
                Console.WriteLine($"{durée} mois = {années:00.00} années.");
                return années;
            }

            // Si la conversion est de années vers mois
            else
            {
               // Calcul du nombre de mois
                float mois = durée * 12; 

                // Affichage et récupération du nombre de mois
                Console.WriteLine($"{durée} années = {mois:00.00} mois.");
                return mois;
            }
        }

        // 8. Convertir les kilomètres en miles et vice-versa
        private static float KilomètresMiles(float longueur, bool versMiles = true)
        {
            // Si la conversion est de kilomètres à miles
            if(versMiles)
            {
                // Calcul du nombre de miles
                float miles = longueur * 0.62137f;

                // Affichage et récupération des miles
                Console.WriteLine($"{longueur}km = {miles:00.00} miles.");
                return miles;
            }

            // Si la conversion est de miles à kilomètres
            else
            {
                // Calcul du nombre de kilomètres
                float kilomètres = longueur / 0.62137f;

                // Affichage et récupération des kilomètres
                Console.WriteLine($"{longueur} miles = {kilomètres:00.00} kilomètres.");
                return kilomètres;
            }
        }

        private static void Main()
        {
           KilomètresMiles(1, false);
        }
    }
}