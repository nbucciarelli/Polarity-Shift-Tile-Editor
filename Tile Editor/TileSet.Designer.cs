namespace Tile_Editor
{
    partial class TileSet
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
            this.loadTileSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthTSNUD = new System.Windows.Forms.NumericUpDown();
            this.HeightTSNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthTNUD = new System.Windows.Forms.NumericUpDown();
            this.HeightTNUD = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTSNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTSNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTileSetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadTileSetToolStripMenuItem
            // 
            this.loadTileSetToolStripMenuItem.Name = "loadTileSetToolStripMenuItem";
            this.loadTileSetToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadTileSetToolStripMenuItem.Text = "Load TileSet";
            this.loadTileSetToolStripMenuItem.Click += new System.EventHandler(this.loadTileSetToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WidthTSNUD);
            this.groupBox1.Controls.Add(this.HeightTSNUD);
            this.groupBox1.Location = new System.Drawing.Point(13, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tile Set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height";
            // 
            // WidthTSNUD
            // 
            this.WidthTSNUD.Location = new System.Drawing.Point(7, 47);
            this.WidthTSNUD.Name = "WidthTSNUD";
            this.WidthTSNUD.Size = new System.Drawing.Size(120, 20);
            this.WidthTSNUD.TabIndex = 1;
            this.WidthTSNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WidthTSNUD.ValueChanged += new System.EventHandler(this.WidthTSNUD_ValueChanged);
            // 
            // HeightTSNUD
            // 
            this.HeightTSNUD.Location = new System.Drawing.Point(7, 20);
            this.HeightTSNUD.Name = "HeightTSNUD";
            this.HeightTSNUD.Size = new System.Drawing.Size(120, 20);
            this.HeightTSNUD.TabIndex = 0;
            this.HeightTSNUD.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.HeightTSNUD.ValueChanged += new System.EventHandler(this.HeightTSNUD_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.WidthTNUD);
            this.groupBox2.Controls.Add(this.HeightTNUD);
            this.groupBox2.Location = new System.Drawing.Point(247, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            // 
            // WidthTNUD
            // 
            this.WidthTNUD.Location = new System.Drawing.Point(7, 47);
            this.WidthTNUD.Name = "WidthTNUD";
            this.WidthTNUD.Size = new System.Drawing.Size(120, 20);
            this.WidthTNUD.TabIndex = 1;
            this.WidthTNUD.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.WidthTNUD.ValueChanged += new System.EventHandler(this.WidthTNUD_ValueChanged);
            // 
            // HeightTNUD
            // 
            this.HeightTNUD.Location = new System.Drawing.Point(7, 20);
            this.HeightTNUD.Name = "HeightTNUD";
            this.HeightTNUD.Size = new System.Drawing.Size(120, 20);
            this.HeightTNUD.TabIndex = 0;
            this.HeightTNUD.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.HeightTNUD.ValueChanged += new System.EventHandler(this.HeightTNUD_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 265);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // TileSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 395);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TileSet";
            this.Text = "TileSet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTSNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTSNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown WidthTSNUD;
        private System.Windows.Forms.NumericUpDown HeightTSNUD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WidthTNUD;
        private System.Windows.Forms.NumericUpDown HeightTNUD;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTileSetToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}