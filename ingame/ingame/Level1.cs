using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ingame
{
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        
        ingame.Game game = new ingame.Game();
        void Level1KeyDown(object sender, KeyEventArgs e) { game.keyd(sender,e);}
		void Level1KeyUp(object sender, KeyEventArgs e) { game.keyu(sender,e);}

        private void Level1_Load(object sender, EventArgs e)
        {

        }
    }
}
