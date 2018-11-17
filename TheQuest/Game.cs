using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    /// <summary>
    /// This class takes care of everything converning the gameplay; the form talks only with it.
    /// </summary>
    class Game
    {
        /// <summary>
        /// List of Enemies in the Room
        /// </summary>
        public IEnumerable<Enemy> Enemies { get; private set; }

        /// <summary>
        /// Single weapon spawned in each level
        /// </summary>
        public Weapon WeaponInRoom { get; private set; }

        /// <summary>
        /// Instance of the player
        /// </summary>
        private Player player;

        /// <summary>
        /// Location of the player
        /// </summary>
        public Point PlayerLocation { get { return player.Location; } } 
        /// <summary>
        /// Hit points of the player
        /// </summary>
        public int PlayerHitPoints { get { return player.HitPoints; } }

        /// <summary>
        /// Weapons of the player
        /// </summary>
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;

        /// <summary>
        /// Current level of the game
        /// </summary>
        public int Level { get { return level; } }

        private Rectangle boundaries;

        /// <summary>
        /// Boundaries of the game area as a Rectangle
        /// </summary>
        public Rectangle Boundaries { get { return boundaries; } }

        /// <summary>
        /// Constructor 1: Create a new game given the game area
        /// </summary>
        /// <param name="boundaries">The game area</param>
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        /// <summary>
        /// Player moves, enemies move
        /// </summary>
        /// <param name="direction">Direction towards which the player moves</param>
        /// <param name="random"></param>
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        /// <summary>
        /// Player equips a weapon
        /// </summary>
        /// <param name="weaponName">The weapon name</param>
        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        /// <summary>
        /// Check if given weapon is in player's inventory
        /// </summary>
        /// <param name="weaponName">The weapon name</param>
        /// <returns></returns>
        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        /// <summary>
        /// Player is suffering damage from enemy
        /// </summary>
        /// <param name="maxDamage">The max amount of damage of this attack</param>
        /// <param name="random"></param>
        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        /// <summary>
        /// Increase player's health
        /// </summary>
        /// <param name="health">Amount of health gained</param>
        /// <param name="random"></param>
        public void IncreasePlayerHealth (int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        /// <summary>
        /// Player attacks, enemies move
        /// </summary>
        /// <param name="direction">Direction towards wich the player attacks</param>
        /// <param name="random"></param>
        public void Attack (Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        /// <summary>
        /// Get a random location in the game area
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        private Point GetRandomLocation (Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        /// <summary>
        /// Takes care of setting up the levels
        /// </summary>
        /// <param name="random"></param>
        public void NewLevel (Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this, GetRandomLocation(random)),
                    };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;

                case 2:
                    Enemies = new List<Enemy>()
                    {
                        new Ghost(this, GetRandomLocation(random)),
                    };
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>() {
                        new Ghoul(this, GetRandomLocation(random)),
                    };
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)),
                    };
                    if (!CheckPlayerInventory("Bow"))
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    else if (!CheckPlayerInventory("Blue Potion"))
                    {
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    } else
                    {
                        WeaponInRoom = null;
                    }
                    break;
                case 5:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };

                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies = new List<Enemy>() {
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };

                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };

                    if (!CheckPlayerInventory("Mace"))
                    {
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    }
                    else if (!CheckPlayerInventory("Red Potion"))
                    {
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = null;
                    }
                    break;
                case 8:
                    MessageBox.Show("You completed the game!");
                    Application.Exit();
                    break;
            }
        }
    }
}
