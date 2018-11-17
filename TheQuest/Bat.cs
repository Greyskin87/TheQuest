using System;
using System.Drawing;

namespace TheQuest
{
    /// <summary>
    /// Bat: moves quite random; easiest
    /// </summary>
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        {
        }

        public override void Move(Random random)
        {
            Direction directionToMove;
            if (HitPoints > 0)
            {
                int choice = random.Next(2);

                //Move towards player
                if (choice == 1)
                {
                    directionToMove = FindPlayerDirection(game.PlayerLocation);
                }
                else
                {
                    directionToMove = (Direction)random.Next(4);
                }

                location = Move(directionToMove, game.Boundaries);

                //Attack player
                if (NearPlayer())
                {
                    game.HitPlayer(2, random);
                }
            }
        }
    }
}