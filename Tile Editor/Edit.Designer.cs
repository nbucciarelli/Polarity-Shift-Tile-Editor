namespace Tile_Editor
{
    partial class Edit
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.LayerLV = new System.Windows.Forms.ListView();
            this.CollisionLV = new System.Windows.Forms.ListView();
            this.CubeLV = new System.Windows.Forms.ListView();
            this.TurretLV = new System.Windows.Forms.ListView();
            this.EnemyLV = new System.Windows.Forms.ListView();
            this.SwitchLV = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.button10 = new System.Windows.Forms.Button();
            this.listView5 = new System.Windows.Forms.ListView();
            this.button11 = new System.Windows.Forms.Button();
            this.listView6 = new System.Windows.Forms.ListView();
            this.button12 = new System.Windows.Forms.Button();
            this.listView7 = new System.Windows.Forms.ListView();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delet Layer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete Collision";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete Cube";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete Turret";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(139, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Delete Enemy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(266, 351);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Delete Switch";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LayerLV
            // 
            this.LayerLV.Location = new System.Drawing.Point(12, 13);
            this.LayerLV.Name = "LayerLV";
            this.LayerLV.Size = new System.Drawing.Size(120, 147);
            this.LayerLV.TabIndex = 12;
            this.LayerLV.UseCompatibleStateImageBehavior = false;
            this.LayerLV.View = System.Windows.Forms.View.List;
            // 
            // CollisionLV
            // 
            this.CollisionLV.Location = new System.Drawing.Point(139, 13);
            this.CollisionLV.Name = "CollisionLV";
            this.CollisionLV.Size = new System.Drawing.Size(120, 148);
            this.CollisionLV.TabIndex = 13;
            this.CollisionLV.UseCompatibleStateImageBehavior = false;
            this.CollisionLV.View = System.Windows.Forms.View.List;
            this.CollisionLV.SelectedIndexChanged += new System.EventHandler(this.CollisionLV_SelectedIndexChanged);
            // 
            // CubeLV
            // 
            this.CubeLV.Location = new System.Drawing.Point(266, 13);
            this.CubeLV.Name = "CubeLV";
            this.CubeLV.Size = new System.Drawing.Size(120, 148);
            this.CubeLV.TabIndex = 14;
            this.CubeLV.UseCompatibleStateImageBehavior = false;
            this.CubeLV.View = System.Windows.Forms.View.List;
            this.CubeLV.SelectedIndexChanged += new System.EventHandler(this.CubeLV_SelectedIndexChanged);
            // 
            // TurretLV
            // 
            this.TurretLV.Location = new System.Drawing.Point(12, 196);
            this.TurretLV.Name = "TurretLV";
            this.TurretLV.Size = new System.Drawing.Size(120, 148);
            this.TurretLV.TabIndex = 15;
            this.TurretLV.UseCompatibleStateImageBehavior = false;
            this.TurretLV.View = System.Windows.Forms.View.List;
            this.TurretLV.SelectedIndexChanged += new System.EventHandler(this.TurretLV_SelectedIndexChanged);
            // 
            // EnemyLV
            // 
            this.EnemyLV.Location = new System.Drawing.Point(139, 197);
            this.EnemyLV.Name = "EnemyLV";
            this.EnemyLV.Size = new System.Drawing.Size(120, 148);
            this.EnemyLV.TabIndex = 16;
            this.EnemyLV.UseCompatibleStateImageBehavior = false;
            this.EnemyLV.View = System.Windows.Forms.View.List;
            this.EnemyLV.SelectedIndexChanged += new System.EventHandler(this.EnemyLV_SelectedIndexChanged);
            // 
            // SwitchLV
            // 
            this.SwitchLV.Location = new System.Drawing.Point(266, 197);
            this.SwitchLV.Name = "SwitchLV";
            this.SwitchLV.Size = new System.Drawing.Size(120, 147);
            this.SwitchLV.TabIndex = 17;
            this.SwitchLV.UseCompatibleStateImageBehavior = false;
            this.SwitchLV.View = System.Windows.Forms.View.List;
            this.SwitchLV.SelectedIndexChanged += new System.EventHandler(this.SwitchLV_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 380);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(119, 148);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(139, 381);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(120, 147);
            this.listView2.TabIndex = 19;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(266, 380);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(120, 148);
            this.listView3.TabIndex = 20;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 535);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "Delete Door";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(139, 535);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "Delete Trigger";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(266, 535);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 23);
            this.button9.TabIndex = 23;
            this.button9.Text = "Delete Trap";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(393, 13);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(115, 147);
            this.listView4.TabIndex = 24;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.List;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(392, 166);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(115, 23);
            this.button10.TabIndex = 25;
            this.button10.Text = "Delete Magnet";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // listView5
            // 
            this.listView5.Location = new System.Drawing.Point(393, 197);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(115, 147);
            this.listView5.TabIndex = 26;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.List;
            this.listView5.SelectedIndexChanged += new System.EventHandler(this.listView5_SelectedIndexChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(392, 350);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 23);
            this.button11.TabIndex = 27;
            this.button11.Text = "Delete Bonus";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // listView6
            // 
            this.listView6.Location = new System.Drawing.Point(392, 380);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(116, 147);
            this.listView6.TabIndex = 28;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.List;
            this.listView6.SelectedIndexChanged += new System.EventHandler(this.listView6_SelectedIndexChanged);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(393, 534);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(114, 23);
            this.button12.TabIndex = 29;
            this.button12.Text = "Delete Inv";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // listView7
            // 
            this.listView7.Location = new System.Drawing.Point(13, 565);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(246, 85);
            this.listView7.TabIndex = 30;
            this.listView7.UseCompatibleStateImageBehavior = false;
            this.listView7.View = System.Windows.Forms.View.List;
            this.listView7.SelectedIndexChanged += new System.EventHandler(this.listView7_SelectedIndexChanged);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(266, 626);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 23);
            this.button13.TabIndex = 31;
            this.button13.Text = "Delete MP";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 662);
            this.ControlBox = false;
            this.Controls.Add(this.button13);
            this.Controls.Add(this.listView7);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SwitchLV);
            this.Controls.Add(this.EnemyLV);
            this.Controls.Add(this.TurretLV);
            this.Controls.Add(this.CubeLV);
            this.Controls.Add(this.CollisionLV);
            this.Controls.Add(this.LayerLV);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.ListView LayerLV;
        public System.Windows.Forms.ListView CubeLV;
        public System.Windows.Forms.ListView TurretLV;
        public System.Windows.Forms.ListView EnemyLV;
        public System.Windows.Forms.ListView CollisionLV;
        public System.Windows.Forms.ListView SwitchLV;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ListView listView2;
        public System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        public System.Windows.Forms.ListView listView4;
        public System.Windows.Forms.ListView listView5;
        public System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.Button button13;
        public System.Windows.Forms.ListView listView7;
    }
}