namespace ingame
{
    partial class Level1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer update;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.update = new System.Windows.Forms.Timer(this.components);
            this.moon = new System.Windows.Forms.PictureBox();
            this.pnldebug = new System.Windows.Forms.Panel();
            this.lblt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblfall = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btntest = new System.Windows.Forms.Button();
            this.btndexit = new System.Windows.Forms.Button();
            this.lblloc2 = new System.Windows.Forms.Label();
            this.lblisd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblJHH = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbwalkspeed = new System.Windows.Forms.TextBox();
            this.tbjumpspeed = new System.Windows.Forms.TextBox();
            this.tbgravity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.scored = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            this.pnldebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Interval = 20;
            this.update.Tick += new System.EventHandler(this.UpdateTick);
            // 
            // moon
            // 
            this.moon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moon.BackgroundImage")));
            this.moon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moon.Location = new System.Drawing.Point(769, 21);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(82, 86);
            this.moon.TabIndex = 0;
            this.moon.TabStop = false;
            // 
            // pnldebug
            // 
            this.pnldebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnldebug.Controls.Add(this.lblt);
            this.pnldebug.Controls.Add(this.label9);
            this.pnldebug.Controls.Add(this.lblfall);
            this.pnldebug.Controls.Add(this.label8);
            this.pnldebug.Controls.Add(this.btntest);
            this.pnldebug.Controls.Add(this.btndexit);
            this.pnldebug.Controls.Add(this.lblloc2);
            this.pnldebug.Controls.Add(this.lblisd);
            this.pnldebug.Controls.Add(this.label7);
            this.pnldebug.Controls.Add(this.lblJHH);
            this.pnldebug.Controls.Add(this.label6);
            this.pnldebug.Controls.Add(this.lblLoc);
            this.pnldebug.Controls.Add(this.label5);
            this.pnldebug.Controls.Add(this.label4);
            this.pnldebug.Controls.Add(this.label3);
            this.pnldebug.Controls.Add(this.label2);
            this.pnldebug.Controls.Add(this.tbwalkspeed);
            this.pnldebug.Controls.Add(this.tbjumpspeed);
            this.pnldebug.Controls.Add(this.tbgravity);
            this.pnldebug.Controls.Add(this.label1);
            this.pnldebug.Location = new System.Drawing.Point(12, 12);
            this.pnldebug.Name = "pnldebug";
            this.pnldebug.Size = new System.Drawing.Size(282, 177);
            this.pnldebug.TabIndex = 1;
            this.pnldebug.Visible = false;
            // 
            // lblt
            // 
            this.lblt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt.ForeColor = System.Drawing.Color.Yellow;
            this.lblt.Location = new System.Drawing.Point(151, 129);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(55, 19);
            this.lblt.TabIndex = 19;
            this.lblt.Text = "0";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(151, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Time";
            // 
            // lblfall
            // 
            this.lblfall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblfall.Location = new System.Drawing.Point(212, 95);
            this.lblfall.Name = "lblfall";
            this.lblfall.Size = new System.Drawing.Size(55, 19);
            this.lblfall.TabIndex = 17;
            this.lblfall.Text = "0";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(212, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fallspeed";
            // 
            // btntest
            // 
            this.btntest.BackColor = System.Drawing.Color.Gray;
            this.btntest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntest.ForeColor = System.Drawing.Color.White;
            this.btntest.Location = new System.Drawing.Point(60, 151);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(75, 23);
            this.btntest.TabIndex = 15;
            this.btntest.Text = "TEST";
            this.btntest.UseVisualStyleBackColor = false;
            this.btntest.Click += new System.EventHandler(this.Btntest_Click);
            // 
            // btndexit
            // 
            this.btndexit.BackColor = System.Drawing.Color.Red;
            this.btndexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndexit.ForeColor = System.Drawing.Color.White;
            this.btndexit.Location = new System.Drawing.Point(141, 151);
            this.btndexit.Name = "btndexit";
            this.btndexit.Size = new System.Drawing.Size(75, 23);
            this.btndexit.TabIndex = 3;
            this.btndexit.Text = "STOP";
            this.btndexit.UseVisualStyleBackColor = false;
            this.btndexit.Click += new System.EventHandler(this.Btndexit_Click);
            // 
            // lblloc2
            // 
            this.lblloc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblloc2.Location = new System.Drawing.Point(148, 48);
            this.lblloc2.Name = "lblloc2";
            this.lblloc2.Size = new System.Drawing.Size(119, 18);
            this.lblloc2.TabIndex = 14;
            this.lblloc2.Text = "x: 0, y: 0";
            // 
            // lblisd
            // 
            this.lblisd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblisd.Location = new System.Drawing.Point(212, 129);
            this.lblisd.Name = "lblisd";
            this.lblisd.Size = new System.Drawing.Size(55, 19);
            this.lblisd.TabIndex = 13;
            this.lblisd.Text = "False";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(212, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "IsDown";
            // 
            // lblJHH
            // 
            this.lblJHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJHH.ForeColor = System.Drawing.Color.Red;
            this.lblJHH.Location = new System.Drawing.Point(151, 95);
            this.lblJHH.Name = "lblJHH";
            this.lblJHH.Size = new System.Drawing.Size(55, 19);
            this.lblJHH.TabIndex = 11;
            this.lblJHH.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(151, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "JumpHH";
            // 
            // lblLoc
            // 
            this.lblLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLoc.Location = new System.Drawing.Point(148, 30);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(119, 18);
            this.lblLoc.TabIndex = 9;
            this.lblLoc.Text = "x: 0, y: 0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(148, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "walkspeed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "jumpspeed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "gravity";
            // 
            // tbwalkspeed
            // 
            this.tbwalkspeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbwalkspeed.Location = new System.Drawing.Point(74, 106);
            this.tbwalkspeed.Name = "tbwalkspeed";
            this.tbwalkspeed.Size = new System.Drawing.Size(65, 20);
            this.tbwalkspeed.TabIndex = 4;
            this.tbwalkspeed.TextChanged += new System.EventHandler(this.tbwalkspeed_TextChanged);
            // 
            // tbjumpspeed
            // 
            this.tbjumpspeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbjumpspeed.Location = new System.Drawing.Point(74, 69);
            this.tbjumpspeed.Name = "tbjumpspeed";
            this.tbjumpspeed.Size = new System.Drawing.Size(65, 20);
            this.tbjumpspeed.TabIndex = 3;
            this.tbjumpspeed.TextChanged += new System.EventHandler(this.tbjumpspeed_TextChanged);
            // 
            // tbgravity
            // 
            this.tbgravity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbgravity.Location = new System.Drawing.Point(74, 36);
            this.tbgravity.Name = "tbgravity";
            this.tbgravity.Size = new System.Drawing.Size(65, 20);
            this.tbgravity.TabIndex = 2;
            this.tbgravity.TextChanged += new System.EventHandler(this.tbgravity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debug variables";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(409, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(56, 65);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // scored
            // 
            this.scored.Interval = 500;
            this.scored.Tick += new System.EventHandler(this.scored_Tick);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(895, 535);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnldebug);
            this.Controls.Add(this.moon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level1_FormClosing);
            this.Load += new System.EventHandler(this.Level1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            this.pnldebug.ResumeLayout(false);
            this.pnldebug.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.Panel pnldebug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbwalkspeed;
        private System.Windows.Forms.TextBox tbjumpspeed;
        private System.Windows.Forms.TextBox tbgravity;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer scored;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblJHH;
        private System.Windows.Forms.Label lblisd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblloc2;
        private System.Windows.Forms.Button btndexit;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblfall;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label label9;
    }
}