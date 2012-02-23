///<summary>
///File: "Form1.cs"
///Author: Leland Nyman (LN)
///Purpose: Display the current map to screen and allow for user input
///</summary>


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Tile_Editor
{
    public partial class Form1 : Form
    {
        public enum PointerMode { NORMAL, COLLSISION, CUBE, ENEMY, TURRET, SWITCH, DOOR, TRIGGER, TRAP, PLAYERSPAWN, PLAYEREND, BONUS, INV, MAGNET, MOVINGP }

        ManagedDirect3D D3D = ManagedDirect3D.Instance;
        ManagedTextureManager TM = ManagedTextureManager.Instance;
        PointerMode mode = PointerMode.NORMAL;
        TileSet tileSet = new TileSet();
        Point Start = new Point(0, 0);
        Point End = new Point(0, 0);
        Edit edit = new Edit();

        public CMap map = new CMap();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loads in all necessary information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void Form1_Load(object sender, EventArgs e)
        {
            edit.Show(this);
            tileSet.Show(this);
            D3D.InitManagedDirect3D(panel1, panel1.Width, panel1.Height, true, false);
            TM.InitManagedTextureManager(D3D.Device, D3D.Sprite);
            tileSet.Map = map;
            map.LoadTexture("PS_TestTile.png");
            map.Panel.X = panel1.Width;
            map.Panel.Y = panel1.Height;

            ListViewItem lvi = new ListViewItem();
            lvi.Text = "Layer 0";
            lvi.Tag = map.layerList[0];
            edit.LayerLV.Items.Add(lvi);


        }

        /// <summary>
        /// sets whether or not the tile set is visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tileSet.Visible = !tileSet.Visible;
            tileToolStripMenuItem.Checked = !tileToolStripMenuItem.Checked;
        }

        /// <summary>
        /// sets whether or not the edit window is visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit.Visible = !edit.Visible;
            editToolStripMenuItem.Checked = !editToolStripMenuItem.Checked;
        }

        /// <summary>
        /// paints the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            tileSet.Map = map;
            map.Render();
        }

        /// <summary>
        /// sets the pointer mode to normal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void NormalB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.NORMAL;
            NormalB.BackColor = Color.Orange;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        /// <summary>
        /// sets the pointer mode to collision rect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void CollisionB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.COLLSISION;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.Orange;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        /// <summary>
        /// sets the pointer mode to cube
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void CubeB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.CUBE;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.Orange;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        /// <summary>
        /// sets the pointer mode to enemy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void EnemyB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.ENEMY;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.Orange;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        /// <summary>
        /// sets the pointer mode to turret
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void TurretB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.TURRET;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.Orange;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        /// <summary>
        /// sets the pointer mode to switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void SwitchB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.SWITCH;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.Orange;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }


        private void DoorB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.DOOR;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.Orange;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        private void TriggerB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.TRIGGER;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.Orange;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        private void TrapB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.TRAP;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.Orange;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        private void PSpawnB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.PLAYERSPAWN;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.Orange;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        private void REndB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.PLAYEREND;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.Orange;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        /// <summary>
        /// changes the width of the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void WidthNUD_ValueChanged(object sender, EventArgs e)
        {
            if (LayerCB.Text == "All")
                return;

            Size prevSize = new Size(map.layerList[tileSet.SelectedLayer].MapSize.Width, map.layerList[tileSet.SelectedLayer].MapSize.Height);
            map.layerList[tileSet.SelectedLayer].MapSize = new Size((int)WidthNUD.Value, (int)HeightNUD.Value);
            cLayer temp = new cLayer(map.layerList[tileSet.SelectedLayer].MapSize.Width, map.layerList[tileSet.SelectedLayer].MapSize.Height);
            temp.TileSize = tileSet.TileSize;

            for (int col = 0; col < map.layerList[tileSet.SelectedLayer].MapSize.Width; ++col)
            {
                for (int row = 0; row < map.layerList[tileSet.SelectedLayer].MapSize.Height; ++row)
                {
                    if (row < prevSize.Height && col < prevSize.Width)
                    {
                        temp.tiles[col, row] = map.layerList[tileSet.SelectedLayer].tiles[col, row];
                    }
                    else
                    {
                        temp.tiles[col, row] = new tTile();
                    }
                }
            }

            map.layerList[tileSet.SelectedLayer] = temp;
            map.layerList[tileSet.SelectedLayer].visible = true;

            map.Render();
        }

        /// <summary>
        /// changes the height of the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void HeightNUD_ValueChanged(object sender, EventArgs e)
        {
            if (LayerCB.Text == "All")
                return;

            Size prevSize = new Size(map.layerList[tileSet.SelectedLayer].MapSize.Width, map.layerList[tileSet.SelectedLayer].MapSize.Height);
            map.layerList[tileSet.SelectedLayer].MapSize = new Size((int)WidthNUD.Value, (int)HeightNUD.Value);
            cLayer temp = new cLayer(map.layerList[tileSet.SelectedLayer].MapSize.Width, map.layerList[tileSet.SelectedLayer].MapSize.Height);
            temp.TileSize = tileSet.TileSize;

            for (int col = 0; col < map.layerList[tileSet.SelectedLayer].MapSize.Width; ++col)
            {
                for (int row = 0; row < map.layerList[tileSet.SelectedLayer].MapSize.Height; ++row)
                {
                    if (row < prevSize.Height && col < prevSize.Width)
                    {
                        temp.tiles[col, row] = map.layerList[tileSet.SelectedLayer].tiles[col, row];
                    }
                    else
                    {
                        temp.tiles[col, row] = new tTile();
                    }
                }
            }

            map.layerList[tileSet.SelectedLayer] = temp;
            map.layerList[tileSet.SelectedLayer].visible = true;

            map.Render();
        }

        /// <summary>
        /// changes the map based on mode and pointer position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case PointerMode.NORMAL:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedTile = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            if (tileSet.SelectedLayer != -1)
                            {
                                clickedTile.X /= (int)(map.layerList[tileSet.SelectedLayer].TileSize.Width * map.Scale);
                                clickedTile.Y /= (int)(map.layerList[tileSet.SelectedLayer].TileSize.Height * map.Scale);

                                if (clickedTile.X < map.layerList[tileSet.SelectedLayer].MapSize.Width && clickedTile.Y < map.layerList[tileSet.SelectedLayer].MapSize.Height)
                                {
                                    for (int row = 0; row < tileSet.SelectedTiles.GetLength(0); row++)
                                    {
                                        for (int col = 0; col < tileSet.SelectedTiles.GetLength(1); col++)
                                        {
                                            if (clickedTile.Y + col < map.layerList[tileSet.SelectedLayer].MapSize.Height && clickedTile.X + row < map.layerList[tileSet.SelectedLayer].MapSize.Width)
                                            {
                                                map.layerList[tileSet.SelectedLayer].tiles[clickedTile.X + row, clickedTile.Y + col] = tileSet.SelectedTiles[col, row];
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (e.Button == MouseButtons.Right && LayerCB.Text != "All")
                        {
                            Start.X = (int)(e.X + (map.WorldPos.X * map.Scale)) / (int)(map.layerList[tileSet.SelectedLayer].TileSize.Width * map.Scale);
                            Start.Y = (int)(e.Y + (map.WorldPos.Y * map.Scale)) / (int)(map.layerList[tileSet.SelectedLayer].TileSize.Height * map.Scale);
                            map.AreaFill.X = Start.X * map.layerList[tileSet.SelectedLayer].TileSize.Width;
                            map.AreaFill.Y = Start.Y * map.layerList[tileSet.SelectedLayer].TileSize.Height;
                        }
                            map.Render();
                    }
                    break;
                case PointerMode.COLLSISION:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.CollisionRects.Add(new Rectangle((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale), 0, 0));
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "CollisionRect " + (map.CollisionRects.Count - 1);
                            lvi.Tag = map.CollisionRects[map.CollisionRects.Count - 1];
                            edit.CollisionLV.Items.Add(lvi);
                        }
                    }
                    break;
                case PointerMode.MAGNET:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.MagnetRects.Add(new Rectangle((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale), 0, 0));
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "MagnetRect " + (map.MagnetRects.Count - 1);
                            lvi.Tag = map.MagnetRects[map.MagnetRects.Count - 1];
                            edit.listView4.Items.Add(lvi);
                        }
                    }
                    break;
 
                case PointerMode.CUBE:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.Cubelist.Add(new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale)));
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Cube " + (map.Cubelist.Count - 1);
                            lvi.Tag = map.Cubelist[map.Cubelist.Count - 1];
                            edit.CubeLV.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.ENEMY:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.EnemyList.Add(new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale)));
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Enemy " + (map.EnemyList.Count - 1);
                            lvi.Tag = map.EnemyList[map.EnemyList.Count - 1];
                            edit.EnemyLV.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.TURRET:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.TuretList.Add(new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale)));
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Turret " + (map.TuretList.Count - 1);
                            lvi.Tag = map.TuretList[map.TuretList.Count - 1];
                            edit.TurretLV.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.SWITCH:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            tSwitch swtch = new tSwitch();
                            swtch.pos = new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale));
                            map.SwitchList.Add(swtch);
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Switch " + (map.SwitchList.Count - 1);
                            lvi.Tag = map.SwitchList[map.SwitchList.Count - 1];
                            edit.SwitchLV.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.DOOR:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            tDoor door = new tDoor();
                            door.pos = new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale));
                            map.DoorList.Add(door);
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Door " + (map.DoorList.Count - 1);
                            lvi.Tag = map.DoorList[map.DoorList.Count - 1];
                            edit.listView1.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.TRIGGER:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            tTrigger trigger = new tTrigger();
                            trigger.pos = new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale));
                            map.TriggerList.Add(trigger);
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Trigger " + (map.TriggerList.Count - 1);
                            lvi.Tag = map.TriggerList[map.TriggerList.Count - 1];
                            edit.listView2.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.TRAP:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            tTrap trap = new tTrap();
                            trap.pos = new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale));
                            map.TrapList.Add(trap);
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Trap " + (map.TrapList.Count - 1);
                            lvi.Tag = map.TrapList[map.TrapList.Count - 1];
                            edit.listView3.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.PLAYERSPAWN:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.PlayerSpawn = new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale));
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.PLAYEREND:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.PlayerEnd = new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale));
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.BONUS:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.BonusList.Add(new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale)));
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Bonus " + (map.BonusList.Count - 1);
                            lvi.Tag = map.BonusList[map.BonusList.Count - 1];
                            edit.listView5.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.INV:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.InvList.Add(new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale)));
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "Inv " + (map.InvList.Count - 1);
                            lvi.Tag = map.InvList[map.InvList.Count - 1];
                            edit.listView6.Items.Add(lvi);
                            map.Render();
                        }
                    }
                    break;
                case PointerMode.MOVINGP:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            map.MPList.Add(new Point((int)(clickedSpot.X / map.Scale), (int)(clickedSpot.Y / map.Scale)));
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "MP " + (map.MPList.Count - 1);
                            lvi.Tag = map.MPList[map.MPList.Count - 1];
                            edit.listView7.Items.Add(lvi);
                            map.Render();
                        }
                    }
 
                    break;
            }
        }

        /// <summary>
        /// changes whether or not the grid is rendered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void GridCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Grid = !map.Grid;
            map.Render();
        }

        /// <summary>
        /// changes whether or not the clooision rects are rendered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void CollisionCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Collision = !map.Collision;
            map.Render();
        }

        /// <summary>
        /// changes whether or not the cubes are rendered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void CubeCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Cube = !map.Cube;
            map.Render();
        }

        /// <summary>
        /// changes whether or not the enemies are rendered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void EnemyCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Enemy = !map.Enemy;
            map.Render();
        }

        /// <summary>
        /// changes whether or not the turrets are rendered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void TurretCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Turret = !map.Turret;
            map.Render();
        }

        /// <summary>
        /// changes whether or not the switch are rendered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void SwitchCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Switch = !map.Switch;
            map.Render();
        }
 
        /// <summary>
        /// changes the map based on mode and position of the mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case PointerMode.NORMAL:
                    {
                        if (e.Button == MouseButtons.Left && e.Location.X > 0 && e.Location.Y > 0 && LayerCB.Text != "All")
                        {
                            Point clickedTile = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));
                                clickedTile.X /= (int)(map.layerList[tileSet.SelectedLayer].TileSize.Width * map.Scale);
                                clickedTile.Y /= (int)(map.layerList[tileSet.SelectedLayer].TileSize.Height * map.Scale);

                                if (clickedTile.X < map.layerList[tileSet.SelectedLayer].MapSize.Width && clickedTile.Y < map.layerList[tileSet.SelectedLayer].MapSize.Height)
                                {
                                    for (int row = 0; row < tileSet.SelectedTiles.GetLength(0); row++)
                                    {
                                        for (int col = 0; col < tileSet.SelectedTiles.GetLength(1); col++)
                                        {
                                            if (clickedTile.Y + col < map.layerList[tileSet.SelectedLayer].MapSize.Height && clickedTile.X + row < map.layerList[tileSet.SelectedLayer].MapSize.Width)
                                            {
                                                map.layerList[tileSet.SelectedLayer].tiles[clickedTile.X + row, clickedTile.Y + col] = tileSet.SelectedTiles[col, row];
                                            }
                                        }
                                    }
                                }
                        }
                        else if (e.Button == MouseButtons.Right && LayerCB.Text != "All")
                        {
                                End.X = (int)(e.X + (map.WorldPos.X * map.Scale)) / (int)(map.layerList[tileSet.SelectedLayer].TileSize.Width * map.Scale);
                                End.Y = (int)(e.Y + (map.WorldPos.Y * map.Scale)) / (int)(map.layerList[tileSet.SelectedLayer].TileSize.Height * map.Scale);
                                map.AreaFill.Width = ((End.X - Start.X) * map.layerList[tileSet.SelectedLayer].TileSize.Width) + map.layerList[tileSet.SelectedLayer].TileSize.Width;
                                map.AreaFill.Height = ((End.Y - Start.Y) * map.layerList[tileSet.SelectedLayer].TileSize.Height) + map.layerList[tileSet.SelectedLayer].TileSize.Height;
                        }

                        map.Render();
                    }
                    break;
                case PointerMode.COLLSISION:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            if (clickedSpot.X < map.layerList[tileSet.SelectedLayer].MapSize.Width * (int)(map.layerList[tileSet.SelectedLayer].TileSize.Width * map.Scale) && clickedSpot.Y < map.layerList[tileSet.SelectedLayer].MapSize.Height * (int)(map.layerList[tileSet.SelectedLayer].TileSize.Height * map.Scale))
                            {
                                if (map.CollisionRects.Count != 0)
                                {
                                    Rectangle rect = new Rectangle(map.CollisionRects[map.CollisionRects.Count - 1].Location, new Size((int)(clickedSpot.X / map.Scale) - map.CollisionRects[map.CollisionRects.Count - 1].X, (int)(clickedSpot.Y / map.Scale) - map.CollisionRects[map.CollisionRects.Count - 1].Y));
                                    map.CollisionRects[map.CollisionRects.Count - 1] = rect;
                                }
                            }
                        }
                        map.Render();
                    }
                    break;
                case PointerMode.MAGNET:
                    {
                        if (e.Button == MouseButtons.Left && LayerCB.Text != "All")
                        {
                            Point clickedSpot = new Point((int)(e.X + (map.WorldPos.X * map.Scale)), (int)(e.Y + (map.WorldPos.Y * map.Scale)));

                            if (clickedSpot.X < map.layerList[tileSet.SelectedLayer].MapSize.Width * (int)(map.layerList[tileSet.SelectedLayer].TileSize.Width * map.Scale) && clickedSpot.Y < map.layerList[tileSet.SelectedLayer].MapSize.Height * (int)(map.layerList[tileSet.SelectedLayer].TileSize.Height * map.Scale))
                            {
                                if (map.MagnetRects.Count != 0)
                                {
                                    Rectangle rect = new Rectangle(map.MagnetRects[map.MagnetRects.Count - 1].Location, new Size((int)(clickedSpot.X / map.Scale) - map.MagnetRects[map.MagnetRects.Count - 1].X, (int)(clickedSpot.Y / map.Scale) - map.MagnetRects[map.MagnetRects.Count - 1].Y));
                                    map.MagnetRects[map.MagnetRects.Count - 1] = rect;
                                }
                            }
                        }
                        map.Render();
                    }
                    break;

            }
        }

        /// <summary>
        /// changes the map based on mode and position of the mouse in the up position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case PointerMode.NORMAL:
                    {
                        if (e.Button == MouseButtons.Right && LayerCB.Text != "All")
                        {
                            End.X = (int)(e.X + (map.WorldPos.X * map.Scale)) / (int)(map.layerList[tileSet.SelectedLayer].TileSize.Width * map.Scale);
                            End.Y = (int)(e.Y + (map.WorldPos.Y * map.Scale)) / (int)(map.layerList[tileSet.SelectedLayer].TileSize.Height * map.Scale);

                            int X = (int)(e.X + (map.WorldPos.X * map.Scale)) % (int)(map.layerList[tileSet.SelectedLayer].TileSize.Width * map.Scale);
                            int Y = (int)(e.Y + (map.WorldPos.Y * map.Scale)) % (int)(map.layerList[tileSet.SelectedLayer].TileSize.Height * map.Scale);

                            if (X > 0)
                            {
                                End.X++;
                            }

                            if (Y > 0)
                            {
                                End.Y++;
                            }

                            for (int row = Start.Y; row < End.Y; row += tileSet.SelectedTiles.GetLength(1))
                            {
                                for (int col = Start.X; col < End.X; col += tileSet.SelectedTiles.GetLength(0))
                                {
                                    for (int row2 = 0; row2 < tileSet.SelectedTiles.GetLength(0); row2++)
                                    {
                                        for (int col2 = 0; col2 < tileSet.SelectedTiles.GetLength(1); col2++)
                                        {
                                            if (row + col2 < map.layerList[tileSet.SelectedLayer].MapSize.Height && row + col2 < End.Y && col + row2 < map.layerList[tileSet.SelectedLayer].MapSize.Width && col + row2 < End.X)
                                            {
                                                map.layerList[tileSet.SelectedLayer].tiles[col + row2, row + col2] = tileSet.SelectedTiles[col2, row2];
                                            }
                                        }
                                    }
                                }
                            }
                            map.AreaFill = Rectangle.Empty;
                        }
                        map.Render();
                    }
                    break;
            }

        }
        /// <summary>
        /// Adds a layer to the current map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void AddB_Click(object sender, EventArgs e)
        {
            map.AddLayer(new Size((int)WidthNUD.Value, (int)HeightNUD.Value));
            LayerCB.Items.Insert(LayerCB.Items.Count - 1, int.Parse(map.layerList.Count.ToString()) - 1);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "Layer " + (map.layerList.Count - 1);
            lvi.Tag = map.layerList[map.layerList.Count - 1];
            edit.LayerLV.Items.Add(lvi);
            LayerCB_SelectedIndexChanged(sender, e);
        }
        /// <summary>
        /// selects the current layer to be edited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void LayerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LayerCB.Text == "All")
            {
                tileSet.SelectedLayer = -1;
                for (int i = 0; i < map.layerList.Count; i++)
                {
                    map.layerList[i].visible = true;
                }
            }
            else if (LayerCB.Text != "All")
            {
                for (int i = 0; i < map.layerList.Count; i++)
                {
                    map.layerList[i].visible = false;
                }
                tileSet.SelectedLayer = int.Parse(LayerCB.Text);
                map.layerList[tileSet.SelectedLayer].visible = true;

                tileSet.TileSize = map.layerList[tileSet.SelectedLayer].TileSize;
                WidthNUD.Value = map.layerList[tileSet.SelectedLayer].MapSize.Width;
                HeightNUD.Value = map.layerList[tileSet.SelectedLayer].MapSize.Height;
            }

            map.Render();

        }

        /// <summary>
        /// changes the virtical position of the map on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            map.WorldPos.Y -= (e.OldValue - e.NewValue) * 10;
            map.Render();
        }

        /// <summary>
        /// changes the horisontal position of the map on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            map.WorldPos.X -= (e.OldValue - e.NewValue) * 10;
            map.Render();
        }

        /// <summary>
        /// renders the map at .5 times scale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            map.Scale = 0.5f;
            map.Render();
        }

        /// <summary>
        /// renders the map at 1.0 times scale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            map.Scale = 1.0f;
            map.Render();
        }

        /// <summary>
        /// renders the map 1.5 times scale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            map.Scale = 1.5f;
            map.Render();
        }

        /// <summary>
        /// renders the map at 2.0 scale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            map.Scale = 2.0f;
            map.Render();
        }

        /// <summary>
        /// saves the map out in binary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void saveAsBianaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bianary Map File|*.bmf|All Files|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter write = new BinaryWriter(File.Open(save.FileName, FileMode.Create, FileAccess.Write));

                write.Write(tileSet.file);

                write.Write(map.layerList.Count);

                for (int i = 0; i < map.layerList.Count; i++)
                {
                    write.Write(map.layerList[i].MapSize.Width);
                    write.Write(map.layerList[i].MapSize.Height);
                    write.Write(map.layerList[i].TileSize.Width);
                    write.Write(map.layerList[i].TileSize.Height);
                    for (int col = 0; col < map.layerList[i].MapSize.Width; col++)
                    {
                        for (int row = 0; row < map.layerList[i].MapSize.Height; row++)
                        {
                            write.Write(map.layerList[i].tiles[col, row].pos.X);
                            write.Write(map.layerList[i].tiles[col, row].pos.Y);
                        }
                    }
                }

                write.Write(map.CollisionRects.Count);
                for (int i = 0; i < map.CollisionRects.Count; i++)
			    {
                    write.Write(map.CollisionRects[i].X);
                    write.Write(map.CollisionRects[i].Y);
                    write.Write(map.CollisionRects[i].Width);
                    write.Write(map.CollisionRects[i].Height);
			    }

                write.Write(map.Cubelist.Count);
                for (int i = 0; i < map.Cubelist.Count; i++)
                {
                    write.Write(map.Cubelist[i].X);
                    write.Write(map.Cubelist[i].Y);
                }

                write.Write(map.EnemyList.Count);
                for (int i = 0; i < map.EnemyList.Count; i++)
                {
                    write.Write(map.EnemyList[i].X);
                    write.Write(map.EnemyList[i].Y);
                }

                write.Write(map.TuretList.Count);
                for (int i = 0; i < map.TuretList.Count; i++)
                {
                    write.Write(map.TuretList[i].X);
                    write.Write(map.TuretList[i].Y);
                }

                write.Write(map.SwitchList.Count);
                for (int i = 0; i < map.SwitchList.Count; i++)
                {
                    write.Write(map.SwitchList[i].pos.X);
                    write.Write(map.SwitchList[i].pos.Y);
                }

                write.Write(map.DoorList.Count);
                for (int i = 0; i < map.DoorList.Count; i++)
                {
                    write.Write(map.DoorList[i].pos.X);
                    write.Write(map.DoorList[i].pos.Y);
                }

                write.Write(map.TriggerList.Count);
                for (int i = 0; i < map.TriggerList.Count; i++)
                {
                    write.Write(map.TriggerList[i].pos.X);
                    write.Write(map.TriggerList[i].pos.Y);
                }

                write.Write(map.TrapList.Count);
                for (int i = 0; i < map.TrapList.Count; i++)
                {
                    write.Write(map.TrapList[i].pos.X);
                    write.Write(map.TrapList[i].pos.Y);
                }

                write.Write(map.PlayerSpawn.X);
                write.Write(map.PlayerSpawn.Y);

                write.Write(map.PlayerEnd.X);
                write.Write(map.PlayerEnd.Y);

                write.Write(map.MagnetRects.Count);
                for (int i = 0; i < map.MagnetRects.Count; i++)
                {
                    write.Write(map.MagnetRects[i].X);
                    write.Write(map.MagnetRects[i].Y);
                    write.Write(map.MagnetRects[i].Width);
                    write.Write(map.MagnetRects[i].Height);
                }
                write.Write(map.BonusList.Count);
                for (int i = 0; i < map.BonusList.Count; i++)
                {
                    write.Write(map.BonusList[i].X);
                    write.Write(map.BonusList[i].Y);
                }

                write.Write(map.InvList.Count);
                for (int i = 0; i < map.InvList.Count; i++)
                {
                    write.Write(map.InvList[i].X);
                    write.Write(map.InvList[i].Y);
                }

                write.Write(map.MPList.Count);
                for (int i = 0; i < map.MPList.Count; i++)
                {
                    write.Write(map.MPList[i].X);
                    write.Write(map.MPList[i].Y);
                }
                write.Close();
            }
        }

        /// <summary>
        /// loads in the map in binary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void loadBianaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bianary Map File|*.bmf";

            if (open.ShowDialog() == DialogResult.OK)
            {
                LayerCB.Items.Clear();
                LayerCB.Items.Add("All");
                map.layerList.Clear();
                map.CollisionRects.Clear();
                map.Cubelist.Clear();
                map.EnemyList.Clear();
                map.TuretList.Clear();
                map.SwitchList.Clear();
                map.DoorList.Clear();
                map.TriggerList.Clear();
                map.TrapList.Clear();
                map.MagnetRects.Clear();
                map.BonusList.Clear();
                map.InvList.Clear();
                edit.LayerLV.Items.Clear();
                edit.CollisionLV.Items.Clear();
                edit.CubeLV.Items.Clear();
                edit.EnemyLV.Items.Clear();
                edit.TurretLV.Items.Clear();
                edit.SwitchLV.Items.Clear();
                edit.listView1.Items.Clear();
                edit.listView2.Items.Clear();
                edit.listView3.Items.Clear();
                edit.listView4.Items.Clear();
                edit.listView5.Items.Clear();
                edit.listView6.Items.Clear();

                BinaryReader read = new BinaryReader(File.Open(open.FileName, FileMode.Open, FileAccess.Read));

                string fName = read.ReadString();
                tileSet.file = fName;
                tileSet.LoadTexture(fName);
                map.layerList = new List<cLayer>();
                int layers = read.ReadInt32();

                for (int i = 0; i < layers; i++)
                {
                    map.layerList.Add(new cLayer(read.ReadInt32(), read.ReadInt32()));
                    map.layerList[i].TileSize = new Size(read.ReadInt32(), read.ReadInt32());

                    for (int col = 0; col < map.layerList[i].MapSize.Width; col++)
                    {
                        for (int row = 0; row < map.layerList[i].MapSize.Height; row++)
                        {
                            map.layerList[i].tiles[col, row].pos.X = read.ReadInt32();
                            map.layerList[i].tiles[col, row].pos.Y = read.ReadInt32();
                            map.layerList[i].visible = true;
                        }
                    }
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Layer " + i;
                    lvi.Tag = map.layerList[map.layerList.Count - 1];
                    edit.LayerLV.Items.Add(lvi);

                    LayerCB.Items.Insert(LayerCB.Items.Count - 1, map.layerList.Count - 1);
                    LayerCB.Text = "All";

                }

                int collision = read.ReadInt32();

                for (int i = 0; i < collision; i++)
                {
                    map.CollisionRects.Add(new Rectangle(read.ReadInt32(), read.ReadInt32(), read.ReadInt32(), read.ReadInt32()));
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Collision " + i;
                    lvi.Tag = map.CollisionRects[map.CollisionRects.Count - 1];
                    edit.CollisionLV.Items.Add(lvi);
                }
                int cube = read.ReadInt32();

                for (int i = 0; i < cube; i++)
                {
                    map.Cubelist.Add(new Point(read.ReadInt32(),read.ReadInt32()));
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Cube " + i;
                    lvi.Tag = map.Cubelist[map.Cubelist.Count - 1];
                    edit.CubeLV.Items.Add(lvi);
                }

                int enemy = read.ReadInt32();

                for (int i = 0; i < enemy; i++)
                {
                    map.EnemyList.Add(new Point(read.ReadInt32(),read.ReadInt32()));
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Enemy " + i;
                    lvi.Tag = map.EnemyList[map.EnemyList.Count - 1];
                    edit.EnemyLV.Items.Add(lvi);
                }

                int turret = read.ReadInt32();

                for (int i = 0; i < turret; i++)
                {
                    map.TuretList.Add(new Point(read.ReadInt32(),read.ReadInt32()));
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Turret " + i;
                    lvi.Tag = map.TuretList[map.TuretList.Count - 1];
                    edit.TurretLV.Items.Add(lvi);
                }

                int switchL = read.ReadInt32();

                for (int i = 0; i < switchL; i++)
                {
                    tSwitch tempSwitch = new tSwitch();
                    tempSwitch.pos = new Point(read.ReadInt32(),read.ReadInt32());
                    map.SwitchList.Add(tempSwitch);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Switch " + i;
                    lvi.Tag = map.SwitchList[map.SwitchList.Count - 1];
                    edit.SwitchLV.Items.Add(lvi);
                }

                int door = read.ReadInt32();

                for (int i = 0; i < door; i++)
                {
                    tDoor tempDoor = new tDoor();
                    tempDoor.pos = new Point(read.ReadInt32(), read.ReadInt32());
                    map.DoorList.Add(tempDoor);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Door " + i;
                    lvi.Tag = map.DoorList[map.DoorList.Count - 1];
                    edit.listView1.Items.Add(lvi);
                }

                int trigger = read.ReadInt32();

                for (int i = 0; i < trigger; i++)
                {
                    tTrigger tempTrigger = new tTrigger();
                    tempTrigger.pos = new Point(read.ReadInt32(), read.ReadInt32());
                    map.TriggerList.Add(tempTrigger);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Trigger " + i;
                    lvi.Tag = map.TriggerList[map.TriggerList.Count - 1];
                    edit.listView2.Items.Add(lvi);
                }

                int trap = read.ReadInt32();

                for (int i = 0; i < trap; i++)
                {
                    tTrap tempTrap = new tTrap();
                    tempTrap.pos = new Point(read.ReadInt32(), read.ReadInt32());
                    map.TrapList.Add(tempTrap);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Trap " + i;
                    lvi.Tag = map.TrapList[map.TrapList.Count - 1];
                    edit.listView3.Items.Add(lvi);
                }

                map.PlayerSpawn.X = read.ReadInt32();
                map.PlayerSpawn.Y = read.ReadInt32();

                map.PlayerEnd.X = read.ReadInt32();
                map.PlayerEnd.Y = read.ReadInt32();

                int magnet = read.ReadInt32();

                for (int i = 0; i < magnet; i++)
                {
                    map.MagnetRects.Add(new Rectangle(read.ReadInt32(), read.ReadInt32(), read.ReadInt32(), read.ReadInt32()));
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Magnet " + i;
                    lvi.Tag = map.MagnetRects[map.MagnetRects.Count - 1];
                    edit.listView4.Items.Add(lvi);
                }

                int bonus = read.ReadInt32();

                for (int i = 0; i < bonus; i++)
                {
                    map.BonusList.Add(new Point(read.ReadInt32(), read.ReadInt32()));
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Bonus " + i;
                    lvi.Tag = map.BonusList[map.BonusList.Count - 1];
                    edit.listView5.Items.Add(lvi);
                }

                int inv = read.ReadInt32();

                for (int i = 0; i < inv; i++)
                {
                    map.InvList.Add(new Point(read.ReadInt32(), read.ReadInt32()));
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "Inv " + i;
                    lvi.Tag = map.InvList[map.InvList.Count - 1];
                    edit.listView6.Items.Add(lvi);
                }

                int MP = read.ReadInt32();

                for (int i = 0; i < MP; i++)
                {
                    map.MPList.Add(new Point(read.ReadInt32(), read.ReadInt32()));
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "MP " + i;
                    lvi.Tag = map.MPList[map.MPList.Count - 1];
                    edit.listView7.Items.Add(lvi);
                }
            }
        }

        /// <summary>
        /// saves the map in XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void saveAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "XML Map File|*.xmf|All Files|*.*";
            
            if (save.ShowDialog() == DialogResult.OK)
            {
              
                StreamWriter write = new StreamWriter(save.FileName);
                //SerializeStuff serializeStuff = new SerializeStuff();
                //XmlSerializer serialize = new XmlSerializer(typeof(List<cLayer>));
                //foreach(cLayer s in map.layerList)
                //{
                   
                //    serialize.Serialize(write, s);
                //}
                XmlSerializer serialize2 = new XmlSerializer(typeof(CMap));
                   
                //foreach (Rectangle s in map.CollisionRects)
                //{
                //    serialize2.Serialize(write, s);
                //}

                //foreach (Point s in map.Cubelist)
                //{
                //    XmlSerializer serialize3 = new XmlSerializer(typeof(List<Point>));
                //    serialize3.Serialize(write, s);
                //}

                //foreach (Point s in map.EnemyList)
                //{
                //    XmlSerializer serialize4 = new XmlSerializer(typeof(List<Point>));
                //    serialize4.Serialize(write, s);
                //}

                //foreach (Point s in map.TuretList)
                //{
                //    XmlSerializer serialize5 = new XmlSerializer(typeof(List<Point>));
                //    serialize5.Serialize(write, s);
                //}

                //foreach (tSwitch s in map.SwitchList)
                //{
                //    XmlSerializer serialize6 = new XmlSerializer(typeof(List<tSwitch>));
                //    serialize6.Serialize(write, s);
                //}
                serialize2.Serialize(write, map);
                //serializeStuff.serializeLayer = map.layerList;
                //serializeStuff.serializeCollision = map.CollisionRects;
                //serializeStuff.serializeCube = map.Cubelist;
                //serializeStuff.serializeEnemy = map.EnemyList;
               // serializeStuff.serializeTurret = map.TuretList;
                //serializeStuff.serializeSwitch = map.SwitchList;

                write.Close();
               
                    

            }

        }

        /// <summary>
        /// loads the map in XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML Map File|*.xmf|All Files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                FileStream read = new FileStream(open.FileName, FileMode.Open);
                XmlSerializer Serialized = new XmlSerializer(typeof(SerializeStuff));
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayerCB.Items.Clear();
            LayerCB.Items.Add("0");
            LayerCB.Items.Add("All");
            LayerCB.Text = "0";
            map.layerList.Clear();
            map.CollisionRects.Clear();
            map.Cubelist.Clear();
            map.EnemyList.Clear();
            map.TuretList.Clear();
            map.SwitchList.Clear();
            edit.LayerLV.Items.Clear();
            edit.CollisionLV.Items.Clear();
            edit.CubeLV.Items.Clear();
            edit.EnemyLV.Items.Clear();
            edit.TurretLV.Items.Clear();
            edit.SwitchLV.Items.Clear();
            map.AddLayer(new Size((int)MapInfo.Width, (int)MapInfo.Height));
            map.layerList[0].visible = true;
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "Layer 0";
            lvi.Tag = map.layerList[0];
            edit.LayerLV.Items.Add(lvi);
            map.Render();
        }

        private void DoorCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Door = !map.Door;
            map.Render();
        }

        private void TriggerCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Trigger = !map.Trigger;
            map.Render();
        }

        private void TrapCB_CheckedChanged(object sender, EventArgs e)
        {
            map.Trap = !map.Trap;
            map.Render();
        }

        private void PSpawnCB_CheckedChanged(object sender, EventArgs e)
        {
            map.PlayerSpawnRender = !map.PlayerSpawnRender;
            map.Render();
        }

        private void PEndCB_CheckedChanged(object sender, EventArgs e)
        {
            map.PlayerEndRender = !map.PlayerEndRender;
            map.Render();
        }

        private void BonusB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.BONUS;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.Orange;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;

        }

        private void InvB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.INV;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.Orange;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;

        }

        private void MagnetB_Click(object sender, EventArgs e)
        {
            mode = PointerMode.MAGNET;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.White;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            map.Bonus = !map.Bonus;
            map.Render();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            map.Inv = !map.Inv;
            map.Render();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            map.Magnet = !map.Magnet;
            map.Render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = PointerMode.MOVINGP;
            NormalB.BackColor = Color.White;
            CollisionB.BackColor = Color.White;
            CubeB.BackColor = Color.White;
            EnemyB.BackColor = Color.White;
            TurretB.BackColor = Color.White;
            SwitchB.BackColor = Color.White;
            DoorB.BackColor = Color.White;
            TriggerB.BackColor = Color.White;
            TrapB.BackColor = Color.White;
            PSpawnB.BackColor = Color.White;
            PEndB.BackColor = Color.White;
            BonusB.BackColor = Color.White;
            InvB.BackColor = Color.White;
            MagnetB.BackColor = Color.White;
            button1.BackColor = Color.Orange;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            map.MovingP = !map.MovingP;
            map.Render();
        }

    }
}