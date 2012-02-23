///<summary>
///File: "TileSet.cs"
///Author: Leland Nyman (LN)
///Purpose: Displays the tile set and allows for selecting individual tiles to paint on the map
///</summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tile_Editor
{
    public partial class TileSet : Form
    {
        private CMap map = new CMap();
        private tTile[,] selectedTiles = new tTile[1, 1];
        int selectedLayer = 0;
        public string file = "PS_TestTile.png";
        public Point Start = new Point();
        public Point End = new Point();

        public int SelectedLayer
        {
            get { return selectedLayer; }
            set { selectedLayer = value; }
        }

        public tTile[,] SelectedTiles
        {
            get { return selectedTiles; }
            set { selectedTiles = value; }
        }

        public CMap Map
        {
            get { return map; }
            set { map = value; }
        }

        public Size TileSize
        {
            get { return new Size((int)HeightTNUD.Value, (int)WidthTNUD.Value); }
            set
            {
                HeightTNUD.Value = value.Height;
                WidthTNUD.Value = value.Width;
            }
        }

        public Image image
        {
            get { return panel1.BackgroundImage; }
            set { panel1.BackgroundImage = value; }
        }


        public TileSet()
        {
            InitializeComponent();

            selectedTiles[0, 0].pos = new Point(0, 0);

            Bitmap bitmap = new Bitmap("PS_TestTile.png");
            panel1.Size = new Size(bitmap.Width, bitmap.Height);
            panel1.BackgroundImage = bitmap;

        }

        /// <summary>
        /// selects the file to load in for the tile set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void loadTileSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Bitmaps|*.bmp|All Files|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string[] buffer = open.FileName.Split('\\');
                file = buffer[buffer.GetLength(0) - 1];
                LoadTexture(open.FileName);

            }
        }

        /// <summary>
        /// loads the texture to the tileset window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        public void LoadTexture(string file)
        {
            try
            {
                Bitmap bitmap = new Bitmap(file);
                panel1.Size = new Size(bitmap.Width, bitmap.Height);
                panel1.BackgroundImage = bitmap;
                map.LoadTexture(file);
                map.Render();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Texture in Wrong File", "Failed to Create Texture", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// changes the height of the tile set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void HeightTSNUD_ValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        /// <summary>
        /// changes the width of the tile set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void WidthTSNUD_ValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        /// <summary>
        /// changes the height of the individual tiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void HeightTNUD_ValueChanged(object sender, EventArgs e)
        {
                for (int layer = 0; layer < map.layerList.Count; layer++)
                {
                    map.layerList[layer].TileSize = new Size((int)WidthTNUD.Value, (int)HeightTNUD.Value);
                }
            map.Render();
            panel1.Invalidate();
        }

        /// <summary>
        /// thanges the width of the individual tiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void WidthTNUD_ValueChanged(object sender, EventArgs e)
        {
                for (int layer = 0; layer < map.layerList.Count; layer++)
                {
                    map.layerList[layer].TileSize = new Size((int)WidthTNUD.Value, (int)HeightTNUD.Value);
                }
            map.Render();
            panel1.Invalidate();
        }

        /// <summary>
        /// paints the pannel of the tile set window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.Black, 2);

            panel1.Width = panel1.BackgroundImage.Width;
            panel1.Height = panel1.BackgroundImage.Height;

            for (int line = 0; line < (int)WidthTSNUD.Value + 1; ++line)
            {
                Point origin = new Point(line * (int)WidthTNUD.Value, 0);
                Point dest = new Point(origin.X, (int)HeightTSNUD.Value * (int)HeightTNUD.Value);

                e.Graphics.DrawLine(pen, (float)origin.X, (float)origin.Y , (float)dest.X , (float)dest.Y);
            };

            for (int line = 0; line < (int)HeightTSNUD.Value + 1; ++line)
            {
                Point origin = new Point(0, line * (int)HeightTNUD.Value);
                Point dest = new Point((int)WidthTSNUD.Value * (int)WidthTNUD.Value, origin.Y);

                e.Graphics.DrawLine(pen, (float)origin.X, (float)origin.Y, (float)dest.X, (float)dest.Y);
            }

            e.Graphics.DrawRectangle(Pens.White, (float)selectedTiles[0, 0].pos.X , (float)selectedTiles[0, 0].pos.Y, (float)(TileSize.Width * selectedTiles.GetLength(0)), (float)(TileSize.Width * selectedTiles.GetLength(1)));

        }

        /// <summary>
        /// selects the tile for painting on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point clickedTile = new Point(e.X, e.Y);

                clickedTile.X /= (int)WidthTNUD.Value;
                clickedTile.Y /= (int)HeightTNUD.Value;

                for (int width = 0; width < (int)WidthTSNUD.Value; width++)
                {
                    for (int height = 0; height < HeightTSNUD.Value; height++)
                    {
                        if (clickedTile.X == width && clickedTile.Y == height)
                        {
                            tTile tile = new tTile();
                            tile.pos = new Point(clickedTile.X * (int)WidthTNUD.Value, clickedTile.Y * (int)HeightTNUD.Value);
                            selectedTiles = new tTile[1, 1];
                            selectedTiles[0, 0] = tile;
                        }
                    }
                }
                panel1.Invalidate();
            }
        }

    }
}