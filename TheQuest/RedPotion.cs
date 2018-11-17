using System;
using System.Drawing;

namespace TheQuest
{
    /// <summary>
    /// Better curative potion
    /// </summary>
    class RedPotion : Weapon,IPotion
    {

        public RedPotion(Game game, Point location) : base(game, location)
        {
        }

        private bool used = false;
        public bool Used { get { return Used; } }
        /// <summary>
        /// potion name
        /// </summary>
        public override string Name { get { return "Red Potion"; } }

        /// <summary>
        /// Cures a big amount of health
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            used = true;
        }
    }
}