using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    /// <summary>
    /// Abstraction for the generic enemy
    /// </summary>
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;

        /// <summary>
        /// Enemy's Hit Points
        /// </summary>
        public int HitPoints { get; private set; }

        /// <summary>
        /// Checks if the enemy is dead
        /// </summary>
        public bool Dead { get{ return (HitPoints <= 0) ? true : false; } }

        /// <summary>
        /// Enemy is a mover with hit points
        /// </summary>
        /// <param name="game"></param>
        /// <param name="location"></param>
        /// <param name="hitPoints"></param>
        public Enemy(Game game, Point location, int hitPoints ) : base(game,location)
        {
            HitPoints = hitPoints;
        }

        /// <summary>
        /// Move is not implemented in the generic enemy
        /// </summary>
        /// <param name="random"></param>
        public abstract void Move(Random random);


        /// <summary>
        /// Decrease heatlh if enemy is hit
        /// </summary>
        /// <param name="maxDamage"></param>
        /// <param name="random"></param>
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        /// <summary>
        /// Checks if the player is near
        /// </summary>
        /// <returns></returns>
        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }


        /// <summary>
        /// Provide the direction to chase the player
        /// </summary>
        /// <param name="playerLocation"></param>
        /// <returns></returns>
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
            {
                directionToMove = Direction.Right;
            }
            else if (playerLocation.X < location.X - 10)
            {
                directionToMove = Direction.Left;
            }
            else if (playerLocation.Y < location.Y - 10)
            {
                directionToMove = Direction.Up;
            }
            else
            {
                directionToMove = Direction.Down;
            }
            return directionToMove;
        }

    }
}
