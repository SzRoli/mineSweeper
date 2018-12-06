using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Minesweeper.Properties;

namespace Minesweeper
{
    
    public partial class Form1 : Form
    {
        public static bool end = false;
        int s = 0, m = 0, h = 0;
        
        private Difficulty difficulty;
        public Form1()
        {
            
            InitializeComponent();
            //this.LoadGame(null, null);
        }

        private enum Difficulty { Hard, Medium, Easy}

        private void LoadGame(object sender, EventArgs e)
        {

            end = false;
            timer1.Start();
            

            int x, y, mines;
            switch (this.difficulty)
            {
                case Difficulty.Easy:
                    x = 9;
                    y = 9;
                    mines = 10;
                    break;
                case Difficulty.Medium:
                    x = 16;
                    y = 16;
                    mines = 40;
                    break;
                case Difficulty.Hard:
                    x = 30;
                    y = 16;
                    mines = 99;
                    break;
                default:
                    throw new InvalidOperationException("Not found this difficulty");
            }
            this.tileGrid.LoadGrid(new Size(x, y), mines);
            this.MaximumSize = new Size(this.tileGrid.Width + 36, this.tileGrid.Height + 98);
            this.MinimumSize = new Size(this.tileGrid.Width + 36, this.tileGrid.Height + 98);
        }

        private void MenuStrip_Game_New_Click(object sender, EventArgs e)
        {
            s = m = h = 0;
            timer1.Stop();
            this.LoadGame(null,null);
            
            

        }
        private void MenuStrip_Game_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if(s==60)
            {
                s = 0;
                m++;
            }
            if (m == 60)
            {
                h++;
            }
            time.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            if (end == true)
            {
                timer1.Stop();
            }

        }

