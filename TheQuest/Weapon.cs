using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    /// <summary>
    /// Base class for all weapons in geme
    /// </summary>
    abstract class Weapon : Mover
    {
        /// <summary>
        /// Is the weapon picked up?
        /// </summary>
        public bool PickedUp { get; private set; }

        /// <summary>
        /// Constructor: it needs a Game and a location (as a mover); sets PickedUp property
        /// </summary>
        /// <param name="game"></param>
        /// <param name="location"></param>
        public Weapon(Game game, Point location) : base(game,location)
        {
            PickedUp = false;
        }

        /// <summary>
        /// Player picks up the weapon
        /// </summary>
        public void PickUpWeapon()
        {
            PickedUp = true;
        }

        /// <summary>
        /// Generic weapon does not need a name
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Each weapon attacks in different ways
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public abstract void Attack(Direction direction, Random random);


        /// <summary>
        /// Check if the attack can damage an enemy
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="radius"></param>
        /// <param name="damage"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;

            for (int distance = 0; distance < radius/2; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location,target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;           
        }                
    }
}
