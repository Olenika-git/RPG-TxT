using System;

namespace RPG_TxT
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomHero, nomMonstre, classeHero, entry;
            int pdvHero, attaqueHero, levelHero, pdvMonstre, attaqueMonstre, levelMonstre;
            string[] inventaireHero, inventaireMonstre;
            bool inGame = true;
            Random random = new Random();

            string titre = @"                               __    ___  ___           _____       _____ 
                              /__\  / _ \/ _ \         /__   \__  _/__   \
                             / \// / /_)/ /_\/  _____    / /\/\ \/ / / /\/
                            / _  \/ ___/ /_\\  |_____|  / /    >  < / /   
                            \/ \_/\/   \____/           \/    /_/\_\\/  By Akinelo  
                                              ";
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
                "Les jours s'assombrisent, les tenebres rodent !\n\n\nEleonore, la fille de Gille à été enlevé il y a peu !" +
                "\n\n\nTu dois la sauver !\n\n\n\nUne Embuscade ! Attention Derrière toi un monstre !");

            while (inGame)
            {

            }
        }
    }
}
