/*
    ©2019 Maurice Golverdingen, github.com/maurictg
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ingame
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUN_Click(object sender, EventArgs e)
        {
            tbUN.Clear();
        }


		void BtnStartClick(object sender, EventArgs e)
		{


		}
        

		
        
    }
}
