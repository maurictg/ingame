/*
    ©2019 Maurice Golverdingen, github.com/maurictg
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace ingame
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
            init();
		}

        SQLiteConnection connection = new SQLiteConnection("Data Source=score.db;Version=3;");
        void init()
        {
            if (!File.Exists("score.db"))
            {
                SQLiteConnection.CreateFile("score.db");
                SQLiteCommand command = new SQLiteCommand("CREATE TABLE score(name, highscore, date)", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM score", connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lbScore.Items.Add(reader["name"].ToString() + " [" + reader["highscore"].ToString() + "] " + reader["date"].ToString());
                }
            }
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
			Level1 lvl = new Level1(cbDebug.Checked, tbUN.Text);
			lvl.Show();
			this.Hide();
		}

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
