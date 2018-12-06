﻿namespace Minesweeper
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
            this.tileGrid = new Minesweeper.Form1.TileGrid();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Game_Easy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Medium = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Hard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Break2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Game_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileGrid
            // 
            this.tileGrid.Location = new System.Drawing.Point(12, 70);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(213, 165);
            this.tileGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip";
            // 
            // menuStrip_Game
            // 
            this.menuStrip_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game_New,
            this.toolStripSeparator1,
            this.menuStrip_Game_Easy,
            this.menuStrip_Game_Medium,
            this.menuStrip_Game_Hard,
            this.menuStrip_Game_Break2,
            this.menuStrip_Game_Exit});
            this.menuStrip_Game.Name = "menuStrip_Game";
            this.menuStrip_Game.Size = new System.Drawing.Size(50, 20);
            this.menuStrip_Game.Text = "Game";
            // 
            // menuStrip_Game_New
            // 
            this.menuStrip_Game_New.Name = "menuStrip_Game_New";
            this.menuStrip_Game_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStrip_Game_New.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_New.Text = "New";
            this.menuStrip_Game_New.Click += new System.EventHandler(this.MenuStrip_Game_New_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuStrip_Game_Easy
            // 
            this.menuStrip_Game_Easy.Name = "menuStrip_Game_Easy";
            this.menuStrip_Game_Easy.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_Easy.Tag = "Easy";
            this.menuStrip_Game_Easy.Text = "Easy";
            this.menuStrip_Game_Easy.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Medium
            // 
            this.menuStrip_Game_Medium.Name = "menuStrip_Game_Medium";
            this.menuStrip_Game_Medium.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_Medium.Tag = "Medium";
            this.menuStrip_Game_Medium.Text = "Medium";
            this.menuStrip_Game_Medium.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Hard
            // 
            this.menuStrip_Game_Hard.Name = "menuStrip_Game_Hard";
            this.menuStrip_Game_Hard.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_Hard.Tag = "Hard";
            this.menuStrip_Game_Hard.Text = "Hard";
            this.menuStrip_Game_Hard.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Break2
            // 
            this.menuStrip_Game_Break2.Name = "menuStrip_Game_Break2";
            this.menuStrip_Game_Break2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuStrip_Game_Exit
            // 
            this.menuStrip_Game_Exit.Name = "menuStrip_Game_Exit";
            this.menuStrip_Game_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuStrip_Game_Exit.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_Exit.Tag = "Exit";
            this.menuStrip_Game_Exit.Text = "Exit";
            this.menuStrip_Game_Exit.Click += new System.EventHandler(this.MenuStrip_Game_Exit_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(807, 524);
            this.Controls.Add(this.tileGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TileGrid tileGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_New;
        private System.Windows.Forms.ToolStripSeparator menuStrip_Game_Break2;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Easy;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Medium;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Hard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Exit;
    }
}

