using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Media.Imaging;
using ApplicationNavigation.Helpers;

namespace ApplicationNavigation.Model
{

    public class PlayerCharacter : Character
    {

        private String characterName;
        private SpecialAttack specialAttack;
        public NormalAttack attack;

        public PlayerCharacter()
        {

        }



       
        public PlayerCharacter(String characterName, int baseDamage, int currentHealthPoints, int maxHealthpoints)
        {
            CharacterName = characterName;
            this.baseDamage = baseDamage;
            this.currentHealthPoints = currentHealthPoints;
            this.maxHealthPoints = maxHealthpoints;

        }

       
        public void GetNormalAttackDamage(NonPlayerCharacter NPC)
        {
            
            Random attackChance = new Random();

            int attackResult = attackChance.Next(0, 2);


            attack = new NormalAttack();

            if (attackResult == 1)
            {
                System.Windows.MessageBox.Show("Player Attack Successful. Non Player Turn Now");

                attack.DealDamage(GameController.Player.baseDamage, GameController.Enemy);
                //GameController.Enemy.currentHealthPoints = GameController.Enemy.currentHealthPoints - 10;

            }

            if (attackResult == 0)
            {
                System.Windows.MessageBox.Show("Player Attack UnSuccessful. Non Player Turn Now ");
                

            }



        }

        
        public void UseSpecial(NonPlayerCharacter enemy)
        {

            specialAttack = new SpecialAttack();

            if (GameController.Enemy.EnemyType.Equals("Berserk"))
            {

                Random attackChanceBerserk = new Random();

                int attackResult = attackChanceBerserk.Next(0, 3);

                if (attackResult == 2)
                {
                    System.Windows.MessageBox.Show("Player Special Attack Successful. Non Player Turn Now");
                    specialAttack.DealDamage(GameController.Player.baseDamage * 3, GameController.Enemy);
                }
                else
                {
                    System.Windows.MessageBox.Show("Player Special Attack UnSuccessful. Non Player Turn Now");
                    specialAttack.DealDamage(0, GameController.Enemy);
                }

            }
            if (GameController.Enemy.EnemyType.Equals("Backstab")) {

                Random attackChanceFireball = new Random();

                int attackResult = attackChanceFireball.Next(0, 3);

                if (attackResult == 2)
                {
                    System.Windows.MessageBox.Show("Player Special Attack Successful. Non Player Turn Now");
                    specialAttack.DealDamage(GameController.Player.baseDamage * 2, GameController.Enemy);
                }
                else
                {
                    System.Windows.MessageBox.Show("Player Special Attack UnSuccessful. Non Player Turn Now");
                    specialAttack.DealDamage(5, GameController.Enemy);
                }

            }

            if (GameController.Enemy.EnemyType.Equals("Fireball")) {

                Random attackChanceBackstab = new Random();

                int attackResult = attackChanceBackstab.Next(0, 2);

                if (attackResult == 1)
                {
                    System.Windows.MessageBox.Show("Player Special Attack Successful. Non Player Turn Now");
                    specialAttack.DealDamage(GameController.Player.baseDamage * 4, GameController.Enemy);
                }
                else
                {
                    System.Windows.MessageBox.Show("Player Special Attack UnSuccessful. Non Player Turn Now");
                    specialAttack.DealDamage(GameController.Player.baseDamage, GameController.Player);
                }

            }


        }

        public String CharacterName { get => characterName; set => characterName = value; }
      
    }

}