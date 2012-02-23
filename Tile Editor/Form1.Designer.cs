namespace Tile_Editor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsBianaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBianaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthNUD = new System.Windows.Forms.NumericUpDown();
            this.HeightNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LayerCB = new System.Windows.Forms.ComboBox();
            this.AddB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PEndCB = new System.Windows.Forms.CheckBox();
            this.PSpawnCB = new System.Windows.Forms.CheckBox();
            this.TrapCB = new System.Windows.Forms.CheckBox();
            this.TriggerCB = new System.Windows.Forms.CheckBox();
            this.DoorCB = new System.Windows.Forms.CheckBox();
            this.SwitchCB = new System.Windows.Forms.CheckBox();
            this.TurretCB = new System.Windows.Forms.CheckBox();
            this.EnemyCB = new System.Windows.Forms.CheckBox();
            this.CubeCB = new System.Windows.Forms.CheckBox();
            this.CollisionCB = new System.Windows.Forms.CheckBox();
            this.GridCB = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PEndB = new System.Windows.Forms.Button();
            this.PSpawnB = new System.Windows.Forms.Button();
            this.TrapB = new System.Windows.Forms.Button();
            this.TriggerB = new System.Windows.Forms.Button();
            this.DoorB = new System.Windows.Forms.Button();
            this.SwitchB = new System.Windows.Forms.Button();
            this.TurretB = new System.Windows.Forms.Button();
            this.EnemyB = new System.Windows.Forms.Button();
            this.CubeB = new System.Windows.Forms.Button();
            this.CollisionB = new System.Windows.Forms.Button();
            this.NormalB = new System.Windows.Forms.Button();
            this.BonusB = new System.Windows.Forms.Button();
            this.InvB = new System.Windows.Forms.Button();
            this.MagnetB = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveAsBianaryToolStripMenuItem,
            this.loadBianaryToolStripMenuItem,
            this.saveAsXMLToolStripMenuItem,
            this.loadXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveAsBianaryToolStripMenuItem
            // 
            this.saveAsBianaryToolStripMenuItem.Name = "saveAsBianaryToolStripMenuItem";
            this.saveAsBianaryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveAsBianaryToolStripMenuItem.Text = "Save as Binary";
            this.saveAsBianaryToolStripMenuItem.Click += new System.EventHandler(this.saveAsBianaryToolStripMenuItem_Click);
            // 
            // loadBianaryToolStripMenuItem
            // 
            this.loadBianaryToolStripMenuItem.Name = "loadBianaryToolStripMenuItem";
            this.loadBianaryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loadBianaryToolStripMenuItem.Text = "Load Binary";
            this.loadBianaryToolStripMenuItem.Click += new System.EventHandler(this.loadBianaryToolStripMenuItem_Click);
            // 
            // saveAsXMLToolStripMenuItem
            // 
            this.saveAsXMLToolStripMenuItem.Enabled = false;
            this.saveAsXMLToolStripMenuItem.Name = "saveAsXMLToolStripMenuItem";
            this.saveAsXMLToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveAsXMLToolStripMenuItem.Text = "Save as XML";
            this.saveAsXMLToolStripMenuItem.Click += new System.EventHandler(this.saveAsXMLToolStripMenuItem_Click);
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.Enabled = false;
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loadXMLToolStripMenuItem.Text = "Load XML";
            this.loadXMLToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Checked = true;
            this.tileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.tileToolStripMenuItem.Text = "Tile Set";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Checked = true;
            this.editToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "50%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem3.Text = "100%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem4.Text = "150%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem5.Text = "200%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 524);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 507);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(629, 17);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(612, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 507);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.WidthNUD);
            this.groupBox1.Controls.Add(this.HeightNUD);
            this.groupBox1.Location = new System.Drawing.Point(648, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // WidthNUD
            // 
            this.WidthNUD.Location = new System.Drawing.Point(7, 47);
            this.WidthNUD.Name = "WidthNUD";
            this.WidthNUD.Size = new System.Drawing.Size(57, 20);
            this.WidthNUD.TabIndex = 1;
            this.WidthNUD.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.WidthNUD.ValueChanged += new System.EventHandler(this.WidthNUD_ValueChanged);
            // 
            // HeightNUD
            // 
            this.HeightNUD.Location = new System.Drawing.Point(7, 20);
            this.HeightNUD.Name = "HeightNUD";
            this.HeightNUD.Size = new System.Drawing.Size(57, 20);
            this.HeightNUD.TabIndex = 0;
            this.HeightNUD.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.HeightNUD.ValueChanged += new System.EventHandler(this.HeightNUD_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LayerCB);
            this.groupBox2.Controls.Add(this.AddB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(766, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Layer";
            // 
            // LayerCB
            // 
            this.LayerCB.FormattingEnabled = true;
            this.LayerCB.Items.AddRange(new object[] {
            "0",
            "All"});
            this.LayerCB.Location = new System.Drawing.Point(6, 19);
            this.LayerCB.Name = "LayerCB";
            this.LayerCB.Size = new System.Drawing.Size(50, 21);
            this.LayerCB.TabIndex = 3;
            this.LayerCB.Text = "0";
            this.LayerCB.SelectedIndexChanged += new System.EventHandler(this.LayerCB_SelectedIndexChanged);
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.White;
            this.AddB.Location = new System.Drawing.Point(7, 47);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(107, 23);
            this.AddB.TabIndex = 2;
            this.AddB.Text = "Add";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.PEndCB);
            this.groupBox3.Controls.Add(this.PSpawnCB);
            this.groupBox3.Controls.Add(this.TrapCB);
            this.groupBox3.Controls.Add(this.TriggerCB);
            this.groupBox3.Controls.Add(this.DoorCB);
            this.groupBox3.Controls.Add(this.SwitchCB);
            this.groupBox3.Controls.Add(this.TurretCB);
            this.groupBox3.Controls.Add(this.EnemyCB);
            this.groupBox3.Controls.Add(this.CubeCB);
            this.groupBox3.Controls.Add(this.CollisionCB);
            this.groupBox3.Controls.Add(this.GridCB);
            this.groupBox3.Location = new System.Drawing.Point(648, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 473);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show";
            // 
            // PEndCB
            // 
            this.PEndCB.AutoSize = true;
            this.PEndCB.Checked = true;
            this.PEndCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PEndCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.PEndCB.Location = new System.Drawing.Point(7, 323);
            this.PEndCB.Name = "PEndCB";
            this.PEndCB.Size = new System.Drawing.Size(77, 17);
            this.PEndCB.TabIndex = 10;
            this.PEndCB.Text = "Player End";
            this.PEndCB.UseVisualStyleBackColor = true;
            this.PEndCB.CheckedChanged += new System.EventHandler(this.PEndCB_CheckedChanged);
            // 
            // PSpawnCB
            // 
            this.PSpawnCB.AutoSize = true;
            this.PSpawnCB.Checked = true;
            this.PSpawnCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PSpawnCB.Location = new System.Drawing.Point(7, 293);
            this.PSpawnCB.Name = "PSpawnCB";
            this.PSpawnCB.Size = new System.Drawing.Size(91, 17);
            this.PSpawnCB.TabIndex = 9;
            this.PSpawnCB.Text = "Player Spawn";
            this.PSpawnCB.UseVisualStyleBackColor = true;
            this.PSpawnCB.CheckedChanged += new System.EventHandler(this.PSpawnCB_CheckedChanged);
            // 
            // TrapCB
            // 
            this.TrapCB.AutoSize = true;
            this.TrapCB.Checked = true;
            this.TrapCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TrapCB.Location = new System.Drawing.Point(7, 263);
            this.TrapCB.Name = "TrapCB";
            this.TrapCB.Size = new System.Drawing.Size(48, 17);
            this.TrapCB.TabIndex = 8;
            this.TrapCB.Text = "Trap";
            this.TrapCB.UseVisualStyleBackColor = true;
            this.TrapCB.CheckedChanged += new System.EventHandler(this.TrapCB_CheckedChanged);
            // 
            // TriggerCB
            // 
            this.TriggerCB.AutoSize = true;
            this.TriggerCB.Checked = true;
            this.TriggerCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TriggerCB.Location = new System.Drawing.Point(7, 234);
            this.TriggerCB.Name = "TriggerCB";
            this.TriggerCB.Size = new System.Drawing.Size(78, 17);
            this.TriggerCB.TabIndex = 7;
            this.TriggerCB.Text = "Trap Triger";
            this.TriggerCB.UseVisualStyleBackColor = true;
            this.TriggerCB.CheckedChanged += new System.EventHandler(this.TriggerCB_CheckedChanged);
            // 
            // DoorCB
            // 
            this.DoorCB.AutoSize = true;
            this.DoorCB.Checked = true;
            this.DoorCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DoorCB.Location = new System.Drawing.Point(7, 204);
            this.DoorCB.Name = "DoorCB";
            this.DoorCB.Size = new System.Drawing.Size(49, 17);
            this.DoorCB.TabIndex = 6;
            this.DoorCB.Text = "Door";
            this.DoorCB.UseVisualStyleBackColor = true;
            this.DoorCB.CheckedChanged += new System.EventHandler(this.DoorCB_CheckedChanged);
            // 
            // SwitchCB
            // 
            this.SwitchCB.AutoSize = true;
            this.SwitchCB.Checked = true;
            this.SwitchCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwitchCB.Location = new System.Drawing.Point(7, 174);
            this.SwitchCB.Name = "SwitchCB";
            this.SwitchCB.Size = new System.Drawing.Size(58, 17);
            this.SwitchCB.TabIndex = 5;
            this.SwitchCB.Text = "Switch";
            this.SwitchCB.UseVisualStyleBackColor = true;
            this.SwitchCB.CheckedChanged += new System.EventHandler(this.SwitchCB_CheckedChanged);
            // 
            // TurretCB
            // 
            this.TurretCB.AutoSize = true;
            this.TurretCB.Checked = true;
            this.TurretCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TurretCB.Location = new System.Drawing.Point(7, 144);
            this.TurretCB.Name = "TurretCB";
            this.TurretCB.Size = new System.Drawing.Size(54, 17);
            this.TurretCB.TabIndex = 4;
            this.TurretCB.Text = "Turret";
            this.TurretCB.UseVisualStyleBackColor = true;
            this.TurretCB.CheckedChanged += new System.EventHandler(this.TurretCB_CheckedChanged);
            // 
            // EnemyCB
            // 
            this.EnemyCB.AutoSize = true;
            this.EnemyCB.Checked = true;
            this.EnemyCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnemyCB.Location = new System.Drawing.Point(7, 114);
            this.EnemyCB.Name = "EnemyCB";
            this.EnemyCB.Size = new System.Drawing.Size(58, 17);
            this.EnemyCB.TabIndex = 3;
            this.EnemyCB.Text = "Enemy";
            this.EnemyCB.UseVisualStyleBackColor = true;
            this.EnemyCB.CheckedChanged += new System.EventHandler(this.EnemyCB_CheckedChanged);
            // 
            // CubeCB
            // 
            this.CubeCB.AutoSize = true;
            this.CubeCB.Checked = true;
            this.CubeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CubeCB.Location = new System.Drawing.Point(7, 84);
            this.CubeCB.Name = "CubeCB";
            this.CubeCB.Size = new System.Drawing.Size(51, 17);
            this.CubeCB.TabIndex = 2;
            this.CubeCB.Text = "Cube";
            this.CubeCB.UseVisualStyleBackColor = true;
            this.CubeCB.CheckedChanged += new System.EventHandler(this.CubeCB_CheckedChanged);
            // 
            // CollisionCB
            // 
            this.CollisionCB.AutoSize = true;
            this.CollisionCB.Checked = true;
            this.CollisionCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CollisionCB.Location = new System.Drawing.Point(7, 54);
            this.CollisionCB.Name = "CollisionCB";
            this.CollisionCB.Size = new System.Drawing.Size(90, 17);
            this.CollisionCB.TabIndex = 1;
            this.CollisionCB.Text = "Collision Rect";
            this.CollisionCB.UseVisualStyleBackColor = true;
            this.CollisionCB.CheckedChanged += new System.EventHandler(this.CollisionCB_CheckedChanged);
            // 
            // GridCB
            // 
            this.GridCB.AutoSize = true;
            this.GridCB.Checked = true;
            this.GridCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridCB.Location = new System.Drawing.Point(7, 24);
            this.GridCB.Name = "GridCB";
            this.GridCB.Size = new System.Drawing.Size(45, 17);
            this.GridCB.TabIndex = 0;
            this.GridCB.Text = "Grid";
            this.GridCB.UseVisualStyleBackColor = true;
            this.GridCB.CheckedChanged += new System.EventHandler(this.GridCB_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.MagnetB);
            this.groupBox4.Controls.Add(this.InvB);
            this.groupBox4.Controls.Add(this.BonusB);
            this.groupBox4.Controls.Add(this.PEndB);
            this.groupBox4.Controls.Add(this.PSpawnB);
            this.groupBox4.Controls.Add(this.TrapB);
            this.groupBox4.Controls.Add(this.TriggerB);
            this.groupBox4.Controls.Add(this.DoorB);
            this.groupBox4.Controls.Add(this.SwitchB);
            this.groupBox4.Controls.Add(this.TurretB);
            this.groupBox4.Controls.Add(this.EnemyB);
            this.groupBox4.Controls.Add(this.CubeB);
            this.groupBox4.Controls.Add(this.CollisionB);
            this.groupBox4.Controls.Add(this.NormalB);
            this.groupBox4.Location = new System.Drawing.Point(772, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 473);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pointer Type";
            // 
            // PEndB
            // 
            this.PEndB.BackColor = System.Drawing.Color.White;
            this.PEndB.Location = new System.Drawing.Point(7, 319);
            this.PEndB.Name = "PEndB";
            this.PEndB.Size = new System.Drawing.Size(107, 23);
            this.PEndB.TabIndex = 10;
            this.PEndB.Text = "Player End";
            this.PEndB.UseVisualStyleBackColor = false;
            this.PEndB.Click += new System.EventHandler(this.REndB_Click);
            // 
            // PSpawnB
            // 
            this.PSpawnB.BackColor = System.Drawing.Color.White;
            this.PSpawnB.Location = new System.Drawing.Point(7, 289);
            this.PSpawnB.Name = "PSpawnB";
            this.PSpawnB.Size = new System.Drawing.Size(107, 23);
            this.PSpawnB.TabIndex = 9;
            this.PSpawnB.Text = "Player Spawn";
            this.PSpawnB.UseVisualStyleBackColor = false;
            this.PSpawnB.Click += new System.EventHandler(this.PSpawnB_Click);
            // 
            // TrapB
            // 
            this.TrapB.BackColor = System.Drawing.Color.White;
            this.TrapB.Location = new System.Drawing.Point(7, 259);
            this.TrapB.Name = "TrapB";
            this.TrapB.Size = new System.Drawing.Size(107, 23);
            this.TrapB.TabIndex = 8;
            this.TrapB.Text = "Trap";
            this.TrapB.UseVisualStyleBackColor = false;
            this.TrapB.Click += new System.EventHandler(this.TrapB_Click);
            // 
            // TriggerB
            // 
            this.TriggerB.BackColor = System.Drawing.Color.White;
            this.TriggerB.Location = new System.Drawing.Point(7, 230);
            this.TriggerB.Name = "TriggerB";
            this.TriggerB.Size = new System.Drawing.Size(107, 23);
            this.TriggerB.TabIndex = 7;
            this.TriggerB.Text = "Trap Trigger";
            this.TriggerB.UseVisualStyleBackColor = false;
            this.TriggerB.Click += new System.EventHandler(this.TriggerB_Click);
            // 
            // DoorB
            // 
            this.DoorB.BackColor = System.Drawing.Color.White;
            this.DoorB.Location = new System.Drawing.Point(7, 200);
            this.DoorB.Name = "DoorB";
            this.DoorB.Size = new System.Drawing.Size(107, 23);
            this.DoorB.TabIndex = 6;
            this.DoorB.Text = "Door";
            this.DoorB.UseVisualStyleBackColor = false;
            this.DoorB.Click += new System.EventHandler(this.DoorB_Click);
            // 
            // SwitchB
            // 
            this.SwitchB.BackColor = System.Drawing.Color.White;
            this.SwitchB.Location = new System.Drawing.Point(7, 170);
            this.SwitchB.Name = "SwitchB";
            this.SwitchB.Size = new System.Drawing.Size(107, 23);
            this.SwitchB.TabIndex = 5;
            this.SwitchB.Text = "Switch";
            this.SwitchB.UseVisualStyleBackColor = false;
            this.SwitchB.Click += new System.EventHandler(this.SwitchB_Click);
            // 
            // TurretB
            // 
            this.TurretB.BackColor = System.Drawing.Color.White;
            this.TurretB.Location = new System.Drawing.Point(7, 140);
            this.TurretB.Name = "TurretB";
            this.TurretB.Size = new System.Drawing.Size(107, 23);
            this.TurretB.TabIndex = 4;
            this.TurretB.Text = "Turret Spawn";
            this.TurretB.UseVisualStyleBackColor = false;
            this.TurretB.Click += new System.EventHandler(this.TurretB_Click);
            // 
            // EnemyB
            // 
            this.EnemyB.BackColor = System.Drawing.Color.White;
            this.EnemyB.Location = new System.Drawing.Point(7, 110);
            this.EnemyB.Name = "EnemyB";
            this.EnemyB.Size = new System.Drawing.Size(107, 23);
            this.EnemyB.TabIndex = 3;
            this.EnemyB.Text = "Enemy Spawn";
            this.EnemyB.UseVisualStyleBackColor = false;
            this.EnemyB.Click += new System.EventHandler(this.EnemyB_Click);
            // 
            // CubeB
            // 
            this.CubeB.BackColor = System.Drawing.Color.White;
            this.CubeB.Location = new System.Drawing.Point(7, 80);
            this.CubeB.Name = "CubeB";
            this.CubeB.Size = new System.Drawing.Size(107, 23);
            this.CubeB.TabIndex = 2;
            this.CubeB.Text = "Cube Spawn";
            this.CubeB.UseVisualStyleBackColor = false;
            this.CubeB.Click += new System.EventHandler(this.CubeB_Click);
            // 
            // CollisionB
            // 
            this.CollisionB.BackColor = System.Drawing.Color.White;
            this.CollisionB.Location = new System.Drawing.Point(7, 50);
            this.CollisionB.Name = "CollisionB";
            this.CollisionB.Size = new System.Drawing.Size(107, 23);
            this.CollisionB.TabIndex = 1;
            this.CollisionB.Text = "Collison Rect";
            this.CollisionB.UseVisualStyleBackColor = false;
            this.CollisionB.Click += new System.EventHandler(this.CollisionB_Click);
            // 
            // NormalB
            // 
            this.NormalB.BackColor = System.Drawing.Color.Orange;
            this.NormalB.Location = new System.Drawing.Point(7, 20);
            this.NormalB.Name = "NormalB";
            this.NormalB.Size = new System.Drawing.Size(107, 23);
            this.NormalB.TabIndex = 0;
            this.NormalB.Text = "Normal";
            this.NormalB.UseVisualStyleBackColor = false;
            this.NormalB.Click += new System.EventHandler(this.NormalB_Click);
            // 
            // BonusB
            // 
            this.BonusB.BackColor = System.Drawing.Color.White;
            this.BonusB.Location = new System.Drawing.Point(7, 349);
            this.BonusB.Name = "BonusB";
            this.BonusB.Size = new System.Drawing.Size(107, 23);
            this.BonusB.TabIndex = 11;
            this.BonusB.Text = "Bonus Power Up";
            this.BonusB.UseVisualStyleBackColor = false;
            this.BonusB.Click += new System.EventHandler(this.BonusB_Click);
            // 
            // InvB
            // 
            this.InvB.BackColor = System.Drawing.Color.White;
            this.InvB.Location = new System.Drawing.Point(7, 379);
            this.InvB.Name = "InvB";
            this.InvB.Size = new System.Drawing.Size(107, 23);
            this.InvB.TabIndex = 12;
            this.InvB.Text = "Inv Power Up";
            this.InvB.UseVisualStyleBackColor = false;
            this.InvB.Click += new System.EventHandler(this.InvB_Click);
            // 
            // MagnetB
            // 
            this.MagnetB.BackColor = System.Drawing.Color.White;
            this.MagnetB.Location = new System.Drawing.Point(7, 408);
            this.MagnetB.Name = "MagnetB";
            this.MagnetB.Size = new System.Drawing.Size(107, 23);
            this.MagnetB.TabIndex = 13;
            this.MagnetB.Text = "Magnet Rect";
            this.MagnetB.UseVisualStyleBackColor = false;
            this.MagnetB.Click += new System.EventHandler(this.MagnetB_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(7, 353);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Bonus Power Up";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(7, 383);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Inv Power Up";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(7, 412);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Magnet Rect";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(7, 442);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "Moving Platform";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(7, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Moving Platform";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 599);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tile Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button NormalB;
        private System.Windows.Forms.Button SwitchB;
        private System.Windows.Forms.Button TurretB;
        private System.Windows.Forms.Button EnemyB;
        private System.Windows.Forms.Button CubeB;
        private System.Windows.Forms.Button CollisionB;
        private System.Windows.Forms.NumericUpDown WidthNUD;
        private System.Windows.Forms.NumericUpDown HeightNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SwitchCB;
        private System.Windows.Forms.CheckBox TurretCB;
        private System.Windows.Forms.CheckBox EnemyCB;
        private System.Windows.Forms.CheckBox CubeCB;
        private System.Windows.Forms.CheckBox CollisionCB;
        private System.Windows.Forms.CheckBox GridCB;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ComboBox LayerCB;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsBianaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBianaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLToolStripMenuItem;
        private System.Windows.Forms.Button DoorB;
        private System.Windows.Forms.Button PEndB;
        private System.Windows.Forms.Button PSpawnB;
        private System.Windows.Forms.Button TrapB;
        private System.Windows.Forms.Button TriggerB;
        private System.Windows.Forms.CheckBox PEndCB;
        private System.Windows.Forms.CheckBox PSpawnCB;
        private System.Windows.Forms.CheckBox TrapCB;
        private System.Windows.Forms.CheckBox TriggerCB;
        private System.Windows.Forms.CheckBox DoorCB;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button MagnetB;
        private System.Windows.Forms.Button InvB;
        private System.Windows.Forms.Button BonusB;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
    }
}

