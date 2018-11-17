using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        /// <summary>
        /// Current number of Hit Points
        /// </summary>
        public int HitPoints { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();

        /// <summary>
        /// The names of all weapon in player's inventory
        /// </summary>
        public IEnumerable<string> Weapons {
            get {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        /// <summary>
        /// A mover with a fixed amount of HitPoints
        /// </summary>
        /// <param name="game"></param>
        /// <param name="location"></param>
        public Player(Game game, Point location) : base(game,location)
        {
            HitPoints = 10;
        }


        /// <summary>
        /// The Hit Points are decreased by a random amount, between 1 and maxDamage
        /// </summary>
        /// <param name="maxDamage"></param>
        /// <param name="random"></param>
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        /// <summary>
        /// The Hit Points are increased by a random amount, between 1 and health
        /// </summary>
        /// <param name="health"></param>
        /// <param name="random"></param>
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }


        /// <summary>
        /// Equips selected weapon
        /// </summary>
        /// <param name="weaponName"></param>
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        /// <summary>
        /// Move the player towards selected direction and picks up objects
        /// </summary>
        /// <param name="direction"></param>
        public void Move(Direction direction)
        {
            location = Move(direction, game.Boundaries);

            if (game.WeaponInRoom != null)
            {
                if (!game.WeaponInRoom.PickedUp)
                {
                    if (Nearby(game.WeaponInRoom.Location, 10))
                    {
                        game.WeaponInRoom.PickUpWeapon();
                        inventory.Add(game.WeaponInRoom);

                        if (inventory.Count == 1)
                        {
                            Equip(game.WeaponInRoom.Name);
                        }
                    }
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon == null)
            {
                return;
            }
            else
            {
                equippedWeapon.Attack(direction,random);
                if (equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                    equippedWeapon = inventory[0];
                }
            }
        }
    }
}
