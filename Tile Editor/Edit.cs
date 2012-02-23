///<summary>
///File: "Edit.cs"
///Author: Leland Nyman (LN)
///Purpose: Show the current items in the lists and allows for the deletion of those layers
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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Removes the selected switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (SwitchLV.FocusedItem != null)
            {
                map.map.SwitchList.RemoveAt(SwitchLV.FocusedItem.Index);
                SwitchLV.Items.RemoveAt(SwitchLV.FocusedItem.Index);

                for (int i = 0; i < map.map.SwitchList.Count; i++)
                {
                    SwitchLV.Items[i].Text = "Turret " + i;
                }
            }

            map.map.Render();
        }

        /// <summary>
        /// removes the selected layer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (LayerLV.FocusedItem != null)
            {
                map.map.layerList.RemoveAt(LayerLV.FocusedItem.Index);
                map.LayerCB.Items.RemoveAt(LayerLV.FocusedItem.Index);
                LayerLV.Items.RemoveAt(LayerLV.FocusedItem.Index);

                if (map.LayerCB.Items.Count != 1)
                {
                    map.LayerCB.Text = "0";

                    for (int i = 0; i < map.map.layerList.Count; i++)
                    {
                        map.map.layerList[i].visible = false;
                    }

                    map.map.layerList[0].visible = true;
                }
                else if (map.LayerCB.Items.Count == 1)
                {
                    map.LayerCB.Text = "All";
                    return;
                }

                for (int i = 0; i < map.LayerCB.Items.Count - 1; ++i)
                {
                    map.LayerCB.Items[i] = i.ToString();
                }

                for (int i = 0; i < LayerLV.Items.Count; ++i)
                {
                    LayerLV.Items[i].Text = "Layer " + i.ToString();
                }
            }

            map.map.Render();

        }

        /// <summary>
        /// removes the selected collision rect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (CollisionLV.FocusedItem != null)
            {
                map.map.CollisionRects.RemoveAt(CollisionLV.FocusedItem.Index);
                CollisionLV.Items.RemoveAt(CollisionLV.FocusedItem.Index);

                for (int i = 0; i < map.map.CollisionRects.Count; i++)
                {
                    CollisionLV.Items[i].Text = "CollisionRect " + i;
                }
            }

            map.map.Render();
        }

        /// <summary>
        /// removes the selected cube
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (CubeLV.FocusedItem != null)
            {
                map.map.Cubelist.RemoveAt(CubeLV.FocusedItem.Index);
                CubeLV.Items.RemoveAt(CubeLV.FocusedItem.Index);

                for (int i = 0; i < map.map.Cubelist.Count; i++)
                {
                    CubeLV.Items[i].Text = "Cube " + i;
                }
            }

            map.map.Render();
        }

        /// <summary>
        /// removes the selected turret
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (TurretLV.FocusedItem != null)
            {
                map.map.TuretList.RemoveAt(TurretLV.FocusedItem.Index);
                TurretLV.Items.RemoveAt(TurretLV.FocusedItem.Index);

                for (int i = 0; i < map.map.TuretList.Count; i++)
                {
                    TurretLV.Items[i].Text = "Turret " + i;
                }
            }

            map.map.Render();
        }

        /// <summary>
        /// removes the selected enemy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (EnemyLV.FocusedItem != null)
            {
                map.map.EnemyList.RemoveAt(EnemyLV.FocusedItem.Index);
                EnemyLV.Items.RemoveAt(EnemyLV.FocusedItem.Index);

                for (int i = 0; i < map.map.EnemyList.Count; i++)
                {
                    EnemyLV.Items[i].Text = "Enemy " + i;
                }
            }

            map.map.Render();
        }

        /// <summary>
        /// changes the selected collison rect on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void CollisionLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedRect = CollisionLV.FocusedItem.Index;

            map.map.Render();
        }

        /// <summary>
        /// changes the selected cube on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void CubeLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedCube = CubeLV.FocusedItem.Index;

            map.map.Render();
        }

        /// <summary>
        /// changes the selected turret on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void TurretLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedTurret = TurretLV.FocusedItem.Index;

            map.map.Render();
        }

        /// <summary>
        /// changes the selected enemy on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void EnemyLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedEnemy = EnemyLV.FocusedItem.Index;

            map.map.Render();
        }

        /// <summary>
        /// changes the selected switch on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void SwitchLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedSwitich = SwitchLV.FocusedItem.Index;

            map.map.Render();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedDoor = listView1.FocusedItem.Index;

            map.map.Render();

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedTrigger = listView2.FocusedItem.Index;

            map.map.Render();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedTrap = listView3.FocusedItem.Index;

            map.map.Render();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (listView1.FocusedItem != null)
            {
                map.map.DoorList.RemoveAt(listView1.FocusedItem.Index);
                listView1.Items.RemoveAt(listView1.FocusedItem.Index);

                for (int i = 0; i < map.map.DoorList.Count; i++)
                {
                    listView1.Items[i].Text = "Door " + i;
                }
            }

            map.map.Render();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (listView2.FocusedItem != null)
            {
                map.map.TriggerList.RemoveAt(listView2.FocusedItem.Index);
                listView2.Items.RemoveAt(listView2.FocusedItem.Index);

                for (int i = 0; i < map.map.TriggerList.Count; i++)
                {
                    listView2.Items[i].Text = "Trigger " + i;
                }
            }

            map.map.Render();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (listView3.FocusedItem != null)
            {
                map.map.TrapList.RemoveAt(listView3.FocusedItem.Index);
                listView3.Items.RemoveAt(listView3.FocusedItem.Index);

                for (int i = 0; i < map.map.TrapList.Count; i++)
                {
                    listView3.Items[i].Text = "Trap " + i;
                }
            }

            map.map.Render();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (listView4.FocusedItem != null)
            {
                map.map.MagnetRects.RemoveAt(listView4.FocusedItem.Index);
                listView4.Items.RemoveAt(listView4.FocusedItem.Index);

                for (int i = 0; i < map.map.MagnetRects.Count; i++)
                {
                    listView4.Items[i].Text = "Magnet " + i;
                }
            }

            map.map.Render();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (listView5.FocusedItem != null)
            {
                map.map.BonusList.RemoveAt(listView5.FocusedItem.Index);
                listView5.Items.RemoveAt(listView5.FocusedItem.Index);

                for (int i = 0; i < map.map.BonusList.Count; i++)
                {
                    listView5.Items[i].Text = "Bonus " + i;
                }
            }

            map.map.Render();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (listView6.FocusedItem != null)
            {
                map.map.InvList.RemoveAt(listView6.FocusedItem.Index);
                listView6.Items.RemoveAt(listView6.FocusedItem.Index);

                for (int i = 0; i < map.map.InvList.Count; i++)
                {
                    listView6.Items[i].Text = "Inv " + i;
                }
            }

            map.map.Render();

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedMagnet = listView4.FocusedItem.Index;

            map.map.Render();

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedBonus = listView5.FocusedItem.Index;

            map.map.Render();

        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedInv = listView6.FocusedItem.Index;

            map.map.Render();

        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            map.map.SelectedMP = listView7.FocusedItem.Index;

            map.map.Render();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 map = Owner as Form1;

            if (listView7.FocusedItem != null)
            {
                map.map.MPList.RemoveAt(listView7.FocusedItem.Index);
                listView7.Items.RemoveAt(listView7.FocusedItem.Index);

                for (int i = 0; i < map.map.MPList.Count; i++)
                {
                    listView7.Items[i].Text = "Inv " + i;
                }
            }

            map.map.Render();
        }
    }
}