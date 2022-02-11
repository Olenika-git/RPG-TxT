using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG_TxT
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Initialisation Fonction Random
            Random random = new Random();

            //  Initialisation du Dictionaire et de notre Liste
            Dictionary<string, int> nomMonstre = new Dictionary<string, int>();
            List<string> Monstre = new List<string>();

            nomMonstre.Add("dragon", 150);
            nomMonstre.Add("gobelin", 78);
            nomMonstre.Add("boulet", 80);
            nomMonstre.Add("brigand", 99);
            nomMonstre.Add("troll", 100);

            foreach (string key in nomMonstre.Keys)
            {
                Monstre.Add(key);
            }

            for (int i = 0; i < Monstre.Count; i++)
            {
                Console.WriteLine(Monstre[i]);
            }

            string nomHero, classeHero, entry, nomMob = "";
            int pdvHero = 0, attaqueHero = 0, levelHero = 0, pdvMonstre = 0, attaqueMonstre, levelMonstre, monstreTuer = 0;
            string[] inventaireHero, inventaireMonstre;
            bool inGame = true;
            string titre = @"                               __    ___  ___           _____       _____ 
                              /__\  / _ \/ _ \         /__   \__  _/__   \
                             / \// / /_)/ /_\/  _____    / /\/\ \/ / / /\/
                            / _  \/ ___/ /_\\  |_____|  / /    >  < / /   
                            \/ \_/\/   \____/           \/    /_/\_\\/  By Akinelo  
                                              ";
            string titreFin = @"
 ▄▄▄▄    ▒█████   ███▄    █  ███▄    █ ▓█████     ▄▄▄██▀▀▀▒█████   █    ██  ██▀███   ███▄    █ ▓█████ ▓█████ 
▓█████▄ ▒██▒  ██▒ ██ ▀█   █  ██ ▀█   █ ▓█   ▀       ▒██  ▒██▒  ██▒ ██  ▓██▒▓██ ▒ ██▒ ██ ▀█   █ ▓█   ▀ ▓█   ▀ 
▒██▒ ▄██▒██░  ██▒▓██  ▀█ ██▒▓██  ▀█ ██▒▒███         ░██  ▒██░  ██▒▓██  ▒██░▓██ ░▄█ ▒▓██  ▀█ ██▒▒███   ▒███   
▒██░█▀  ▒██   ██░▓██▒  ▐▌██▒▓██▒  ▐▌██▒▒▓█  ▄    ▓██▄██▓ ▒██   ██░▓▓█  ░██░▒██▀▀█▄  ▓██▒  ▐▌██▒▒▓█  ▄ ▒▓█  ▄ 
░▓█  ▀█▓░ ████▓▒░▒██░   ▓██░▒██░   ▓██░░▒████▒    ▓███▒  ░ ████▓▒░▒▒█████▓ ░██▓ ▒██▒▒██░   ▓██░░▒████▒░▒████▒
░▒▓███▀▒░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ░ ▒░   ▒ ▒ ░░ ▒░ ░    ▒▓▒▒░  ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░░ ▒░   ▒ ▒ ░░ ▒░ ░░░ ▒░ ░
▒░▒   ░   ░ ▒ ▒░ ░ ░░   ░ ▒░░ ░░   ░ ▒░ ░ ░  ░    ▒ ░▒░    ░ ▒ ▒░ ░░▒░ ░ ░   ░▒ ░ ▒░░ ░░   ░ ▒░ ░ ░  ░ ░ ░  ░
 ░    ░ ░ ░ ░ ▒     ░   ░ ░    ░   ░ ░    ░       ░ ░ ░  ░ ░ ░ ▒   ░░░ ░ ░   ░░   ░    ░   ░ ░    ░      ░   
 ░          ░ ░           ░          ░    ░  ░    ░   ░      ░ ░     ░        ░              ░    ░  ░   ░  ░
      ░                                                                                                      ";

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (titre.Length / 2)) + "}", titre));
            Console.Write("Bienvenue, l'inconnu !\n\n\nJe suis Ergan, le mage du village.\nQuel est ton nom ?\n\nJe m'appelle : ");
            nomHero = Console.ReadLine();
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
                        break;
                    }
                case "Mage":
                    {
                        pdvHero = 40;
                        attaqueHero = 60;
                        break;
                    }
                case "Voleur":
                    {
                        pdvHero = 70;
                        attaqueHero = 30;
                        break;
                    }
                case "Barbare":
                    {
                        pdvHero = 80;
                        attaqueHero = 20;
                        break;
                    }
                case "Clerc":
                    {
                        pdvHero = 90;
                        attaqueHero = 5;
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
                
                int nbMonstre = random.Next(0, 5);
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
                            Console.WriteLine(nbMonstre + " lAAAAAAAAAAAAAA");
                            break;

                        case "2":
                            attaqueMagique = random.Next(attaqueHero, attaqueHero + 10);
                            Console.WriteLine("\n\nVous effectuer une attaque magique." +
                                "\nVous infligez : " + attaqueMagique + " points de dégat");
                            pdvMonstre -= attaqueMagique;
                            break;

                        case "3":
                            Console.WriteLine("\n\nInventaire de " + nomHero);
                            break;

                        case "4":
                            Console.WriteLine("\n\nCaractéristique de " + nomHero);
                            Console.Write("\nNom : " + nomHero + "\nClasse : " + classeHero
                                + "\nPoint de Vie : " + pdvHero + "\nPoint d'Attaque : " + attaqueHero
                                + "\nNiveau : " + levelHero + "\n");
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine(titreFin);
                            inGame = false;
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
                    Console.WriteLine(titreFin);
                    inGame = false;
                    break;
                }
                else
                    monstreTuer++;
                    
            }
        }
    }
}