using System;
using System.Drawing;

namespace TheQuest
{
    /// <summary>
    /// Worse curative potion
    /// </summary>
    class BluePotion : Weapon,IPotion
    {

        public BluePotion(Game game, Point location) : base(game, location)
        {
        }

        /// <summary>
        /// Name of the potion
        /// </summary>
        public override string Name { get { return "Blue Potion"; } }

        private bool used = false;
        public bool Used { get { return used; } }


        /// <summary>
        /// Cures a moderate amounth of Health
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            used = true;

        }
    }
}