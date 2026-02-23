// Importation des espaces de noms nécessaires
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Déclaration du namespace
namespace GestionPortefeuilles
{
    // Classe Action qui représente une action boursière
    class Action
    {
        // Propriétés de l'action
        public string Nom;
        public double PrixAchat;
        public double PrixActuel;
        public int Quantite;

        // Méthode pour calculer la valeur actuelle
        public double ValeurActuelle()
        {
            return PrixActuel * Quantite;
        }

        // Méthode pour calculer le gain ou la perte
        public double Gain()
        {
            return (PrixActuel - PrixAchat) * Quantite;
        }
    }
    // Classe principale du programme
    class Program
    {
        static void Main()
        {
            // Création de la liste des actions
            List<Action> portefeuille = new List<Action>();

            // ===== Saisie du nombre d'actions avec boucle while =====
            int n = 0;
            while (true)
            {
                Console.Write("Combien d'actions voulez-vous ajouter ? : ");
                string saisie = Console.ReadLine();
                if (int.TryParse(saisie, out n) && n > 0)
                    break; // valeur valide → on sort de la boucle
                else
                    Console.WriteLine("❌ Erreur : veuillez entrer un nombre entier positif (ex: 2) !");
            }
            // Boucle pour ajouter les actions
            for (int i = 0; i < n; i++)
            {
                // Affichage d'un séparateur pour chaque action
                Console.WriteLine("\n--- Action " + (i + 1) + " ---");
                Action a = new Action();
                // Saisie du nom (le nom peut être n'importe quoi)
                Console.Write("Nom de l'action : ");
                a.Nom = Console.ReadLine();
                // ===== Saisie du Prix d'achat avec boucle while =====
                while (true)
                {
                    Console.Write("Prix d'achat : ");
                    string saisie = Console.ReadLine();
                    // TryParse accepte virgule ET point comme séparateur décimal
                    if (double.TryParse(saisie, NumberStyles.Any, CultureInfo.InvariantCulture, out a.PrixAchat)
                        || double.TryParse(saisie, NumberStyles.Any, CultureInfo.CurrentCulture, out a.PrixAchat))
                        break; // valeur valide → on sort de la boucle
                    else
                        Console.WriteLine(" Erreur : veuillez entrer un nombre valide (ex: 120.5 ou 120,5) !");
                }

                // ===== Saisie du Prix actuel avec boucle while =====
                while (true)
                {
                    Console.Write("Prix actuel : ");
                    string saisie = Console.ReadLine();
                    if (double.TryParse(saisie, NumberStyles.Any, CultureInfo.InvariantCulture, out a.PrixActuel)
                        || double.TryParse(saisie, NumberStyles.Any, CultureInfo.CurrentCulture, out a.PrixActuel))
                        break; // valeur valide → on sort de la boucle
                    else
                        Console.WriteLine(" Erreur : veuillez entrer un nombre valide (ex: 150.0 ou 150,0) !");
                }

                // ===== Saisie de la quantité avec boucle while =====
                while (true)
                {
                    Console.Write("Quantité : ");
                    string saisie = Console.ReadLine();
                    if (int.TryParse(saisie, out a.Quantite) && a.Quantite > 0)
                        break; // valeur valide → on sort de la boucle
                    else
                        Console.WriteLine(" Erreur : veuillez entrer un entier positif (ex: 10) !");
                }

                // Ajouter l'action dans la liste
                portefeuille.Add(a);
            }

            double total = 0;
            Console.WriteLine("\n===== RESULTATS =====\n");

            // Parcours de la liste pour afficher les résultats
            foreach (var action in portefeuille)
            {
                double valeur = action.ValeurActuelle();
                double gain = action.Gain();

                // Ajout de la valeur de l'action au total du portefeuille
                total += valeur;

                // Affichage des détails de l'action
                Console.WriteLine("Action : " + action.Nom);
                Console.WriteLine("Valeur actuelle : " + valeur + " DH");
                Console.WriteLine("Gain / Perte : " + gain + " DH");

                // Alerte si l'action est en perte
                if (gain < 0)
                    Console.WriteLine("⚠️  Action en perte");

                Console.WriteLine("---------------------------");
            }

            // Affichage du total du portefeuille
            Console.WriteLine("\nValeur totale du portefeuille : " + total + " DH");

            // Liste des actions en perte
            var pertes = portefeuille
                .Where(x => x.Gain() < 0)
                .Select(x => x.Nom);
            Console.WriteLine("Actions en perte : " + string.Join(", ", pertes));

            // Pause avant fermeture
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}