namespace TheQuest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player = new System.Windows.Forms.PictureBox();
            this.swordField = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.bowField = new System.Windows.Forms.PictureBox();
            this.bluePotionField = new System.Windows.Forms.PictureBox();
            this.redPotionField = new System.Windows.Forms.PictureBox();
            this.maceField = new System.Windows.Forms.PictureBox();
            this.swordInventory = new System.Windows.Forms.PictureBox();
            this.bluePotionInventory = new System.Windows.Forms.PictureBox();
            this.redPotionInventory = new System.Windows.Forms.PictureBox();
            this.bowInventory = new System.Windows.Forms.PictureBox();
            this.maceInventory = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHP = new System.Windows.Forms.Label();
            this.batHP = new System.Windows.Forms.Label();
            this.ghostHP = new System.Windows.Forms.Label();
            this.ghoulHP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::TheQuest.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(90, 71);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // swordField
            // 
            this.swordField.BackColor = System.Drawing.Color.Transparent;
            this.swordField.Image = global::TheQuest.Properties.Resources.sword;
            this.swordField.Location = new System.Drawing.Point(126, 71);
            this.swordField.Name = "swordField";
            this.swordField.Size = new System.Drawing.Size(30, 30);
            this.swordField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swordField.TabIndex = 1;
            this.swordField.TabStop = false;
            this.swordField.Visible = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = global::TheQuest.Properties.Resources.bat;
            this.bat.Location = new System.Drawing.Point(162, 71);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(30, 30);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bat.TabIndex = 2;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = global::TheQuest.Properties.Resources.ghoul;
            this.ghoul.Location = new System.Drawing.Point(198, 71);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(30, 30);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghoul.TabIndex = 3;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = global::TheQuest.Properties.Resources.ghost;
            this.ghost.Location = new System.Drawing.Point(234, 71);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(30, 30);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghost.TabIndex = 4;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // bowField
            // 
            this.bowField.BackColor = System.Drawing.Color.Transparent;
            this.bowField.Image = global::TheQuest.Properties.Resources.bow;
            this.bowField.Location = new System.Drawing.Point(270, 71);
            this.bowField.Name = "bowField";
            this.bowField.Size = new System.Drawing.Size(30, 30);
            this.bowField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bowField.TabIndex = 5;
            this.bowField.TabStop = false;
            this.bowField.Visible = false;
            // 
            // bluePotionField
            // 
            this.bluePotionField.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionField.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.bluePotionField.Location = new System.Drawing.Point(306, 71);
            this.bluePotionField.Name = "bluePotionField";
            this.bluePotionField.Size = new System.Drawing.Size(30, 30);
            this.bluePotionField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bluePotionField.TabIndex = 6;
            this.bluePotionField.TabStop = false;
            this.bluePotionField.Visible = false;
            // 
            // redPotionField
            // 
            this.redPotionField.BackColor = System.Drawing.Color.Transparent;
            this.redPotionField.Image = global::TheQuest.Properties.Resources.potion_red;
            this.redPotionField.Location = new System.Drawing.Point(342, 71);
            this.redPotionField.Name = "redPotionField";
            this.redPotionField.Size = new System.Drawing.Size(30, 30);
            this.redPotionField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redPotionField.TabIndex = 7;
            this.redPotionField.TabStop = false;
            this.redPotionField.Visible = false;
            // 
            // maceField
            // 
            this.maceField.BackColor = System.Drawing.Color.Transparent;
            this.maceField.Image = global::TheQuest.Properties.Resources.mace;
            this.maceField.Location = new System.Drawing.Point(378, 71);
            this.maceField.Name = "maceField";
            this.maceField.Size = new System.Drawing.Size(30, 30);
            this.maceField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maceField.TabIndex = 8;
            this.maceField.TabStop = false;
            this.maceField.Visible = false;
            // 
            // swordInventory
            // 
            this.swordInventory.BackColor = System.Drawing.Color.Transparent;
            this.swordInventory.Image = global::TheQuest.Properties.Resources.sword;
            this.swordInventory.Location = new System.Drawing.Point(70, 322);
            this.swordInventory.Name = "swordInventory";
            this.swordInventory.Size = new System.Drawing.Size(50, 50);
            this.swordInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swordInventory.TabIndex = 9;
            this.swordInventory.TabStop = false;
            this.swordInventory.Visible = false;
            this.swordInventory.Click += new System.EventHandler(this.swordInventory_Click);
            // 
            // bluePotionInventory
            // 
            this.bluePotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionInventory.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.bluePotionInventory.Location = new System.Drawing.Point(126, 322);
            this.bluePotionInventory.Name = "bluePotionInventory";
            this.bluePotionInventory.Size = new System.Drawing.Size(50, 50);
            this.bluePotionInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bluePotionInventory.TabIndex = 10;
            this.bluePotionInventory.TabStop = false;
            this.bluePotionInventory.Visible = false;
            this.bluePotionInventory.Click += new System.EventHandler(this.bluePotionInventory_Click);
            // 
            // redPotionInventory
            // 
            this.redPotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.redPotionInventory.Image = global::TheQuest.Properties.Resources.potion_red;
            this.redPotionInventory.Location = new System.Drawing.Point(238, 322);
            this.redPotionInventory.Name = "redPotionInventory";
            this.redPotionInventory.Size = new System.Drawing.Size(50, 50);
            this.redPotionInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redPotionInventory.TabIndex = 11;
            this.redPotionInventory.TabStop = false;
            this.redPotionInventory.Visible = false;
            this.redPotionInventory.Click += new System.EventHandler(this.redPotionInventory_Click);
            // 
            // bowInventory
            // 
            this.bowInventory.BackColor = System.Drawing.Color.Transparent;
            this.bowInventory.Image = global::TheQuest.Properties.Resources.bow;
            this.bowInventory.Location = new System.Drawing.Point(182, 322);
            this.bowInventory.Name = "bowInventory";
            this.bowInventory.Size = new System.Drawing.Size(50, 50);
            this.bowInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bowInventory.TabIndex = 12;
            this.bowInventory.TabStop = false;
            this.bowInventory.Visible = false;
            this.bowInventory.Click += new System.EventHandler(this.bowInventory_Click);
            // 
            // maceInventory
            // 
            this.maceInventory.BackColor = System.Drawing.Color.Transparent;
            this.maceInventory.Image = global::TheQuest.Properties.Resources.mace;
            this.maceInventory.Location = new System.Drawing.Point(294, 322);
            this.maceInventory.Name = "maceInventory";
            this.maceInventory.Size = new System.Drawing.Size(50, 50);
            this.maceInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maceInventory.TabIndex = 8;
            this.maceInventory.TabStop = false;
            this.maceInventory.Visible = false;
            this.maceInventory.Click += new System.EventHandler(this.maceInventory_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.5F));
            this.tableLayoutPanel1.Controls.Add(this.ghoulHP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghostHP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerHP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(351, 208);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(174, 72);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            // 
            // playerHP
            // 
            this.playerHP.AutoSize = true;
            this.playerHP.Location = new System.Drawing.Point(66, 0);
            this.playerHP.Name = "playerHP";
            this.playerHP.Size = new System.Drawing.Size(0, 13);
            this.playerHP.TabIndex = 4;
            // 
            // batHP
            // 
            this.batHP.AutoSize = true;
            this.batHP.Location = new System.Drawing.Point(66, 18);
            this.batHP.Name = "batHP";
            this.batHP.Size = new System.Drawing.Size(0, 13);
            this.batHP.TabIndex = 5;
            // 
            // ghostHP
            // 
            this.ghostHP.AutoSize = true;
            this.ghostHP.Location = new System.Drawing.Point(66, 36);
            this.ghostHP.Name = "ghostHP";
            this.ghostHP.Size = new System.Drawing.Size(0, 13);
            this.ghostHP.TabIndex = 6;
            // 
            // ghoulHP
            // 
            this.ghoulHP.AutoSize = true;
            this.ghoulHP.Location = new System.Drawing.Point(66, 54);
            this.ghoulHP.Name = "ghoulHP";
            this.ghoulHP.Size = new System.Drawing.Size(0, 13);
            this.ghoulHP.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveDown);
            this.groupBox1.Controls.Add(this.moveRight);
            this.groupBox1.Controls.Add(this.moveUp);
            this.groupBox1.Controls.Add(this.moveLeft);
            this.groupBox1.Location = new System.Drawing.Point(368, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(83, 62);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveLeft
            // 
            this.moveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLeft.Location = new System.Drawing.Point(6, 30);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(20, 20);
            this.moveLeft.TabIndex = 0;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveUp
            // 
            this.moveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUp.Location = new System.Drawing.Point(32, 16);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(20, 20);
            this.moveUp.TabIndex = 1;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveRight
            // 
            this.moveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveRight.Location = new System.Drawing.Point(57, 30);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(20, 20);
            this.moveRight.TabIndex = 2;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveDown
            // 
            this.moveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDown.Location = new System.Drawing.Point(32, 42);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(20, 20);
            this.moveDown.TabIndex = 3;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackDown);
            this.groupBox2.Controls.Add(this.attackRight);
            this.groupBox2.Controls.Add(this.attackUp);
            this.groupBox2.Controls.Add(this.attackLeft);
            this.groupBox2.Location = new System.Drawing.Point(457, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 62);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackDown
            // 
            this.attackDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackDown.Location = new System.Drawing.Point(32, 42);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(20, 20);
            this.attackDown.TabIndex = 3;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackRight
            // 
            this.attackRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackRight.Location = new System.Drawing.Point(57, 30);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(20, 20);
            this.attackRight.TabIndex = 2;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackUp
            // 
            this.attackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackUp.Location = new System.Drawing.Point(32, 16);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(20, 20);
            this.attackUp.TabIndex = 1;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackLeft.Location = new System.Drawing.Point(6, 30);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(20, 20);
            this.attackLeft.TabIndex = 0;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.ClientSize = new System.Drawing.Size(598, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bowInventory);
            this.Controls.Add(this.redPotionInventory);
            this.Controls.Add(this.bluePotionInventory);
            this.Controls.Add(this.swordInventory);
            this.Controls.Add(this.player);
            this.Controls.Add(this.maceInventory);
            this.Controls.Add(this.maceField);
            this.Controls.Add(this.redPotionField);
            this.Controls.Add(this.bluePotionField);
            this.Controls.Add(this.bowField);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.swordField);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "The Quest - basic edition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox swordField;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox bowField;
        private System.Windows.Forms.PictureBox bluePotionField;
        private System.Windows.Forms.PictureBox redPotionField;
        private System.Windows.Forms.PictureBox maceField;
        private System.Windows.Forms.PictureBox swordInventory;
        private System.Windows.Forms.PictureBox bluePotionInventory;
        private System.Windows.Forms.PictureBox redPotionInventory;
        private System.Windows.Forms.PictureBox bowInventory;
        private System.Windows.Forms.PictureBox maceInventory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ghoulHP;
        private System.Windows.Forms.Label ghostHP;
        private System.Windows.Forms.Label batHP;
        private System.Windows.Forms.Label playerHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.Button attackLeft;
    }
}

