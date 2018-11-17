using System;
using System.Drawing;

namespace TheQuest
{
    /// <summary>
    /// Best weapon: plenty of damage, full circle, big radius
    /// </summary>
    class Mace : Weapon
    {
        private const int radius = 20;
        private const int maxDamage = 6;

        public Mace(Game game, Point location) : base(game, location)
        {
        }

        public override string Name { get { return "Mace"; } }

        /// <summary>
        /// Swing a sword attack
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public override void Attack(Direction direction, Random random)
        {

            //try to hit the enemy in every direction
            foreach (Direction nextDirection in Enum.GetValues(typeof(Direction)))
            {
                if (DamageEnemy(nextDirection, radius, maxDamage, random))
                {
                    return;
                }
            }
        }
    }
}