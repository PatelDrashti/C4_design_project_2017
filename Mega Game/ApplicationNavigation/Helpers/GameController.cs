using System;
using ApplicationNavigation.Model;

namespace ApplicationNavigation.Helpers
{

    public class GameController
    {

        private static NonPlayerCharacter enemy = new NonPlayerCharacter();
        private static PlayerCharacter player = new PlayerCharacter();


        public GameController()
        {

        }

        ~GameController()
        {

        }

        public static PlayerCharacter Player { get => player; set => player = value; }
        public static NonPlayerCharacter Enemy { get => enemy; set => enemy = value; }

        public static void ChooseClass(String playerClass)
        {
            if (playerClass.Equals("Warrior")){

                player.CharacterName = "Warrior";
                player.baseDamage = 10;
                player.currentHealthPoints = 50;
                player.maxHealthPoints = 50;

            }

            if (playerClass.Equals("Mage")){

                player.CharacterName = "Mage";
                player.baseDamage = 10;
                player.currentHealthPoints = 50;
                player.maxHealthPoints = 50;

            }


            if (playerClass.Equals("Thief"))
            {
                player.CharacterName = "Thief";
                player.baseDamage = 10;
                player.currentHealthPoints = 50;
                player.maxHealthPoints = 50;



            }

            Random selectNPC = new Random();
            int selectedNPC = selectNPC.Next(1, 4);

            if (selectedNPC == 1)
            {
                selectNPC1();
            }

            if (selectedNPC == 2)
            {
                selectNPC2();
            }

            if (selectedNPC == 3)
            {
                selectNPC3();
            }


        }

           public static void selectNPC1()
           {

               enemy.baseDamage = 10;
               enemy.currentHealthPoints = 35;
               enemy.maxHealthPoints = 35;

           }

           public static void selectNPC2()
           {

            enemy.baseDamage = 5;
            enemy.currentHealthPoints = 80;
            enemy.maxHealthPoints = 80;


        }

        public static void selectNPC3()
           {

            enemy.baseDamage = 20;
            enemy.currentHealthPoints = 30;
            enemy.maxHealthPoints = 30;

        }

        public static void AttackNPC(Char attackType)
        {
            Enemy.EnemyType = attackType;
            player.UseSpecial(Enemy);

        }


        public int GetNPCHealth()
        {

            return enemy.currentHealthPoints;

        }

        public int GetPlayerHealth()
        {

            return player.currentHealthPoints;

        }

        internal static void AttackNPC(string attackType)
        {
            throw new NotImplementedException();
        }
    }

}
