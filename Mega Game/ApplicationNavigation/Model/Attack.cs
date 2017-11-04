

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ApplicationNavigation.Helpers;

namespace ApplicationNavigation.Model
{


    public abstract class Attack
    {

        //private int attackBaseDamage;

        public Attack()
        {

        }

        ~Attack()
        {

        }
        
        public Attack(int characterBaseDamage)
        {

        }

        
        public int MakeAttack(Character Character)
        {

            return 0;
        }


        public void DealDamage(int damage, Character character)
        {
            if (character.GetType() == typeof(PlayerCharacter))
            {
                GameController.Player.currentHealthPoints = GameController.Player.currentHealthPoints - damage;
            }

            if (character.GetType() == typeof(NonPlayerCharacter))
            {
                GameController.Enemy.currentHealthPoints = GameController.Enemy.currentHealthPoints - damage;
            }
        }

    }

}