        private void MenuStrip_Game_DifficultyChanged(object sender, EventArgs e)
        {
            
            s = m = h = 0;
            timer1.Stop();
            this.difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), (string)((ToolStripMenuItem)sender).Tag);
            this.LoadGame(null, null);

        }
        
        private class TileGrid : Panel
        {
            
            private static readonly HashSet<Tile> gridSearchBlackList = new HashSet<Tile>();
            private static readonly Random random = new Random();

            private Size gridSize;
            private int mines;
            private int flags;
            private bool minesGenerated;
            

            private Tile this[Point point] => (Tile)this.Controls[$"Tile_{point.X}_{point.Y}"];
            private void Tile_MouseDown(object sender, MouseEventArgs e)
            {
                Tile tile = (Tile)sender;
                if (!tile.Opened)
                {
                    
                    switch (e.Button)
                    {
                        case MouseButtons.Left when !tile.Flagged:
                            if (!this.minesGenerated)
                            {
                                this.GenerateMines(tile);
                            }
                            if (tile.Mined)
                            {
                                this.DisableTiles(true);
                            }
                            else
                            {
                                tile.TestAdjacentTiles();
                                gridSearchBlackList.Clear();
                            }
                            break;
                        case MouseButtons.Right when this.flags > 0:
                            if (tile.Flagged)
                            {
                                tile.Flagged = false;
                                this.flags--;
                            }
                            else
                            {
                                tile.Flagged = true;
                                this.flags++;
                            }
                            break;
                    }
                }
                this.CheckForWin();
                
                
            }
            internal void LoadGrid(Size gridSize, int mines)
            {
                this.minesGenerated = false;
                this.Controls.Clear();
                this.gridSize = gridSize;
                this.mines = mines;
                this.flags = mines;
                this.Size = new Size(gridSize.Width * Tile.LENGTH, gridSize.Height * Tile.LENGTH + 35);
                for(int x = 0; x < gridSize.Width; x++)
                {
                    for(int y = 0; y<gridSize.Height; y++)
                    {
                        Tile tile = new Tile(x,y);
                        tile.MouseDown += Tile_MouseDown;
                        this.Controls.Add(tile);
                    }
                }
                foreach(Tile tile in this.Controls)
                {
                    tile.SetAdjacentTiles();
                }
                
            }

            private void GenerateMines(Tile safeTile)
            {
                int safeTilesCount = safeTile.AdjacentTiles.Length +1;
                Point[] usedPositions = new Point[this.mines + safeTilesCount];
                usedPositions[0] = safeTile.GridPosition;
                for(int i = 1; i<safeTilesCount; i++)
                {
                    usedPositions[i] = safeTile.AdjacentTiles[i - 1].GridPosition;
                }
                for(int i = safeTilesCount; i < usedPositions.Length; i++)
                {
                    Point point = new Point(random.Next(this.gridSize.Width), random.Next(this.gridSize.Height));
                    if (!usedPositions.Contains(point)){
                        this[point].Mine();
                        usedPositions[i] = point;
                    }
                    else
                    {
                        i--;
                    }
                }
                this.minesGenerated = true;
            }

            private void DisableTiles(bool gameLost)
            {
                foreach(Tile tile in this.Controls)
                {
                    tile.MouseDown -= this.Tile_MouseDown;
                    if (gameLost)
                    {
                        end = true;
                        tile.Image = !tile.Opened && tile.Mined && !tile.Flagged ? Resources.MINESWEEPER_M :
                            tile.Flagged && !tile.Mined ? Resources.MINESWEEPER_tray : tile.Image;
                        
                    }

                    if (tile.Opened)
                    {
                        tile.Image = Resources.MINESWEEPER_8;
                    }
                }
            }
            private void CheckForWin()
            {
                if(this.flags != 0 && this.Controls.OfType<Tile>().Count(tile => tile.Opened || tile.Flagged) != this.gridSize.Width * this.gridSize.Height)
                {
                    
                    return;
                }
               // t.stop();
                MessageBox.Show("Gratulálok őn győzött!","Játék vége!",MessageBoxButtons.OK);
                this.DisableTiles(false);
                end = true;


            }
            private class Tile : PictureBox
            {
                internal const int LENGTH = 20;
                private static readonly int[][] adjacentCoords = {
                    new [] {-1, -1 }, new [] {0, -1 }, new [] {1, -1 }, new [] {1, 0 },
                    new [] {1, 1}, new [] { 0, 1}, new [] {-1, 1 }, new [] {-1, 0 }
                };

                private bool flagged;

                //Tile definiálása
                internal Tile(int x, int y)
                {
                    this.Name = $"Tile_{x}_{y}";
                    this.Location = new Point ( x * LENGTH, y * LENGTH );
                    this.GridPosition = new Point(x, y);
                    this.Size = new Size(LENGTH, LENGTH);
                    this.Image = Resources.Tile;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                }

                internal Tile[] AdjacentTiles { get; private set; }
                internal Point GridPosition { get; }
                internal bool Opened { get; private set; }
                internal bool Mined { get; private set; }

                internal bool Flagged
                {
                    get => this.flagged;
                    set
                    {
                        this.flagged = value;
                        this.Image = value ? Resources.MINESWEEPER_F : Resources.Tile;

                    }
                }

                private int AdjacentMines => this.AdjacentTiles.Count(tile => tile.Mined);

                internal void SetAdjacentTiles()
                {
                    TileGrid tileGrid = (TileGrid)this.Parent;
                    List<Tile> adjacentTiles = new List<Tile>(8);
                    foreach(int[] adjacentCoord in adjacentCoords)
                    {
                        Tile tile = tileGrid[new Point(this.GridPosition.X + adjacentCoord[0], this.GridPosition.Y + adjacentCoord[1])];
                        if(tile != null)
                        {
                            adjacentTiles.Add(tile);
                        }
                    }

                    this.AdjacentTiles = adjacentTiles.ToArray();
                    

                }

                internal void TestAdjacentTiles()
                {
                    if(this.flagged || gridSearchBlackList.Contains(this))
                    {
                        return;
                    }
                    gridSearchBlackList.Add(this);
                    if (this.AdjacentMines == 0)
                    {
                        foreach (Tile tile in this.AdjacentTiles)
                        {
                            
                            tile.TestAdjacentTiles();
                        }
                    }
                    this.Open();
                }

                internal void Mine()
                {
                    this.Mined = true;
                    
                }

                private void Open()
                {
                    this.Opened = true;
                    this.Image = (Image)Resources.ResourceManager.GetObject($"MINESWEEPER_{this.AdjacentMines}");
                }

                
              
            }
            
        }

        
    }
}
