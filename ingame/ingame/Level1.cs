using System;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace ingame
{
    public partial class Level1 : Form
    {
        //DEBUG MODE
        bool debug = false;
        string playername = "Anonymous";

        public Level1(bool debugmode, string pn)
        {
            InitializeComponent();
            this.KeyPreview = true;
            debug = debugmode;
            update.Interval = 10;
            playername = pn;
        }
        
        void Level1KeyDown(object sender, KeyEventArgs e) { keyd(sender,e);}
		void Level1KeyUp(object sender, KeyEventArgs e) { keyu(sender,e);}

        private void Level1_Load(object sender, EventArgs e)
        {
        	update.Start();
            init();
        }

        void UpdateTick(object sender, EventArgs e) { doupdate(); }

        //Global variables
        /*const*/ int gravity = 5;
        /*const*/ int jumpspeed = 30;
        /*const*/ int walkspeed = 5;




        int score = 0;
        int t = 0;

        bool right = false;
        bool left = false;
        bool up = false;
        bool down = true;

        Panel player = new Panel();
        Panel ground = new Panel();
        int x = 0;
        int y = 0;

        void init()
        {
            Console.WriteLine("Initializing game...");
            player.Location = new Point(20, 400);
            player.Size = new Size(40, 40);
            player.Name = "player";
            player.BackColor = Color.Red;
            player.BringToFront();
            //ISSUE 001: Player is not topmost (SOLVED)
            p_setpoint(player.Location);

            ground.Height = 15;
            ground.Width = this.Width;
            ground.Location = new Point(0, this.Height - ground.Height);
            ground.BackColor = Color.Green;
            ground.Name = "OBground";

            Random random = new Random();
            //add 25 coins (random generated)
            for (int i = 0; i < 26; i++)
            {
                Panel coin = new Panel();
                coin.Size = new Size(10, 10);
                coin.BackColor = Color.Yellow;
                coin.Name = "CN" + i.ToString();
                int ry = random.Next(16, this.Height - coin.Height);
                int rx = random.Next(0, this.Width - coin.Width);
                coin.Location = new Point(rx, ry);
                this.Controls.Add(coin);
            }


            this.Controls.Add(ground);
            this.Controls.Add(player);
            init_gameOB();

            if(debug)
            {
                tbgravity.Text = gravity.ToString();
                tbjumpspeed.Text = jumpspeed.ToString();
                tbwalkspeed.Text = walkspeed.ToString();
                pnldebug.Visible = true;
            }

            scored.Start();

            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Tick += Tm_Tick;
            tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e) { t += 1; if (debug) { lblt.Text = t.ToString(); } }

        Random rnd = new Random();
        void init_gameOB()
        {
            //Add "mario" features #1
            for (int i = 0; i < 6; i++)
            {
                Panel tw = new Panel();
                tw.Size = new Size(40, rnd.Next(70, 120));
                tw.BackColor = Color.Green;
                int rx = rnd.Next(0, this.Width - tw.Width);
                int ry = this.Height - ground.Height - tw.Height;
                tw.Location = new Point(rx, ry);
                tw.Name = "OBtw" + i.ToString();
                if(!checktouch_coin(tw) && !checktouch_OB(tw))
                {
                    this.Controls.Add(tw);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Panel pf = new Panel();
                pf.Size = new Size(120, 15);
                pf.BackColor = Color.Gray;
                int rx = rnd.Next(0, this.Width - pf.Width);
                int ry = rnd.Next(0+pf.Height+player.Height,this.Height - ground.Height - pf.Height);
                pf.Location = new Point(rx, ry);
                pf.Name = "OBpf" + i.ToString();
                if (!checktouch_coin(pf) && !checktouch_OB(pf))
                {
                    this.Controls.Add(pf);
                }
            }


        }


        //Gameplay
        double fallspeed = 0;


        void doupdate()
        {
           
            if (down)
            {
                if(!checktouch_OB(player)) //checktouchOB
                {
                    y += gravity + Convert.ToInt32(fallspeed);
                    fallspeed += 0.1;
                }
                else
                {
                    fallspeed = 0; //?
                }
            }
            else { fallspeed = 0; }


            //if (!checkwall(player))
            //{
                if (left) x -= walkspeed;
                if (right) x += walkspeed;
            //} 

                //add "jump delay" => ISSUE 002: This causes "freezing" when you are jumping in "debug mode" with a high gravity value
                if(up){
                	up = false;
                	performjump();
                }

            checktouch_coin(player);
           

            player.Location = new Point(x, y);
            player.BringToFront(); //ISSUE 001 FIXED!

            checkwin();
            if(debug){
            	lblLoc.Text = "X: "+player.Location.X.ToString()+", Y: "+player.Location.Y.ToString();
            	lblloc2.Text = "X: "+x.ToString()+", Y: "+y.ToString();
            	lblisd.Text = down.ToString();
            	lblJHH.Text = jumphh.ToString();
                lblfall.Text = fallspeed.ToString();
            }
        }
        
        
        Timer jt = new Timer();
        int jumphh = 50;
        void performjump(){
        	if(checktouch_OB(player)){ //checktouchOBs
        		if(!jt.Enabled){
                    jumphh = 50;
                    jt.Interval = 20;
        			down = false;
        			jt.Start();
        			jt.Tick += jt_Tick;
        		}}
        	
        }

		void jt_Tick(object sender, EventArgs e)
		{
			jumphh -= 5;
			y -= jumphh;
			if(jumphh < 1){down = true;jt.Stop();jumphh = 0; }
			//if(checkcollision(player,ground)){down = true;jt.Stop();jumphh = 50;}
			
			
		}
        public void keyd(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = true; } //left |= e.KeyCode == Keys.Left; kan ?niet
            if (e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.Space) { up = true;}
            if(e.KeyCode == Keys.Escape) { Application.Exit(); }
        }

        public void keyu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = false; } //left &= e.KeyCode != Keys.Left; kan niet!
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space) { up = false; }
        }

        //Locatie updaten van speler
        public Point p_getpoint() { return new Point(x, y); }
        public void p_setpoint(Point point) { x = point.X; y = point.Y; }



        //COLLISION TESTS

        /*bool checkwall(Control player)
        {
            //DOES NOT WORKKKKKK!!!!!
            bool iss = false;
            if(player.Location.X > this.Width) { player.Location = new Point(player.Location.X - 100, player.Location.Y); iss = true; }
            if (player.Location.X < 0) { player.Location = new Point(player.Location.X + 100, player.Location.Y); iss = true; }
            if (player.Location.Y < 0) { player.Location = new Point(player.Location.X, player.Location.Y + 100); iss = true; }
            return iss;
        }*/

       

        bool checktouch(Control c1, Control c2)
        {
            return (!c2.Equals(c1) /*&& c2 is Button*/&& c1.Bounds.IntersectsWith(c2.Bounds)) ? true : false;
        }

        public bool checktouch_all(Control check)
        {
            bool does = false;
            foreach (Control cnt in this.Controls)
            {
                if (!cnt.Equals(check))
                {
                    if (check.Bounds.IntersectsWith(cnt.Bounds))
                    {
                        does = true;
                    }
                }
            }
            return does;

        }

        public bool checktouch_OB(Control check)
        {
            bool does = false;
            foreach (Control cnt in this.Controls)
            {
                if (!cnt.Equals(check) && cnt.Name.StartsWith("OB"))
                {
                    if (check.Bounds.IntersectsWith(cnt.Bounds))
                    {
                        does = true;
                        Console.WriteLine("PASS: " + cnt.Name);
                    }
                }
            }
            return does;

        }

       

        public bool checktouch_coin(Control check)
        {
            bool does = false;
            foreach (Control cnt in this.Controls)
            {
                if (!cnt.Equals(check) && cnt.Name.StartsWith("CN"))
                {
                    if (check.Bounds.IntersectsWith(cnt.Bounds))
                    {
                        does = true;
                        this.Controls.Remove(cnt);
                        score += 10;
                        lblScore.Text = score.ToString();
                    }
                }
            }
            return does;

        }

        bool checkcollision(Control obj1, Control obj2)
        {
            if (obj1.Location.X + obj1.Width < obj2.Location.X)
                return false;
            if (obj2.Location.X + obj2.Width < obj1.Location.X)
                return false;
            if (obj1.Location.Y + obj1.Height < obj2.Location.Y)
                return false;
            if (obj2.Location.Y + obj2.Height < obj1.Location.Y)
                return false;
            return true;
        }

        private void tbgravity_TextChanged(object sender, EventArgs e){if (debug) { try { gravity = int.Parse(tbgravity.Text); } catch { } }}
        private void tbjumpspeed_TextChanged(object sender, EventArgs e) { if (debug) { try { jumpspeed = int.Parse(tbjumpspeed.Text); } catch { } }}
        private void tbwalkspeed_TextChanged(object sender, EventArgs e){if (debug) { try { walkspeed = int.Parse(tbwalkspeed.Text); } catch { } }}

        private void scored_Tick(object sender, EventArgs e)
        {
            score -= 1;
            lblScore.Text = score.ToString();
        }

        void checkwin()
        {
            /*bool win = true;
            Control[] all = { };
            this.Controls.CopyTo(all,0);
            foreach (Control c in all.Where(a => a.Name.StartsWith("CN"))) { win = false; }
            if (win) { Console.WriteLine("WIN!!!!"); }*/
        }

        private void Btndexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btntest_Click(object sender, EventArgs e)
        {
            init_gameOB();
            x = 40;
            y = 40;
        }

        //save score
        SQLiteConnection connection = new SQLiteConnection("Data Source=score.db;Version=3;");
        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!debug)
            {
                try
                {
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO score(name, highscore, date) VALUES (@n, @h, @d) ", connection);
                    command.Parameters.AddWithValue("@n", playername);
                    command.Parameters.AddWithValue("@h", score.ToString());
                    command.Parameters.AddWithValue("@d", DateTime.Now.ToShortDateString());
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {

                }
            }
           
        }
    }
}
