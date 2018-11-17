using System;
using System.Drawing;

namespace TheQuest
{
    /// <summary>
    /// Moves a lot; hard
    /// </summary>
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {
        }

        public override void Move(Random random)
        {
            Direction directionToMove;
            if (HitPoints > 0)
            {
                int choice = random.Next(3);

                //Move towards player
                if (choice > 1)
                {
                    directionToMove = FindPlayerDirection(game.PlayerLocation);
                    location = Move(directionToMove, game.Boundaries);
                }

                //Attack player
                if (NearPlayer())
                {
                    game.HitPlayer(4, random);
                }
            }
        }
    }
}