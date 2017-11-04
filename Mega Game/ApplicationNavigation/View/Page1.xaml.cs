using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ApplicationNavigation.Helpers;

namespace ApplicationNavigation.View
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
           
            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " Current Health: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Base Damage: " + GameController.Player.baseDamage;

            if (GameController.Player.CharacterName.Equals("Warrior"))
            {

                
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri("c:\\images\\warrior.JPG");
                b.EndInit();

                
                Img_Character.Source = b;
                

            }

            if (GameController.Player.CharacterName.Equals("Mage"))
            {

                
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri("c:\\images\\Mage.JPG");
                b.EndInit();

                
                Img_Character.Source = b;


            }

            if (GameController.Player.CharacterName.Equals("Thief"))
            {

                //Img_Character.Source = (ImageSource)new ImageSourceConverter().ConvertFromString("warrior.png");
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri("c:\\images\\Theif.JPG");
                b.EndInit();
                Img_Character.Source = b;


            }

            // Non Player Character 
            Npc_hp.Content = " Current Health: " + GameController.Enemy.currentHealthPoints;
            BitmapImage b1 = new BitmapImage();
            b1.BeginInit();
            b1.UriSource = new Uri("c:\\images\\DD_Action_Mage.png");
            b1.EndInit();

           
            Img_NPC.Source = b1;

            Npc_hp.Content = " Current Health: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Base Damage: " + GameController.Enemy.baseDamage;


        }

        private void Button_NormalAttack_Click(object sender, RoutedEventArgs e)
        {
            
            GameController.Player.GetNormalAttackDamage(GameController.Enemy);
            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " Current Health: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Base Damage: " + GameController.Player.baseDamage;
            Npc_hp.Content = " Current Health: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Base Damage: " + GameController.Enemy.baseDamage;

            GameController.Enemy.GetNormalAttackDamage(GameController.Player);
            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " Current Health: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Base Damage: " + GameController.Player.baseDamage;
            Npc_hp.Content = " Current Health: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Base Damage: " + GameController.Enemy.baseDamage;

            if(GameController.Player.currentHealthPoints<=0 || GameController.Enemy.currentHealthPoints <= 0)
            {
                this.NavigationService.Navigate(new Page2());
            }






        }

        private void Button_SpecialAttack_Click(object sender, RoutedEventArgs e)
        {
            String attackType;
            

            if (GameController.Player.CharacterName.Equals("Warrior"))
            {
                attackType = "Berserk";
                GameController.AttackNPC(attackType);
            }
            if (GameController.Player.CharacterName.Equals("Mage"))
            {
                attackType = "Fireball";
                GameController.AttackNPC(attackType);
            }

            if (GameController.Player.CharacterName.Equals("Thief"))
            {
                attackType = "Backstab";
                GameController.AttackNPC(attackType);
            }

            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " Current Health: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Base Damage: " + GameController.Player.baseDamage;
            
            Npc_hp.Content = " Current Health: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Base Damage: " + GameController.Enemy.baseDamage;
            GameController.Enemy.GetNormalAttackDamage(GameController.Player);
            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " Current Health: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Base Damage: " + GameController.Player.baseDamage;
            Npc_hp.Content = " Current Health: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Base Damage: " + GameController.Enemy.baseDamage;

            if (GameController.Player.currentHealthPoints <= 0 || GameController.Enemy.currentHealthPoints <= 0)
            {
                this.NavigationService.Navigate(new Page2());
            }

        }
    }
}
