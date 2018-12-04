namespace Minesweeper
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileGrid
            // 
            this.tileGrid.Location = new System.Drawing.Point(12, 70);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(482, 292);
            this.tileGrid.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Minesweeper.Properties.Resources.MINESWEEPER_tray;
            this.pictureBox1.Location = new System.Drawing.Point(216, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.LoadGame);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(523, 407);
            this.Controls.Add(this.tileGrid);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TileGrid tileGrid;
        private System.Windows.Forms.PictureBox gameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

