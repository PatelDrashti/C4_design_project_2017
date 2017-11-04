
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ApplicationNavigation.Model
{


    public abstract class Character
    {
       
        public int baseDamage;
        public int currentHealthPoints;
        public int maxHealthPoints;

        public Character()
        {

        }

        ~Character()
        {

        }

        
        public Character(int baseDamage, int currentHealthPoints, int maxHealthPoints)
        {

        }

       
        public void GetNormalAttackDamage(Character character)
        {
           
        }

    }

}