namespace LettresN
{
    class LettresC
    {
        // 1. Compter le nombre de lettres dans une chaîne
        private static int Compte(string txt)
        {
            // Stockage du nb de lettres
            int compte = txt.Length;

            // Afficher le nb de lettres
            Console.WriteLine($"Longueur de \"{txt}\" : {compte} caractères.");
            return compte;
        }

        // 2. Inverser une chaîne
        private static string Inversion(string txt)
        {
            Console.WriteLine($"Avant inversion: {txt}.");

            // Liste de caractères
            List<char> caractères = [];

            // Pour chaque caractère de txt
            foreach(char caractère in txt)
            {
                // Ajouter ce caractère à la liste de caractères
                caractères.Add(caractère);
            }

            // Inversion de la liste de caractères
            caractères.Reverse();

            // Formation d'une chaîne de caractères à partir de tous les caractères de la liste inversée
            string txt_inversé = string.Join("", caractères); // Join is a method of the string class

            // Affichage et récupération de la chaîne inversé
            Console.WriteLine($"Après inversion : {txt_inversé}.");
            return txt_inversé;
        }

        // 3. Compter le nb de voyelles et de consonnes dans une chaîne
        private static int[] CompteVoyellesConsonnes(string txt)
        {
            // Listes de consonnes et de voyelles
            char[] consonnes = ['b', 'c', 'd', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'];
            char[] voyelles = ['a', 'e', 'i', 'o', 'u', 'y'];

            // Comptes du nb de consonnes et de voyelles
            int nbConsonnes = 0;
            int nbVoyelles = 0;

            // Affichage de txt
            Console.WriteLine($"{txt}");

            // Pour chaque caractère de txt
            foreach(char caractère in txt)
            {
                // Pour chaque consonne
                foreach(char consonne in consonnes)
                {
                    // Si le caractère de txt est une consonne
                    if(caractère == consonne)
                    {
                        // Monter de 1 le nb de consonnes
                        nbConsonnes++;
                    }
                }

                // Pour chaque voyelle
                foreach(char voyelle in voyelles)
                {
                    // Si le caractère de txt est une voyelle
                    if(caractère == voyelle)
                    {
                        // Monter de 1 le nb de voyelles
                        nbVoyelles++;
                    }
                }
            }
        
            // Affichage du nb de consonnes et de voyelles
            Console.WriteLine($"Nb de consonnes : {nbConsonnes}.\nNb de voyelles : {nbVoyelles}.");
            return [nbConsonnes, nbVoyelles];
        }

        // 4. Dire si une chaîne est un palindrome
        private static bool Palindrome(string txt)
        {
            // Texte à l'endroit
            string txt_droit = txt;

            // Liste de caractères
            List<char> caractères = [];

            // Pour chaque caractère de txt
            foreach(char caractère in txt)
            {
                // Ajouter ce caractère à la liste de caractères
                caractères.Add(caractère);
            }

            // Inversion de la liste de caractères
            caractères.Reverse();

            // Formation d'une chaîne de caractères à partir de tous les caractères de la liste inversée
            string txt_inversé = string.Join("", caractères); // Join is a method of the string class

            // Si le texte est identique dans les deux sens
            if(txt_droit == txt_inversé)
            {
                // Affichage et récupération de la réponse à "txt est-il un palindrome ?"
                Console.WriteLine($"{txt} est un palindrome.");
                return true;
            }

            // Si le texte est différent d'un sens à l'autre
            else
            {
                // Affichage et récupération de la réponse à "txt est-il un palindrome ?"
                Console.WriteLine($"{txt} n'est pas un palindrome.");
                return false;
            }
        }

        // 5. Dire si deux chaînes sont des anagrammes
        private static bool Anagrammes(string txt1, string txt2)
        {
            // Si les deux txt sont de longueurs différentes
            if(txt1.Length != txt2.Length)
            {
                // Dire que les textes ne sont pas des anagrammes car de tailles différentes
                Console.WriteLine($"{txt1} et {txt2} ne sont pas des anagrammes: leur tailles sont différentes.");

                // Récupération de la réponse à "Ces deux textes sont-il des anagrammes ?"
                return false;
            }

            // Si les deux txt sont de même longueur
            else
            {
                // Listes de caractères de txt1 et txt2
                List<char> caractères_txt1 = [];
                List<char> caractères_txt2 = [];

                // --- ARRANGEMENT DES LETTRES DE TXT1 EN ORDRE ALPHA --- //

                // Pour chaque caractère de txt1
                foreach(char caractère in txt1)
                {
                    // Ajouter ce caractère à caractères_txt1
                    caractères_txt1.Add(caractère);
                }

                // Classement des lettres de caractères_txt1 par ordre alphabétique
                caractères_txt1.Sort();

                // --- ARRANGEMENT DES LETTRES DE TXT2 EN ORDRE ALPHA --- //

                // Pour chaque caractère de txt2
                foreach(char caractère in txt2)
                {
                    // Ajouter ce caractère à caractères_txt2
                    caractères_txt2.Add(caractère);
                }

                // Classement des lettres de caractères_txt2 par ordre alphabétique
                caractères_txt2.Sort();

                // --- COMPARAISON DE TXT1 ET TXT2 --- //

                // Réponse par défaut à la question "txt1 et txt2 sont-il des anagrammes ?"
                bool anagrammes = true;

                // Pour tous les caractères de caractères_txt1
                for(int caractère = 0; caractère < caractères_txt1.Count; caractère++)
                {
                    // Si deux caractères sont différents
                    if(caractères_txt1[caractère] != caractères_txt2[caractère])
                    {
                        // On donne la réponse à l'utilisateur, on la déclare puis on la récupère
                        Console.WriteLine($"{txt1} et {txt2} ne sont pas des anagrammes.");
                        anagrammes = false;
                        return anagrammes;
                    }
                }

                // On donne la réponse à l'utilisateur puis on la récupère
                Console.WriteLine($"{txt1} et {txt2} sont des anagrammes.");
                return anagrammes;
            }
        }

        // 6. Trouver une sous-chaîne dans une chaîne
        private static bool SousChaine(string sous_txt, string txt)
        {
            // 1. Stocker la longueur de la sous-chaîne
            int longueurSousTxt = sous_txt.Length;

            // 2. Pour chaque caractère de la grande chaîne
            for(int cara = 0; cara < txt.Length; cara++)
            {
                // 2b. Si ce caractère est égale au premier caractère de la sous-chaîne
                if(txt[cara] == sous_txt[0])
                {
                   string essai_sous_txt = txt.Substring(cara, longueurSousTxt);

                    // Si la chaîne capturée est identique à la sous-chaîne
                    if(essai_sous_txt == sous_txt)
                    {
                        // Affichage et récupération de la réponse à "sous_txt est-il dans txt ?"
                        Console.WriteLine($"{sous_txt} est dans {txt} au caractère {cara+1}.");
                        return true;
                    } 
                }
            }

            // Affichage et récupération de la réponse à "sous_txt est-il dans txt ?"
            Console.WriteLine($"{sous_txt} n'est pas dans {txt}.");
            return false;
        }

        // 7. Dire combien de fois chaque lettre d'une chaîne apparaît
        private static List<Tuple<char, int, float>> FréquenceLettres(string txt)
        {
            // Longueur du texte
            int tailleTxt = txt.Length;
            Console.WriteLine($"Taille du texte: {tailleTxt} caractères.\n");

            // Compteurs de chaque lettres
            int a = 0,
                b = 0,
                c = 0,
                d = 0,
                e = 0,
                f = 0,
                g = 0,
                h = 0,
                i = 0,
                j = 0,
                k = 0,
                l = 0,
                m = 0,
                n = 0,
                o = 0,
                p = 0,
                q = 0,
                r = 0,
                s = 0,
                t = 0,
                u = 0,
                v = 0,
                w = 0,
                x = 0,
                y = 0, 
                z = 0;
            
            // Bools des lettres présentes ou non dans le txt
            bool aPrésent = false,
                 bPrésent = false,
                 cPrésent = false,
                 dPrésent = false,
                 ePrésent = false,
                 fPrésent = false,
                 gPrésent = false,
                 hPrésent = false,
                 iPrésent = false,
                 jPrésent = false,
                 kPrésent = false,
                 lPrésent = false,
                 mPrésent = false,
                 nPrésent = false,
                 oPrésent = false,
                 pPrésent = false,
                 qPrésent = false,
                 rPrésent = false,
                 sPrésent = false,
                 tPrésent = false,
                 uPrésent = false,
                 vPrésent = false,
                 wPrésent = false,
                 xPrésent = false,
                 yPrésent = false,
                 zPrésent = false;

            // Pour chaque lettre de txt
            foreach(char cara in txt)
            {
                char caraMinuscule = char.ToLower(cara);

                // On déclare comme vrai la présence d'une lettre minuscule si elle apparait
               switch(caraMinuscule)
                {
                    case 'a':
                    aPrésent = true;
                    break;

                    case 'b':
                    bPrésent = true;
                    break;

                    case 'c':
                    cPrésent = true;
                    break;

                    case 'd':
                    dPrésent = true;
                    break;

                    case 'e':
                    ePrésent = true;
                    break;

                    case 'f':
                    fPrésent = true;
                    break;

                    case 'g':
                    gPrésent = true;
                    break;

                    case 'h':
                    hPrésent = true;
                    break;

                    case 'i':
                    iPrésent = true;
                    break;

                    case 'j':
                    jPrésent = true;
                    break;

                    case 'l':
                    lPrésent = true;
                    break;

                    case 'm':
                    mPrésent = true;
                    break;

                    case 'n':
                    nPrésent = true;
                    break;

                    case 'o':
                    oPrésent = true;
                    break;

                    case 'p':
                    pPrésent = true;
                    break;

                    case 'q':
                    qPrésent = true;
                    break;

                    case 'r':
                    rPrésent = true;
                    break;

                    case 's':
                    sPrésent = true;
                    break;

                    case 't':
                    tPrésent = true;
                    break;

                    case 'u':
                    uPrésent = true;
                    break;

                    case 'v':
                    vPrésent = true;
                    break;

                    case 'w':
                    wPrésent = true;
                    break;

                    case 'x':
                    xPrésent = true;
                    break;

                    case 'y':
                    yPrésent = true;
                    break;

                    case 'z':
                    zPrésent = true;
                    break;
                } 
            }

            // Augmentation du compte de chaque lettre chaque fois qu'elle apparait dans txt
            foreach(char cara in txt)
            {
                // Mise en minuscule du caractère
                char caraMinuscule = char.ToLower(cara);

                // Compte de chaque lettre mise en minuscule
                switch(caraMinuscule)
                {
                    case 'a':
                    a++;
                    break;

                    case 'b':
                    b++;
                    break;

                    case 'c':
                    c++;
                    break;

                    case 'd':
                    d++;
                    break;

                    case 'e':
                    e++;
                    break;

                    case 'f':
                    f++;
                    break;

                    case 'g':
                    g++;
                    break;

                    case 'h':
                    h++;
                    break;

                    case 'i':
                    i++;
                    break;

                    case 'j':
                    j++;
                    break;

                    case 'k':
                    k++;
                    break;

                    case 'l':
                    l++;
                    break;

                    case 'm':
                    m++;
                    break;

                    case 'n':
                    n++;
                    break;

                    case 'o':
                    o++;
                    break;

                    case 'p':
                    p++;
                    break;

                    case 'q':
                    q++;
                    break;

                    case 'r':
                    r++;
                    break;

                    case 's':
                    s++;
                    break;

                    case 't':
                    t++;
                    break;

                    case 'u':
                    u++;
                    break;

                    case 'v':
                    v++;
                    break;

                    case 'w':
                    w++;
                    break;

                    case 'x':
                    x++;
                    break;

                    case 'y':
                    y++;
                    break;

                    case 'z':
                    z++;
                    break;
                }
            } 

            // Uplet de lettres dont on veut récupérer le nom, le compte et la fréquence dans le texte à la fin du programme
            List<Tuple<char, int, float>> donnéesLettres = [];

            if(aPrésent)
            {
                // Calcul de la fréquence
                float fréquenceA = (float) a/tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesA = new ('a', a, fréquenceA);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesA);
            }

            if(bPrésent)
            {
                // Calcul de la fréquence
                float fréquenceB = (float) b/tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesB = new ('b', b, fréquenceB);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesB);
            }

