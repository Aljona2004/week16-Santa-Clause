using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaClauseIsComingToTown
{
    public partial class Form1 : Form
    {

        int gravity = 10;
        int sunSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            santa.Top += gravity;
            sun.Left += sunSpeed;
            christmasTree.Left += sunSpeed;
            snowFlake.Left += sunSpeed;
            scorelable.Text = $"score: {score}";

            if(sun.Left < -100)
            {
                sun.Left = 1240;
                score++;
            }
            if(christmasTree.Left < -100)
            {
                christmasTree.Left = 1260;
                score++;
            }
            if(snowFlake.Left < -100)
            {
                snowFlake.Left = 1300;
                score++;
            }

            if(santa.Top < -25)
            {
                gameOver();
            }

            if(santa.Bounds.IntersectsWith(sun.Bounds) || santa.Bounds.IntersectsWith(sun.Bounds) || santa.Bounds.IntersectsWith(grounds.Bounds))
            {
                gameOver();
            }
            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void gameOver()
        {
            timer1.Stop();
            scorelable.Text = $"Game Over!";
            playagain.Visible = true;
        }

        private void Playagain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
