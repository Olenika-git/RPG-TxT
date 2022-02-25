using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RPG_TxT
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Initialization of Ascii class to bring some magic to console
            Ascii a = new Ascii();
            string titre = a.GetTitre();
            string titreFin = a.GetTitreFin();

            //  Initialization of Random Fonction
            Random random = new Random();

            //  Initialisation du Dictionaire et de notre Liste
            Dictionary<string, int> nomMonstre = new Dictionary<string, int>();
            List<string> Monstre = new List<string>();
            List<string> HistoriqueAction = new List<string>();

            nomMonstre.Add("dragon", 150);
            nomMonstre.Add("gobelin", 78);
            nomMonstre.Add("boulet", 80);
            nomMonstre.Add("brigand", 99);
            nomMonstre.Add("troll", 100);

            foreach (string key in nomMonstre.Keys)
            {
                Monstre.Add(key);
            }

            string nomHero, classeHero, entry, nomMob = "";
            int pdvHero = 0, attaqueHero = 0, levelHero = 0, pdvMonstre = 0, attaqueMonstre, levelMonstre, monstreTuer = 0;
            string[] inventaireHero, inventaireMonstre;
            bool inGame = true;
            //---------------------------------------------------
            //Try Beg Animation
            string beg1 = a.GetBeg1();
            string beg2 = a.GetBeg2();
            string beg3 = a.GetBeg3();
            string beg4 = a.GetBeg4();
            string[] animationBeg = {beg1, beg2, beg3, beg4 };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(animationBeg[i]);
                Thread.Sleep(500);
                Console.Clear();
            }
            //---------------------------------------------------
            Player player = new Player();
            player.CreatePlayer();
            Console.WriteLine("TEEEEEEST DE LOBJET"+player.Name + player.Health);

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (titre.Length / 2)) + "}", titre));
            Console.Write("Bienvenue, l'inconnu !\n\n\nJe suis Ergan, le mage du village.\nQuel est ton nom ?\n\nJe m'appelle : ");
            nomHero = Console.ReadLine();
            HistoriqueAction.Add("Nom du Joueur : "+nomHero);
            Console.Write("\n\n\n\nEnchanté " + nomHero +" !\n\n\nA ton allure je dirait que tu est un Guerrier pas vrai ?" +
                "\n\nListe des Classes :\n\nN°1 - Guerrier\nN°2 - Mage\nN°3 - Voleur\nN°4 - Barbare\nN°5 - Clerc\n\n\nJe suis un : ");
            classeHero = Console.ReadLine();

            while(classeHero != "Guerrier" && classeHero != "Mage" && classeHero != "Voleur" && classeHero != "Barbare" 
                && classeHero != "Clerc")
            {
                Console.Write("\n\nSaisie Incorrect, veuillez entrez le nom de la classe !" +
                    "\n\nListe des Classes :\n\nN°1 - Guerrier\nN°2 - Mage\nN°3 - Voleur\nN°4 - Barbare\nN°5 - Clerc\n\n\nJe suis un : ");
                classeHero = Console.ReadLine();
            }

            //  Attribution Statistique Hero
            levelHero = 1;
            switch (classeHero)
            {
                case "Guerrier":
                    {
                        pdvHero = 140;
                        attaqueHero = 10;
                        HistoriqueAction.Add("Le joueur à choisit la Classe Guerrier");
                        break;
                    }
                case "Mage":
                    {
                        pdvHero = 40;
                        attaqueHero = 60;
                        HistoriqueAction.Add("Le joueur à choisit la Classe Mage");
                        break;
                    }
                case "Voleur":
                    {
                        pdvHero = 70;
                        attaqueHero = 30;
                        HistoriqueAction.Add("Le joueur à choisit la Classe Voleur");
                        break;
                    }
                case "Barbare":
                    {
                        pdvHero = 80;
                        attaqueHero = 20;
                        HistoriqueAction.Add("Le joueur à choisit la Classe Barbare");
                        break;
                    }
                case "Clerc":
                    {
                        pdvHero = 90;
                        attaqueHero = 5;
                        HistoriqueAction.Add("Le joueur à choisit la Classe Clerc");
                        break;
                    }
                default:
                    Console.WriteLine("Erreur : Switch Statistique Classe");
                    break;
            }
            
            Console.WriteLine("\n\n\nTrès bien jeune : "+classeHero + "\nDes choses étranges se passent en ce moment dans le royaume !" +
                "Les jours s'assombrisent, les tenebres rodent !\n\n\nEleonore, la fille de Gilles à été enlevé il y a peu !" +
                "\n\n\nTu dois la sauver !\n\n\n\nUne Embuscade ! Attention Derrière toi un monstre !");

            //  Boucle du Jeu
            while (inGame)
            {
                //  Attribution Statistique Monstre de Base
                
                int nbMonstre = random.Next(1, 5);
                switch (nbMonstre)
                {
                    case 1:
                        nomMob = Monstre[0];
                        pdvMonstre = nomMonstre["dragon"];
                        break;
                    case 2:
                        nomMob = Monstre[1];
                        pdvMonstre = nomMonstre["gobelin"];
                        break;
                    case 3:
                        nomMob = Monstre[2];
                        pdvMonstre = nomMonstre["boulet"];
                        break;
                    case 4:
                        nomMob = Monstre[3];
                        pdvMonstre = nomMonstre["brigand"];
                        break;
                    case 5:
                        nomMob = Monstre[4];
                        pdvMonstre = nomMonstre["troll"];
                        break;

                    default:
                        break;
                }
                levelMonstre = random.Next(1, 20);
                attaqueMonstre = levelMonstre + 100 / 3;
                Console.WriteLine("\n\n\nUn " + nomMob + " Apparait !\nPoints de Vie : " + pdvMonstre);
                Console.WriteLine("VOICI LE CHIFFRE "+ nbMonstre);

                while (pdvMonstre > 0 && inGame)
                {
                    int attaqueMelee, attaqueMagique;
                    Console.Write("\n\n\nC'est à vous !\n\nQue voulez vous faire ?\n\n" +
                        "N°1 - Attaque de Melee\nN°2 - Attaque Magique\nN°3 - Afficher l'inventaire\nN°4 - Affiche les Caractéristique du personnage\nN°5 - Quitter le Jeu" +
                        "\n\nVotre choix : ");

                    entry = Console.ReadLine();

                    while (entry != "1" && entry != "2" && entry != "3" && entry != "4" && entry != "5")
                    {
                        Console.Write("\n\nSaisie Incorrect, veuillez entrez le nombre correspondant à l'action !" +
                        "\n\n\nN°1 - Attaque de Melee\nN°2 - Attaque Magique\nN°3 - Afficher l'inventaire\nN°4 - Affiche les Caractéristique du personnage\nN°5 - Quitter le Jeu" +
                        "\n\nVotre choix : ");
                        entry = Console.ReadLine();
                    }
                    //  Menu Combat
                    switch (entry)
                    {
                        case "1":
                            attaqueMelee = random.Next(attaqueHero, attaqueHero + 5);
                            Console.WriteLine("\n\nVous effectuer une attaque de melee." +
                                "\nVous infligez : " + attaqueMelee + " points de dégat");
                            pdvMonstre -= attaqueMelee;
                            HistoriqueAction.Add("Le joueur à attaquer : " +nomMob+" Pour " + attaqueMelee +" pts de dégats.");
                            break;

                        case "2":
                            attaqueMagique = random.Next(attaqueHero, attaqueHero + 10);
                            Console.WriteLine("\n\nVous effectuer une attaque magique." +
                                "\nVous infligez : " + attaqueMagique + " points de dégat");
                            pdvMonstre -= attaqueMagique;
                            HistoriqueAction.Add("Le joueur à attaquer : " + nomMob + " Pour " + attaqueMagique + " pts de dégats magique.");
                            break;

                        case "3":
                            Console.WriteLine("\n\nInventaire de " + nomHero);
                            HistoriqueAction.Add("Le joueur à afficher sont inventaire");
                            break;

                        case "4":
                            Console.WriteLine("\n\nCaractéristique d' " + nomHero);
                            Console.Write("\nNom : " + nomHero + "\nClasse : " + classeHero
                                + "\nPoint de Vie : " + pdvHero + "\nPoint d'Attaque : " + attaqueHero
                                + "\nNiveau : " + levelHero + "\n");
                            HistoriqueAction.Add("Le joueur à afficher ses Caractéristique");
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine(titreFin + "\nActions du Joueur lors de la partie :\n");
                            for (int i = 0; i < HistoriqueAction.Count; i++)
                            {
                                Console.WriteLine(HistoriqueAction[i] + " ");
                            }
                            inGame = false;
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Erreur dans le Switch Combat");
                            break;
                    }
                }

                Console.WriteLine("\n\n\nLe monstre as été vaincu\nVoulez vous continuer ? (oui / non)");
                entry = Console.ReadLine();
                if (entry == "non")
                {
                    Console.Clear();
                    Console.WriteLine(titreFin+"\nActions du Joueur lors de la partie :\n");
                    for (int i = 0; i < HistoriqueAction.Count; i++)
                    {
                        Console.WriteLine(HistoriqueAction[i]+" ");
                    }
                    inGame = false;
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    HistoriqueAction.Add("Le joueur à tué : " + nomMob);
                    monstreTuer++;

                    if(monstreTuer > 2 && inGame)
                    {

                        Console.Clear();
                        Console.WriteLine("Bravo vous avez gagnez la partie !");
                        Console.WriteLine(titreFin + "\nActions du Joueur lors de la partie :\n");
                        for (int i = 0; i < HistoriqueAction.Count; i++)
                        {
                            Console.WriteLine(HistoriqueAction[i] + " ");
                        }
                        inGame = false;
                        Environment.Exit(0);
                        break;
                    }
                }
                    
            }
        }
    }
}