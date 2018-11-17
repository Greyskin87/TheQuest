using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        string upArrow = "↑";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //those values depend from the actual screen size
            game = new Game(new Rectangle(78, 57, 420,155));
            
            game.NewLevel(random);
            UpdateCharacters();
            MessageBox.Show("1.\t Muovi il personaggio nella direzione desiderata (MOVE)\n" +
                "2.\tRaccogli le armi (ricordati di equipaggiarle!\n" +
                "3.\tAvvicinati al nemico (HINT: per colpirlo devi essere ben allineato)\n" +
                "4.\tAttacca nella direzione desiderata (ATTACK)","Benvenuto!");

            groupBox2.Visible = false;


            MessageBox.Show("Level " + game.Level.ToString() + "!");
        }

        private void UpdateCharacters()
        {
            //Update player's position and stats
            player.Location = game.PlayerLocation;
            playerHP.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemyShown = 0;

            //Update enemy's positions and stats;
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemyShown++;
                    }
                    if (!showBat)
                    {
                        bat.Visible = false;
                        batHP.Text = "";
                    }
                    else
                    {
                        bat.Visible = true;
                    }
                }

                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemyShown++;
                    }
                    if (!showGhost)
                    {
                        ghost.Visible = false;
                        ghostHP.Text = "";
                    }
                    else
                    {
                        ghost.Visible = true;
                    }
                }

                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemyShown++;
                    }
                    if (!showGhoul)
                    {
                        ghoul.Visible = false;
                        ghoulHP.Text = "";
                    }
                    else
                    {
                        ghoul.Visible = true;
                    }
                }
            }

            //Update weapon's pictureboxes
            swordField.Visible = false;
            bowField.Visible = false;
            redPotionField.Visible = false;
            bluePotionField.Visible = false;
            maceField.Visible = false;

            Control weaponControl = null;
            if (game.WeaponInRoom != null)
            {
                switch (game.WeaponInRoom.Name)
                {
                    case "Sword":
                        weaponControl = swordField; break;
                    case "Bow":
                        weaponControl = bowField; break;
                    case "Red Potion":
                        weaponControl = redPotionField; break;
                    case "Blue Potion":
                        weaponControl = bluePotionField; break;
                    case "Mace":
                        weaponControl = maceField; break;
                    default:
                        break;
                }

                weaponControl.Visible = true;
            }
            
            swordInventory.Visible = false;
            bowInventory.Visible = false;
            bluePotionInventory.Visible = false;
            redPotionInventory.Visible = false;
            maceInventory.Visible = false;

            //Check inventory
            if (game.CheckPlayerInventory("Sword"))
            {
                swordInventory.Visible = true;               
            }

            if (game.CheckPlayerInventory("Bow"))
            {
                bowInventory.Visible = true;
            }

            if (game.CheckPlayerInventory("Blue Potion"))
            {
                bluePotionInventory.Visible = true;
            }

            if (game.CheckPlayerInventory("Red Potion"))
            {
                redPotionInventory.Visible = true;
            }

            if (game.CheckPlayerInventory("Mace"))
            {
                maceInventory.Visible = true;
            }

            //Check if player's already picked up the weapon
            if (weaponControl != null)
            {
                weaponControl.Location = game.WeaponInRoom.Location;
            
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }
            }
            //Check if player died
            if (game.PlayerHitPoints <= 0) 
            {
                MessageBox.Show("You died!","Game over!");
                Application.Exit();
            }

            //Check for level up
            if (enemyShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                
                game.NewLevel(random);
                MessageBox.Show("Level " + game.Level.ToString() + "!");
                UpdateCharacters();
            }
        }

        private void swordInventory_Click(object sender, EventArgs e)
        {
            string weaponName = "Sword";
            if (game.CheckPlayerInventory(weaponName))
            {
                game.Equip(weaponName);
            }

            swordInventory.BorderStyle = BorderStyle.FixedSingle;
            bluePotionInventory.BorderStyle = BorderStyle.None;
            redPotionInventory.BorderStyle = BorderStyle.None;
            bowInventory.BorderStyle = BorderStyle.None;
            maceInventory.BorderStyle = BorderStyle.None;

            groupBox2.Visible = true;
        }

        private void bluePotionInventory_Click(object sender, EventArgs e)
        {
            string weaponName = "Blue Potion";
            if (game.CheckPlayerInventory(weaponName))
            {
                game.Equip(weaponName);
            }

            swordInventory.BorderStyle = BorderStyle.None;
            bluePotionInventory.BorderStyle = BorderStyle.FixedSingle;
            redPotionInventory.BorderStyle = BorderStyle.None;
            bowInventory.BorderStyle = BorderStyle.None;
            maceInventory.BorderStyle = BorderStyle.None;

            attackDown.Visible = false;
            attackLeft.Visible = false;
            attackRight.Visible = false;
            attackUp.AutoSize = true;
            attackUp.Text = "Drink";
        }

        private void bowInventory_Click(object sender, EventArgs e)
        {
            string weaponName = "Bow";
            if (game.CheckPlayerInventory(weaponName))
            {
                game.Equip(weaponName);
            }

            swordInventory.BorderStyle = BorderStyle.None;
            bluePotionInventory.BorderStyle = BorderStyle.None;
            redPotionInventory.BorderStyle = BorderStyle.None;
            bowInventory.BorderStyle = BorderStyle.FixedSingle;
            maceInventory.BorderStyle = BorderStyle.None;

        }

        private void redPotionInventory_Click(object sender, EventArgs e)
        {
            string weaponName = "Red Potion";
            if (game.CheckPlayerInventory(weaponName))
            {
                game.Equip(weaponName);
            }

            swordInventory.BorderStyle = BorderStyle.None;
            bluePotionInventory.BorderStyle = BorderStyle.None;
            redPotionInventory.BorderStyle = BorderStyle.FixedSingle;
            bowInventory.BorderStyle = BorderStyle.None;
            maceInventory.BorderStyle = BorderStyle.None;

            attackDown.Visible = false;
            attackLeft.Visible = false;
            attackRight.Visible = false;
            attackUp.AutoSize = true;
            attackUp.Text = "Drink";
        }

        private void maceInventory_Click(object sender, EventArgs e)
        {
            string weaponName = "Mace";
            if (game.CheckPlayerInventory(weaponName))
            {
                game.Equip(weaponName);
            }

            swordInventory.BorderStyle = BorderStyle.None;
            bluePotionInventory.BorderStyle = BorderStyle.None;
            redPotionInventory.BorderStyle = BorderStyle.None;
            bowInventory.BorderStyle = BorderStyle.None;
            maceInventory.BorderStyle = BorderStyle.FixedSingle;

        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
            attackDown.Visible = true;
            attackLeft.Visible = true;
            attackRight.Visible = true;
            attackUp.AutoSize = false;
            attackUp.Text = upArrow;
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }
    }
}
