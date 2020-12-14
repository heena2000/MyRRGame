using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRRGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Game_logic Obj_Game = new Game_logic();
        Random Rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_load.Enabled = true; //Enable load button
            btn_spin.Enabled = false; //disable spin button
            btn_shoot.Enabled = false; //disable shoot button
            btn_shootaway.Enabled = false; //disable shootaway button
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            // code helps to show the image
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("MyRRGame.Resources.load.gif");
            Bitmap bmpObj = new Bitmap(Str);
            picbox_main.Image = bmpObj;

            //code helps for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(MyRRGame.Properties.Resources.gun_load1);
            sndObj.Play();
            //Enable spin button and disable other buttons
            btn_spin.Enabled = true;
            btn_load.Enabled = false;

            //set bullet at first position
            Obj_Game.load = 1;
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            //coding helps for images//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("MyRRGame.Resources.spin.gif");
            Bitmap bmpObj = new Bitmap(Str);
            picbox_main.Image = bmpObj;




            Obj_Game.spin_Bullet = Rand.Next(1, 7); // assign random position between 1 to 6 
            MessageBox.Show(Obj_Game.spin_Bullet.ToString());
            //enable shoot and shoot away buttons and disable other buttons
            btn_shoot.Enabled = true;
            btn_shootaway.Enabled = true;
            btn_spin.Enabled = false;
        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            //below code helps to show the image
            //coding for images//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("MyRRGame.Resources.shoot.gif");
            Bitmap bmpObj = new Bitmap(Str);
            picbox_main.Image = bmpObj;

            //coding for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(MyRRGame.Properties.Resources.gun_shoot);
            sndObj.Play();

            if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet == Obj_Game.load) // condition to check bullet is under gun hammer
            {
                MessageBox.Show("Sorry! you loose the game");
                btn_shootaway.Enabled = false;
                btn_shoot.Enabled = false;
            }
            else if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet != Obj_Game.load) // condition to check bullet is not under gun hammer
            {
                MessageBox.Show("Empty Fire");
                Obj_Game.Total_Fire = Obj_Game.Total_Fire - 1;//minus one from total
                Obj_Game.spin_Bullet = Obj_Game.Bulleteloop(Obj_Game.spin_Bullet); // call spin_bullet method from Roullet class to set the bullet position
            }
        }

        private void btn_shootaway_Click(object sender, EventArgs e)
        {
            //coding helps for image//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("MyRRGame.Resources.shootaway.gif");
            Bitmap bmpObj = new Bitmap(Str);
            picbox_main.Image = bmpObj;

            //coding helps for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(MyRRGame.Properties.Resources.gun_shoot);
            sndObj.Play();

            if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet == Obj_Game.load) // condition to check shot is under firearm hammer
            {
                if (Obj_Game.Point_Away == 2) // condition to check slug terminated in first possibility
                {
                    MessageBox.Show("You won and your score is 100");
                    btn_shootaway.Enabled = false;
                    btn_shoot.Enabled = false;
                }
                if (Obj_Game.Point_Away == 1) // condition to check shot discharged in additional opportunity
                {
                    MessageBox.Show("You won and your score is 50");
                    btn_shoot.Enabled = false;
                    btn_shootaway.Enabled = false;
                }
            }

            else if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet != Obj_Game.load) // condition to check slug isn't under weapon hammer
            {
                MessageBox.Show("Empty Fire");
                Obj_Game.Total_Fire = Obj_Game.Total_Fire - 1; //diminishing the all out fire 
                Obj_Game.Point_Away = Obj_Game.Point_Away - 1; //decreasing the absolute possibilities
                Obj_Game.spin_Bullet = Obj_Game.Bulleteloop(Obj_Game.spin_Bullet); // call spin_bullet technique from Roullet class to set the shot position
                if (Obj_Game.Point_Away == 0) // condition to check any chance left or not
                {
                    MessageBox.Show("Sorry! you loose the game");
                    btn_shoot.Enabled = false;
                    btn_shootaway.Enabled = false;
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // close the application
        }

        private void btn_playagain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

