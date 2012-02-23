///<summary>
///File: "CMap.cs"
///Author: Leland Nyman (LN)
///Purpose: Used for storing and rendering the map information
///</summary>
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tile_Editor
{
    public enum MapInfo { Width = 32, Height = 19 };
    public enum TileInfo { Width = 32, Height = 32 };

    public struct SerializeStuff
    {
        
        public List<cLayer> serializeLayer;
        public List<Rectangle> serializeCollision;
        public List<Point> serializeCube;
        public List<Point> serializeEnemy;
        public List<Point> serializeTurret;
        public List<tSwitch> serializeSwitch;
         
    }
    public struct tTile
    {
        public Point pos;
    };
    public struct tDoor
    {
        public Point pos;
    };
    public struct tSwitch
    {
        public Point pos;
        public tDoor door;
    };
    public struct tTrigger
    {
        public Point pos;
        public tTrap trap;
    };
    public struct tTrap
    {
        public Point pos;
    };
    public class cLayer
    {
        public tTile[,] tiles;
        Size mapSize = new Size((int)MapInfo.Width, (int)MapInfo.Height);
        Size tileSize = new Size((int)TileInfo.Width, (int)TileInfo.Height);
        public bool visible = false;

        public Size MapSize
        {
            get { return mapSize; }
            set { mapSize = value; }
        }

        public Size TileSize
        {
            get { return tileSize; }
            set { tileSize = value; }
        }
        public cLayer(int mapWidth, int mapHeight)
        {
            tiles = new tTile[mapWidth, mapHeight];
            mapSize = new Size(mapWidth, mapHeight);
            for (int cols = 0; cols < mapWidth; cols++)
            {
                for (int rows = 0; rows < mapHeight; rows++)
                {
                    tiles[cols, rows].pos.X = 0;
                    tiles[cols, rows].pos.Y = 0;
                }
            }
        }
    };
    public class CMap
    {
        ManagedDirect3D D3D = ManagedDirect3D.Instance;
        ManagedTextureManager TM = ManagedTextureManager.Instance;
        public Point WorldPos = new Point(0, 0);
        int imageID;
        public int colorKey = Color.White.ToArgb();
        public List<cLayer> layerList = new List<cLayer>();
        public List<Rectangle> CollisionRects = new List<Rectangle>();
        public List<Rectangle> MagnetRects = new List<Rectangle>();
        public List<Point> Cubelist = new List<Point>();
        public List<Point> EnemyList = new List<Point>();
        public List<Point> TuretList = new List<Point>();
        public List<tSwitch> SwitchList = new List<tSwitch>();
        public List<tDoor> DoorList = new List<tDoor>();
        public List<tTrigger> TriggerList = new List<tTrigger>();
        public List<tTrap> TrapList = new List<tTrap>();
        public List<Point> BonusList = new List<Point>();
        public List<Point> InvList = new List<Point>();
        public List<Point> MPList = new List<Point>();
        public Point PlayerSpawn =  new Point();
        public Point PlayerEnd = new Point();
        public int SelectedRect = -1;
        public int SelectedMagnet = -1;
        public int SelectedCube = -1;
        public int SelectedEnemy = -1;
        public int SelectedTurret = -1;
        public int SelectedSwitich = -1;
        public int SelectedDoor = -1;
        public int SelectedTrigger = -1;
        public int SelectedTrap = -1;
        public int SelectedBonus = -1;
        public int SelectedInv = -1;
        public int SelectedMP = -1;
        public bool Grid = true;
        public bool Collision = true;
        public bool Cube = true;
        public bool Enemy = true;
        public bool Turret = true;
        public bool Switch = true;
        public bool Door = true;
        public bool Trigger = true;
        public bool Trap = true;
        public bool Bonus = true;
        public bool Inv = true;
        public bool Magnet = true;
        public bool MovingP = true;
        public bool PlayerSpawnRender = true;
        public bool PlayerEndRender = true;
        public float Scale = 1;
        public Rectangle AreaFill = new Rectangle(0, 0, 0, 0);
        public Point Panel = new Point(0, 0);

        public CMap()
        {
            AddLayer(new Size((int)MapInfo.Width,(int)MapInfo.Height));
            layerList[0].visible = true;
        }

        public void AddLayer(Size MapSize)
        {
            layerList.Add(new cLayer(MapSize.Width,MapSize.Height));
        }

        public void LoadTexture(string file)
        {
            imageID = TM.LoadTexture(file, colorKey);
        }

        /// <summary>
        /// Renders all information associated with the map
        /// </summary>
        /// <returns>void</returns>
        public void Render()
        {
            D3D.DeviceBegin();
            D3D.SpriteBegin();
            D3D.Clear(0, 0, 0);
            RenderLayers();
            D3D.SpriteEnd();
            D3D.DeviceEnd();

            D3D.LineBegin();

            if (Grid == true)
            {
                RenderGrid();
            }
            if (Collision == true)
            {
                RenderCollision();
            }
            if (Magnet == true)
            {
                RenderMagnet();
            }
            if (Cube == true)
            {
                RenderCube();
            }
            if (Enemy == true)
            {
                RenderEnemy();
            }
            if (Turret == true)
            {
                RenderTurret();
            }
            if (Switch == true)
            {
                RenderSwitch();
            }
            if (Door == true)
            {
                RenderDoor();
            }
            if (Trigger == true)
            {
                RenderTrigger();
            }
            if (Trap == true)
            {
                RenderTrap();
            }
            if (Bonus == true)
            {
                RenderBonus();
            }
            if (Inv == true)
            {
                RenderInv();
            }
            if (MovingP == true)
            {
                RenderMovingP();
            }
            if (PlayerSpawnRender == true)
            {
                RenderPlayerSpawn();
            }
            if (PlayerEndRender == true)
            {
                RenderPlayerEnd();
            }
            RenderAreaFill();
            D3D.LineEnd();
            D3D.Present();
        }

        /// <summary>
        /// Renders the maps layers
        /// </summary>
        /// <returns>void</returns>
        private void RenderLayers()
        {
            for (int layer = 0; layer < layerList.Count; layer++)
            {
                Point Start = new Point((int)(WorldPos.X * Scale) / (int)(layerList[layer].TileSize.Width * Scale), (int)(WorldPos.Y * Scale) / (int)(layerList[layer].TileSize.Height * Scale));
                Point End = new Point((int)(((WorldPos.X * Scale) + Panel.X)) / (int)(layerList[layer].TileSize.Width * Scale), (int)(((WorldPos.Y * Scale) + Panel.Y)) / (int)(layerList[layer].TileSize.Height * Scale));
                End.X++;
                End.Y++;
                if (End.X > layerList[layer].MapSize.Width)
                {
                    End.X = layerList[layer].MapSize.Width;
                }
                if (End.Y > layerList[layer].MapSize.Height)
                {
                    End.Y = layerList[layer].MapSize.Height;
                }
                Rectangle section = new Rectangle(0, 0, layerList[layer].TileSize.Width, layerList[layer].TileSize.Height);
                for (int col = Start.X; col < End.X; col++)
                {
                    for (int row = Start.Y; row < End.Y; row++)
                    {
                        if (layerList[layer].visible == true)
                        {
                            section.X = layerList[layer].tiles[col, row].pos.X;
                            section.Y = layerList[layer].tiles[col, row].pos.Y;
                            TM.Draw(imageID, (int)(((col * layerList[layer].TileSize.Width) - WorldPos.X) * Scale), (int)(((row * layerList[layer].TileSize.Height) - WorldPos.Y) * Scale), Scale, Scale, section, 0, 0, 0, Color.White.ToArgb());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Renders the grid
        /// </summary>
        /// <returns>void</returns>
        private void RenderGrid()
        {
            for (int layer = 0; layer < layerList.Count; layer++)
            {
                for (int vLines = 0; vLines < layerList[layer].MapSize.Width+1; vLines++)
                {
                    if (layerList[layer].visible == true)
                    {
                        Point origin = new Point(vLines * layerList[layer].TileSize.Width, 0);
                        Point dest = new Point(origin.X, layerList[layer].MapSize.Height * layerList[layer].TileSize.Height);
                        D3D.DrawLine((int)((origin.X - WorldPos.X) * Scale), (int)((origin.Y - WorldPos.Y) * Scale), (int)((dest.X - WorldPos.X) * Scale), (int)((dest.Y - WorldPos.Y) * Scale), 128, 128, 128);
                    }
                }
                for (int hLines = 0; hLines < layerList[layer].MapSize.Height+1; hLines++)
                {
                    if (layerList[layer].visible == true)
                    {
                        Point origin = new Point(0, hLines * layerList[layer].TileSize.Height);
                        Point dest = new Point(layerList[layer].MapSize.Width * layerList[layer].TileSize.Width, origin.Y);

                        D3D.DrawLine((int)((origin.X - WorldPos.X) * Scale), (int)((origin.Y - WorldPos.Y) * Scale), (int)((dest.X - WorldPos.X) * Scale), (int)((dest.Y - WorldPos.Y) * Scale), 128, 128, 128);
                    }
                }
            }
        }

        /// <summary>
        /// renders the collision rects on the map
        /// </summary>
        /// <returns>void</returns>
        private void RenderCollision()
        {
            for (int index = 0; index < CollisionRects.Count; index++)
            {
                if (index != SelectedRect)
                {
                    D3D.DrawLine((int)((CollisionRects[index].X - WorldPos.X) * Scale), (int)((CollisionRects[index].Y - WorldPos.Y) * Scale), (int)(((CollisionRects[index].X + CollisionRects[index].Width) - WorldPos.X) * Scale), (int)((CollisionRects[index].Y - WorldPos.Y) * Scale), 0, 255, 0);
                    D3D.DrawLine((int)(((CollisionRects[index].X + CollisionRects[index].Width) - WorldPos.X) * Scale), (int)((CollisionRects[index].Y - WorldPos.Y) * Scale), (int)(((CollisionRects[index].X + CollisionRects[index].Width) - WorldPos.X) * Scale), (int)(((CollisionRects[index].Y + CollisionRects[index].Height) - WorldPos.Y) * Scale), 0, 255, 0);
                    D3D.DrawLine((int)(((CollisionRects[index].X + CollisionRects[index].Width) - WorldPos.X) * Scale), (int)(((CollisionRects[index].Y + CollisionRects[index].Height) - WorldPos.Y) * Scale), (int)((CollisionRects[index].X - WorldPos.X) * Scale), (int)(((CollisionRects[index].Y + CollisionRects[index].Height) - WorldPos.Y) * Scale), 0, 255, 0);
                    D3D.DrawLine((int)((CollisionRects[index].X - WorldPos.X) * Scale), (int)(((CollisionRects[index].Y + CollisionRects[index].Height) - WorldPos.Y) * Scale), (int)((CollisionRects[index].X - WorldPos.X) * Scale), (int)((CollisionRects[index].Y - WorldPos.Y) * Scale), 0, 255, 0);
                }
                else if (index == SelectedRect)
                {
                    D3D.DrawLine((int)((CollisionRects[index].X - WorldPos.X) * Scale), (int)((CollisionRects[index].Y - WorldPos.Y) * Scale), (int)(((CollisionRects[index].X + CollisionRects[index].Width) - WorldPos.X) * Scale), (int)((CollisionRects[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)(((CollisionRects[index].X + CollisionRects[index].Width) - WorldPos.X) * Scale), (int)((CollisionRects[index].Y - WorldPos.Y) * Scale), (int)(((CollisionRects[index].X + CollisionRects[index].Width) - WorldPos.X) * Scale), (int)(((CollisionRects[index].Y + CollisionRects[index].Height) - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)(((CollisionRects[index].X + CollisionRects[index].Width) - WorldPos.X) * Scale), (int)(((CollisionRects[index].Y + CollisionRects[index].Height) - WorldPos.Y) * Scale), (int)((CollisionRects[index].X - WorldPos.X) * Scale), (int)(((CollisionRects[index].Y + CollisionRects[index].Height) - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((CollisionRects[index].X - WorldPos.X) * Scale), (int)(((CollisionRects[index].Y + CollisionRects[index].Height) - WorldPos.Y) * Scale), (int)((CollisionRects[index].X - WorldPos.X) * Scale), (int)((CollisionRects[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }
        }

        private void RenderMagnet()
        {
            for (int index = 0; index < MagnetRects.Count; index++)
            {
                if (index != SelectedMagnet)
                {
                    D3D.DrawLine((int)((MagnetRects[index].X - WorldPos.X) * Scale), (int)((MagnetRects[index].Y - WorldPos.Y) * Scale), (int)(((MagnetRects[index].X + MagnetRects[index].Width) - WorldPos.X) * Scale), (int)((MagnetRects[index].Y - WorldPos.Y) * Scale), 255, 0, 0);
                    D3D.DrawLine((int)(((MagnetRects[index].X + MagnetRects[index].Width) - WorldPos.X) * Scale), (int)((MagnetRects[index].Y - WorldPos.Y) * Scale), (int)(((MagnetRects[index].X + MagnetRects[index].Width) - WorldPos.X) * Scale), (int)(((MagnetRects[index].Y + MagnetRects[index].Height) - WorldPos.Y) * Scale), 255, 0, 0);
                    D3D.DrawLine((int)(((MagnetRects[index].X + MagnetRects[index].Width) - WorldPos.X) * Scale), (int)(((MagnetRects[index].Y + MagnetRects[index].Height) - WorldPos.Y) * Scale), (int)((MagnetRects[index].X - WorldPos.X) * Scale), (int)(((MagnetRects[index].Y + MagnetRects[index].Height) - WorldPos.Y) * Scale), 255, 0, 0);
                    D3D.DrawLine((int)((MagnetRects[index].X - WorldPos.X) * Scale), (int)(((MagnetRects[index].Y + MagnetRects[index].Height) - WorldPos.Y) * Scale), (int)((MagnetRects[index].X - WorldPos.X) * Scale), (int)((MagnetRects[index].Y - WorldPos.Y) * Scale), 255, 0, 0);
                }
                else if (index == SelectedMagnet)
                {
                    D3D.DrawLine((int)((MagnetRects[index].X - WorldPos.X) * Scale), (int)((MagnetRects[index].Y - WorldPos.Y) * Scale), (int)(((MagnetRects[index].X + MagnetRects[index].Width) - WorldPos.X) * Scale), (int)((MagnetRects[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)(((MagnetRects[index].X + MagnetRects[index].Width) - WorldPos.X) * Scale), (int)((MagnetRects[index].Y - WorldPos.Y) * Scale), (int)(((MagnetRects[index].X + MagnetRects[index].Width) - WorldPos.X) * Scale), (int)(((MagnetRects[index].Y + MagnetRects[index].Height) - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)(((MagnetRects[index].X + MagnetRects[index].Width) - WorldPos.X) * Scale), (int)(((MagnetRects[index].Y + MagnetRects[index].Height) - WorldPos.Y) * Scale), (int)((MagnetRects[index].X - WorldPos.X) * Scale), (int)(((MagnetRects[index].Y + MagnetRects[index].Height) - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((MagnetRects[index].X - WorldPos.X) * Scale), (int)(((MagnetRects[index].Y + MagnetRects[index].Height) - WorldPos.Y) * Scale), (int)((MagnetRects[index].X - WorldPos.X) * Scale), (int)((MagnetRects[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }
        }

        /// <summary>
        /// Renders all cube spawns on the map
        /// </summary>
        /// <returns>void</returns>
        private void RenderCube()
        {
            for (int index = 0; index < Cubelist.Count; index++)
            {
                if (index != SelectedCube)
                {
                    D3D.DrawLine((int)(((Cubelist[index].X - 10) - WorldPos.X) * Scale), (int)((Cubelist[index].Y - WorldPos.Y) * Scale), (int)(((Cubelist[index].X + 10) - WorldPos.X) * Scale), (int)((Cubelist[index].Y - WorldPos.Y) * Scale), 255, 0, 0);
                    D3D.DrawLine((int)((Cubelist[index].X - WorldPos.X) * Scale), (int)(((Cubelist[index].Y - 10) - WorldPos.Y) * Scale), (int)((Cubelist[index].X - WorldPos.X) * Scale), (int)(((Cubelist[index].Y + 10) - WorldPos.Y) * Scale), 255, 0, 0);
                }
                else if (index == SelectedCube)
                {
                    D3D.DrawLine((int)(((Cubelist[index].X - 10) - WorldPos.X) * Scale), (int)((Cubelist[index].Y - WorldPos.Y) * Scale), (int)(((Cubelist[index].X + 10) - WorldPos.X) * Scale), (int)((Cubelist[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((Cubelist[index].X - WorldPos.X) * Scale), (int)(((Cubelist[index].Y - 10) - WorldPos.Y) * Scale), (int)((Cubelist[index].X - WorldPos.X) * Scale), (int)(((Cubelist[index].Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }
        }

        /// <summary>
        /// Renders all enemy spawns on the map
        /// </summary>
        /// <returns>void</returns>
        private void RenderEnemy()
        {
            for (int index = 0; index < EnemyList.Count; index++)
            {
                if (index != SelectedEnemy)
                {
                    D3D.DrawLine((int)(((EnemyList[index].X - 10) - WorldPos.X) * Scale), (int)((EnemyList[index].Y - WorldPos.Y) * Scale), (int)(((EnemyList[index].X + 10) - WorldPos.X) * Scale), (int)((EnemyList[index].Y - WorldPos.Y) * Scale), 255, 255, 0);
                    D3D.DrawLine((int)((EnemyList[index].X - WorldPos.X) * Scale), (int)(((EnemyList[index].Y - 10) - WorldPos.Y) * Scale), (int)((EnemyList[index].X - WorldPos.X) * Scale), (int)(((EnemyList[index].Y + 10) - WorldPos.Y) * Scale), 255, 255, 0);
                }
                else if (index == SelectedEnemy)
                {
                    D3D.DrawLine((int)(((EnemyList[index].X - 10) - WorldPos.X) * Scale), (int)((EnemyList[index].Y - WorldPos.Y) * Scale), (int)(((EnemyList[index].X + 10) - WorldPos.X) * Scale), (int)((EnemyList[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((EnemyList[index].X - WorldPos.X) * Scale), (int)(((EnemyList[index].Y - 10) - WorldPos.Y) * Scale), (int)((EnemyList[index].X - WorldPos.X) * Scale), (int)(((EnemyList[index].Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }
        }

        /// <summary>
        /// Renders all turret spawns on the map
        /// </summary>
        /// <returns>void</returns>
        private void RenderTurret()
        {
            for (int index = 0; index < TuretList.Count; index++)
            {
                if (index != SelectedTurret)
                {
                    D3D.DrawLine((int)(((TuretList[index].X - 10) - WorldPos.X) * Scale), (int)((TuretList[index].Y - WorldPos.Y) * Scale), (int)(((TuretList[index].X + 10) - WorldPos.X) * Scale), (int)((TuretList[index].Y - WorldPos.Y) * Scale), 255, 0, 255);
                    D3D.DrawLine((int)((TuretList[index].X - WorldPos.X) * Scale), (int)(((TuretList[index].Y - 10) - WorldPos.Y) * Scale), (int)((TuretList[index].X - WorldPos.X) * Scale), (int)(((TuretList[index].Y + 10) - WorldPos.Y) * Scale), 255, 0, 255);
                }
                else if (index == SelectedTurret)
                {
                    D3D.DrawLine((int)(((TuretList[index].X - 10) - WorldPos.X) * Scale), (int)((TuretList[index].Y - WorldPos.Y) * Scale), (int)(((TuretList[index].X + 10) - WorldPos.X) * Scale), (int)((TuretList[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((TuretList[index].X - WorldPos.X) * Scale), (int)(((TuretList[index].Y - 10) - WorldPos.Y) * Scale), (int)((TuretList[index].X - WorldPos.X) * Scale), (int)(((TuretList[index].Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }
        }

        /// <summary>
        /// Renders all Switches on the map
        /// </summary>
        /// <returns>void</returns>
        private void RenderSwitch()
        {
            for (int index = 0; index < SwitchList.Count; index++)
            {
                if (index != SelectedSwitich)
                {
                    D3D.DrawLine((int)(((SwitchList[index].pos.X - 10) - WorldPos.X) * Scale), (int)((SwitchList[index].pos.Y - WorldPos.Y) * Scale), (int)(((SwitchList[index].pos.X + 10) - WorldPos.X) * Scale), (int)((SwitchList[index].pos.Y - WorldPos.Y) * Scale), 0, 255, 255);
                    D3D.DrawLine((int)((SwitchList[index].pos.X - WorldPos.X) * Scale), (int)(((SwitchList[index].pos.Y - 10) - WorldPos.Y) * Scale), (int)((SwitchList[index].pos.X - WorldPos.X) * Scale), (int)(((SwitchList[index].pos.Y + 10) - WorldPos.Y) * Scale), 0, 255, 255);
                }
                else if (index == SelectedSwitich)
                {
                    D3D.DrawLine((int)(((SwitchList[index].pos.X - 10) - WorldPos.X) * Scale), (int)((SwitchList[index].pos.Y - WorldPos.Y) * Scale), (int)(((SwitchList[index].pos.X + 10) - WorldPos.X) * Scale), (int)((SwitchList[index].pos.Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((SwitchList[index].pos.X - WorldPos.X) * Scale), (int)(((SwitchList[index].pos.Y - 10) - WorldPos.Y) * Scale), (int)((SwitchList[index].pos.X - WorldPos.X) * Scale), (int)(((SwitchList[index].pos.Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }
        }

        /// <summary>
        /// Renders all doors on the map
        /// </summary>
        /// <returns>void</returns>
        private void RenderDoor()
        {
            for (int index = 0; index < DoorList.Count; index++)
            {
                if (index != SelectedDoor)
                {
                    D3D.DrawLine((int)(((DoorList[index].pos.X - 10) - WorldPos.X) * Scale), (int)((DoorList[index].pos.Y - WorldPos.Y) * Scale), (int)(((DoorList[index].pos.X + 10) - WorldPos.X) * Scale), (int)((DoorList[index].pos.Y - WorldPos.Y) * Scale), 255, 128, 255);
                    D3D.DrawLine((int)((DoorList[index].pos.X - WorldPos.X) * Scale), (int)(((DoorList[index].pos.Y - 10) - WorldPos.Y) * Scale), (int)((DoorList[index].pos.X - WorldPos.X) * Scale), (int)(((DoorList[index].pos.Y + 10) - WorldPos.Y) * Scale), 255, 128, 255);
                }
                else if (index == SelectedDoor)
                {
                    D3D.DrawLine((int)(((DoorList[index].pos.X - 10) - WorldPos.X) * Scale), (int)((DoorList[index].pos.Y - WorldPos.Y) * Scale), (int)(((DoorList[index].pos.X + 10) - WorldPos.X) * Scale), (int)((DoorList[index].pos.Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((DoorList[index].pos.X - WorldPos.X) * Scale), (int)(((DoorList[index].pos.Y - 10) - WorldPos.Y) * Scale), (int)((DoorList[index].pos.X - WorldPos.X) * Scale), (int)(((DoorList[index].pos.Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }
        }

        private void RenderTrigger()
        {
            for (int index = 0; index < TriggerList.Count; index++)
            {
                if (index != SelectedTrigger)
                {
                    D3D.DrawLine((int)(((TriggerList[index].pos.X - 10) - WorldPos.X) * Scale), (int)((TriggerList[index].pos.Y - WorldPos.Y) * Scale), (int)(((TriggerList[index].pos.X + 10) - WorldPos.X) * Scale), (int)((TriggerList[index].pos.Y - WorldPos.Y) * Scale), 128, 255, 255);
                    D3D.DrawLine((int)((TriggerList[index].pos.X - WorldPos.X) * Scale), (int)(((TriggerList[index].pos.Y - 10) - WorldPos.Y) * Scale), (int)((TriggerList[index].pos.X - WorldPos.X) * Scale), (int)(((TriggerList[index].pos.Y + 10) - WorldPos.Y) * Scale), 128, 255, 255);
                }
                else if (index == SelectedTrigger)
                {
                    D3D.DrawLine((int)(((TriggerList[index].pos.X - 10) - WorldPos.X) * Scale), (int)((TriggerList[index].pos.Y - WorldPos.Y) * Scale), (int)(((TriggerList[index].pos.X + 10) - WorldPos.X) * Scale), (int)((TriggerList[index].pos.Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((TriggerList[index].pos.X - WorldPos.X) * Scale), (int)(((TriggerList[index].pos.Y - 10) - WorldPos.Y) * Scale), (int)((TriggerList[index].pos.X - WorldPos.X) * Scale), (int)(((TriggerList[index].pos.Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }

        }

        private void RenderTrap()
        {
            for (int index = 0; index < TrapList.Count; index++)
            {
                if (index != SelectedTrap)
                {
                    D3D.DrawLine((int)(((TrapList[index].pos.X - 10) - WorldPos.X) * Scale), (int)((TrapList[index].pos.Y - WorldPos.Y) * Scale), (int)(((TrapList[index].pos.X + 10) - WorldPos.X) * Scale), (int)((TrapList[index].pos.Y - WorldPos.Y) * Scale), 255, 255, 128);
                    D3D.DrawLine((int)((TrapList[index].pos.X - WorldPos.X) * Scale), (int)(((TrapList[index].pos.Y - 10) - WorldPos.Y) * Scale), (int)((TrapList[index].pos.X - WorldPos.X) * Scale), (int)(((TrapList[index].pos.Y + 10) - WorldPos.Y) * Scale), 255, 255, 128);
                }
                else if (index == SelectedTrap)
                {
                    D3D.DrawLine((int)(((TrapList[index].pos.X - 10) - WorldPos.X) * Scale), (int)((TrapList[index].pos.Y - WorldPos.Y) * Scale), (int)(((TrapList[index].pos.X + 10) - WorldPos.X) * Scale), (int)((TrapList[index].pos.Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((TrapList[index].pos.X - WorldPos.X) * Scale), (int)(((TrapList[index].pos.Y - 10) - WorldPos.Y) * Scale), (int)((TrapList[index].pos.X - WorldPos.X) * Scale), (int)(((TrapList[index].pos.Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }

        }

        private void RenderBonus()
        {
            for (int index = 0; index < BonusList.Count; index++)
            {
                if (index != SelectedBonus)
                {
                    D3D.DrawLine((int)(((BonusList[index].X - 10) - WorldPos.X) * Scale), (int)((BonusList[index].Y - WorldPos.Y) * Scale), (int)(((BonusList[index].X + 10) - WorldPos.X) * Scale), (int)((BonusList[index].Y - WorldPos.Y) * Scale), 0, 255, 0);
                    D3D.DrawLine((int)((BonusList[index].X - WorldPos.X) * Scale), (int)(((BonusList[index].Y - 10) - WorldPos.Y) * Scale), (int)((BonusList[index].X - WorldPos.X) * Scale), (int)(((BonusList[index].Y + 10) - WorldPos.Y) * Scale), 0, 255, 0);
                }
                else if (index == SelectedBonus)
                {
                    D3D.DrawLine((int)(((BonusList[index].X - 10) - WorldPos.X) * Scale), (int)((BonusList[index].Y - WorldPos.Y) * Scale), (int)(((BonusList[index].X + 10) - WorldPos.X) * Scale), (int)((BonusList[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((BonusList[index].X - WorldPos.X) * Scale), (int)(((BonusList[index].Y - 10) - WorldPos.Y) * Scale), (int)((BonusList[index].X - WorldPos.X) * Scale), (int)(((BonusList[index].Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }

        }

        private void RenderInv()
        {
            for (int index = 0; index < InvList.Count; index++)
            {
                if (index != SelectedInv)
                {
                    D3D.DrawLine((int)(((InvList[index].X - 10) - WorldPos.X) * Scale), (int)((InvList[index].Y - WorldPos.Y) * Scale), (int)(((InvList[index].X + 10) - WorldPos.X) * Scale), (int)((InvList[index].Y - WorldPos.Y) * Scale), 255, 0, 128);
                    D3D.DrawLine((int)((InvList[index].X - WorldPos.X) * Scale), (int)(((InvList[index].Y - 10) - WorldPos.Y) * Scale), (int)((InvList[index].X - WorldPos.X) * Scale), (int)(((InvList[index].Y + 10) - WorldPos.Y) * Scale), 255, 0, 128);
                }
                else if (index == SelectedInv)
                {
                    D3D.DrawLine((int)(((InvList[index].X - 10) - WorldPos.X) * Scale), (int)((InvList[index].Y - WorldPos.Y) * Scale), (int)(((InvList[index].X + 10) - WorldPos.X) * Scale), (int)((InvList[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((InvList[index].X - WorldPos.X) * Scale), (int)(((InvList[index].Y - 10) - WorldPos.Y) * Scale), (int)((InvList[index].X - WorldPos.X) * Scale), (int)(((InvList[index].Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }

        }
        private void RenderMovingP()
        {
            for (int index = 0; index < MPList.Count; index++)
            {
                if (index != SelectedMP)
                {
                    D3D.DrawLine((int)(((MPList[index].X - 10) - WorldPos.X) * Scale), (int)((MPList[index].Y - WorldPos.Y) * Scale), (int)(((MPList[index].X + 10) - WorldPos.X) * Scale), (int)((MPList[index].Y - WorldPos.Y) * Scale), 255,128, 0);
                    D3D.DrawLine((int)((MPList[index].X - WorldPos.X) * Scale), (int)(((MPList[index].Y - 10) - WorldPos.Y) * Scale), (int)((MPList[index].X - WorldPos.X) * Scale), (int)(((MPList[index].Y + 10) - WorldPos.Y) * Scale), 255, 128, 0);
                }
                else if (index == SelectedMP)
                {
                    D3D.DrawLine((int)(((MPList[index].X - 10) - WorldPos.X) * Scale), (int)((MPList[index].Y - WorldPos.Y) * Scale), (int)(((MPList[index].X + 10) - WorldPos.X) * Scale), (int)((MPList[index].Y - WorldPos.Y) * Scale), 0, 0, 255);
                    D3D.DrawLine((int)((MPList[index].X - WorldPos.X) * Scale), (int)(((MPList[index].Y - 10) - WorldPos.Y) * Scale), (int)((MPList[index].X - WorldPos.X) * Scale), (int)(((MPList[index].Y + 10) - WorldPos.Y) * Scale), 0, 0, 255);
                }
            }

        }

        private void RenderPlayerSpawn()
        {
            D3D.DrawLine((int)(((PlayerSpawn.X - 10) - WorldPos.X) * Scale), (int)((PlayerSpawn.Y - WorldPos.Y) * Scale), (int)(((PlayerSpawn.X + 10) - WorldPos.X) * Scale), (int)((PlayerSpawn.Y - WorldPos.Y) * Scale), 255, 255, 255);
            D3D.DrawLine((int)((PlayerSpawn.X - WorldPos.X) * Scale), (int)(((PlayerSpawn.Y - 10) - WorldPos.Y) * Scale), (int)((PlayerSpawn.X - WorldPos.X) * Scale), (int)(((PlayerSpawn.Y + 10) - WorldPos.Y) * Scale), 255, 255, 255);

        }

        private void RenderPlayerEnd()
        {
            D3D.DrawLine((int)(((PlayerEnd.X - 10) - WorldPos.X) * Scale), (int)((PlayerEnd.Y - WorldPos.Y) * Scale), (int)(((PlayerEnd.X + 10) - WorldPos.X) * Scale), (int)((PlayerEnd.Y - WorldPos.Y) * Scale), 0, 0, 0);
            D3D.DrawLine((int)((PlayerEnd.X - WorldPos.X) * Scale), (int)(((PlayerEnd.Y - 10) - WorldPos.Y) * Scale), (int)((PlayerEnd.X - WorldPos.X) * Scale), (int)(((PlayerEnd.Y + 10) - WorldPos.Y) * Scale), 0, 0, 0);

        }
        /// <summary>
        /// Renders the area fill rectangle 
        /// </summary>
        /// <returns>void</returns>
        private void RenderAreaFill()
        {
            D3D.DrawLine((int)((AreaFill.X - WorldPos.X) * Scale), (int)((AreaFill.Y - WorldPos.Y) * Scale), (int)(((AreaFill.X + AreaFill.Width) - WorldPos.X) * Scale), (int)((AreaFill.Y - WorldPos.Y) * Scale), 0, 255, 0);
            D3D.DrawLine((int)(((AreaFill.X + AreaFill.Width) - WorldPos.X) * Scale), (int)((AreaFill.Y - WorldPos.Y) * Scale), (int)(((AreaFill.X + AreaFill.Width) - WorldPos.X) * Scale), (int)(((AreaFill.Y + AreaFill.Height) - WorldPos.Y) * Scale), 0, 255, 0);
            D3D.DrawLine((int)(((AreaFill.X + AreaFill.Width) - WorldPos.X) * Scale), (int)(((AreaFill.Y + AreaFill.Height) - WorldPos.Y) * Scale), (int)((AreaFill.X - WorldPos.X) * Scale), (int)(((AreaFill.Y + AreaFill.Height) - WorldPos.Y) * Scale), 0, 255, 0);
            D3D.DrawLine((int)((AreaFill.X - WorldPos.X) * Scale), (int)(((AreaFill.Y + AreaFill.Height) - WorldPos.Y) * Scale), (int)((AreaFill.X - WorldPos.X) * Scale), (int)((AreaFill.Y - WorldPos.Y) * Scale), 0, 255, 0);
        }

    };
}
