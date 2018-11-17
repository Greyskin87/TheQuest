using System;
using System.Drawing;

namespace TheQuest
{
    //Medium weapon: long radius, narrow angle
    class Bow : Weapon
    {
        private const int radius = 30;
        private const int maxDamage = 1;

        public Bow(Game game, Point location) : base(game, location)
        {
        }

        public override string Name { get { return "Bow"; } }

        /// <summary>
        /// Make an attack
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public override void Attack(Direction direction, Random random)
        {
            //Try to hit enemy in that direction
            DamageEnemy(direction, radius, maxDamage, random);
        }
    }
}