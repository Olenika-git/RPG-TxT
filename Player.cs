using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_TxT
{
    class Player
    {
        //  Player Property
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public string PlayerClass { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }


        //  Player Default Constructor
        public Player()
        {
            Name = "";
            Health = 0;
            Level = 0;
            PlayerClass= "";
            Attack = 0;
            Defense = 0;
        }

        //  Player Constructor
        public Player(string name, int health, int level, string playerClass, int attack, int defense)
        {
            Name = name;
            Health = health;
            Level = level;
            PlayerClass = playerClass;
            Attack = attack;
            Defense = defense;
        }


        public void CreatePlayer()
        {
            string userEntry = "";
            Dictionary<int, string> listClass = new Dictionary<int, string>();
            listClass.Add(1, "Warrior");
            listClass.Add(2, "Mage");
            listClass.Add(3, "Rogue");
            listClass.Add(4, "Barbarian");
            listClass.Add(5, "Cleric");
            //--------------------------------
            Console.WriteLine("Create your Character");
            Console.Write("Choose a name : ");
            Name = Console.ReadLine();  //Player choosed a Name
            Console.WriteLine("List of Class (1-5) :\n1 - Warrior\n2 - Mage\n3 - Rogue\n4 - Barbarian\n5 - Cleric");
            Console.Write("Choose a Class (1-5) : ");
            bool classOk = int.TryParse(Console.ReadLine(), out int result);
            while(result < 1 || result > 5)
            {
                Console.WriteLine("Invalid Entry please try again !");
                Console.WriteLine("List of Class (1-5) :\n1 - Warrior\n2 - Mage\n3 - Rogue\n4 - Barbarian\n5 - Cleric");
                Console.Write("Choose a Class (1-5) : ");
                classOk = int.TryParse(Console.ReadLine(), out result);
            }
            userEntry = result.ToString();
            PlayerClass = listClass[int.Parse(userEntry)]; //Player choosed a Class

            switch (userEntry) //   Class Statistic Attribution
            {
                case "1":
                    Health = 120;
                    Attack = 50;
                    Defense = 50;
                    break;
                case "2":
                    Health = 100;
                    Attack = 70;
                    Defense = 30;
                    break;
                case "3":
                    Health = 90;
                    Attack = 60;
                    Defense = 40;
                    break;
                case "4":
                    Health = 80;
                    Attack = 80;
                    Defense = 20;
                    break;
                case "5":
                    Health = 100;
                    Attack = 40;
                    Defense = 60;
                    break;
                default:
                    Console.WriteLine("Error in Class Stat Switch : CreatePlayer()");
                    break;
            }
        }




        //Methode TryParse pour convertir un INT en String sans crash de l'appli si erreur
        //bool ok = int.TryParse(Console.ReadLine(), out int result);
        //        if(ok)
        //            Console.WriteLine(result);
        //        else
        //            Console.WriteLine("Erreur Convertion");



    }
}
