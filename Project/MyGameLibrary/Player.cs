using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public int Level { get;  private set; }
        public int EXP { get; private set; }

        public Player(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            Level = 1;
            EXP = 0;
        }

        /// <summary>
        /// increments exp by given amount, returns true on a level up, false otherwise
        /// </summary>
        /// <param name="xp">amount to increase exp, must be a positive number</param>
        /// <returns></returns>
        public bool AwardEXP(int xp)
        {
            // award experience points if the given xp value isn't negative
            if (xp > 0)
                EXP += xp;

            // adjust player level based on accrued experience
            int prevLevel = Level;
            Level = (EXP / 100) + 1;

            // if player levels up, increase and refill health
            if (Level > prevLevel)
            {
                MaxHealth += 5;
                Health = MaxHealth;
                return true;
            }
            else
                return false;
        }
    }
}
