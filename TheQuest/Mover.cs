using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    /// <summary>
    /// Something that can move on screen
    /// </summary>
    abstract class Mover
    {
        private const int MoveInterval = 10;
        
        protected Point location;

        /// <summary>
        /// The position of the object
        /// </summary>
        public Point Location { get { return location; } }

        protected Game game;

        /// <summary>
        /// Build a Mover object taking a game instance and a intial location
        /// </summary>
        /// <param name="game"></param>
        /// <param name="location"></param>
        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        /// <summary>
        /// Checks if the object is within "distance" from the "locationToCheck"
        /// </summary>
        /// <param name="locationToCheck">Location to check</param>
        /// <param name="distance">Target distance from the object</param>
        /// <returns></returns>
        public bool Nearby(Point locationToCheck, int distance)
        {
            return Nearby(location, locationToCheck, distance);
        }

        public bool Nearby(Point location, Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && (Math.Abs(location.Y - locationToCheck.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Moves the object towards the selected "direction" in the game "boundaries"
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="boundaries"></param>
        /// <returns></returns>
        public Point Move(Direction direction, Point location, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Left:
                    if(newLocation.X - MoveInterval >= boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                default:
                    break;
            }
            return newLocation;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            return Move(direction, location, boundaries);
        }
    }
}
