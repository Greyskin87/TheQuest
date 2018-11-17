using System;
using System.Drawing;

namespace TheQuest
{
    /// <summary>
    /// Basic weapon: short radius, hit in half a circle
    /// </summary>
    internal class Sword : Weapon
    {
        private const int radius = 10;
        private const int maxDamage = 3;

        public Sword(Game game, Point location) : base(game,location)
        {
        }

        public override string Name { get { return "Sword"; } }

        /// <summary>
        /// Swing a sword attack
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public override void Attack(Direction direction, Random random)
        {

            //try to hit the enemy in that direction
            if (!DamageEnemy(direction, radius, maxDamage, random))
            {
                //try hit clockwise
                Direction newDirection = (int)direction + 1 > 3 ? (Direction)0 : direction + 1;
                if (!DamageEnemy(newDirection, radius, maxDamage, random))
                {
                    //try counterclockwise
                    newDirection = (int)direction - 1 < 0 ? (Direction)3 : direction - 1;
                    DamageEnemy(newDirection, radius, maxDamage, random);
                }
            }
        }
    }
}