            if(cPrésent)
            {
                // Calcul de la fréquence
                float fréquenceC = (float) c/tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesC = new ('c', c, fréquenceC);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesC);
            }

            if(dPrésent)
            {
                // Calcul de la fréquence
                float fréquenceD = (float) d/tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesD = new ('d', d, fréquenceD);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesD);
            }

            if(ePrésent)
            {
                // Calcul de la fréquence
                float fréquenceE = (float) e/tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesE = new ('e', e, fréquenceE);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesE);
            }

            if (fPrésent)
            {
                // Calcul de la fréquence
                float fréquenceF = (float) f / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesF = new ('f', f, fréquenceF);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesF);
            }

            if (gPrésent)
            {
                // Calcul de la fréquence
                float fréquenceG = (float) g / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesG = new ('g', g, fréquenceG);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesG);
            }

            if (hPrésent)
            {
                // Calcul de la fréquence
                float fréquenceH = (float) h / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesH = new ('h', h, fréquenceH);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesH);
            }

            if (iPrésent)
            {
                // Calcul de la fréquence
                float fréquenceI = (float) i / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesI = new ('i', i, fréquenceI);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesI);
            }

            if (jPrésent)
            {
                // Calcul de la fréquence
                float fréquenceJ = (float) j / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesJ = new ('j', j, fréquenceJ);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesJ);
            }

            if (kPrésent)
            {
                // Calcul de la fréquence
                float fréquenceK = (float) k / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesK = new ('k', k, fréquenceK);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesK);
            }

            if (lPrésent)
            {
                // Calcul de la fréquence
                float fréquenceL = (float) l / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesL = new ('l', l, fréquenceL);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesL);
            }

            if (mPrésent)
            {
                // Calcul de la fréquence
                float fréquenceM = (float) m / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesM = new ('m', m, fréquenceM);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesM);
            }

            if (nPrésent)
            {
                // Calcul de la fréquence
                float fréquenceN = (float) n / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesN = new ('n', n, fréquenceN);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesN);
            }

            if (oPrésent)
            {
                // Calcul de la fréquence
                float fréquenceO = (float) o / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesO = new ('o', o, fréquenceO);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesO);
            }

            if (pPrésent)
            {
                // Calcul de la fréquence
                float fréquenceP = (float) p / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesP = new ('p', p, fréquenceP);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesP);
            }

            if (qPrésent)
            {
                // Calcul de la fréquence
                float fréquenceQ = (float) q / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesQ = new ('q', q, fréquenceQ);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesQ);
            }

            if (rPrésent)
            {
                // Calcul de la fréquence
                float fréquenceR = (float) r / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesR = new ('r', r, fréquenceR);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesR);
            }

            if (sPrésent)
            {
                // Calcul de la fréquence
                float fréquenceS = (float) s / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesS = new ('s', s, fréquenceS);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesS);
            }

            if (tPrésent)
            {
                // Calcul de la fréquence
                float fréquenceT = (float) t / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesT = new ('t', t, fréquenceT);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesT);
            }

            if (uPrésent)
            {
                // Calcul de la fréquence
                float fréquenceU = (float) u / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesU = new ('u', u, fréquenceU);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesU);
            }

            if (vPrésent)
            {
                // Calcul de la fréquence
                float fréquenceV = (float) v / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesV = new ('v', v, fréquenceV);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesV);
            }

            if (wPrésent)
            {
                // Calcul de la fréquence
                float fréquenceW = (float) w / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesW = new ('w', w, fréquenceW);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesW);
            }

            if (xPrésent)
            {
                // Calcul de la fréquence
                float fréquenceX = (float) x / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesX = new ('x', x, fréquenceX);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesX);
            }

            if (yPrésent)
            {
                // Calcul de la fréquence
                float fréquenceY = (float) y / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesY = new ('y', y, fréquenceY);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesY);
            }

            if (zPrésent)
            {
                // Calcul de la fréquence
                float fréquenceZ = (float) z / tailleTxt * 100;

                // Uplet Lettre-Compte-Fréquence
                Tuple<char, int, float> donnéesZ = new ('z', z, fréquenceZ);

                // Ajout de l'uplet à la liste d'uplets Lettre-Compte-Fréquence
                donnéesLettres.Add(donnéesZ);
            }


            // Affichage des uplets Lettre-Compte-Fréquence
            for(int lettre = 0; lettre < donnéesLettres.Count; lettre++)
            {
                Console.WriteLine($"donnéesLettres[{lettre}] == {donnéesLettres[lettre]}.");
            }

            return donnéesLettres;
        }

        // 8. Convertir une chaîne en TitleCase
        private static string ToTitleCase(string txt)
        {
            // 1. Couper la chaîne en un groupe de mots
            string[] mots = txt.Split(" ");

            Console.WriteLine("Avant:");
            foreach(string mot in mots)
            {
                Console.Write($"{mot} ");
            }

            // Groupe de lettres d'un unique mot
            List<char> lettres = [];

            // 2. Mettre en majuscule la première lettre de chaque mot du groupe de mots

            // Pour chaque mot du groupe de mots
            for(int mot = 0; mot < mots.Length; mot++)
            {
                // Pour chaque lettre du mot du groupe de mots
                for(int lettre = 0; lettre < mots[mot].Length; lettre++)
                {
                    // Si c'est la première lettre
                    if(lettre == 0)
                    {
                        // Mettre cette lettre en majuscule
                        char lettreMaj = char.ToUpper(mots[mot][lettre]);

                        // L'ajouter au groupe de lettres
                        lettres.Add(lettreMaj);

                        // Passer à la lettre suivante
                        continue;
                    }

                    // Ajouter cette lettre au groupe de lettres
                    lettres.Add(mots[mot][lettre]);
                }

                // Faire un mot commençant par une maj. à partir de chaque lettre du groupe de lettres
                string motMaj = string.Join("", lettres);

                // Remplacer le mot du groupe de mots par ce mot en majuscule
                mots[mot] = motMaj;

                // Vider le groupe de lettres pour former le prochain mot à partir de ses lettres seulement
                lettres.Clear();
            }

            // 3. Former une phrase faite de chaque mot mis en majuscule

            // Phrase initial
            string? phrase = "";

            // Pour chaque mot du groupe de mots
            for(int mot = 0; mot < mots.Length; mot++)
            {
                // Concatener ce mot à la phrase
                phrase += $"{mots[mot]} ";
            }

            // Affichage et récupération de la phrase finale
            Console.WriteLine($"\n\nAprès:\n{phrase}");
            return phrase;
        }

        // 9. Chiffrer/Déchiffrer une chaîne avec un Code César 
        // (clé : 0 = chiffrement, 1 = déchiffrement)
        private static string CodeCésar(string txt, int clé)
        {
            // Affichage de l'opération effectuée selon le signe de la clé
            if(clé >= 0)
            {
                Console.WriteLine("Chiffrement.\n");
            }

            else
            {
                Console.WriteLine("Déchiffrement.\n");
            }

            // Affichage du texte initial
            Console.WriteLine($"Texte initial: {txt}");

            // Alphabet en minuscule
            char[] alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

            // Mise en minuscule et affichage du txt
            string txtMin = txt.ToLower();
            // Console.WriteLine($"txtMin == {txtMin}");

            // Coupage de txtMin en lettres
            char[] lettresTxtMin = txtMin.ToCharArray();

            // Affichage des lettres du texte minuscule
            // Console.Write("Lettres: ");
            // foreach(char lettre in lettresTxtMin)
            // {
            //     Console.Write($"{lettre} ");
            // }

            // Console.WriteLine("\n");

            // Pour toutes les lettres de lettresTxtMin
            for(int lettre = 0; lettre < lettresTxtMin.Length; lettre++)
            {
                // Pour toutes les lettres de alphabet
                for(int alpha = 0; alpha < alphabet.Length; alpha++)
                {
                    // Si la lettre de lettresTxtMin est égale à la lettre de l'alphabet
                    if(lettresTxtMin[lettre] == alphabet[alpha])
                    {
                        // Confirmation que les lettres sont identiques et que le numéro est le bon
                        // Console.WriteLine($"alpha == {alpha}.");
                        // Console.WriteLine($"alphabet[alpha]: {alphabet[alpha]}");
                        // Console.WriteLine($"Avant chiffrage : {lettresTxtMin[lettre]}");

                        // --- I. CAS LE PLUS SIMPLE --- //
                        // Si la clé est un multiple de 26
                        if(clé % 26 == 0)
                        {
                            // Afficher dans quel cas on se trouve
                            // Console.WriteLine("La clé est un multiple de 26, la lettre ne changera pas.");

                            // La lettre reste la même
                            // Console.WriteLine($"Lettre après chiffrage : {lettresTxtMin[lettre]}\n");

                            // On passe à la lettre suivante du texte
                            break;
                        }

                        // --- II. CAS SANS DÉBORDEMENT --- //
                        // Si la clé est positive et que la position de la lettre plus la 
                        // clé n'amène pas au-delà de Z

                        // ou que la clé est négative et que la position de la lettre plus 
                        // la clé n'amène pas en-dessous de A
                        else if(clé > 0 && alpha + clé <= 25 || clé < 0 && alpha + clé >= 0)
                        {
                            // Afficher dans quel cas on se trouve
                            // Console.WriteLine("Cas sans débordement.");

                            // On remplace la lettre du texte par la lettre de l'alphabet de
                            // position alpha + clé
                            lettresTxtMin[lettre] = alphabet[alpha + clé];
                            // Console.WriteLine($"Lettre après chiffrage : {lettresTxtMin[lettre]}\n");

                            // On passe à la lettre suivante du texte
                            break;
                        }

                        // --- III. CAS AVEC DÉBORDEMENT --- //
                        // Si la clé est positive et que la position de la lettre plus la 
                        // clé amène au-delà de Z

                        // ou que la clé est négative et que la position de la lettre plus 
                        // la clé amène en-dessous de A
                        else if(clé > 0 && alpha + clé > 25 || clé < 0 && alpha + clé < 0)
                        {
                            // Afficher dans quel cas on se trouve
                            // Console.WriteLine("Cas avec débordement."); 

                            // On définit une nouvelle clé, selon son signe, avec une 
                            // opération de modulo pour obtenir une clé de taille < 26
                            if(clé > 0)
                            {
                                // On affiche le signe de la clé de base
                                // Console.WriteLine("Clé positive.");

                                int nouvelleClé = clé % 26;
                                // Console.WriteLine($"nouvelleClé == {nouvelleClé}.");

                                // Si la position de la lettre du texte plus nouvelleClé 
                                // dépasse encore 25
                                if(alpha + nouvelleClé > 25)
                                {
                                    // Afficher le deuxième dépassement
                                    // Console.WriteLine($"Deuxième dépassement, alpha + nouvelleClé == {alpha + nouvelleClé}");

                                    // Moduler 26 et stocker le reste
                                    int nouvellePosition = alpha + nouvelleClé - 26;
                                    // Console.WriteLine($"nouvellePosition == {nouvellePosition}");

                                    // Remplacer la lettre du texte par celle de 
                                    // N°nouvellePosition
                                    lettresTxtMin[lettre] = alphabet[nouvellePosition];
                                    // Console.WriteLine($"Après chiffrage : {lettresTxtMin[lettre]}\n");

                                    // On passe à la lettre suivante
                                    break;
                                }

                                // Si la position de la lettre du texte plus nouvelleClé 
                                // ne dépasse pas 25
                                else
                                {
                                    // Affichage de la nouvelle position
                                    // Console.WriteLine($"alpha + nouvelleClé == {alpha + nouvelleClé}");

                                    // Assignation la lettre n°alpha + nouvelleClé à la lettre
                                    // du texte
                                    lettresTxtMin[lettre] = alphabet[alpha + nouvelleClé];
                                    // Console.WriteLine($"Après chiffrage : {lettresTxtMin[lettre]}\n");

                                    // On passe à la lettre suivante
                                    break;
                                }
                            }

                            else
                            {
                                // On affiche le signe de la clé de base
                                // Console.WriteLine("Clé négative.");

                                int nouvelleClé = clé % 26;
                                // Console.WriteLine($"nouvelleClé == {nouvelleClé}.");
                                // Console.WriteLine($"alpha + nouvelleClé == {alpha + nouvelleClé}.");

                                // Si alpha + nouvelleClé passe sous 0
                                if(alpha + nouvelleClé < 0)
                                {
                                    // Affichage du deuxième sous-passement
                                    // Console.WriteLine($"Deuxième sous-passement, alpha + nouvelleClé = {alpha + nouvelleClé}.");

                                    // La nouvelle lettre de l'alphabet devient la numéro 26 - alpha + nouvelleClé
                                    int nouvellePosition = 26 + (alpha + nouvelleClé);
                                    // Console.WriteLine($"nouvellePosition == {nouvellePosition}.");

                                    // On assigne à la lettre du texte, la lettre de position 
                                    // nouvelleClé
                                    lettresTxtMin[lettre] = alphabet[nouvellePosition];
                                    // Console.WriteLine($"Après chiffrage : {lettresTxtMin[lettre]}\n");

                                    // On passe à la lettre suivante
                                    break;
                                }

                                else
                                {
                                    // On assigne à la lettre du texte, la lettre de position 
                                    // nouvelleClé
                                    lettresTxtMin[lettre] = alphabet[alpha + nouvelleClé];
                                    // Console.WriteLine($"Après chiffrage : {lettresTxtMin[lettre]}\n");

                                    // On passe à la lettre suivante
                                    break;
                                }
                            }
                        }
                    }   
                }
            }

            // Former un nouveau texte à partir des nouvelles lettres de lettresTxtMin
            string nouveauTxt = string.Join("", lettresTxtMin);
            Console.WriteLine($"Texte final: {nouveauTxt}");

            return nouveauTxt;
        }

        // 10. Inverser l'ordre des mots d'un texte
        private static string InversionTexte(string txt)
        {
            // Affichage du texte initial
            Console.WriteLine($"Texte initial : {txt}\n");

            // Couper puis afficher le texte en un groupe de mots
            string[] mots = txt.Split(" ");

            // Liste de mots
            List<string> listeMots = [];

            // Pour chaque mot du groupe de mots
            // Console.WriteLine("Array de mots:");
            foreach(string mot in mots)
            {
                // Afficher le mot
                // Console.WriteLine($"{mot}");

                // Ajouter le mot à la liste de mots
                listeMots.Add(mot);
            }

            // Console.WriteLine("\n");

            // Pour chaque mot dans la liste de mots
            // Console.WriteLine("Liste de mots:");
            // foreach(string mot in listeMots)
            // {
            //     // Afficher le mot
            //     Console.WriteLine($"{mot}");
            // }

            // Console.WriteLine("\n");

            // Inverser l'ordre de la liste de mots
            listeMots.Reverse();

            // Pour chaque mot dans la liste de mots
            // Console.WriteLine("Liste inversée de mots:");
            // foreach(string mot in listeMots)
            // {
            //     // Afficher le mot
            //     Console.WriteLine($"{mot}");
            // }

            // Former une phrase à partir de tous les mots de la liste inversée de mots
            string txtInversé = string.Join(" ", listeMots);
            Console.WriteLine($"Texte inversé: {txtInversé}");

            return txtInversé;
        } 

        // Exécutions
        private static void Main()
        {
            string? txt = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non risus. Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor. ";
            InversionTexte(txt);
        }
    }
}