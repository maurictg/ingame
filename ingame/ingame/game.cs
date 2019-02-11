/*
 * Created by SharpDevelop.
 * User: 15547
 * Date: 8-2-2019
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace ingame
{
	public class Game
	{
		const int gravity = 10;
		const int jumpspeed = 12;
        const int walkspeed = 13;

		
		int jumph = 0;
        int score = 0;

		bool right = false;
		bool left = false;

		Timer tick = new Timer();
        List<Control> controls = new List<Control>();
		
		int x = 0;
		int y = 0;
		
		
		
		public void init(List<Control> allcontrols)
		{
			tick.Interval = 20;
			tick.Tick += tick_Tick;

            //init
            controls = allcontrols;
		}
		//Gameplay
		
		public void keyd(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Left){left = true;} //left |= e.KeyCode == Keys.Left; kan ?niet
			if(e.KeyCode == Keys.Right){right = true;}
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.Space) {if(jumph<=0){jumph += jumpspeed;}}
		}
		
		public void keyu(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Left){left = false;} //left &= e.KeyCode != Keys.Left; kan niet!
			if(e.KeyCode == Keys.Right){right = false;}
		}
		
		//Locatie updaten van speler
		public Point p_getpoint() {return new Point(x,y);}
		public void p_setpoint(Point point) {x = point.X; y = point.Y;}

		void tick_Tick(object sender, EventArgs e)
		{
			//isjuming, isleft, isright..
		}
		
		void update()
		{

		}

		

        //COLLISION TESTS
		void checktouches()
		{
			foreach (Control c1 in controls)
			{
			    foreach (Control c2 in controls)
			    {
			        if (!c2.Equals(c1) 
			        && c1.Bounds.IntersectsWith(c2.Bounds))
			        {
			            // c1 has touched c2
			        }
			
			    }
			}
		}

        bool checktouch(Control c1, Control c2)
        {
            return (!c2.Equals(c1) /*&& c2 is Button*/&& c1.Bounds.IntersectsWith(c2.Bounds)) ? true : false;
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

        /* foreach (Panel obj in this.Controls.OfType<Panel>().Where(o => o.Name.StartsWith("obj")))
         * {
         *    jumping &= checkjumping(obj);
         * }
        */

        List<Control> predef_controls = new List<Control>();
        void createcontrols()
        {

        }
    }

}
