/*
 * Created by SharpDevelop.
 * User: 15547
 * Date: 8-2-2019
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ingame
{
	partial class Home
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbUN = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(265, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(293, 112);
			this.label1.TabIndex = 0;
			this.label1.Text = "InGame";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(537, 22);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(72, 72);
			this.panel1.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(842, 0);
			this.btnExit.Margin = new System.Windows.Forms.Padding(0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(35, 35);
			this.btnExit.TabIndex = 2;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(277, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(347, 40);
			this.label2.TabIndex = 3;
			this.label2.Text = "IN-GAME bij INformatica";
			// 
			// tbUN
			// 
			this.tbUN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tbUN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbUN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUN.ForeColor = System.Drawing.Color.White;
			this.tbUN.Location = new System.Drawing.Point(283, 240);
			this.tbUN.Name = "tbUN";
			this.tbUN.Size = new System.Drawing.Size(325, 35);
			this.tbUN.TabIndex = 4;
			this.tbUN.Text = "Naam";
			this.tbUN.Click += new System.EventHandler(this.tbUN_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(357, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "Kies uw gebruikersnaam";
			// 
			// btnStart
			// 
			this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnStart.FlatAppearance.BorderSize = 2;
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.White;
			this.btnStart.Location = new System.Drawing.Point(378, 346);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(140, 48);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Location = new System.Drawing.Point(654, 158);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(195, 236);
			this.panel2.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(3, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(138, 21);
			this.label9.TabIndex = 12;
			this.label9.Text = "==Geen scores==";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(3, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 30);
			this.label8.TabIndex = 11;
			this.label8.Text = "Scores";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Location = new System.Drawing.Point(21, 158);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(204, 236);
			this.panel3.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(4, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 42);
			this.label5.TabIndex = 11;
			this.label5.Text = "Om de game te sluiten,\r\ngebruikt u de ESC-toets";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(3, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 30);
			this.label4.TabIndex = 10;
			this.label4.Text = "Informatie";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(4, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(200, 42);
			this.label6.TabIndex = 9;
			this.label6.Text = "Verzin een gebruikersnaam\r\nen druk op \"Start\"";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(3, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 30);
			this.label7.TabIndex = 7;
			this.label7.Text = "Welkom!";
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(877, 491);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbUN);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ingame";
			this.TopMost = true;
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}
