using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunGame
{
    public partial class gungame : Form
    {
        public gungame()
        {
            InitializeComponent();
        }
        gameClass  classobj = new gameClass();
        Random spinrandom = new Random();

        private void buttonload_Click(object sender, EventArgs e)
        {
            videoplayer.Image = GunGame.Properties.Resources.load;//this is playing the gif

            classobj.load = 1;
            buttonspin.Enabled = true;
            buttonload.Enabled = false;
        }

        private void buttonspin_Click(object sender, EventArgs e)
        {
            

            classobj.Loadspiner = spinrandom.Next(1,6);//chooses a random number from 1 to 6

           buttonshoot.Enabled = true;
            buttonshootaway.Enabled = true;
            buttonspin.Enabled = false;
        }

        private void buttonshoot_Click(object sender, EventArgs e)
        {
            videoplayer.Image = GunGame.Properties.Resources.shoot;
            System.IO.Stream str = GunGame.Properties.Resources._3;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            if (classobj.buellets > 0 && classobj.load== classobj.Loadspiner)//you will loose if the statment is true
            {

                MessageBox.Show("You Loose");

                buttonload.Enabled = false;
                buttonshoot.Enabled = false;
                buttonspin.Enabled = false;
                buttonshootaway.Enabled = false;



            }
            else if (classobj.buellets > 0 && classobj.Loadspiner != classobj.load)
            {
                classobj.buellets = classobj.buellets - 1;
                classobj.Loadspiner = classobj.spinmethod(classobj.Loadspiner);
               

                MessageBox.Show("Saved missed");

            }
        }

        private void buttonshootaway_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = GunGame.Properties.Resources._3;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            if (classobj.buellets > 0 && classobj.Loadspiner == 1 && classobj.shootaway == 2)

            {
                MessageBox.Show("You win the score is 10");//you will win if the statment is true
                buttonload.Enabled = false;
                buttonshoot.Enabled = false;
                buttonspin.Enabled = false;
                buttonshootaway.Enabled = false;
                

            }
            if (classobj.buellets > 0 && classobj.Loadspiner == 1 && classobj.shootaway == 1)
            {
                MessageBox.Show("You win the score is 5");//you will win if the statment is true
                buttonload.Enabled = false;
                buttonshoot.Enabled = false;
                buttonspin.Enabled = false;
                buttonshootaway.Enabled = false;
            }
            if (classobj.buellets > 0 && classobj.Loadspiner != 1)
            {

                MessageBox.Show("bullete not fired");
                
                classobj.buellets = classobj.buellets - 1;
                classobj.shootaway = classobj.shootaway - 1;
                classobj.Loadspiner = classobj.spinmethod(classobj.Loadspiner);
                classobj.load++;

            }
            if (classobj.buellets == 0)
            {

                MessageBox.Show("bullete shoot u lose");//you will loose if the statment is true
                buttonload.Enabled = false;
                buttonshoot.Enabled = false;
                buttonspin.Enabled = false;
                buttonshootaway.Enabled = false;


            }
            if (classobj.shootaway == 0)
            {

                MessageBox.Show("no more chance left u loose");//you will loose if the statment is true
                buttonload.Enabled = false;
                buttonshoot.Enabled = false;
                buttonspin.Enabled = false;
                buttonshootaway.Enabled = false;


            }

        }
        
        private void buttonnextgame_Click(object sender, EventArgs e)
        {
            (new gungame()).Show();
            this.Hide();//reset the form
        }

        private void gungame_Load(object sender, EventArgs e)
        {

        }
    }
}
