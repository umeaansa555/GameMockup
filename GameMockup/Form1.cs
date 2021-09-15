using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GameMockup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer titlepressPlayer = new SoundPlayer(Properties.Resources.jingle);
            titlepressPlayer.Play();
            this.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            SoundPlayer countdownPlayer = new SoundPlayer(Properties.Resources.coin);
            countdownPlayer.Play();


            Thread.Sleep(1000);
            countdownPlayer.Play();

            Thread.Sleep(1000);
            countdownPlayer.Play();


            SoundPlayer endPlayer = new SoundPlayer(Properties.Resources.end);
            Thread.Sleep(1000);
            endPlayer.Play();

            this.BackColor = Color.Crimson;
            Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void countdownLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
