using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace GameBoardAmbiantPlayer
{
    // Use https://github.com/naudio/NAudio

    public partial class Form1 : Form
    {
        private static string forest = "../../sounds/Forest/";
        private static string battle = "../../sounds/battle/";
        BackgroundPlayer player_thread = null;

        private void Battle_Click(object sender, EventArgs e)
        {
            player_thread.interrupt_play = true;
            var files = Directory.GetFiles(battle);
            player_thread = new BackgroundPlayer(battle, files);
        }

        public Form1()
        {
            InitializeComponent();
            var files = Directory.GetFiles(forest);
            player_thread = new BackgroundPlayer(forest, files);

            //audioFile1 = new AudioFileReader(@path1 + "DayForest02.mp3");
            //audioFile2 = new AudioFileReader(@path2 + "orgrimmar02-moment.mp3");
            //fade1 = new FadeInOutSampleProvider(audioFile1, true);
            //fade2 = new FadeInOutSampleProvider(audioFile2, true);
            //outputDevice1 = new WaveOutEvent();
            //outputDevice1.Init(fade1);
            //outputDevice2 = new WaveOutEvent();
            //outputDevice2.Init(fade2);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Thread.Sleep(10000);
            //fade1.BeginFadeOut(3000);
            //Thread.Sleep(2000);
            //outputDevice2.Play();
            //fade2.BeginFadeIn(3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //play_forest();
            //outputDevice1.Play();
            //fade1.BeginFadeIn(1000);
            // outputDevice1.Play();
        }
    }
}
